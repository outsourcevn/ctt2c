using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AppPortal.AdminSite.Authorization
{
    public class ClaimsTransformer : IClaimsTransformation
    {
        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            ((ClaimsIdentity)principal.Identity).AddClaim(new Claim("ProjectReader", "true"));
            return Task.FromResult(principal);
        }
    }
}
