using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.Core.Entities
{
    public class Media : BaseEntity<int>
    {
        public string name { get; set; }
        public long size { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnDeleted { get; set; }
        public DateTime? OnPublish { get; set; }
    }
}
