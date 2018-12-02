using System.ComponentModel;
using AppPortal.AdminSite.Controllers.Base;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.AdminSite.Controllers
{
    [DisplayName("Cài đặt nâng cao")]
    public class AppController : AdminBaseController<AppController>
    {
        private readonly IMediaService _mediaService;
        public AppController(
            IConfiguration configuration,
             IMediaService mediaService,
            IAppLogger<AppController> logger) : base(configuration, logger)
        {
            _mediaService = mediaService;
        }

        [DisplayName("Thiết lập hệ thống")]
        public IActionResult Config()
        {
            var data = _mediaService.GetConfig("map");
            ViewData["url"] = data.url;
            return View();
        }
    }
}