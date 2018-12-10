using System.ComponentModel;
using AppPortal.AdminSite.Controllers.Base;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models.News;
using AppPortal.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace AppPortal.AdminSite.Controllers
{
    [DisplayName("Tổng hợp báo cáo")]
    public class ReportsController : AdminBaseController<ReportsController>
    {
        private readonly INewsService _newsService;

        public ReportsController(
            INewsService newsService,
            IConfiguration configuration, 
            IAppLogger<ReportsController> logger) : base(configuration, logger)
        {
            _newsService = newsService;
        }

        [DisplayName("Báo cáo thống kê")]
        public IActionResult Index()
        {
            IList<ListItemNewsMap> data = _newsService.ReportNews();
            ViewData["data"] = data;
            return View();
        }

        [DisplayName("Báo cáo thống kê bằng biểu đồ")]
        public IActionResult Chart()
        {
            // Theo các loại ô nhiễm
            IList<ListItemNewsCategory> data = _newsService.ReportNewsCategory();
            ViewData["data"] = data;

            // Theo năm
            IList<ListItemNewsMapYear> data2 = _newsService.ReportNewsYear();
            ViewData["dataYear"] = data2;
            // Theo các loại và năm
            return View();
        }

        [DisplayName("Báo cáo thống kê bằng biểu đồ")]
        [HttpGet("Reports/gopy-phananh")]
        public IActionResult gopyphananh()
        {
            return View();
        }

        [HttpGet("Reports/gopy-phananh-nguoidan-ngoanhnghiep")]
        public IActionResult gopyphananh_nd_dn()
        {
            return View();
        }

        [HttpGet("Reports/gopy-phananh-nguoidan-ngoanhnghiep-chude")]
        public IActionResult gopyphananh_nd_dn_chude()
        {
            return View();
        }

        [HttpGet("Reports/gopy-phananh-khuvuc-dialy")]
        public IActionResult gopyphananh_khuvuc_dialy()
        {
            return View();
        }

    }
}