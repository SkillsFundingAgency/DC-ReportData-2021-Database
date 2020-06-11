using System.Linq;
using ESFA.DC.PeriodEnd.DataPersist.Model.Interface;
using Microsoft.EntityFrameworkCore;

namespace ESFA.DC.PeriodEnd.DataPersist.Model
{
    public partial class ReportDataContext : IReportDataReadWriteContext, IReportDataContext
    {
        DbSet<McaGlaDevolvedOccupancyReport> IReportDataReadWriteContext.McaGlaDevolvedOccupancyReports => McaGlaDevolvedOccupancyReports;

        IQueryable<McaGlaDevolvedOccupancyReport> IReportDataContext.McaGlaDevolvedOccupancyReports => McaGlaDevolvedOccupancyReports;
    }
}
