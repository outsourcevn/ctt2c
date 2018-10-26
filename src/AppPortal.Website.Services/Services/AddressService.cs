using System.Collections.Generic;
using System.Linq;
using AppPortal.Core.Entities;
using AppPortal.Core.Interfaces;
using AppPortal.Website.Services.Extensions;
using AppPortal.Website.Services.Interfaces;
using AppPortal.Website.Services.Models.Addresses;

namespace AppPortal.Website.Services.Websites
{
    public class AddressService : IAddressService
    {
        private readonly IRepository<Address, int> _address;
        private readonly IAppLogger<AddressService> _appLogger;
        public AddressService(
            IRepository<Address, int> address,
            IAppLogger<AddressService> appLogger)
        {
            _appLogger = appLogger;
        }
        public IList<AddressModel> GetAddress(int? ProvinceId)
        {
            if (!ProvinceId.HasValue || ProvinceId == 0)
            {
                var entities = GetTables().Where(x => x.ProvinceId == null || x.ProvinceId == 0);
                var lstModels = entities.ToList().MapLstEntityToListModel();
                return lstModels;
            }else
            {
                var entities = GetTables().Where(x => x.ProvinceId == ProvinceId);
                var lstModels = entities.ToList().MapLstEntityToListModel();
                return lstModels;
            }
        }

        public IQueryable<Address> GetTables()
        {
            return _address.Table;
        }
    }
}
