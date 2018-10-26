using System;
using Microsoft.AspNetCore.Authorization;

namespace AppPortal.ApiHost.Controllers.Base
{
    public class RolesAttribute : AuthorizeAttribute
    {
        public RolesAttribute(string policy = null)
        {
            if (Policy != null)
                Policy = policy;
        }
        public RolesAttribute(string[] policy = null)
        {
            if (Policy != null)
                Policy = String.Join(",", policy);
        }
    }
}
