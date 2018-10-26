using System.Collections.Generic;
using System.Linq;
using AppPortal.Core.Entities;
using AppPortal.Website.Services.Models.Addresses;

namespace AppPortal.Website.Services.Interfaces
{
    public interface IAddressService
    {
        IList<AddressModel> GetAddress(int? ProvinceId);
        IQueryable<Address> GetTables();
    }
}
