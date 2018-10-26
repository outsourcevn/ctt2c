using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using AppPortal.AdminSite.Services.Extensions;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models.Accounts;
using AppPortal.ApiHost.Controllers.Base;
using AppPortal.ApiHost.ViewModels;
using AppPortal.ApiHost.ViewModels.Accounts;
using AppPortal.Core;
using AppPortal.Core.Interfaces;
using AppPortal.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace AppPortal.ApiHost.Controllers
{
    [Produces("application/json")]
    public class AccountController : ApiBaseController<AccountController>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly PasswordHasher<ApplicationUser> _passwordHasher;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        public AccountController(
            IConfiguration configuration,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            PasswordHasher<ApplicationUser> passwordHasher,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            IAppLogger<AccountController> logger) : base(configuration, logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _passwordHasher = passwordHasher;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        #region 'FOR USER'
        [Authorize(PolicyRole.EMPLOYEE_ID)]
        [HttpPost("sign-out")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return ResponseInterceptor(new SignOutModel { IsLogout = true, messager = "Đã đăng xuất" });
        }

        [Authorize(PolicyRole.EMPLOYEE_ID)]
        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }

            var user = await _userManager.FindByIdAsync(User.FindFirst(c => c.Type == "userloginedId").Value);
            if(user == null)
            {
                return ToBadUserNotExist();
            }
            var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (!changePasswordResult.Succeeded)
            {
                return ToHttpBadRequest(AddErrors(changePasswordResult));
            }

            await _signInManager.SignInAsync(user, isPersistent: false);

            return ResponseInterceptor<string>("Mật khẩu đã được thay đổi.");
        }

        [Authorize(PolicyRole.EMPLOYEE_ID)]
        [HttpPost("setup-password")]
        public async Task<IActionResult> SetupPassword([FromBody] SetPasswordViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }

            var user = await _userManager.FindByIdAsync(User.FindFirst(c => c.Type == "userloginedId").Value); ;
            if (user == null)
            {
                return ToBadUserNotExist();
            }

            var addPasswordResult = await _userManager.AddPasswordAsync(user, model.NewPassword);
            if (!addPasswordResult.Succeeded)
            {
                return ToHttpBadRequest(AddErrors(addPasswordResult));
            }

            await _signInManager.SignInAsync(user, isPersistent: false);
           
            return ResponseInterceptor("Mật khẩu đã được cài đặt.");
        }
        #endregion 'FOR USER'

        #region 'ONLY FOR ADMINISTRATOR'
        [Authorize(PolicyRole.ADMINISTRATOR_ONLY)]
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }
            var user = await _userManager.FindByIdAsync(model.UserId);
            if(user == null)
            {
                return ToBadUserNotExist();
            }
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, code, model.Password);
            if (!result.Succeeded)
            {
                return ToHttpBadRequest(AddErrors(result));
            }
            return ResponseInterceptor<string>("Làm mới mật khẩu thành công.");
        }

        [Authorize(PolicyRole.ADMINISTRATOR_ONLY)]
        [HttpPost("change-email")]
        public async Task<IActionResult> ChangeEmail([FromBody] ChangeEmailViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }
            var user = await _userManager.FindByIdAsync(model.UserId);
            if(user == null)
            {
                return ToBadUserNotExist();
            }
            var code = await _userManager.GenerateChangeEmailTokenAsync(user, model.EmailChange);
            var result = await _userManager.ChangeEmailAsync(user, model.EmailChange, code);
            if(!result.Succeeded)
            {
                return ToHttpBadRequest(AddErrors(result));
            }
            return ResponseInterceptor("Email đã được thay đổi");
        }

        [Authorize(PolicyRole.ADMINISTRATOR_ONLY)]
        [HttpPost("confirm-email")]
        public async Task<IActionResult> SendEmailConfirm([FromBody] ConfirmEmailViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if(user == null)
            {
                return ToBadUserNotExist();
            }
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if(!result.Succeeded)
            {
                return ToHttpBadRequest(AddErrors(result));
            }
            return ResponseInterceptor("Email đã được kích hoạt thành công.");
        }
        #endregion 'ONLY FOR ADMINISTRATOR'

        #region 'AllowAnonymous'
        [HttpPost("token")]
        [AllowAnonymous]
        public async Task<IActionResult> Token([FromBody] UserLoginAuthenticate model)
        {
            if (!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }

            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user == null || _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, model.Password) != PasswordVerificationResult.Success)
            {
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "UsernameAsPassword",
                    Description = "You cannot use your username as your password.",
                }));
            }

            var token = await GetJwtSecurityToken(user);

            return Ok(new UserLogined
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                ExpiresIn = token.ValidTo,
                IsLoggedIn = true,
                TokenType = "Bearer"
            });
        }

        [HttpPost("forgot-password")]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null /*|| !(await _userManager.IsEmailConfirmedAsync(user))*/)
                {
                    return ToHttpBadRequest(AddErrors(new IdentityError()
                    {
                        Code = "UserNotExistOrEmailNotConfirm",
                        Description = "Không tìm thấy địa chỉ email hoặc không tồn tại trong hệ thống."
                    }));
                }
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                // Confirm Email Token Expiration/Lifetime #859
                // issues: https://github.com/aspnet/Identity/issues/859
                var callbackUrl = Url.ResetPasswordCallbackLink(apiSettings.CorsSites.AdminSite, user.Email, HttpUtility.UrlEncode(code));
                // For more information on how to enable account confirmation and password reset please
                // visit https://go.microsoft.com/fwlink/?LinkID=532713
                await _emailSender.SendEmailAsync(model.Email, "Reset Password on Portal",
                $"<h3>You're receiving this email because someone requested a password reset for your user account at Portal.</h3> <br/>" +
                $"Please <b>reset your password</b> by clicking here: <a style='background: #22B8EB;" +
                $"color: #fff; padding: 10px 20px; margin-bottom: 20px;'" +
                $"href='{callbackUrl}'>Reset Password</a> <br/><br/>" +
                $"<br/> <i>Your username, in case you've forgotten: {user.UserName}</i>" + 
                $"<br/> <i>Thanks for using the App Portal!</i>", 
                user.FullName, apiSettings.EmailConfig.Email, apiSettings.EmailConfig.Password);
            }
            // If we got this far, something failed, redisplay form
            return ResponseInterceptor("Vui lòng kiểm tra email để xác nhận đổi lại mật khẩu mới.");
        }

        [HttpPost("reset-password-forget")]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPasswordForgot([FromBody] ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return ToHttpBadRequest(AddErrors(new IdentityError()
                {
                    Code = "UserNotExistOrEmailNotConfirm",
                    Description = "Không tìm thấy địa chỉ email hoặc không tồn tại trong hệ thống."
                }));
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Code, model.Password);
            if (!result.Succeeded)
            {
                return ToHttpBadRequest(AddErrors(result));
            }
            return ResponseInterceptor("Mật khẩu đã được khôi phục. Vui lòng <a href='/Account/Login' class='btn btn-primary btn-flat'>đăng nhập</a>.");
        }

        #endregion 'AllowAnonymous'

        #region ' Private '
        private IEnumerable<Claim> GetTokenClaims(ApplicationUser user)
        {
            var roles =  _userManager.GetRolesAsync(user).Result;
            return new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim("EmployeeId", $"EmployeeId.{user.Id}", ClaimValueTypes.String, "emp"),
                new Claim("rolesForUser", string.Join(",", roles)),
                new Claim("userloginedId", user.Id),
                new Claim(ClaimTypes.Name, user.UserName)
            };
        }

        private async Task<JwtSecurityToken> GetJwtSecurityToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            
            return new JwtSecurityToken(
                issuer: apiSettings.BaseUrl,
                audience: apiSettings.AppConfiguration.Audience,
                claims: GetTokenClaims(user).Union(userClaims),
                expires: DateTime.UtcNow.AddMinutes(60),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(apiSettings.AppConfiguration.Key)), SecurityAlgorithms.HmacSha256)
            );
        }      

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false, //you might want to validate the audience and issuer depending on your use case
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("the server key used to sign the JWT token is here, use more than 16 chars")),
                ValidateLifetime = false //here we are saying that we don't care about the token's expiration date
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            return principal;
        }

        #endregion
    }
}