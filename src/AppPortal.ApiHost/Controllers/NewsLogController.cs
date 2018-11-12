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
        public IList<NewsLog> GetReport(int NewsId)
        {
            return _newLog.GetReport(NewsId);
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
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
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
                        using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
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
                    if(fileid > 0)
                    {
                        obj.deleteUrl = urlWeb + "/api/NewsLog/delete/" + fileid.ToString();
                        dataReturn.Add(obj);
                    }
                }
                
                return Ok(new { files = dataReturn});
            }
            catch (Exception e) {
                return BadRequest(new { err = e.Message });
            }      
        }
    }
}