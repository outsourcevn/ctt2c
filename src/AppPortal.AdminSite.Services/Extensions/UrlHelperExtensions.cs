using Microsoft.AspNetCore.Mvc;

namespace AppPortal.AdminSite.Services.Extensions
{
    public static class UrlHelperExtensions
    {
        public static string EmailConfirmationLink(this IUrlHelper urlHelper, string host, string userId, string code, string scheme = null)
        {
           return $"{host}/Account/ConfirmEmail?userId={userId}&code={code}";
        }

        public static string ResetPasswordCallbackLink(this IUrlHelper urlHelper, string host, string userId, string code, string scheme = null)
        {
            return $"{host}/Account/ResetPasswordForgot?userId={userId}&code={code}";
        }


    }
}
