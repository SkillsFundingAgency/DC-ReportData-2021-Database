CREATE TABLE [dbo].[FundingSummaryReport]
(
    [Id] [int] IDENTITY(1,1) NOT NULL,
	[Ukprn] INT NOT NULL,
	[ReturnPeriod] INT NOT NULL,
    [ContractNo] NVARCHAR(100) NULL,
    [FundingCategory] NVARCHAR(90) NULL,
    [FundingSubCategory] NVARCHAR(70) NULL,
    [FundLine] NVARCHAR(200) NULL,
    [Aug20] DECIMAL(15, 5) NULL,
    [Sep20] DECIMAL(15, 5) NULL,
    [Oct20] DECIMAL(15, 5) NULL,
    [Nov20] DECIMAL(15, 5) NULL,
    [Dec20] DECIMAL(15, 5) NULL,
    [Jan21] DECIMAL(15, 5) NULL,
    [Feb21] DECIMAL(15, 5) NULL,
    [Mar21] DECIMAL(15, 5) NULL,
    [Apr21] DECIMAL(15, 5) NULL,
    [May21] DECIMAL(15, 5) NULL,
    [Jun21] DECIMAL(15, 5) NULL,
    [Jul21] DECIMAL(15, 5) NULL,
    [AugMar] DECIMAL(15, 5) NULL,
    [AprJul] DECIMAL(15, 5) NULL,
    [YearToDate] DECIMAL(15, 5) NULL,
    [Total] DECIMAL(15, 5) NULL,
    CONSTRAINT [PK_FundingSummaryReport] PRIMARY KEY ([Id])
)

GO

CREATE NONCLUSTERED INDEX [IDX_FundingSummaryReport] ON [dbo].[FundingSummaryReport]
(
	[Ukprn] ASC,
	[ReturnPeriod] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
