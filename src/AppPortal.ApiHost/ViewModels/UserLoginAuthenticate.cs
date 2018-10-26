using System.ComponentModel.DataAnnotations;

namespace AppPortal.ApiHost.ViewModels
{
    public class UserLoginAuthenticate
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
}
