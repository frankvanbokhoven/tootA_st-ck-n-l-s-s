USE [master]
GO
/****** Object:  Database [Stock]    Script Date: 07/24/2018 10:05:00 ******/
CREATE DATABASE [Stock] ON  PRIMARY 
( NAME = N'Stock', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVERYGGDRA\MSSQL\DATA\Stock.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Stock_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVERYGGDRA\MSSQL\DATA\Stock_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Stock] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Stock].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Stock] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Stock] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Stock] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Stock] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Stock] SET ARITHABORT OFF
GO
ALTER DATABASE [Stock] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Stock] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Stock] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Stock] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Stock] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Stock] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Stock] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Stock] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Stock] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Stock] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Stock] SET  DISABLE_BROKER
GO
ALTER DATABASE [Stock] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Stock] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Stock] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Stock] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Stock] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Stock] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Stock] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Stock] SET  READ_WRITE
GO
ALTER DATABASE [Stock] SET RECOVERY FULL
GO
ALTER DATABASE [Stock] SET  MULTI_USER
GO
ALTER DATABASE [Stock] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Stock] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Stock', N'ON'
GO
USE [Stock]
GO
/****** Object:  Table [dbo].[tblTickerSymbolsUpdateDates]    Script Date: 07/24/2018 10:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTickerSymbolsUpdateDates](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TickerSymbol_Id] [int] NULL,
	[LastUpdated] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTickerSymbols]    Script Date: 07/24/2018 10:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTickerSymbols](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[StockName] [varchar](150) NULL,
	[ISIN] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
	[Exchange] [varchar](50) NULL,
	[Industry] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTickerData]    Script Date: 07/24/2018 10:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTickerData](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TickerId] [int] NULL,
	[Date] [datetime] NULL,
	[OpenPrice] [decimal](18, 0) NULL,
	[HighPrice] [decimal](18, 0) NULL,
	[LowPrice] [decimal](18, 0) NULL,
	[ClosePrice] [decimal](18, 0) NULL,
	[Adjusted_ClosePrice] [decimal](18, 0) NULL,
	[Volume] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblAutoUpdateTickers]    Script Date: 07/24/2018 10:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblAutoUpdateTickers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TickerId] [int] NULL,
	[UpdateFrequency] [varchar](20) NULL,
	[LatestUpdate] [datetime] NULL,
	[Datasource] [varchar](200) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
