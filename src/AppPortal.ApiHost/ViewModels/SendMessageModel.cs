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
}
