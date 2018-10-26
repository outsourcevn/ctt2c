using System.ComponentModel.DataAnnotations;

namespace AppPortal.AdminSite.ViewModels.Accounts
{
    public class SetPasswordViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu mới")]
        [StringLength(100, ErrorMessage = "Mật khẩu phải ít nhất {2} và tối đa {1} kí tự độ dài.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu mới")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("NewPassword", ErrorMessage = "Mật khẩu xác nhận không khớp.")]
        public string ConfirmPassword { get; set; }

        public string StatusMessage { get; set; }
    }
}
