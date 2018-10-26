using AppPortal.Core.Interfaces;

namespace AppPortal.Core.Entities
{
    public class BaseEntity<Tkey> : IEntity<Tkey>
    {
        public Tkey Id { get; set; }
    }
}
