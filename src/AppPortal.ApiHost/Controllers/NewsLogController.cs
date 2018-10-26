using System;
using System.Collections.Generic;
using System.Linq;
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
        public NewsLogController(
            IConfiguration configuration,
            IAppLogger<NewsLogController> logger,
            UserManager<ApplicationUser> userManager,
            INewsService newsService,
            INewsLog newLog
            ) : base(configuration, logger)
        {
            _newsService = newsService;
            _newLog = newLog;
            _userManager = userManager;
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

    }
}