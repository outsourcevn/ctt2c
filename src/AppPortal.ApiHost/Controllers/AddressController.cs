using System.Linq;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models.Addresses;
using AppPortal.ApiHost.Controllers.Base;
using AppPortal.ApiHost.ViewModels;
using AppPortal.ApiHost.ViewModels.Addresses;
using AppPortal.Core;
using AppPortal.Core.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.ApiHost.Controllers
{
    [Produces("application/json")]
    public class AddressController : ApiBaseController<AddressController>
    {
        private readonly IAddressService _addressService;
        public AddressController(
            IAddressService addressService,
            IConfiguration configuration, 
            IAppLogger<AddressController> logger) : base(configuration, logger)
        {
            _addressService = addressService;
        }

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("getAddress")]
        public IActionResult ListAddressAsync(int? skip = 0, int? page = 1, int? take = 15, string keyword = "", int? provinceId = -1)
        {
            var query = _addressService.GetLstAddressPaging(out int rows, skip, take, keyword, provinceId);
            var vm = query.Select(n => Mapper.Map<AddressModel, AddressViewModel>(n));
            return ResponseInterceptor(vm, rows, new Paging()
            {
                PageNumber = page.Value,
                PageSize = take.Value,
                Take = take.Value,
                Skip = skip.Value,
                Query = keyword,
            });
        }
    }
}
