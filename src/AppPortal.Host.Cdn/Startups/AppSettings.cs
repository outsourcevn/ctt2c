namespace AppPortal.Host.Cdn.Startups
{
    public class AppSettings
    {
        public AppSettings()
        {

        }
        public string BaseUrl { get; set; }
        public AppConfiguration AppConfiguration { get; set; }
        public string CorsOrigins { get; set; }
        public Folder Folder { get; set; }
        public string DefaultFilterImage { get; set; }
        public string DefaultFilterFile { get; set; }
    }

    public class AppConfiguration
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }

    public class Folder
    {
        public string Root { get; set; }
        public string Images { get; set; }
        public string Files { get; set; }
    }
}