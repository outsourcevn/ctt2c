using AppPortal.Core;

namespace AppPortal.ApiHost
{
    public class ApiSettings : AppSettings
    {
        public ApiSettings()
        {

        }

        public AppConfiguration AppConfiguration { get; set; }
        public CorsSites CorsSites { get; set; }
        public EmailConfig EmailConfig { get; set; }
    }

    public class EmailConfig
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Smtp { get; set; }
        public int Port { get; set; }
    }
}
