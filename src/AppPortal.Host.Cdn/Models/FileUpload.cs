using System;

namespace AppPortal.Host.Cdn.Models
{
    public class FileUpload
    {
        public int chunkIndex { get; set; }
        public string contentType { get; set; }
        public string fileName { get; set; }
        public float totalFileSize { get; set; }
        public int totalChunks { get; set; }
        public Guid uploadUid { get; set; }
    }
}
