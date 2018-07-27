USE [Stock]
GO

/****** Object:  Table [dbo].[tblTickerSymbols]    Script Date: 07/26/2018 14:09:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTickerSymbols]') AND type in (N'U'))
DROP TABLE [dbo].[tblTickerSymbols]
GO

USE [Stock]
GO

/****** Object:  Table [dbo].[tblTickerSymbols]    Script Date: 07/26/2018 14:09:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblTickerSymbols](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[StockName] [varchar](1000) NULL,
	[ISIN] [varchar](50) NULL,
	[Type] [varchar](1000) NULL, -- oftewel market category
	[Exchange] [varchar](50) NULL,
	[Industry] [varchar](50) NULL,
	[TestIssue] [varchar](1) NULL,
	[FinancialStatus] [varchar](1) NULL,
	[RoundLotSize] [varchar](1) NULL,
	[ETF] [varchar](1) NULL,
    [NextShares] [varchar](1) NULL	
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


