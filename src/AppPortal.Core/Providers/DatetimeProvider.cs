using AppPortal.Core.Interfaces;
using System;

namespace AppPortal.Core.Providers
{
    public class DatetimeProvider : IDatetimeProvider
    {
        public DateTime Now => DateTime.Now;
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
