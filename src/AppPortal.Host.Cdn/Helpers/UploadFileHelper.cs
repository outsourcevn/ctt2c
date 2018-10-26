using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Hosting;

namespace AppPortal.Host.Cdn.Helpers
{
    public partial class UploadFileHelper
    {
        public static string GetUniqueFileName(string filePath)
        {
            try
            {
                return GetUniqueFilePath(filePath);
            }
            catch { return Guid.NewGuid().ToString(); }
        }

        public static string InitFolderAssets(IHostingEnvironment hostingEnvironment, string folderRoot = "MyStaticFiles", string folderPath = "Images", string userFolder = "UserFiles")
        {
            var virtualPath = Path.Combine(folderRoot, userFolder, folderPath);
            var path = hostingEnvironment.WebRootFileProvider.GetFileInfo(virtualPath).PhysicalPath;
            var folderYMD = $"{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}";
            var directory = Path.Combine(path, folderYMD);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            return directory;
        }

        public static string GetUniqueFilePath(string filePath)
        {
            if (File.Exists(filePath))
            {
                string folder = Path.GetDirectoryName(filePath);
                string filename = Path.GetFileNameWithoutExtension(filePath);
                string extension = Path.GetExtension(filePath);
                int number = 1;

                Match regex = Regex.Match(filePath, @"(.+) \((\d+)\)\.\w+");

                if (regex.Success)
                {
                    filename = regex.Groups[1].Value;
                    number = int.Parse(regex.Groups[2].Value);
                }
                do
                {
                    number++;
                    filePath = Path.Combine(folder, $"{filename}({number}){extension}");
                }
                while (File.Exists(filePath));
            }
            return filePath;
        }
    }
}
