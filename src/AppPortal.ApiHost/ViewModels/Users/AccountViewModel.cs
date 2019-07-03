using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppPortal.ApiHost.ViewModels.Users
{
    public class AccountViewModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "{0} không được để trống.")]
        [StringLength(100, ErrorMessage = "{0} không vượt quá {2} và ít nhất {1} kí tự độ dài.", MinimumLength = 5)]
        public string FullName { get; set; }
        [Required(ErrorMessage = "{0} không được để trống.")]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "{0} không được để trống.")]
        [EmailAddress(ErrorMessage = "{0} chưa đúng định dạng.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Loại tài khoản")]
        public string TypeAccount { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Quyền truy cập")]
        public Dictionary<string, bool> Roles { get; set; }
        [Display(Name = "Mã nhóm")]
        public string GroupId { get; set; }
        [Display(Name = "Nhóm")]
		public string GroupName { get; set; }
		public string EmailAuth { get; set; }
	}
}
