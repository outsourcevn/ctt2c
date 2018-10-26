using System.ComponentModel.DataAnnotations;

namespace AppPortal.ApiHost.ViewModels.Accounts
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "{0} không được để trống")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
