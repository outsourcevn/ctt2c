using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.Core.Entities.v2
{
    public class V2Assignment : BaseEntity<long>
    {
        public string OrganizationId { get; set; }
        public long V2PriorityId { get; set; }
    }
}
