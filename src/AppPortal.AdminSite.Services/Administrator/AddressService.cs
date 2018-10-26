using System.Collections.Generic;
using System.Linq;
using AppPortal.AdminSite.Services.Extensions;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models.Addresses;
using AppPortal.Core.Entities;
using AppPortal.Core.Interfaces;

namespace AppPortal.AdminSite.Services.Administrator
{
    public class AddressService : IAddressService
    {
        private readonly IRepository<Address, int> _addressRepository;
        private readonly IAppLogger<AddressService> _appLogger;
        public AddressService(
            IRepository<Address, int> addressRepository,
            IAppLogger<AddressService> appLogger)
        {
            _addressRepository = addressRepository;
            _appLogger = appLogger;
        }

        public Address GetById(int Id)
        {
            return GetTables().SingleOrDefault(t => t.ProvinceId == Id);
        }

        public IList<AddressModel> GetLstAddressPaging(out int rows, int? skip = 0, int? take = 15, string keyword = "", int? ProvinceId = -1)
        {
            var query = GetTables();
            if (query == null)
            {
                rows = 0;
                return new List<AddressModel>() { };
            }
            if (!string.IsNullOrEmpty(keyword) && keyword != "") query = query.Where(x => x.Name.Contains(keyword));
            if (ProvinceId.Value > 0) query = query.Where(x => x.ProvinceId == ProvinceId);
            rows = query.Count();
            query = query.OrderByDescending(x => x.ProvinceType);
            if (skip > rows)
            {
                take = rows % take.Value;
                skip = 0;
                query = query.Skip(rows - take.Value).Take(take.Value);
            }
            else query = query.Skip(skip.Value).Take(take.Value);
            return query.Select(x => x.EntityToModel()).ToList();
        }

        public IQueryable<Address> GetTables()
        {
            return _addressRepository.Table;
        }
    }
}
