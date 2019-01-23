using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.Core.Entities
{
    public class Vanban : BaseEntity<int>
    {
        public string sovanban { get; set; }
        public string tenvanban { get; set; }
        public DateTime ngaybanhanh { get; set; }
        public string loaivanban { get; set; }
        public string coquanbanhanh { get; set; }
        public string url { get; set; }
        public bool IsPublish { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnDeleted { get; set; }
        public DateTime? OnPublish { get; set; }
    }
}
