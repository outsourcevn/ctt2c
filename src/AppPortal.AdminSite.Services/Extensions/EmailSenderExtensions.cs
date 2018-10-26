using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AppPortal.AdminSite.Services.Interfaces;

namespace AppPortal.AdminSite.Services.Extensions
{
    public static class EmailSenderExtensions
    {
        public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link, string fullName = null, string userName = null, string passWord = null)
        {
            return emailSender.SendEmailAsync(email, "Confirm your email",
                $"Please confirm your account by clicking this link: <a href='{HtmlEncoder.Default.Encode(link)}'>link</a>", fullName, userName, passWord);
        }
    }
}
