using System;
using System.Collections.Generic;

namespace ESFA.DC.ReportData.Model
{
    public partial class UYPSummaryViewReport
    {
        public int Id { get; set; }
        public int Ukprn { get; set; }
        public int ReturnPeriod { get; set; }
        public int? NumberofLearners { get; set; }
        public int? NumberofDatalocks { get; set; }
        public int? NumberofClawbacks { get; set; }
        public int? NumberofHBCP { get; set; }
        public int? NumberofOthers { get; set; }
        public int? NumberofCoInvestmentsToCollect { get; set; }
        public int? NumberofEarningsReleased { get; set; }
        public decimal? EarningsReleased { get; set; }
        public decimal? TotalEarningsForThisPeriod { get; set; }
        public decimal? TotalCostOfDataLocksForThisPeriod { get; set; }
        public decimal? TotalCostOfHBCPForThisPeriod { get; set; }
        public decimal? TotalCostofClawbackForThisPeriod { get; set; }
        public decimal? TotalCostofOthersForThisPeriod { get; set; }
        public decimal? ESFAPlannedPaymentsForThisPeriod { get; set; }
        public decimal? CoInvestmentPaymentsToCollectForThisPeriod { get; set; }
        public decimal? TotalEarningsToDate { get; set; }
        public decimal? TotalPaymentsToDate { get; set; }
        public decimal? TotalCoInvestmentCollectedToDate { get; set; }
        public decimal? YTDTotalEarnings { get; set; }
        public decimal? SummaryTotal { get; set; }
    }
}
