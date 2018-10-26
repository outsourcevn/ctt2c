using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.Core.Entities
{
    public class NewsLog : BaseEntity<int>
    {
        public int? NewsId { get; set; }
        public string GroupNameFrom { get; set; }
        public string GroupNameTo { get; set; }
        public string UserNameTo { get; set; }
        public string FullUserNameTo { get; set; }
        public string UserName { get; set; }
        public string FullUserName { get; set; }
        public string Note { get; set; }
        public string Data { get; set; }
        public IsTypeStatus TypeStatus { get; set; }
        public string DetailTypeStatus { get; set; }
        public string AttachFile { get; set; }
        public DateTime? OnCreated { get; set; }
    }

    public enum IsTypeStatus : int
    {
        is_logs,
        is_report,
        is_report_end,
        is_phancong,
        is_chuyencongvan
    }
}
