using System;

namespace AppPortal.Core.Entities
{
    public class Notifications : BaseEntity<int>
    {
        public int? NewsId { get; set; }
        public string Notification { get; set; }
        public string UserName { get; set; }
        public bool isRead { get; set; }
        public DateTime? OnCreated { get; set; }
    }
}