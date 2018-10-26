using System.Collections.Generic;

namespace AppPortal.AdminSite.ViewModels
{
    public class MvcControllerInfoViewModel
    {
        public string Id => $"{AreaName}:{Name}";
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string AreaName { get; set; }
        public IEnumerable<MvcActionInfoViewModel> Actions { get; set; }
    }

    public class MvcActionInfoViewModel
    {
        public string Id => $"{ControllerId}:{Name}";
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ControllerId { get; set; }
    }
}
