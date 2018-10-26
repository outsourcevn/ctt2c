using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.Core.Entities.v2
{
    public class V2User : BaseEntity<string>
    {
        public V2User()
        {
            if (string.IsNullOrEmpty(Id))
            {
                this.Id = Guid.NewGuid().ToString();
            }
        }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Office { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string V2OrganizationId { get; set; }
        public V2Organization V2Organization { get; set; }
    }
}
