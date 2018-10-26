using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace AppPortal.AdminSite.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu.")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Nhớ đăng nhập lần sau?")]
        public bool RememberMe { get; set; }
    }

    public class UserLoginedViewModel
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("expires_in")]
        public DateTime? ExpiresIn { get; set; }
        [JsonProperty("isLoggedIn")]
        public bool? IsLoggedIn { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }
}