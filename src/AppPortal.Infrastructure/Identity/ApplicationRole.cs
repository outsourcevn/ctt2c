using Microsoft.AspNetCore.Identity;

namespace AppPortal.Infrastructure.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public string AccessPage { get; set; }
        public string RoleDescription { get; set; }
    }
}
