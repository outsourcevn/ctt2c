using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AppPortal.Core.Responses
{
    public class SingleModelResponse<TModel> : ISingleModelResponse<TModel>
    {
        [JsonProperty("message")]
        public String Message { get; set; }
        [JsonProperty("did_error")]
        public Boolean DidError { get; set; }
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }
        [JsonProperty("model")]
        public TModel Model { get; set; }
    }
}
