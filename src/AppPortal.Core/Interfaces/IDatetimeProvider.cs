using System;

namespace AppPortal.Core.Interfaces
{
    public interface IDatetimeProvider
    {
        DateTime Now { get; }
        DateTime NowUtc { get; }
    }
}
