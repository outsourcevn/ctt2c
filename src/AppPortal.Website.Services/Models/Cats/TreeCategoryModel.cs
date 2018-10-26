using System.Collections.Generic;

namespace AppPortal.Website.Services.Models.Cats
{
    public class TreeCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sename { set; get; }
        public string TargetUrl { get; set; }
        public int? OrderSort { get; set; }
        public bool IsShow { get; set; }
        public IList<TreeCategoryModel> items { get; set; }
    }
}
