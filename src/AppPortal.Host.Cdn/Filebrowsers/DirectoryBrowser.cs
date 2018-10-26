using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;

namespace App.Host.Media
{
    public class DirectoryBrowser
    {

        public IEnumerable<FileBrowserEntry> GetContent(string path, string filter)
        {
            return GetFiles(path, filter).Concat(GetDirectories(path));
        }

        private IEnumerable<FileBrowserEntry> GetFiles(string path, string filter)
        {
            var directory = new DirectoryInfo(Path.Combine(Server.WebRootPath, path));

            var extensions = (filter ?? "*").Split(",|;".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries);

            return extensions.SelectMany(directory.GetFiles)
                .Select(file => new FileBrowserEntry
                {
                    Name = file.Name,
                    Size = file.Length,
                    Type = EntryType.File
                });
        }

        private IEnumerable<FileBrowserEntry> GetDirectories(string path)
        {
            var directory = new DirectoryInfo(Path.Combine(Server.WebRootPath, path));

            return directory.GetDirectories()
                .Select(subDirectory => new FileBrowserEntry
                {
                    Name = subDirectory.Name,
                    Type = EntryType.Directory
                });
        }
        public IHostingEnvironment Server { get; set; }
    }
}
