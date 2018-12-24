using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPortal.AdminSite.Controllers.Base
{
    public class RolesAttribute : AuthorizeAttribute
    {
        public RolesAttribute(string roles)
        {
            Roles = roles;
        }
        public RolesAttribute(params string[] roles)
        {
            Roles = String.Join(",", roles);
        }
    }
}
