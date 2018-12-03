using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.Core.Entities
{
    public class Config : BaseEntity<int>
    {
        public string type { get; set; }
        public string url { get; set; }
    }
}
