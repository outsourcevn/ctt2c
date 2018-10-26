using System.Threading.Tasks;

namespace AppPortal.AdminSite.Services.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message, string fullName = null, string userName = null, string passWord = null);
    }
}
