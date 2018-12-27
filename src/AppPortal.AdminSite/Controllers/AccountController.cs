using System;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AppPortal.AdminSite.Controllers.Base;
using AppPortal.AdminSite.Services.Models.Accounts;
using AppPortal.AdminSite.ViewModels;
using AppPortal.AdminSite.ViewModels.Accounts;
using AppPortal.Core;
using AppPortal.Core.Interfaces;
using AppPortal.Core.Responses;
using AppPortal.Infrastructure.Identity;
using Fiver.Api.HttpClient;
using Hanssens.Net;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace AppPortal.AdminSite.Controllers
{
    [DisplayName("Quản lý tài khoản")]
    public class AccountController : AdminBaseController<AccountController>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
       
        private readonly LocalStorageConfiguration _configLocalStorage = new LocalStorageConfiguration()
        {
            Filename = "appsettings",
            EnableEncryption = false
        };
        
        private readonly LocalStorage _storage;
        public AccountController(
            IConfiguration configuration,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            SignInManager<ApplicationUser> signInManager,
            IAppLogger<AccountController> logger) : base(configuration, logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _storage = new LocalStorage();
        }

        [TempData]
        public string StatusMessage { get; set; }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // logout api
            await InvokeAsync(LogoutFromApi());

            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            RemoveCookie("ACCESS-TOKEN");
            if(_storage.Count > 0)
            {
                _storage.Clear();
                //_storage.Destroy();
            }
            
            return Redirect("/Account/Login?ReturnUrl=%2F");
        }

        [DisplayName("Thay đổi mật khẩu")]
        public async Task<IActionResult> ChangePassword()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                StatusMessage = "Error: Tài khoản không tồn tại.";
            }
            var hasPassword = await _userManager.HasPasswordAsync(user);
            if (!hasPassword)
            {
                return RedirectToAction(nameof(SetPassword));
            }
            var model = new ChangePasswordViewModel { StatusMessage = StatusMessage };
            return View(model);
        }

        [HttpGet]
        [DisplayName("Cài đặt mật khẩu")]
        public async Task<IActionResult> SetPassword()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                StatusMessage = "Error: Tài khoản không tồn tại.";
            }

            var hasPassword = await _userManager.HasPasswordAsync(user);

            if (hasPassword)
            {
                return RedirectToAction(nameof(ChangePassword));
            }

            var model = new SetPasswordViewModel { StatusMessage = StatusMessage };
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult AccessDenied(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [AllowAnonymous]
        [DisplayName("Đăng nhập")]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToLocal("/");
            }
            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Đăng nhập không hợp lệ.");
                return View(model);
            }
            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, set lockoutOnFailure: true
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);
            var access_token = "";
            if (result.Succeeded)
            {
                try
                {
                    // Get token
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new System.Uri(adminSetting.ApiHostUrl);
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var response = await client.PostAsJsonAsync("/api/account/token", new LoginViewModel
                        {
                            UserName = model.UserName,
                            Password = model.Password,
                            RememberMe = true
                        });
                        if (response.IsSuccessStatusCode && response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            var userLogined = JsonConvert.DeserializeObject<UserLoginedViewModel>(response.Content.ReadAsStringAsync().Result);

                            // add token to clamin
                            //((ClaimsIdentity)User.Identity).AddClaims(new[] {
                            //    new Claim("access_token", userLogined.AccessToken),
                            //});

                            access_token = userLogined.AccessToken;
                        }
                    }
                }
                catch
                {
                    return RedirectToAction(nameof(Login), new { returnUrl = returnUrl });
                }

                // save token to localstoged               
                SetCookie("ACCESS-TOKEN", access_token, 6000);
                return RedirectToLocal(returnUrl);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Đăng nhập không hợp lệ.");
                return View(model);
            }
        }

        [Route("api/account/load-config")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult LoadConfig()
        {
            SetConfigLocalStorage();
            return Ok( new { data = GetConfigLocalStorage("appsettings") });
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPasswordForgot(string userId = null, string code = null)
        {
            if (code == null || userId == null)
            {
                return new NotFoundResult();
            }
            var model = new ResetPasswordViewModel { Code = code, Email = userId };
            return View(model);
        }

        #region 'PRIVATE'
        /// <summary>
        /// SetLocalStorage 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="token"></param>
        private void SetConfigLocalStorage()
        {
            var appConfigs = new AppConfig()
            {
                ApiHostUrl = adminSetting.ApiHostUrl,
                BaseUrl = adminSetting.BaseUrl,
                Cdn = adminSetting.Cdn
            };
            // store any object
            _storage.Store("appsettings", appConfigs);
            // finally, persist the stored objects to disk (.localstorage file)
            _storage.Persist();
        }

        /// <summary>
        /// GetKeyFromLocalStorage
        /// </summary>
        /// <param name="config"></param>
        /// <param name="keyName"></param>
        /// <returns></returns>
        private AppConfig GetConfigLocalStorage(string keyName)
        {
            return _storage.Get<AppConfig>(keyName);
        }

        /// <summary>
        /// Logout from Api
        /// </summary>
        /// <returns></returns>
        private async Task LogoutFromApi()
        {
            // logout api
            var response = await HttpRequestFactory.Post($"{adminSetting.ApiHostUrl}/api/Account/sign-out", null, TokenAccess);
            if (response.IsSuccessStatusCode && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = response.ContentAsType<SingleModelResponse<SignOutModel>>();
                if (result != null) _logger.LogInformation($"logout from api: {result.Model.messager}");
            }
        }

        private string ConvertToBase64String(string strBase)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(strBase);
            return Convert.ToBase64String(bytes);
        }
        #endregion 'PRIVATE'
    }
}