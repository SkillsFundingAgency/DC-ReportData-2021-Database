using System;
using System.Collections.Generic;

namespace ESFA.DC.ReportData.Model
{
    public partial class FundingSummaryReport
    {
        public int Id { get; set; }
        public int Ukprn { get; set; }
        public int ReturnPeriod { get; set; }
        public string ContractNo { get; set; }
        public string FundingCategory { get; set; }
        public string FundingSubCategory { get; set; }
        public string FundLine { get; set; }
        public decimal? Aug20 { get; set; }
        public decimal? Sep20 { get; set; }
        public decimal? Oct20 { get; set; }
        public decimal? Nov20 { get; set; }
        public decimal? Dec20 { get; set; }
        public decimal? Jan21 { get; set; }
        public decimal? Feb21 { get; set; }
        public decimal? Mar21 { get; set; }
        public decimal? Apr21 { get; set; }
        public decimal? May21 { get; set; }
        public decimal? Jun21 { get; set; }
        public decimal? Jul21 { get; set; }
        public decimal? AugMar { get; set; }
        public decimal? AprJul { get; set; }
        public decimal? YearToDate { get; set; }
        public decimal? Total { get; set; }
    }
}
