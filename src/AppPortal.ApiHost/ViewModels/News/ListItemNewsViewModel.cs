using System;
using AppPortal.Core.Entities;
using Newtonsoft.Json;

namespace AppPortal.ApiHost.ViewModels.News
{
    public class ListItemNewsViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("se_name")]
        public string Sename { get; set; }
        [JsonProperty("abstract")]
        public string Abstract { get; set; }
        [JsonProperty("content")]
        public string Content { get; set; }
        [JsonProperty("is_show")]
        public bool? IsShow { get; set; }
        [JsonProperty("on_created")]
        public DateTime? OnCreated { get; set; }
        [JsonProperty("on_updated")]
        public DateTime? OnUpdated { get; set; }
        [JsonProperty("on_deleted")]
        public DateTime? OnDeleted { get; set; }
        [JsonProperty("on_published")]
        public DateTime? OnPublished { get; set; }
        [JsonProperty("is_status")]
        public IsStatus status { get; set; }
        [JsonProperty("note")]
        public string Note { get; set; }
        [JsonProperty("file_upload")]
        public string fileUpload { get; set; }
        [JsonProperty("is_type")]
        public IsType IsType { get; set; }
        [JsonProperty("stt")]
        public int stt { get; set; }
        [JsonProperty("doituong")]
        public int doituong { get; set; }
        [JsonProperty("category_id")]
        public int? Category_Id { get; set; }
        [JsonProperty("ma_pakn")]
        public string MaPakn { get; set; }
    }
}
