using System.Collections.Generic;
using System.Linq;
using AppPortal.AdminSite.Services.Models.Addresses;
using AppPortal.Core.Entities;

namespace AppPortal.AdminSite.Services.Interfaces
{
    public interface IAddressService
    {
        IList<AddressModel> GetLstAddressPaging(out int rows, int? skip = 0, int? take = 15, string keyword = "", int? ProvinceId = -1);
        IQueryable<Address> GetTables();
        Address GetById(int Id);
    }
}
