using System;
using System.Linq;

namespace ESFA.DC.ReportData.Model.Interface
{
    public interface IReportDataContext : IDisposable
    {
        IQueryable<McaGlaDevolvedOccupancyReport> McaGlaDevolvedOccupancyReports { get; }
    }
}
