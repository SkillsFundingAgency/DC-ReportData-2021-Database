using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ESFA.DC.ReportData.Model
{
    public partial class ReportDataContext : DbContext
    {
        public ReportDataContext()
        {
        }

        public ReportDataContext(DbContextOptions<ReportDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppsAdditionalPayment> AppsAdditionalPayments { get; set; }
        public virtual DbSet<AppsCoInvestmentContribution> AppsCoInvestmentContributions { get; set; }
        public virtual DbSet<AppsMonthlyPayment> AppsMonthlyPayments { get; set; }
        public virtual DbSet<FundingSummaryReport> FundingSummaryReports { get; set; }
        public virtual DbSet<LearnerLevelViewReport> LearnerLevelViewReports { get; set; }
        public virtual DbSet<McaGlaDevolvedOccupancyReport> McaGlaDevolvedOccupancyReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\;Database=ESFA.DC.ReportData.Database;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AppsAdditionalPayment>(entity =>
            {
                entity.Property(e => e.AprilEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilR09Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustR01Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberR05Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.EmployerIdentifierFromILR).IsUnicode(false);

                entity.Property(e => e.EmployerNameFromApprenticeshipService).IsUnicode(false);

                entity.Property(e => e.FamilyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FebruaryEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryR07Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FundingLineType).IsUnicode(false);

                entity.Property(e => e.GivenNames)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JanuaryEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryR06Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyR12Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneR11Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.LearnerReferenceNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LearningStartDate).HasColumnType("datetime");

                entity.Property(e => e.MarchEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchR08Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayR10Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberR04Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberR03Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.ProviderSpecifiedLearnerMonitoringA)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderSpecifiedLearnerMonitoringB)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.R13Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R14Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberR02Payments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalEarnings).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalPaymentsYearToDate).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TypeOfAdditionalPayment).IsUnicode(false);
            });

            modelBuilder.Entity<AppsCoInvestmentContribution>(entity =>
            {
                entity.ToTable("AppsCoInvestmentContribution");

                entity.Property(e => e.ApplicableProgrammeStartDate).HasColumnType("datetime");

                entity.Property(e => e.CoInvestmentDueFromEmployerForApril).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForAugust).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForDecember).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForFebruary).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForJanuary).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForJuly).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForJune).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForMarch).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForMay).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForNovember).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForOctober).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForR13).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForR14).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentDueFromEmployerForSeptember).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CompletionEarningThisFundingYear).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CompletionPaymentsThisFundingYear).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.EmployerCoInvestmentPercentage).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.EmployerNameFromApprenticeshipService)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FamilyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GivenNames)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LDM356Or361)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LearnRefNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LearningStartDate).HasColumnType("datetime");

                entity.Property(e => e.PercentageOfCoInvestmentCollected).HasColumnType("decimal(28, 10)");

                entity.Property(e => e.SoftwareSupplierAimIdentifier)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCoInvestmentDueFromEmployerInPreviousFundingYears).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalCoInvestmentDueFromEmployerThisFundingYear).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalPMRPreviousFundingYears).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalPMRThisFundingYear).HasColumnType("decimal(15, 5)");
            });

            modelBuilder.Entity<AppsMonthlyPayment>(entity =>
            {
                entity.ToTable("AppsMonthlyPayment");

                entity.Property(e => e.AprilApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilTotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustTotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberTotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FcsContractContractAllocationContractAllocationNumber).IsUnicode(false);

                entity.Property(e => e.FebruaryApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryTotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryTotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyTotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneTotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.LarsLearningDeliveryLearningAimTitle).IsUnicode(false);

                entity.Property(e => e.LearnerCampusIdentifier).IsUnicode(false);

                entity.Property(e => e.LearnerEmploymentStatusDate).HasColumnType("datetime");

                entity.Property(e => e.LearnerFamilyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LearnerGivenNames)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LearningDeliveryAchievementDate).HasColumnType("datetime");

                entity.Property(e => e.LearningDeliveryEndPointAssessmentOrganisation).IsUnicode(false);

                entity.Property(e => e.LearningDeliveryFamTypeLearningDeliveryMonitoringA).IsUnicode(false);

                entity.Property(e => e.LearningDeliveryFamTypeLearningDeliveryMonitoringB).IsUnicode(false);

                entity.Property(e => e.LearningDeliveryFamTypeLearningDeliveryMonitoringC).IsUnicode(false);

                entity.Property(e => e.LearningDeliveryFamTypeLearningDeliveryMonitoringD).IsUnicode(false);

                entity.Property(e => e.LearningDeliveryFamTypeLearningDeliveryMonitoringE).IsUnicode(false);

                entity.Property(e => e.LearningDeliveryFamTypeLearningDeliveryMonitoringF).IsUnicode(false);

                entity.Property(e => e.LearningDeliveryLearningActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.LearningDeliveryLearningPlannedEndDate).HasColumnType("datetime");

                entity.Property(e => e.LearningDeliveryOriginalLearningStartDate).HasColumnType("datetime");

                entity.Property(e => e.LearningDeliverySoftwareSupplierAimIdentifier).IsUnicode(false);

                entity.Property(e => e.MarchApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchTotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayTotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberTotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberTotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PaymentFundingLineType).IsUnicode(false);

                entity.Property(e => e.PaymentLearnerReferenceNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentLearningAimReference).IsUnicode(false);

                entity.Property(e => e.PaymentLearningStartDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentPriceEpisodeStartDate).HasColumnType("datetime");

                entity.Property(e => e.ProviderSpecifiedDeliveryMonitoringA).IsUnicode(false);

                entity.Property(e => e.ProviderSpecifiedDeliveryMonitoringB).IsUnicode(false);

                entity.Property(e => e.ProviderSpecifiedDeliveryMonitoringC).IsUnicode(false);

                entity.Property(e => e.ProviderSpecifiedDeliveryMonitoringD).IsUnicode(false);

                entity.Property(e => e.ProviderSpecifiedLearnerMonitoringA)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderSpecifiedLearnerMonitoringB)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.R13ApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R13CoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R13CoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R13EmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R13EnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R13LearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R13LevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R13ProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R13TotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R14ApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R14CoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R14CoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R14EmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R14EnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R14LearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R14LevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R14ProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.R14TotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.RulebaseAecApprenticeshipPriceEpisodePriceEpisodeActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.SeptemberApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberProviderAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberTotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalApprenticeAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalCoInvestmentDueFromEmployerPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalCoInvestmentPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalEmployerAdditionalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalEnglishAndMathsPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalLearningSupportDisadvantageAndFrameworkUpliftPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalLevyPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalPayments).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalProviderAdditionalPayments).HasColumnType("decimal(15, 5)");
            });

            modelBuilder.Entity<FundingSummaryReport>(entity =>
            {
                entity.ToTable("FundingSummaryReport");

                entity.Property(e => e.Apr21).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprJul).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Aug20).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugMar).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.ContractNo).HasMaxLength(100);

                entity.Property(e => e.Dec20).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Feb21).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FundLine).HasMaxLength(200);

                entity.Property(e => e.FundingCategory).HasMaxLength(90);

                entity.Property(e => e.FundingSubCategory).HasMaxLength(70);

                entity.Property(e => e.Jan21).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Jul21).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Jun21).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Mar21).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.May21).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Nov20).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Oct20).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Sep20).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Total).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.YearToDate).HasColumnType("decimal(15, 5)");
            });

            modelBuilder.Entity<LearnerLevelViewReport>(entity =>
            {
                entity.ToTable("LearnerLevelViewReport");

                entity.Property(e => e.CoInvestmentOutstandingFromEmplToDate).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CoInvestmentPaymentsToCollectThisPeriod).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.ESFAPlannedPaymentsThisPeriod).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.EmployerName).IsUnicode(false);

                entity.Property(e => e.FamilyName).IsUnicode(false);

                entity.Property(e => e.GivenNames).IsUnicode(false);

                entity.Property(e => e.IssuesAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PaymentFundingLineType).IsUnicode(false);

                entity.Property(e => e.PaymentLearnerReferenceNumber)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedPaymentsToYouToDate).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.ReasonForIssues).IsUnicode(false);

                entity.Property(e => e.RuleDescription).IsUnicode(false);

                entity.Property(e => e.TotalCoInvestmentCollectedToDate).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalEarningsForPeriod).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalEarningsToDate).HasColumnType("decimal(15, 5)");
            });

            modelBuilder.Entity<McaGlaDevolvedOccupancyReport>(entity =>
            {
                entity.ToTable("McaGlaDevolvedOccupancyReport");

                entity.Property(e => e.AchievementElement).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.AchievementPercentage).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.AimValue).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ApplicableAreaFromSourceOfFunding)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicableFundingRate).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.ApplicableFundingRateFromESOLHours).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ApplicableProgrammeWeighting)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AprilAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilBalancingPaymentEarnedcash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AprilOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AreaUplift).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.AugustAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustBalancingPaymentEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.AugustOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CampusIdentifier)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CappingFactor).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DateUsedForUpliftsAndOtherLookups).HasColumnType("date");

                entity.Property(e => e.DecemberAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberBalancingPaymentEarnedcash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DecemberOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DeliveryLocationPostcode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DisadvantageUplift).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.EntitlementCategoryLevel2or3)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FamilyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FebruaryAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryBalancingPaymentEarnedcash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FebruaryOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FundingLineType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GivenNames)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JanuaryAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryBalancingPaymentEarnedcash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JanuaryOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyBalancingPaymentEarnedcash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JulyOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneBalancingPaymentEarnedcash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.JuneOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.LDFAMTypeCommunityLearningProvisionType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeDAMA)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeDAMB)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeDAMC)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeDAMD)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeDAME)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeDAMF)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeFullOrCoFundingIndicator)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeHHSA)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeHHSB)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeLDMA)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeLDMB)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeLDMC)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeLDMD)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeLDME)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeLDMF)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeLSFDateAppliesFromEarliest).HasColumnType("date");

                entity.Property(e => e.LDFAMTypeLSFDateAppliesToLatest).HasColumnType("date");

                entity.Property(e => e.LDFAMTypeLearningSupportFundingHighestApplicable)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeRestartIndicator)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LDFAMTypeSourceOfFunding)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LearnerReferenceNumber)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LearningActualEndDate).HasColumnType("date");

                entity.Property(e => e.LearningAimReference)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LearningAimTitle)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.LearningPlannedEndDate).HasColumnType("date");

                entity.Property(e => e.LearningStartDate).HasColumnType("date");

                entity.Property(e => e.LearningStartDatePostcode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocalAuthorityCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.MarchAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchBalancingPaymentEarnedcash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MarchOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayBalancingPaymentEarnedcash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MayOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NonPublicFundedContribution).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.NotionalNVQLevel)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NovemberAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberBalancingPaymentEarnedcash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NovemberOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OFFICIALSENSITIVE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OctoberAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberBalancingPaymentEarnedcash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OctoberOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OriginalLearningStartDate).HasColumnType("date");

                entity.Property(e => e.PartnerUKPRNName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PostcodePriorToEnrolment)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderSpecifiedDeliveryMonitoringA)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderSpecifiedDeliveryMonitoringB)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderSpecifiedDeliveryMonitoringC)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderSpecifiedDeliveryMonitoringD)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderSpecifiedLearnerMonitoringA)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderSpecifiedLearnerMonitoringB)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SeptemberAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberBalancingPaymentEarnedcash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SeptemberOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareSupplierAimIdentifier)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Tier2SectorSubjectArea).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Tier2SectorSubjectAreaName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAimAchievementEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalBalancingPaymentEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalJobOutcomeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalLearningSupportEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.TotalOnProgrammeEarnedCash).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
