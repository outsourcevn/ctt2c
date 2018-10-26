using System.ComponentModel.DataAnnotations;

namespace AppPortal.AdminSite.ViewModels.Accounts
{
    public class ResetPasswordViewModel
    {
        public string Code { get; set; }
        [Required(ErrorMessage = "Email không được trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }

        [Display(Name = "Mật khẩu mới")]
        [Required(ErrorMessage = "Mật khẩu không được để trống.")]
        [StringLength(100, ErrorMessage = "Mật khẩu phải ít nhất {2} và tối đa {1} kí tự độ dài.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Xác nhận mật khẩu")]
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu xác nhận.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu xác nhận chưa khớp.")]
        public string ConfirmPassword { get; set; }
    }
}
