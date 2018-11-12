using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPortal.ApiHost.ViewModels.News
{
    public class FileUpload2
    {
        public string deleteType { get; set; }
        public string deleteUrl { get; set; }
        public string name { get; set; }
        public long size { get; set; }
        public string thumbnailUrl { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }
}
