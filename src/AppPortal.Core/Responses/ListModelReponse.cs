using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPortal.Core.Responses
{
    public class ListModelResponse<TModel> : IListModelResponse<TModel>
    {
        [JsonProperty("message")]
        public String Message { get; set; }
        [JsonProperty("did_error")]
        public Boolean DidError { get; set; }
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }
        [JsonProperty("counts")]
        public int Counts { get; set; }
        [JsonProperty("page")]
        public IPaging Page { get; set; }
        [JsonProperty("datas")]
        public IEnumerable<TModel> Datas { get; set; }
        [JsonProperty("new_key")]
        public Object NewKey { get; set; }
    }
}
