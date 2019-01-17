using Newtonsoft.Json;

namespace AppPortal.AdminSite.ViewModels
{
    public class AppConfig
    {
        [JsonProperty("apiBaseUrl")]
        public string BaseUrl { set; get; }
        [JsonProperty("apiHostUrl")]
        public string ApiHostUrl { get; set; }
        [JsonProperty("apiCdnUrl")]
        public string Cdn { get; set; }
        public string LoginURL { get; set; }
    }
}
