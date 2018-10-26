using System;
namespace AppPortal.Core.Entities
{
    public class ReportNews : BaseEntity<int>
    {
        public int? NewsId { get; set; }
        public string data { get; set; }
        public string UserName { get; set; }
        public DateTime? OnCreated { get; set; }
    }
}
