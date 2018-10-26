using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppPortal.AdminSite.ViewModels.Roles
{
    public class RoleViewModel
    {
        [Required]
        [StringLength(256, ErrorMessage = "The {0} must be at least {1} characters long.")]
        public string Name { get; set; }
        public string RoleDescription { get; set; }
        public IEnumerable<MvcControllerInfoViewModel> SelectedControllers { get; set; }
    }
}
