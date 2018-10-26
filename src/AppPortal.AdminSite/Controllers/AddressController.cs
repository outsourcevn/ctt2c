using System.ComponentModel;
using AppPortal.AdminSite.Controllers.Base;
using AppPortal.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.AdminSite.Controllers
{
    public class AddressController : AdminBaseController<AddressController>
    {
        public AddressController(IConfiguration configuration, IAppLogger<AddressController> logger) : base(configuration, logger)
        {
        }

        [DisplayName("Danh sách địa chỉ")]
        public IActionResult Index(string keyword, int? pageSize, int? take = 15, int? skip = 0, int? page = 1, int? provinceId = -1)
        {
            if (!take.HasValue) take = 15;
            if (!page.HasValue) page = 1;
            if (!pageSize.HasValue) pageSize = take;
            if (string.IsNullOrEmpty(keyword)) keyword = "";
            ViewData["keyword"] = keyword;
            ViewData["take"] = take;
            ViewData["page"] = page;
            ViewData["pageSize"] = pageSize;
            ViewData["provinceId"] = provinceId;
            return View();
        }
    }
}