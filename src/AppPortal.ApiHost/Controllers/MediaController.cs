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
    public class MediaController : ApiBaseController<MediaController>
    {
        private readonly INewsService _newsService;
        private readonly INewsLog _newLog;
        private readonly UserManager<ApplicationUser> _userManager;
        private IHostingEnvironment _hostingEnvironment;
        public MediaController(
            IConfiguration configuration,
            IAppLogger<MediaController> logger,
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
    }
}