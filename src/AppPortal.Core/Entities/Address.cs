using System.Collections.Generic;

namespace AppPortal.Core.Entities
{
    public class Address : BaseEntity<int>
    {
        public string Name { get; set; }
        public string ProvinceType { get; set; }
        public string LatLong { get; set; }
        public int? ProvinceId { get; set; }
        public IEnumerable<News> News { get; set; }
    }
}
