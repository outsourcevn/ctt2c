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

    public class NewsLogModel
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public string Data { get; set; }
        public IList<Files> files { get; set; }
    }

    public enum IsTypeStatus : int
    {
        is_logs,
        is_report,
        is_report_end,
        is_phancong,
        is_chuyencongvan
    }

    public class FileUpload
    {
        public string deleteType { get; set; }
        public string deleteUrl { get; set; }
        public string name { get; set; }
        public long size { get; set; }
        public string thumbnailUrl { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class NewLogUpLoad
    {
        public string FullUserName { get; set; }
        public string Data { get; set; }
        public IList<Files> files { get; set; }
    }

    public class NewsLogFile
    {
        public NewsLog newsLog;
        public IList<Files> lstFiles { get; set; }
    }
}
