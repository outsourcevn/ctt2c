using System.Collections.Generic;
using Newtonsoft.Json;

namespace AppPortal.ApiHost.ViewModels.Cats
{
    public class TreeCategoryViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("see_name")]
        public string Sename { set; get; }
        [JsonProperty("target_url")]
        public string TargetUrl { get; set; }
        [JsonProperty("order_sort")]
        public int OrderSort { get; set; }
        [JsonProperty("is_show")]
        public bool IsShow { get; set; }
        [JsonProperty("items")]
        public IList<TreeCategoryViewModel> items { get; set; }
    }
}
