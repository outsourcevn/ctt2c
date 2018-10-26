using Newtonsoft.Json;

namespace AppPortal.ApiHost.ViewModels.Addresses
{
    public class AddressViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("province_type")]
        public string ProvinceType { get; set; }
        [JsonProperty("lat_long")]
        public string LatLong { get; set; }
        [JsonProperty("province_id")]
        public int? ProvinceId { get; set; }
    }
}
