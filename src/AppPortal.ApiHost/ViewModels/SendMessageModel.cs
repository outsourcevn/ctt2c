using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace AppPortal.ApiHost.ViewModels
{
    public class SendMessageModel
    {
        [Required]
        public string[] Ids { get; set; }
        [Required]
        public string TopicId { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public string Content { get; set; }
    }

    public class city
    {
        public string id { get; set; }

        public string code { get; set; }

        public string name { get; set; }

        public List<districts> districts { get; set; }
    }

    public class districts
    {
        public string id { get; set; }

        public string name { get; set; }

        public List<wards> wards { get; set; }

        public List<streets> streets { get; set; }

        public List<projects> projects { get; set; }
    }

    public class wards
    {
        public string id { get; set; }
        public string name { get; set; }
        public string prefix { get; set; }
    }

    public class streets
    {
        public string id { get; set; }
        public string name { get; set; }
        public string prefix { get; set; }
    }

    public class projects
    {
        public string id { get; set; }
        public string name { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
    }
}
