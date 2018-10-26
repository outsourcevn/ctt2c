using AppPortal.ApiHost.Controllers.Base;
using AppPortal.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.ApiHost.Controllers
{
    [Produces("application/json")]
    public class ReportsController : ApiBaseController<ReportsController>
    {
        public ReportsController(
            IConfiguration configuration, 
            IAppLogger<ReportsController> logger) : base(configuration, logger)
        {
        }
    }
}