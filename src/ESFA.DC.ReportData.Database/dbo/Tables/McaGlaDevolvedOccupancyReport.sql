﻿CREATE TABLE [dbo].[McaGlaDevolvedOccupancyReport]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Year] [varchar](10) NOT NULL,
	[Return] [int] NOT NULL,
	[AcMnth] [int] NOT NULL,
	[UKPRN] [int] NOT NULL,
	[ProviderName] [varchar](250) NULL,
	[LearnerReferenceNumber] [varchar](12) NOT NULL,
	[UniqueLearnerNumber] [bigint] NULL,
	[FamilyName] [varchar](100) NULL,
	[GivenNames] [varchar](100) NULL,
	[DateOfBirth] [date] NULL,
	[Ethnicity] [int] NOT NULL,
	[Sex] [char](1) NOT NULL,
	[LLDDandHealthProblem] [int] NULL,
	[PriorAttainment] [int] NULL,
	[PostcodePriorToEnrolment] [varchar](8) NULL,
	[PreMergerUKPRN] [int] NULL,
	[CampusIdentifier] [varchar](8) NULL,
	[ProviderSpecifiedLearnerMonitoringA] [varchar](20) NULL,
	[ProviderSpecifiedLearnerMonitoringB] [varchar](20) NULL,
	[AimSeqNumber] [int] NOT NULL,
	[LearningAimReference] [varchar](8) NOT NULL,
	[LearningAimTitle] [varchar](254) NULL,
	[SoftwareSupplierAimIdentifier] [varchar](36) NULL,
	[ApplicableFundingRateFromESOLHours] [decimal](18, 5) NULL,
	[ApplicableFundingRate] [decimal](10, 5) NULL,
	[ApplicableProgrammeWeighting] [char](1) NULL,
	[AimValue] [decimal](18, 5) NULL,
	[NotionalNVQLevel] [varchar](5) NULL,
	[EntitlementCategoryLevel2or3] [varchar](3) NULL,
	[Tier2SectorSubjectArea] [decimal](10, 2) NULL,
	[Tier2SectorSubjectAreaName] [varchar](60) NULL,
	[FundingModel] [int] NULL,
	[FundingAdjustmentForPriorLearning] [int] NULL,
	[OtherFundingAdjment] [int] NULL,
	[OriginalLearningStartDate] [date] NULL,
	[LearningStartDate] [date] NULL,
	[LearningPlannedEndDate] [date] NULL,
	[CompletionStatus] [int] NULL,
	[LearningActualEndDate] [date] NULL,
	WithdrawReason [int] NULL,
	[Outcome] [int] NULL,
	[AdditionalDeliveryHours] [int] NULL,
	[LearningStartDatePostcode] [varchar](8) NULL,
	[LocalAuthorityCode]  [varchar] (9) NULL,
	[ApplicableAreaFromSourceOfFunding] [varchar](10) NULL,
	[LDFAMTypeSourceOfFunding] [varchar](5) NULL,
	[LDFAMTypeFullOrCoFundingIndicator] [varchar](5) NULL,
	[LDFAMTypeLearningSupportFundingHighestApplicable] [varchar](5) NULL,
	[LDFAMTypeLSFDateAppliesFromEarliest] [date] NULL,
	[LDFAMTypeLSFDateAppliesToLatest] [date] NULL,
	[LDFAMTypeLDMA] [varchar](5) NULL,
	[LDFAMTypeLDMB] [varchar](5) NULL,
	[LDFAMTypeLDMC] [varchar](5) NULL,
	[LDFAMTypeLDMD] [varchar](5) NULL,
	[LDFAMTypeLDME] [varchar](5) NULL,
	[LDFAMTypeLDMF] [varchar](5) NULL,
	[LDFAMTypeDAMA] [varchar](5) NULL,
	[LDFAMTypeDAMB] [varchar](5) NULL,
	[LDFAMTypeDAMC] [varchar](5) NULL,
	[LDFAMTypeDAMD] [varchar](5) NULL,
	[LDFAMTypeDAME] [varchar](5) NULL,
	[LDFAMTypeDAMF] [varchar](5) NULL,
	[LDFAMTypeRestartIndicator] [varchar](5) NULL,
	[LDFAMTypeCommunityLearningProvisionType] [varchar](5) NULL,
	[LDFAMTypeHHSA] [varchar](20) NULL,
	[LDFAMTypeHHSB] [varchar](20) NULL,
	[ProviderSpecifiedDeliveryMonitoringA] [varchar](20) NULL,
	[ProviderSpecifiedDeliveryMonitoringB] [varchar](20) NULL,
	[ProviderSpecifiedDeliveryMonitoringC] [varchar](20) NULL,
	[ProviderSpecifiedDeliveryMonitoringD] [varchar](20) NULL,
	[LearnerEmploymentStatus] [int] NULL,
	[ESMTypeEmploymentIntensityIndicator] [int] NULL,
	[ESMTypeBenefitStatusIndicator] [int] NULL,
	[FundingLineType] [varchar] (100) NULL,
	[StartForFundingPurposes] [bit] NULL,
	[PlannedNumberOfOnProgrammeInstalments] [int] NULL,
	[AchievementElement] [decimal](10, 5) NULL,
	[AchievementPercentage] [decimal](10, 5) NULL,
	[NonPublicFundedContribution] [decimal](10, 5) NULL,
	[CappingFactor] [decimal](10, 5) NULL,
	[PartnerUKPRN] [int] NULL,
	[PartnerUKPRNName] [varchar] (250) NULL,
	[DeliveryLocationPostcode] [varchar](8) NULL,
	[AreaUplift] [decimal](10, 5) NULL,
	[DisadvantageUplift] [decimal](10, 4) NULL,
	[DateUsedForUpliftsAndOtherLookups] [date] NULL,
	[AugustOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[AugustBalancingPaymentEarnedCash] [decimal](15, 5) NULL,
	[AugustAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[AugustJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[AugustLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[SeptemberOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[SeptemberBalancingPaymentEarnedcash] [decimal](15, 5) NULL,
	[SeptemberAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[SeptemberJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[SeptemberLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[OctoberOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[OctoberBalancingPaymentEarnedcash] [decimal](15, 5) NULL,
	[OctoberAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[OctoberJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[OctoberLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[NovemberOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[NovemberBalancingPaymentEarnedcash] [decimal](15, 5) NULL,
	[NovemberAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[NovemberJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[NovemberLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[DecemberOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[DecemberBalancingPaymentEarnedcash] [decimal](15, 5) NULL,
	[DecemberAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[DecemberJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[DecemberLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[JanuaryOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[JanuaryBalancingPaymentEarnedcash] [decimal](15, 5) NULL,
	[JanuaryAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[JanuaryJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[JanuaryLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[FebruaryOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[FebruaryBalancingPaymentEarnedcash] [decimal](15, 5) NULL,
	[FebruaryAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[FebruaryJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[FebruaryLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[MarchOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[MarchBalancingPaymentEarnedcash] [decimal](15, 5) NULL,
	[MarchAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[MarchJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[MarchLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[AprilOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[AprilBalancingPaymentEarnedcash] [decimal](15, 5) NULL,
	[AprilAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[AprilJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[AprilLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[MayOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[MayBalancingPaymentEarnedcash] [decimal](15, 5) NULL,
	[MayAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[MayJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[MayLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[JuneOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[JuneBalancingPaymentEarnedcash] [decimal](15, 5) NULL,
	[JuneAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[JuneJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[JuneLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[JulyOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[JulyBalancingPaymentEarnedcash] [decimal](15, 5) NULL,
	[JulyAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[JulyJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[JulyLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[TotalOnProgrammeEarnedCash] [decimal](15, 5) NULL,
	[TotalBalancingPaymentEarnedCash] [decimal](15, 5) NULL,
	[TotalAimAchievementEarnedCash] [decimal](15, 5) NULL,
	[TotalJobOutcomeEarnedCash] [decimal](15, 5) NULL,
	[TotalLearningSupportEarnedCash] [decimal](15, 5) NULL,
	[TotalEarnedCash] [decimal](15, 5) NULL,
	[OFFICIALSENSITIVE] [varchar](100) NULL,
	[CreatedDateTime] [datetime] NULL, 
    CONSTRAINT [PK_McaGlaDevolvedOccupancyReport] PRIMARY KEY ([Id]),
)
GO

CREATE NONCLUSTERED INDEX [IDX_McaGlaDevolvedOccupancyReport] ON [dbo].[McaGlaDevolvedOccupancyReport]
(
	[Ukprn] ASC,
	[Return] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
