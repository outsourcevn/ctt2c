using System.Linq;
using System.Security.Claims;

namespace AppPortal.Core.ClaimsIdentityExtension
{
    public static class ClaimsIdentityExtension
    {
        /// <summary>
        ///    Get claim type extension
        /// </summary>
        /// <example>
        ///    @((ClaimsIdentity) User.Identity).GetSpecificClaim("someclaimtype"
        /// </example>
        /// <param name="claimsIdentity"></param>
        /// <param name="claimType"></param>
        /// <returns></returns>
        public static string GetSpecificClaim(this ClaimsIdentity claimsIdentity, string claimType)
        {
            var claim = claimsIdentity.Claims.FirstOrDefault(x => x.Type == claimType);

            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}
