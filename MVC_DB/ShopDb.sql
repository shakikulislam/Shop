USE [master]
GO
/****** Object:  Database [ShopDb]    Script Date: 3/31/2019 10:38:08 PM ******/
CREATE DATABASE [ShopDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ShopDb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ShopDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ShopDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ShopDb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShopDb] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ShopDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShopDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShopDb] SET  MULTI_USER 
GO
ALTER DATABASE [ShopDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ShopDb]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 3/31/2019 10:38:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[Name] [varchar](50) NULL,
	[Code] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [int] NULL,
	[Age] [int] NULL,
	[LoyalityPoint] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [CustomerId], [Name], [Code], [Address], [Email], [Contact], [Age], [LoyalityPoint]) VALUES (1, 1, N'Kamal', N'100', N'Dhaka', N'kamal@mail.com', 123, 23, 500)
INSERT [dbo].[Customers] ([Id], [CustomerId], [Name], [Code], [Address], [Email], [Contact], [Age], [LoyalityPoint]) VALUES (3, 12, N'Hasib', N'33', N'Kumilla', N'hasib@mail.com', 2456, 30, 900)
INSERT [dbo].[Customers] ([Id], [CustomerId], [Name], [Code], [Address], [Email], [Contact], [Age], [LoyalityPoint]) VALUES (4, 10, N'Ashik', N'56', N'Kallyanpur', N'ashik@mail.com', 123654, 20, 600)
INSERT [dbo].[Customers] ([Id], [CustomerId], [Name], [Code], [Address], [Email], [Contact], [Age], [LoyalityPoint]) VALUES (6, 3, N'Manik', N'542', N'Dhanmondi', N'manik@mail.com', 5632, 23, 400)
INSERT [dbo].[Customers] ([Id], [CustomerId], [Name], [Code], [Address], [Email], [Contact], [Age], [LoyalityPoint]) VALUES (7, 4, N'Korim', N'3', N'Savar', N'korim@mail.com', 65478, 40, 300)
SET IDENTITY_INSERT [dbo].[Customers] OFF
USE [master]
GO
ALTER DATABASE [ShopDb] SET  READ_WRITE 
GO
