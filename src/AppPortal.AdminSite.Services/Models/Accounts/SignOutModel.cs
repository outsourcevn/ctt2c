using Newtonsoft.Json;

namespace AppPortal.AdminSite.Services.Models.Accounts
{
    public class SignOutModel
    {
        [JsonProperty("messager")]
        public string messager { get; set; }
        [JsonProperty("is_logout")]
        public bool IsLogout { get; set; }
    }
}
