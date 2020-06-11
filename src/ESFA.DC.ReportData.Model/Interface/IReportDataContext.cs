using System;
using System.Linq;

namespace ESFA.DC.PeriodEnd.DataPersist.Model.Interface
{
    public interface IReportDataContext : IDisposable
    {
        IQueryable<McaGlaDevolvedOccupancyReportV2> McaGlaDevolvedOccupancyReportV2s { get; }
    }
}
