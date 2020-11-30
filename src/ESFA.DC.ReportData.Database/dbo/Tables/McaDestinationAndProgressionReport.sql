CREATE TABLE [dbo].[McaDestinationAndProgressionReport]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
    [Ukprn] INT NOT NULL , 
	[Year] [varchar](10) NULL,
    [Return] INT NOT NULL,
	[ApplicableAreaFromSourceOfFunding] [varchar](10) NOT NULL,
	[ProviderName] NVARCHAR(250) NULL,  
	[LearnRefNumber] VARCHAR(12) NULL, 
    [UniqueLearnerNumber] BIGINT NULL,
	[LearningAimReference] VARCHAR(8) NOT NULL,
	[LearningAimTitle] VARCHAR(254) NULL,
	[FundingModel] INT NOT NULL,
	[LSDPostcode] VARCHAR(8) NULL,
	[SOF] VARCHAR(5) NOT NULL,
	[LearnActEndDate] DATETIME NULL,
	[CompStatus] INT NOT NULL,
	[Outcome] INT NULL,
	[OutType] VARCHAR(3) NOT NULL,
	[OutCode] INT NOT NULL,
	[OutStartDate] DATETIME NOT NULL,
	[OutEndDate] DATETIME NULL,
	[OutCollDate] DATETIME NOT NULL,
    CONSTRAINT [PK_McaDestinationAndProgressionReport] PRIMARY KEY ([Id])
)
GO

CREATE NONCLUSTERED INDEX [IDX_McaDestinationAndProgressionReport] ON [dbo].[McaDestinationAndProgressionReport]
(
	[Ukprn] ASC,
	[Return] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
