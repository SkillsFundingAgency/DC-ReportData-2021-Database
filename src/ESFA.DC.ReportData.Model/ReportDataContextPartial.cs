using System.Linq;
using ESFA.DC.PeriodEnd.DataPersist.Model.Interface;
using Microsoft.EntityFrameworkCore;

namespace ESFA.DC.PeriodEnd.DataPersist.Model
{
    public partial class ReportDataContext : IReportDataReadWriteContext, IReportDataContext
    {
        DbSet<McaGlaDevolvedOccupancyReportV2> IReportDataReadWriteContext.McaGlaDevolvedOccupancyReportV2s => McaGlaDevolvedOccupancyReportV2s;

        IQueryable<McaGlaDevolvedOccupancyReportV2> IReportDataContext.McaGlaDevolvedOccupancyReportV2s => McaGlaDevolvedOccupancyReportV2s;
    }
}
