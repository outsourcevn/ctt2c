using System;
using System.Security.Claims;
using System.Threading.Tasks;
using AppPortal.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.AdminSite.Controllers.Base
{
    [Authorize]
    public abstract class AdminBaseController<T> : Controller
    {
        protected readonly IConfiguration _configuration;
        protected readonly IAppLogger<T> _logger;
        public AdminBaseController(
            IConfiguration configuration,
            IAppLogger<T> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        private AdminSettings _adminSettings;
        protected AdminSettings adminSetting
        {
            get
            {
                if (_adminSettings == null) this._adminSettings = _configuration.GetSection("AppSettings").Get<AdminSettings>();
                return this._adminSettings;
            }
        }

        private string _userId;
        protected string UserId
        {
            get
            {
                if (string.IsNullOrEmpty(_userId))
                {
                    ClaimsPrincipal currentUser = this.User;
                    _userId = currentUser?.FindFirst(ClaimTypes.NameIdentifier).Value;
                }
                return _userId;
            }
        }

        private string _userEmail;
        protected string UserEmail
        {
            get
            {
                if (string.IsNullOrEmpty(_userEmail))
                {
                    ClaimsPrincipal currentUser = this.User;
                    _userEmail = currentUser?.FindFirst(ClaimTypes.Email).Value;
                }
                return _userEmail;
            }
        }

        private string _userFullName;
        protected string UserFullName
        {
            get
            {
                if (string.IsNullOrEmpty(_userFullName))
                {
                    ClaimsPrincipal currentUser = this.User;
                    _userFullName = currentUser?.FindFirst(ClaimTypes.GivenName).Value;
                }
                return _userFullName;
            }
        }

        private string _userName;
        protected string UserName
        {
            get
            {
                if (string.IsNullOrEmpty(_userName))
                {
                    _userName = User != null ? User.Identity.Name : Guid.NewGuid().ToString();
                }
                return _userName;
            }
        }

        private string _roles;
        protected string roles
        {
            get
            {
                if (_roles.Length == 0)
                {
                    ClaimsPrincipal currentUser = this.User;
                    _roles = currentUser?.FindFirst(ClaimTypes.Role).Value;
                }
                return _roles;
            }
        }

        private string _token;
        protected string TokenAccess
        {
            get
            {
                if (string.IsNullOrEmpty(_token))
                {
                    //access_token
                    _token = GetCookie("ACCESS-TOKEN");
                }
                return _token;
            }
        }

        protected void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        protected IActionResult RedirectToLocal(string returnUrl = null, string actionName = null, string controler = null)
        {
            if (returnUrl != null && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            if (actionName != null && controler != null)
            {
                return RedirectToAction(actionName, controler);
            }
            return RedirectToAction(actionName);
        }

        protected void TryAction(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Exception from {nameof (action)}: {ex.ToString()}");
            }
        }

        protected async Task InvokeAsync(Task action)
        {
            try
            {
                await action;
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Error from {nameof (action)}: {ex.ToString()}");
            }
        }

        #region Cookie Helper
        /// <summary>  
        /// Get the cookie  
        /// </summary>  
        /// <param name="key">Key </param>  
        /// <returns>string value</returns>  
        protected string GetCookie(string key)
        {
            return Request.Cookies[key];
        }
        /// <summary>  
        /// set the cookie  
        /// </summary>  
        /// <param name="key">key (unique indentifier)</param>  
        /// <param name="value">value to store in cookie object</param>  
        /// <param name="expireTime">expiration time</param>  
        protected void SetCookie(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);
            Response.Cookies.Append(key, value, option);
        }
        /// <summary>  
        /// Delete the key  
        /// </summary>  
        /// <param name="key">Key</param>  
        protected void RemoveCookie(string key)
        {
            Response.Cookies.Delete(key);
        }
        #endregion
    }
}
