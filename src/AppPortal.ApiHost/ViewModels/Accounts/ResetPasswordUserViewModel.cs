using System.ComponentModel.DataAnnotations;

namespace AppPortal.ApiHost.ViewModels.Accounts
{
    public class ResetPasswordUserViewModel
    {
        public string UserId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Mật khẩu phải ít nhất {2} và tối đa {1} kí tự độ dài.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nhập mật khẩu mới")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu xác nhận chưa khớp.")]
        public string ConfirmPassword { get; set; }
    }
}
