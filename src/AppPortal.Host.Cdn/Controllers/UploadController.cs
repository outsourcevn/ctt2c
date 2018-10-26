using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using AppPortal.Host.Cdn.Interfaces;
using AppPortal.Host.Cdn.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.Host.Cdn.Controllers
{
    public class UploadController : BaseController<UploadController>
    {
        public UploadController(
            IHostingEnvironment environment,
            IConfiguration configuration,
            IAppLogger<UploadController> logger) : base(environment, configuration, logger)
        {
        }

        private string _pathFolder;
        private string pathFolder
        {
            get
            {
                if (string.IsNullOrEmpty(_pathFolder)) _pathFolder = Helpers.UploadFileHelper.InitFolderAssets(_hostingEnvironment, appSettings.Folder.Root, appSettings.Folder.Images);
                return this._pathFolder;
            }
        }

        private string NormalizePath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return pathFolder;
            }

            return Path.Combine(pathFolder, path);
        }

        [HttpPost]
        public ActionResult Submit(IEnumerable<IFormFile> files)
        {
            if (files != null)
            {
                TempData["UploadedFiles"] = GetFileInfo(files);
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Save(string path, IList<IFormFile> files)
        {
            path = NormalizePath(path);
            // The Name of the Upload component is "files"
            if (files != null)
            {
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        var filePath = Path.Combine(path, $"{file.FileName}-{new DateTime().Millisecond}");
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                        }
                    }
                }
            }

            return Json(files.Count);
        }

        public ActionResult Remove(string path, string[] fileNames)
        {
            path = NormalizePath(path);
            if (fileNames != null)
            {
                foreach (var fullName in fileNames)
                {
                    var fileName = Path.GetFileName(fullName);
                    var physicalPath = Path.Combine(path, fileName);

                    // TODO: Verify user permissions
                    if (System.IO.File.Exists(physicalPath))
                    {
                        // The files are not actually removed in this demo
                        System.IO.File.Delete(physicalPath);
                    }
                }
            }

            // Return an empty string to signify success
            return Json("");
        }

        public async Task AppendToFile(string filePath, IFormFile file)
        {
            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> ChunkSave(string path, IList<IFormFile> files, string metaData)
        {
            path = NormalizePath(path);
            if (metaData == null)
            {
                return await Save(path, files);
            }

            Models.FileResult fileBlob = new Models.FileResult();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(metaData));
            var serializer = new DataContractJsonSerializer(typeof(ChunkMetaData));
            ChunkMetaData somemetaData = serializer.ReadObject(ms) as ChunkMetaData;
            // The Name of the Upload component is "files"
            if (files != null)
            {
                foreach (var file in files)
                {
                    var filePath = Path.Combine(path, $"{somemetaData.FileName}");
                    var fileName = Helpers.UploadFileHelper.GetUniqueFileName(filePath);
                    fileBlob.url = fileName.Replace(_hostingEnvironment.WebRootPath, string.Empty).Replace("\\", "/");
                    await AppendToFile(fileName, file);
                }
            }

            fileBlob.uploaded = somemetaData.TotalChunks - 1 <= somemetaData.ChunkIndex;
            fileBlob.fileUid = somemetaData.UploadUid;

            return Json(fileBlob);
        }

        private IEnumerable<string> GetFileInfo(IEnumerable<IFormFile> files)
        {
            return
                from a in files
                where a != null
                select string.Format("{0} ({1} bytes)", Path.GetFileName(a.FileName), a.Length);
        }

        public IActionResult Index()
        {
            return NotFound();
        }

        private byte[] readFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }

                return ms.ToArray();
            }
        }
    }
}
