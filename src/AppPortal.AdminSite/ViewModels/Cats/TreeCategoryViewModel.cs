using System.Collections.Generic;

namespace AppPortal.AdminSite.ViewModels.Cats
{
    public class TreeCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sename { set; get; }
        public string TargetUrl { get; set; }
        public int OrderSort { get; set; }
        public bool IsShow { get; set; }
        public IList<TreeCategoryViewModel> items { get; set; }
    }
}
