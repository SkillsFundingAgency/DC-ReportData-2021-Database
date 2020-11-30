using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ESFA.DC.ReportData.Model.Interface
{
    public interface IReportDataReadWriteContext : IDisposable
    {
        DbSet<McaGlaDevolvedOccupancyReport> McaGlaDevolvedOccupancyReports { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        DatabaseFacade Database { get; }
    }
}
