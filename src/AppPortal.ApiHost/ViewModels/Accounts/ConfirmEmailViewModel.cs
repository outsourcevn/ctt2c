using System.ComponentModel.DataAnnotations;

namespace AppPortal.ApiHost.ViewModels.Accounts
{
    public class ConfirmEmailViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
