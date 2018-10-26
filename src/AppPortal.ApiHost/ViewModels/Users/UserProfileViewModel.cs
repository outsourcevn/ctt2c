using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppPortal.ApiHost.ViewModels.Users
{
    public class UserProfileViewModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "{0} không được để trống.")]
        [StringLength(100, ErrorMessage = "{0} không vượt quá {2} và ít nhất {1} kí tự độ dài.", MinimumLength = 5)]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "{0} không được để trống.")]
        [EmailAddress(ErrorMessage = "{0} chưa đúng định dạng.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
    }
}
