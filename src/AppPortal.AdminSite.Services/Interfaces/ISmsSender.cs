using System.Threading.Tasks;

namespace AppPortal.AdminSite.Services.Interfaces
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
