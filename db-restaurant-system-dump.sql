USE [master]
GO
/****** Object:  Database [RestaurantSystem]    Script Date: 8.12.2019 г. 12:55:29 ******/
CREATE DATABASE [RestaurantSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RestaurantSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RestaurantSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RestaurantSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RestaurantSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RestaurantSystem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RestaurantSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RestaurantSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RestaurantSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RestaurantSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RestaurantSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RestaurantSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [RestaurantSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RestaurantSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RestaurantSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RestaurantSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RestaurantSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RestaurantSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RestaurantSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RestaurantSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RestaurantSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RestaurantSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RestaurantSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RestaurantSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RestaurantSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RestaurantSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RestaurantSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RestaurantSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RestaurantSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RestaurantSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [RestaurantSystem] SET  MULTI_USER 
GO
ALTER DATABASE [RestaurantSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RestaurantSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RestaurantSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RestaurantSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RestaurantSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'RestaurantSystem', N'ON'
GO
ALTER DATABASE [RestaurantSystem] SET QUERY_STORE = OFF
GO
USE [RestaurantSystem]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 8.12.2019 г. 12:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Qty] [int] NOT NULL,
	[LowStockThresheld] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Product] ([ID], [Name], [Price], [Qty], [LowStockThresheld]) VALUES (1, N'Milk', CAST(1 AS Decimal(18, 0)), 30, 10)
INSERT [dbo].[Product] ([ID], [Name], [Price], [Qty], [LowStockThresheld]) VALUES (2, N'Sugar', CAST(2 AS Decimal(18, 0)), 5, 15)
INSERT [dbo].[Product] ([ID], [Name], [Price], [Qty], [LowStockThresheld]) VALUES (3, N'Bread', CAST(2 AS Decimal(18, 0)), 0, 20)
USE [master]
GO
ALTER DATABASE [RestaurantSystem] SET  READ_WRITE 
GO
