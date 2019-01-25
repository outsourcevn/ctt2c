using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models;
using AppPortal.AdminSite.Services.Models.News;
using AppPortal.ApiHost.Controllers.Base;
using AppPortal.ApiHost.ViewModels;
using AppPortal.ApiHost.ViewModels.News;
using AppPortal.Core;
using AppPortal.Core.Entities;
using AppPortal.Core.Interfaces;
using AppPortal.Infrastructure.Identity;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.ApiHost.Controllers
{

    [Produces("application/json")]
    [DisableRequestSizeLimit]
    public class MediaController : ApiBaseController<MediaController>
    {
        private readonly IMediaService _mediaService;
        private readonly ICategoryService _categoryService;
        private IHostingEnvironment _hostingEnvironment;
        public MediaController(
           IConfiguration configuration,
           IAppLogger<MediaController> logger,
           IMediaService mediaService,
           IHostingEnvironment environment,
           ICategoryService categoryService) : base(configuration, logger)
        {
            _categoryService = categoryService;
            _mediaService = mediaService;
            _hostingEnvironment = environment;
        }

        [AllowAnonymous]
        [HttpGet("AddOrEditConfig")]
        public IActionResult AddOrEditConfig(string type , string url)
        {
            var media = _mediaService.AddOrEditConfig(type, url);
            return Ok(media);
        }

        [AllowAnonymous]
        [HttpGet("GetConfig")]
        public IActionResult GetConfig(string type)
        {
            var media = _mediaService.GetConfig(type);
            return Ok(media);
        }

        [AllowAnonymous]
        [HttpGet("getMedia")]
        public IActionResult GetMedia(string type , int is_publish)
        {
            return Ok(_mediaService.GetMedia(type , is_publish));
        }

        [AllowAnonymous]
        [HttpGet("getVanban")]
        public IActionResult getVanban(string type, string searchValue = "")
        {
            return Ok(_mediaService.GetVanban(type, searchValue));
        }

        [AllowAnonymous]
        [HttpPost("AddOrEdit")]
        public IActionResult AddOrEdit(Media models)
        {
            var media = _mediaService.AddOrEdit(models);
            return Ok(media);
        }

        [AllowAnonymous]
        [HttpPost("AddOrEditVanBan")]
        public IActionResult AddOrEditVanBan(Vanban models)
        {
            var media = _mediaService.AddOrEditVanban(models);
            return Ok(media);
        }

        [AllowAnonymous]
        [HttpPost("upLoadFileVanban")]
        public virtual async Task<IActionResult> upLoadFile(IFormFile files, string tenvanban, string IsPublish, string coquanbanhanh, string ngaybanhanh, string loaivanban,
            string sovanban)
        {
            try
            {
                var urlWeb = apiSettings.BaseUrl + "/uploads/vanban/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
                long size = files.Length;
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/vanban/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/");

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                var dataReturn = new List<FileUpload>();
                var formFile = files;
                var fileType = formFile.ContentType;
                var fileSize = formFile.Length;
                DateTime nx = new DateTime(1970, 1, 1);
                TimeSpan ts = DateTime.UtcNow - nx;
                var fileName = ((int)ts.TotalSeconds).ToString() + ' ' + formFile.FileName;

                if (fileSize < 50000000)
                {
                    if (formFile.Length > 0)
                    {
                        using (var stream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                        {
                            await formFile.CopyToAsync(stream);
                        }
                    }
                }
                else
                {
                    return BadRequest("File lớn!");
                }

                var media = new Vanban();
                media.sovanban = sovanban;
                media.tenvanban = tenvanban;
                media.coquanbanhanh = coquanbanhanh;
                media.url = urlWeb + fileName;
                media.ngaybanhanh = DateTime.Parse(ngaybanhanh);
                media.loaivanban = loaivanban;
                media.IsPublish = IsPublish == "1";
                media.OnCreated = DateTime.Now;
                _mediaService.AddOrEditVanban(media);
                return Ok(new { success = "Tải lên thành công!" });
            }
            catch (Exception e)
            {
                return BadRequest(new { err = e.Message });
            }
        }

        [AllowAnonymous]
        [HttpPost("upLoadFile")]
        public virtual async Task<IActionResult> upLoadFile(IFormFile files , IFormFile filesImage, string description , string is_publish, string type)
        {
            try
            {
                var urlWeb = apiSettings.BaseUrl + "/uploads/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
                long size = files.Length;
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/");

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                var dataReturn = new List<FileUpload>();
                var formFile = files;
                var fileType = formFile.ContentType;
                var fileSize = formFile.Length;
                DateTime nx = new DateTime(1970, 1, 1);
                TimeSpan ts = DateTime.UtcNow - nx;
                var fileName = ((int)ts.TotalSeconds).ToString() + ' '+ formFile.FileName;
                if (fileType.IndexOf("image") != -1 || fileType.IndexOf("video") != -1)
                {
                    if (fileSize < 50000000)
                    {
                        if (formFile.Length > 0)
                        {
                            using (var stream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                            {
                                await formFile.CopyToAsync(stream);
                            }
                        }
                    }
                    else
                    {
                        return BadRequest("File lớn!");
                    }

                }
                else
                {
                    return BadRequest("Không đúng định dạng file!");
                }

                var media = new Media();
                media.description = description;
                media.name = formFile.FileName;
                media.url = urlWeb + fileName;
                media.size = formFile.Length;

                if (filesImage != null)
                {
                    var dataReturnImg = new List<FileUpload>();
                    var formFileImg = filesImage;
                    var fileTypeImg = formFileImg.ContentType;
                    var fileSizeImg = formFileImg.Length;
                    DateTime nx1 = new DateTime(1970, 1, 1);
                    TimeSpan ts1 = DateTime.UtcNow - nx1;
                    var fileName1 = ((int)ts1.TotalSeconds).ToString() + ' ' + formFileImg.FileName;
                    if (fileTypeImg.IndexOf("image") != -1 || fileTypeImg.IndexOf("video") != -1)
                    {
                        if (fileSizeImg < 50000000)
                        {
                            if (formFileImg.Length > 0)
                            {
                                using (var stream = new FileStream(Path.Combine(filePath, fileName1), FileMode.Create))
                                {
                                    await formFileImg.CopyToAsync(stream);
                                }
                            }
                        }
                        else
                        {
                            return BadRequest("File lớn!");
                        }

                    }
                    else
                    {
                        return BadRequest("Không đúng định dạng file!");
                    }
                    media.filesImage = urlWeb + fileName1;
                }
               
                media.type = type;
                if (is_publish != null)
                {
                    media.OnPublish = DateTime.Now;
                    media.IsPublish = true;
                }
                else
                {
                    media.OnPublish = null;
                    media.IsPublish = false;
                }

                media.OnCreated = DateTime.Now;
                _mediaService.AddOrEdit(media);
                return Ok(new { success = "Tải lên thành công!" });
            }
            catch (Exception e)
            {
                return BadRequest(new { err = e.Message });
            }
        }


        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("delete")]
        public IActionResult delete(int id)
        {
            _mediaService.delete(id);
            return Ok();
        }

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("deleteVanban")]
        public IActionResult deleteVanban(int id)
        {
            _mediaService.deleteVanban(id);
            return Ok();
        }
    }
}