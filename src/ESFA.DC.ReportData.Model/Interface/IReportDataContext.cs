using System;
using System.Linq;

namespace ESFA.DC.PeriodEnd.DataPersist.Model.Interface
{
    public interface IReportDataContext : IDisposable
    {
        IQueryable<McaGlaDevolvedOccupancyReport> McaGlaDevolvedOccupancyReports { get; }
    }
}
