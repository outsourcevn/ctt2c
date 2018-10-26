using AppPortal.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AppPortal.AdminSite.Authorization
{
    public class AppClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, ApplicationRole>
    {
        public AppClaimsPrincipalFactory(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IOptions<IdentityOptions> options) : base(userManager, roleManager, options)
        {
        }
        public async override Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
        {
            var principal = await base.CreateAsync(user);
            ((ClaimsIdentity)principal.Identity).AddClaims(new[] {
            new Claim(ClaimTypes.GroupSid, user.TypeUser),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.GivenName, user.FullName)
            });
            // add Roles for user
            var roles = await UserManager.GetRolesAsync(user);
            var rolesForUser = await RoleManager.Roles.Where(r => roles.Contains(r.NormalizedName)).ToListAsync();
            var rolesJson = JsonConvert.SerializeObject(rolesForUser);

            ((ClaimsIdentity)principal.Identity).AddClaims(new[] {
                new Claim("rolesForUser", rolesJson),
            });

            return principal;
        }
    }
}
