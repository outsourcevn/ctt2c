using System.ComponentModel.DataAnnotations;

namespace AppPortal.ApiHost.ViewModels.Accounts
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Email không được trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống.")]
        [StringLength(100, ErrorMessage = "Mật khẩu phải ít nhất {2} và tối đa {1} kí tự độ dài.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu mới")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu xác nhận.")]
        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu xác nhận chưa khớp.")]
        public string ConfirmPassword { get; set; }
        
        public string Code { get; set; }
    }
}
