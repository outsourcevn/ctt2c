using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.Core.Entities.v2
{
    public class V2Organization : BaseEntity<string>
    {
        public V2Organization()
        {
            if (string.IsNullOrEmpty(Id))
            {
                this.Id = Guid.NewGuid().ToString();
            }
        }

        public string Name { get; set; }
        public string OrganizationId { get; set; }
        public string AddRess { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string UserCreator { get; set; }
        public ICollection<V2User> V2Users { get; set; }
    }
}
