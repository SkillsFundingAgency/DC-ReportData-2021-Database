﻿CREATE TABLE [dbo].[AppsAdditionalPayments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ukprn] [int] NOT NULL,
	[ReturnPeriod] [int] NOT NULL,
	[LearnerReferenceNumber] [varchar](12) NULL,
	[UniqueLearnerNumber] [bigint] NULL,
	[ProviderSpecifiedLearnerMonitoringA] [varchar](250) NULL,
	[ProviderSpecifiedLearnerMonitoringB] [varchar](250) NULL,
	[FamilyName] [varchar](100) NULL,
	[GivenNames] [varchar](100) NULL,
	[LearningStartDate] [datetime] NULL,
	[FundingLineType] [varchar](max) NULL,
	[TypeOfAdditionalPayment] [varchar](max) NULL,
	[EmployerNameFromApprenticeshipService] [varchar](max) NULL,
	[EmployerIdentifierFromILR] [varchar](max) NULL,
	[AugustEarnings] [decimal](15, 5) NULL,
	[AugustR01Payments] [decimal](15, 5) NULL,
	[SeptemberEarnings] [decimal](15, 5) NULL,
	[SeptemberR02Payments] [decimal](15, 5) NULL,
	[OctoberEarnings] [decimal](15, 5) NULL,
	[OctoberR03Payments] [decimal](15, 5) NULL,
	[NovemberEarnings] [decimal](15, 5) NULL,
	[NovemberR04Payments] [decimal](15, 5) NULL,
	[DecemberEarnings] [decimal](15, 5) NULL,
	[DecemberR05Payments] [decimal](15, 5) NULL,
	[JanuaryEarnings] [decimal](15, 5) NULL,
	[JanuaryR06Payments] [decimal](15, 5) NULL,	
	[FebruaryEarnings] [decimal](15, 5) NULL,
	[FebruaryR07Payments] [decimal](15, 5) NULL,
	[MarchEarnings] [decimal](15, 5) NULL,
	[MarchR08Payments] [decimal](15, 5) NULL,
	[AprilEarnings] [decimal](15, 5) NULL,
	[AprilR09Payments] [decimal](15, 5) NULL,
	[MayEarnings] [decimal](15, 5) NULL,
	[MayR10Payments] [decimal](15, 5) NULL,
	[JuneEarnings] [decimal](15, 5) NULL,
	[JuneR11Payments] [decimal](15, 5) NULL,
	[JulyEarnings] [decimal](15, 5) NULL,
	[JulyR12Payments] [decimal](15, 5) NULL,
	[R13Payments] [decimal](15, 5) NULL,
	[R14Payments] [decimal](15, 5) NULL,
	[TotalEarnings] [decimal](15, 5) NULL,
	[TotalPaymentsYearToDate] [decimal](15, 5) NULL,
	CONSTRAINT [PK_AppsAdditionalPayments] PRIMARY KEY ([Id])
)
GO

CREATE NONCLUSTERED INDEX [IDX_AppsAdditionalPayments] ON [dbo].[AppsAdditionalPayments]
(
	[Ukprn] ASC,
	[ReturnPeriod] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]

