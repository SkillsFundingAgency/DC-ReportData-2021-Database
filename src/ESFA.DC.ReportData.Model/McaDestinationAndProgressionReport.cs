using System;
using System.Collections.Generic;

namespace ESFA.DC.ReportData.Model
{
    public partial class McaDestinationAndProgressionReport
    {
        public int Id { get; set; }
        public int Ukprn { get; set; }
        public string Year { get; set; }
        public int Return { get; set; }
        public string ApplicableAreaFromSourceOfFunding { get; set; }
        public string ProviderName { get; set; }
        public string LearnRefNumber { get; set; }
        public long? UniqueLearnerNumber { get; set; }
        public string LearningAimReference { get; set; }
        public string LearningAimTitle { get; set; }
        public int FundingModel { get; set; }
        public string LSDPostcode { get; set; }
        public string SOF { get; set; }
        public DateTime? LearnActEndDate { get; set; }
        public int CompStatus { get; set; }
        public int? Outcome { get; set; }
        public string OutType { get; set; }
        public int OutCode { get; set; }
        public DateTime OutStartDate { get; set; }
        public DateTime? OutEndDate { get; set; }
        public DateTime OutCollDate { get; set; }
    }
}
