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
        public AppController(
            IConfiguration configuration,
            IAppLogger<AppController> logger) : base(configuration, logger)
        {
        }

        [DisplayName("Thiết lập hệ thống")]
        public IActionResult Config()
        {
            return View();
        }
    }
}