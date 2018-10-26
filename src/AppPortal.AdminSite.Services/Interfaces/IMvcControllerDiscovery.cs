using AppPortal.AdminSite.Services.Models;
using System.Collections.Generic;

namespace AppPortal.AdminSite.Services.Interfaces
{
    public interface IMvcControllerDiscovery
    {
        IEnumerable<MvcControllerInfo> GetControllers();
    }
}
