using AppPortal.Core;

namespace AppPortal.AdminSite
{
    public class AdminSettings : AppSettings
    {
        public AdminSettings()
        {

        }
        public string ApiHostUrl { get; set; }
        public string Cdn { get; set; }
        public Folder Folder { get; set; }
        public string DefaultFilterImage { get; set; }
        public string DefaultFilterFile { get; set; }
        public string LoginURL { get; set; }
    }

    public class Folder
    {
        public string Root { get; set; }
        public string Images { get; set; }
        public string Files { get; set; }
    }
}
