using Newtonsoft.Json;

namespace AppPortal.ApiHost.ViewModels
{
    public class ListItemsViewModel<Tkey, TField>
    {

        [JsonProperty("id")]
        public Tkey Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("field")]
        public TField Field { get; set; }
    }
}
