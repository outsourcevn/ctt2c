using Newtonsoft.Json;

namespace AppPortal.ApiHost.ViewModels.Cats
{
    public class ListItemCategoryViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("prefix_name")]
        public string PrefixName { get; set; }
    }
}
