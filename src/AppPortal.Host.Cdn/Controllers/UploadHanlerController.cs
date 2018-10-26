using System.Net;
using System.Threading.Tasks;
using AppPortal.Host.Cdn.Interfaces;
using Backload.Contracts.Context;
using Backload.Contracts.FileHandler;
using Backload.Helper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppPortal.Host.Cdn.Controllers
{
    // custom file handler endpoint url: "/UploadHanler/FileHandler"
    public class UploadHanlerController : BaseController<UploadHanlerController>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UploadHanlerController(
            IHttpContextAccessor httpContextAccessor,
            IHostingEnvironment environment, 
            IConfiguration configuration, 
            IAppLogger<UploadHanlerController> logger) : base(environment, configuration, logger)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: /<controller>/
        [HttpGet]
        [HttpPost]
        [HttpDelete]
        [HttpPut]
        [HttpOptions]
        public async Task<IActionResult> FileHandler()
        {
            try
            {
                // Create and initialize the handler
                IFileHandler handler = Backload.FileHandler.Create();
                handler.Init(_httpContextAccessor.HttpContext, _hostingEnvironment);

                // Call an execution method and get the result
                IBackloadResult result = await handler.Execute(false);

                // MVC: Helper to create an ActionResult object from the IBackloadResult instance
                return ResultCreator.Create(result);
            }
            catch
            {
                return new NotFoundObjectResult(HttpStatusCode.InternalServerError);
            }
        }
    }
}
