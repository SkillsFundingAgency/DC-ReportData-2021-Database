﻿ CREATE TABLE [dbo].[UYPSummaryViewReport](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ukprn] [int] NOT NULL,
	[ReturnPeriod] [int] NOT NULL,
	NumberofLearners int,
    NumberofDatalocks int,
    NumberofClawbacks int,
    NumberofHBCP int,
    NumberofOthers int,
    NumberofCoInvestmentsToCollect int,
    NumberofEarningsReleased int ,
    EarningsReleased decimal(15,5),
    TotalEarningsForThisPeriod decimal(15,5) ,
    TotalCostOfDataLocksForThisPeriod decimal(15,5),
    TotalCostOfHBCPForThisPeriod decimal(15,5),
    TotalCostofClawbackForThisPeriod decimal(15,5),
    TotalCostofOthersForThisPeriod decimal(15,5),
    ESFAPlannedPaymentsForThisPeriod decimal(15,5),
    CoInvestmentPaymentsToCollectForThisPeriod decimal(15,5),
    TotalEarningsToDate decimal(15,5),
	TotalPaymentsToDate decimal(15,5),
    TotalCoInvestmentCollectedToDate decimal(15,5),
    [SummaryTotal] DECIMAL(15, 5) NULL,
    CONSTRAINT [PK_UYPSummaryViewReport] PRIMARY KEY ([Id]) 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


CREATE NONCLUSTERED INDEX [IDX_UYPSummaryViewReport] ON [dbo].[UYPSummaryViewReport]
(
	[Ukprn] ASC,
	[ReturnPeriod] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
