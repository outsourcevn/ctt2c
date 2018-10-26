using Newtonsoft.Json;

namespace AppPortal.AdminSite.ViewModels
{
    public class UserViewModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("typeAccount")]
        public string TypeAccount { get; set; }
    }
}
