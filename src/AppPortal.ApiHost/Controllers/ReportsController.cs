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
    public class ReportsController : ApiBaseController<ReportsController>
    {
        private readonly INewsService _newsService;
        private readonly INewsLog _newLog;
        private readonly UserManager<ApplicationUser> _userManager;
        public ReportsController(
            IConfiguration configuration,
            IAppLogger<ReportsController> logger,
            UserManager<ApplicationUser> userManager,
            INewsService newsService,
            INewsLog newLog
            ) : base(configuration, logger)
        {
            _newsService = newsService;
            _newLog = newLog;
            _userManager = userManager;
        }

        [AllowAnonymous]
        [HttpGet("getReport1")]
        public IActionResult GetReport1(string startdate = "" , string enddate = "")
        {
            var query = _newsService.GetReport1(startdate, enddate);
            return Ok(query);
        }

        [AllowAnonymous]
        [HttpGet("getReport2")]
        public IActionResult GetReport2(string startdate = "", string enddate = "")
        {
            var query = _newsService.GetReport2(startdate, enddate);
            return Ok(query);
        }

        [AllowAnonymous]
        [HttpGet("getReport3")]
        public IActionResult GetReport3(string startdate = "", string enddate = "")
        {
            var query = _newsService.GetReport3(startdate, enddate);
            return Ok(query);
        }

        [AllowAnonymous]
        [HttpGet("getReport4")]
        public IActionResult GetReport4(string startdate = "", string enddate = "")
        {
            var query = _newsService.GetReport4(startdate, enddate);
            return Ok(query);
        }
    }
}