using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace App.Host.Media
{
    public class ContentInitializer
    {
        private string _rootFolder;
        private string _folderName;
        private string[] _foldersToCopy;
        public IHostingEnvironment _hostingEnvironment { get; set; }
        public ContentInitializer(string rootFolder, string folderName, string[] foldersToCopy)
        {
            this._rootFolder = rootFolder;
            this._folderName = folderName;
            this._foldersToCopy = foldersToCopy;
        }

        public string CreateUserFolder(string userFolder = null)
        {            
            var virtualPath = Path.Combine(_rootFolder, userFolder ?? "UserFiles", _folderName);
            var path = _hostingEnvironment.WebRootFileProvider.GetFileInfo(virtualPath).PhysicalPath;
            var folderYMD = $"{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}";
            var directory = Path.Combine(path, folderYMD);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
                if (_foldersToCopy.Length > 0 && _foldersToCopy != null)
                {
                    foreach (var sourceFolder in _foldersToCopy)
                    {
                        CopyFolder(_hostingEnvironment.WebRootFileProvider.GetFileInfo(sourceFolder).PhysicalPath, path);
                    }
                }
            }
            return path;
        }

        private string CreateDirectory(string path)
        {
            var folderYMD = $"{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}";
            var directory = Path.Combine(path, folderYMD);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            return directory;
        }

        private void CopyFolder(string source, string destination)
        {
            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }

            foreach (var file in Directory.EnumerateFiles(source))
            {
                var dest = Path.Combine(destination, Path.GetFileName(file));
                System.IO.File.Copy(file, dest);
            }

            foreach (var folder in Directory.EnumerateDirectories(source))
            {
                var dest = Path.Combine(destination, Path.GetFileName(folder));
                CopyFolder(folder, dest);
            }
        }
    }
}
