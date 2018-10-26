using System.ComponentModel.DataAnnotations;

namespace AppPortal.ApiHost.ViewModels.Accounts
{
    public class ChangeEmailViewModel
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        [EmailAddress]
        public string EmailOld { get; set; }
        [Required]
        [EmailAddress]
        public string EmailChange { get; set; }
    }
}
