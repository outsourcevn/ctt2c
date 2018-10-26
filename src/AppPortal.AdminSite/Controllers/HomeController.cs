using AppPortal.AdminSite.Controllers.Base;
using AppPortal.AdminSite.ViewModels;
using AppPortal.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;
using System.Diagnostics;

namespace AppPortal.AdminSite.Controllers
{
    [DisplayName("Trang chủ")]
    public class HomeController : AdminBaseController<HomeController>
    {
        public HomeController(
            IConfiguration configuration,
            IAppLogger<HomeController> logger) : base(configuration, logger)
        {
        }

        [DisplayName("Giới thiệu")]
        public IActionResult Index()
        {
            var url = "/news";
            return Redirect(url);
        }

        [AllowAnonymous]
        [DisplayName("Error")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("/Error/{StatusCode}")]
        [AllowAnonymous]
        public IActionResult StatusCode(int? statusCode)
        {
            var reExecute = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            _logger.LogInformation($"Unexpected Status Code: {statusCode}, OriginalPath: {reExecute.OriginalPath}");
            return View(statusCode);
        }
    }
}
