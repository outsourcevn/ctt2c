using AppPortal.ApiHost.Controllers.Base;
using AppPortal.Core;
using AppPortal.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.ApiHost.Controllers
{
    public class ValuesController : ApiBaseController<ValuesController>
    {
        public ValuesController(
            IConfiguration configuration,
            IAppLogger<ValuesController> logger) : base(configuration, logger)
        {
        }

        [Authorize(PolicyRole.EMPLOYEE_ID)]
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        [Authorize(PolicyRole.EMPLOYEE_ID)]
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Authorize(PolicyRole.EMPLOYEE_ID)]
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [Authorize(PolicyRole.EMPLOYEE_ID)]
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [Authorize(PolicyRole.EMPLOYEE_ID)]
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
