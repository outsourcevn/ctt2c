using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using App.Host.Media;
using AppPortal.Host.Cdn.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.Host.Cdn.Controllers
{
    public class ImageBrowserController : BaseController<ImageBrowserController>
    {
        private const int ThumbnailHeight = 80;
        private const int ThumbnailWidth = 80;
        private const string contentType = "image/png";

        private ContentInitializer contentInitializer;
        private readonly DirectoryBrowser directoryBrowser = new DirectoryBrowser();
        private readonly ThumbnailCreator thumbnailCreator = new ThumbnailCreator();

        public ImageBrowserController(
            IHostingEnvironment environment,
            IConfiguration configuration,
            IAppLogger<ImageBrowserController> logger) : base(environment, configuration, logger)
        {
        }

        private string _contentPath;
        private string ContentPath
        {
            get
            {
                if (string.IsNullOrEmpty(_contentPath))
                {
                    contentInitializer = new ContentInitializer(appSettings.Folder.Root, appSettings.Folder.Images, new string[] { });
                    contentInitializer._hostingEnvironment = _hostingEnvironment;
                    _contentPath = contentInitializer.CreateUserFolder();
                }
                return this._contentPath;
            }
        }

        public virtual IActionResult Read(string path)
        {
            path = NormalizePath(path);
            try
            {
                directoryBrowser.Server = _hostingEnvironment;
                var result = directoryBrowser
                    .GetContent(path, appSettings.DefaultFilterImage)
                    .Select(f => new
                    {
                        name = f.Name,
                        type = f.Type == EntryType.File ? "f" : "d",
                        size = f.Size
                    });

                return Json(result);
            }
            catch (DirectoryNotFoundException)
            {
                return NotFound();
            }
        }

        public virtual IActionResult Thumbnail(string path)
        {
            var physicalPath = Path.Combine(ContentPath, path);
            return CreateThumbnail(physicalPath);
        }

        private FileContentResult CreateThumbnail(string physicalPath)
        {
            using (var fileStream = System.IO.File.OpenRead(physicalPath))
            {
                var desiredSize = new ImageSize
                {
                    Width = ThumbnailWidth,
                    Height = ThumbnailHeight
                };
                return File(thumbnailCreator.Create(fileStream, desiredSize, contentType), contentType);
            }
        }

        [HttpPost]
        public IActionResult Destroy(string path, string name, string type)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(type))
            {
                if (type.ToLowerInvariant() == "f")
                {
                    DeleteFile(path, name);
                }
                else
                {
                    DeleteDirectory(path, name);
                }

                return Json(new object[0]);
            }
            // Return an empty string to signify success
            return Json(new object[0]);
        }

        public void DeleteDirectory(string path, string name)
        {
            path = NormalizePath(path);
            path = Path.Combine(path, name);
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
        }

        public void DeleteFile(string path, string name)
        {
            path = NormalizePath(path);
            path = Path.Combine(path, name);
            // TODO: Verify user permissions
            if (System.IO.File.Exists(path))
            {
                // The files are not actually removed in this demo
                System.IO.File.Delete(path);
            }
        }

        //public virtual bool AuthorizeCreateDirectory(string path, string name)
        //{
        //    return CanAccess(path);
        //}

        public bool AuthorizeUpload(IFormFile file, string path = null)
        {
            return IsValidFile(file.FileName);
        }

        //protected virtual bool CanAccess(string path)
        //{
        //    return path.StartsWith(ToAbsolute(ContentPath), StringComparison.OrdinalIgnoreCase);
        //}

        [HttpPost]
        public virtual IActionResult Create(string path, FileBrowserEntry entry)
        {
            path = NormalizePath(path);

            var name = entry.Name;
            var physicalPath = Path.Combine(path, name);

            if (!Directory.Exists(physicalPath))
            {
                Directory.CreateDirectory(physicalPath);
            }
            return Json(new
            {
                name = entry.Name,
                type = "d",
                size = entry.Size
            });
        }


        private bool IsValidFile(string fileName)
        {
            var extension = Path.GetExtension(fileName);
            var allowedExtensions = appSettings.DefaultFilterImage.Split(',');
            return allowedExtensions.Any(e => e.EndsWith(extension, StringComparison.InvariantCultureIgnoreCase));
        }

        [HttpPost]
        public virtual async Task<IActionResult> Upload(string path, IFormFile file)
        {
            path = NormalizePath(path);

            var fileName = Path.GetFileName(file.FileName);

            if (AuthorizeUpload(file))
            {
                var filePath = Path.Combine(path, $"{file.FileName}");
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            return Json(new
            {
                size = file.Length,
                name = fileName,
                type = "f"
            });
        }

        [HttpGet]
        public IActionResult Image(string path)
        {
            path = NormalizePath(path);

            if (System.IO.File.Exists(path))
            {
                return File(System.IO.File.OpenRead(path), contentType);
            }
            return NotFound();
        }

        public IActionResult Index()
        {
            return NotFound();
        }

        private string NormalizePath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return ContentPath;
            }

            return Path.Combine(ContentPath, path);
        }
    }
}
