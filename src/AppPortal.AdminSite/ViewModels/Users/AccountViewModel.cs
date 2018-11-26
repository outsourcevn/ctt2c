using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AppPortal.Core;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppPortal.AdminSite.ViewModels.Users
{
    public class AccountViewModel : IValidatableObject
    {
        public string AccountId { get; set; }
        [Required(ErrorMessage = "{0} không được để trống.")]
        [StringLength(100, ErrorMessage = "{0} không vượt quá {2} và ít nhất {1} kí tự độ dài.", MinimumLength = 5)]
        [Display(Name = "Họ và tên")]
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
        public List<SelectListItem> TypeAccounts { get; } = new List<SelectListItem>() {
                new SelectListItem() { Value = AppConst.GROUP_ADMIN, Text = "Quản trị hệ thống" },
                new SelectListItem() { Value = AppConst.GROUP_USER, Text = "Cán bộ nhân viên", Selected = true }
        };
        [StringLength(100, ErrorMessage = "{0} phải có độ dài ít nhất {2} và không vượt quá {1} kí tự độ dài.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu với mật khẩu xác nhận không khớp.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Quyền truy cập")]
        public Dictionary<string, bool> Roles { get; set; }

        [Display(Name = "Mã nhóm")]
        public string GroupId { get; set; }
        public List<SelectListItem> GroupIds { get; } = new List<SelectListItem>() {
                new SelectListItem() { Value = "ttdl", Text = "Trung tâm Thông tin và Dữ liệu môi trường" ,Selected = true },
                new SelectListItem() { Value = "cbtddn", Text = "Cán bộ đường dây nóng" },
                new SelectListItem() { Value = "dvct", Text = "Đơn vị chủ trì" },
                new SelectListItem() { Value = "ldtcmt", Text = "Lãnh đạo tổng cục môi trường" },
                new SelectListItem() { Value = "sysadmin", Text = "Tài khoản quản trị (Admin)" }
        };
        [Display(Name = "Nhóm")]
        public string GroupName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Password) && string.IsNullOrWhiteSpace(AccountId))
            {
                yield return new ValidationResult("Mật khẩu không được để trống.");
            }
        }
    }
}
