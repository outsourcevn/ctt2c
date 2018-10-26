﻿using System.Collections.Generic;

namespace AppPortal.AdminSite.Services.Models
{
    public class MvcControllerInfo
    {
        public string Id => $"{AreaName}:{Name}";
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string AreaName { get; set; }
        public IEnumerable<MvcActionInfo> Actions { get; set; }
    }

    public class MvcActionInfo
    {
        public string Id => $"{ControllerId}:{Name}";
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ControllerId { get; set; }
    }
}
