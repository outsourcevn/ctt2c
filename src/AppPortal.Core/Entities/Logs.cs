using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.Core.Entities
{
    public class Logs : BaseEntity<int>
    {
        public string type { get; set; }
        public long user_id { get; set; }
        public string fullname { get; set; }
        public string events { get; set; }
        public string ip_address { get; set; }
        public DateTime? created_at { get; set; }
    }
}
