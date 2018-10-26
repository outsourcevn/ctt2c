using AppPortal.Core.Responses;
using Newtonsoft.Json;

namespace AppPortal.AdminSite.ViewModels
{
    public class Paging : IPaging
    {
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }
        [JsonProperty("take")]
        public int Take { get; set; }
        [JsonProperty("skip")]
        public int Skip { get; set; }
        [JsonProperty("query")]
        public string Query { get; set; }
    }
}
