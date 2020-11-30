using System.Linq;
using ESFA.DC.ReportData.Model.Interface;
using Microsoft.EntityFrameworkCore;

namespace ESFA.DC.ReportData.Model
{
    public partial class ReportDataContext : IReportDataReadWriteContext, IReportDataContext
    {
        DbSet<McaGlaDevolvedOccupancyReport> IReportDataReadWriteContext.McaGlaDevolvedOccupancyReports => McaGlaDevolvedOccupancyReports;

        IQueryable<McaGlaDevolvedOccupancyReport> IReportDataContext.McaGlaDevolvedOccupancyReports => McaGlaDevolvedOccupancyReports;
    }
}
