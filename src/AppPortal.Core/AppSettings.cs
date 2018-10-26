namespace AppPortal.Core
{
    public class AppSettings
    {
        public string BaseUrl { set; get; }
    }

    public class AppConfiguration
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }

    public class CorsSites
    {
        public string AdminSite { get; set; }
        public string PublishSite { get; set; }
    }
}
