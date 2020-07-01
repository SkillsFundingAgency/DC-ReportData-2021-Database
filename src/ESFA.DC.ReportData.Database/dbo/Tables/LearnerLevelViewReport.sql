﻿ CREATE TABLE [dbo].[LearnerLevelViewReport](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ukprn] [int] NOT NULL,
	[ReturnPeriod] [int] NOT NULL,
	[PaymentLearnerReferenceNumber] [varchar](12) NOT NULL,
	[PaymentUniqueLearnerNumber] [bigint] NULL,
	[FamilyName] [varchar](max) NULL,
	[GivenNames] [varchar](max) NULL,
	[LearnerEmploymentStatusEmployerId] [int]  NULL,
	[EmployerName] [varchar](max) NULL,
	[TotalEarningsToDate] [decimal](15, 5) NULL,
	[PlannedPaymentsToYouToDate] [decimal](15, 5) NULL,	
	[TotalCoInvestmentCollectedToDate] [decimal](15, 5) NULL,
	[CoInvestmentOutstandingFromEmplToDate] [decimal](15, 5) NULL,
	[TotalEarningsForPeriod] [decimal](15, 5) NULL,
	[ESFAPlannedPaymentsThisPeriod] [decimal](15, 5) NULL,
	[CoInvestmentPaymentsToCollectThisPeriod] [decimal](15, 5) NULL,
	[IssuesAmount] [decimal](15, 5) NULL,
	[ReasonForIssues] [varchar](max) NULL,
	[PaymentFundingLineType] [varchar](max) NULL,
	[RuleDescription] [varchar](max) NULL,
	CONSTRAINT [PK_LearnerLevelViewReport] PRIMARY KEY ([Id])
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
