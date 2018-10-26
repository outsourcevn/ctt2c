using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace AppPortal.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string TypeUser { get; set; }
        public string GroupName { get; set; }
        public string GroupId { get; set; }
        public virtual ICollection<IdentityUserRole<string>> Roles { get; } = new List<IdentityUserRole<string>>();
    }
}
