using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.Core.Entities
{
    public class Files : BaseEntity<int>
    {
        public int? NewsLogId { get; set; }
        public string name { get; set; }
        public long size { get; set; }
        public string thumbnailUrl { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public int isDelete { get; set; }
        public DateTime? OnCreated { get; set; }
    }
}
