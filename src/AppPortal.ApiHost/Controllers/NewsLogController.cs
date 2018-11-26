using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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
    public class NewsLogController : ApiBaseController<NewsLogController>
    {
        private readonly INewsService _newsService;
        private readonly INewsLog _newLog;
        private readonly UserManager<ApplicationUser> _userManager;
        private IHostingEnvironment _hostingEnvironment;
        public NewsLogController(
            IConfiguration configuration,
            IAppLogger<NewsLogController> logger,
            UserManager<ApplicationUser> userManager,
            INewsService newsService,
            INewsLog newLog,
            IHostingEnvironment environment
            ) : base(configuration, logger)
        {
            _newsService = newsService;
            _newLog = newLog;
            _userManager = userManager;
            _hostingEnvironment = environment;
        }



        // list new
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("GetNewsLogByNewsIdGroupNameFrom")]
        public IList<NewsLog> GetNewsLogByNewsIdGroupNameFrom(int NewsId, string GroupNameFrom , int type)
        {
            return _newLog.GetNewsLogByNewsIdGroupNameFrom(NewsId, GroupNameFrom , type);
        }

        // list new
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("GetNewsLogByNewsIdNameFrom")]
        public IList<NewsLog> GetNewsLogByNewsIdNameFrom(int NewsId, string UserName)
        {
            return _newLog.GetNewsLogByNewsIdNameFrom(NewsId, UserName);
        }

        // list new
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("PostReport")]
        public NewsLog PostReport([FromBody]NewViewReport2 data)
        {
            return _newLog.AddOrUpdateReport(data.Id , data.Data);
        }

        // list Report 
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("GetReport")]
        public IList<NewLogUpLoad> GetReport(int NewsId)
        {
            return _newLog.GetReport(NewsId);
        }

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("GetInfoNewLog")]
        public async Task<IActionResult> GetInfoNewLog(int news_id, string group)
        {
            try
            {
                var phancongData = _newLog.GetPhanCongList(news_id, group);
                var info = _newLog.GetInfoNewLog(news_id, group);
                return Ok(new { phancong = phancongData, info = info });
            }
            catch(Exception ex)
            {
                return BadRequest(new { err = ex.Message });
            }
           
        }
        
        [HttpDelete("delete/{id}")]
        public string deletefile(int id)
        {
            return _newLog.DeleteFile(id);
        }

        [HttpGet("upload/{id}")]
        public async Task<IActionResult> Getfile(int id)
        {
            var urlWeb = apiSettings.BaseUrl;
            var fileUpload = _newLog.GetFile(id, urlWeb);
            return Ok(new { files = fileUpload });
        }

        [HttpPost("upload")]
        public virtual async Task<IActionResult> Upload(string __RequestVerificationToken, IList<IFormFile> files)
        {
            try
            {
                var urlWeb = apiSettings.BaseUrl;
                var id = Request.Headers.Where(x => x.Key == "IdReprot").FirstOrDefault();
                var idReport = id.Value;
                long size = files.Sum(f => f.Length);
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/");
               
                    if (!Directory.Exists(filePath))
                    {
                        Directory.CreateDirectory(filePath);
                    }

                    var dataReturn = new List<FileUpload>();
                    foreach (var formFile in files)
                    {
                        var fileType = formFile.ContentType;
                        var fileSize = formFile.Length;
                        if (fileType.IndexOf("image") != -1 || fileType.IndexOf("officedocument") != -1)
                        {
                            if(fileSize < 50000000)
                            {
                                var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(formFile.FileName);
                                if (formFile.Length > 0)
                                {
                                    using (var stream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                                    {
                                        await formFile.CopyToAsync(stream);
                                    }
                                }
                                var obj = new FileUpload();
                                obj.deleteType = "DELETE";
                                obj.name = formFile.FileName;
                                obj.size = formFile.Length;
                                obj.thumbnailUrl = urlWeb + "/uploads/" + fileName;
                                obj.type = formFile.ContentType;
                                obj.url = urlWeb + "/uploads/" + fileName;
                                int fileid = _newLog.AddtoFileTable(obj, idReport);
                                if (fileid > 0)
                                {
                                    obj.deleteUrl = urlWeb + "/api/NewsLog/delete/" + fileid.ToString();
                                    dataReturn.Add(obj);
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
                    }
                    return Ok(new { files = dataReturn });
            }
            catch (Exception e) {
                return BadRequest(new { err = e.Message });
            }      
        }

        [AllowAnonymous]
        [HttpDelete("deleteAno/{filename}")]
        public string deleteAno(string filename)
        {
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "uploadsAno/");
            System.IO.File.Delete(Path.Combine(filePath, filename));
            return filename;
        }

        [AllowAnonymous]
        [HttpPost("uploadAno")]
        public virtual async Task<IActionResult> UploadAno(string __RequestVerificationToken, IList<IFormFile> files)
        {
            try
            {
                if(string.IsNullOrEmpty(__RequestVerificationToken) == false)
                {
                    var urlWeb = apiSettings.BaseUrl;
                    long size = files.Sum(f => f.Length);
                    var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "uploadsAno/");
                    if (!Directory.Exists(filePath))
                    {
                        Directory.CreateDirectory(filePath);
                    }

                    var dataReturn = new List<FileUpload>();
                    foreach (var formFile in files)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(formFile.FileName);
                        if (formFile.Length > 0)
                        {
                            using (var stream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                            {
                                await formFile.CopyToAsync(stream);
                            }
                        }
                        var obj = new FileUpload();
                        obj.deleteType = "DELETE";
                        obj.name = formFile.FileName;
                        obj.size = formFile.Length;
                        obj.thumbnailUrl = urlWeb + "/uploadsAno/" + fileName;
                        obj.type = formFile.ContentType;
                        obj.url = urlWeb + "/uploadsAno/" + fileName;
                        obj.deleteUrl = urlWeb + "/api/NewsLog/deleteAno/" + fileName;
                        dataReturn.Add(obj);
                        
                    }

                    return Ok(new { files = dataReturn });
                }
                return BadRequest(new { err = "error" });
            }
            catch (Exception e)
            {
                return BadRequest(new { err = e.Message });
            }
        }

        [AllowAnonymous]
        [HttpPost("uploadAnoVideo")]
        public virtual async Task<IActionResult> UploadAnoVideo(string __RequestVerificationToken, IFormFile files)
        {
            try
            {
                var urlWeb = apiSettings.BaseUrl;
                long size = files.Length;
                var fileType = files.ContentType;
                if(fileType.IndexOf("video") != -1)
                {
                    if(size <= 50000000)
                    {
                        var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "uploadsAno/");
                        if (!Directory.Exists(filePath))
                        {
                            Directory.CreateDirectory(filePath);
                        }

                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(files.FileName);
                        if (files.Length > 0)
                        {
                            using (var stream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                            {
                                await files.CopyToAsync(stream);
                            }
                        }
                        var obj = new FileUpload();
                        obj.deleteType = "DELETE";
                        obj.name = files.FileName;
                        obj.size = files.Length;
                        obj.thumbnailUrl = urlWeb + "/uploadsAno/" + fileName;
                        obj.type = files.ContentType;
                        obj.url = urlWeb + "/uploadsAno/" + fileName;
                        obj.deleteUrl = urlWeb + "/api/NewsLog/deleteAno/" + fileName;

                        return Ok(new { files = obj });
                    }
                    else
                    {
                        return BadRequest(new { err = "Dung lượng nhỏ hơn 50mb!" });
                    }
                    
                }
                else
                {
                    return BadRequest(new { err = "Đây không phải là tệp video!" });
                }
            }
            catch (Exception e)
            {
                return BadRequest(new { err = e.Message });
            }
        }
    }
}