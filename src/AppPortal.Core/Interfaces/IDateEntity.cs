using System;
namespace AppPortal.Core.Interfaces
{
    public interface IDateEntity
    {
        DateTime? OnCreated { get; set; }
        DateTime? OnUpdated { get; set; }
        DateTime? OnDeleted { get; set; }
        DateTime? OnPublished { get; set; }
    }
}
