using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.AdminSite.Services.Models
{
    public class ReportNewsView
    {
        public int Id { get; set; }
        public int? NewsId { get; set; }
        public string data { get; set; }
        public string UserName { get; set; }
        public DateTime? OnCreated { get; set; }
    }
}
