USE [master]
GO
/****** Object:  Database [Ship-shop]    Script Date: 25.10.2020 21:35:21 ******/
CREATE DATABASE [Ship-shop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Shop', FILENAME = N'D:\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Shop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Shop_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Shop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ship-shop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ship-shop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ship-shop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ship-shop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ship-shop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ship-shop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ship-shop] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ship-shop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ship-shop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ship-shop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ship-shop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ship-shop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ship-shop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ship-shop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ship-shop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ship-shop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ship-shop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ship-shop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ship-shop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ship-shop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ship-shop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ship-shop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ship-shop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ship-shop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ship-shop] SET RECOVERY FULL 
GO
ALTER DATABASE [Ship-shop] SET  MULTI_USER 
GO
ALTER DATABASE [Ship-shop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ship-shop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ship-shop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ship-shop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ship-shop] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ship-shop', N'ON'
GO
ALTER DATABASE [Ship-shop] SET QUERY_STORE = OFF
GO
USE [Ship-shop]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 25.10.2020 21:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [varchar](50) NOT NULL,
	[description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 25.10.2020 21:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[middle_name] [varchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order Details]    Script Date: 25.10.2020 21:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order Details](
	[order_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[unit_price] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[discount] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 25.10.2020 21:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[ship_name] [varchar](50) NOT NULL,
	[ship_city] [varchar](50) NOT NULL,
	[ship_country] [varchar](50) NOT NULL,
	[customer_id] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([customer_id], [first_name], [last_name], [middle_name]) VALUES (1, N'Ярослав', N'Пылаев', N'Сергеевич')
GO
INSERT [dbo].[Customers] ([customer_id], [first_name], [last_name], [middle_name]) VALUES (2, N'Павел', N'Смирнов', N'Алексеевич')
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
INSERT [dbo].[Order Details] ([order_id], [product_id], [unit_price], [quantity], [discount]) VALUES (1, 1, 100, 5, 10)
GO
INSERT [dbo].[Order Details] ([order_id], [product_id], [unit_price], [quantity], [discount]) VALUES (2, 5, 15, 3, 0)
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([order_id], [ship_name], [ship_city], [ship_country], [customer_id]) VALUES (1, N'Silja Line', N'Хельсинки', N'Финляндия', 2)
GO
INSERT [dbo].[Orders] ([order_id], [ship_name], [ship_city], [ship_country], [customer_id]) VALUES (2, N'St.Peter Line', N'Санкт-Петербург', N'Россия', 1)
GO
INSERT [dbo].[Orders] ([order_id], [ship_name], [ship_city], [ship_country], [customer_id]) VALUES (3, N'Viking Line', N'Таллин', N'Эстония', 1)
GO
INSERT [dbo].[Orders] ([order_id], [ship_name], [ship_city], [ship_country], [customer_id]) VALUES (4, N'test', N'test', N'test', 2)
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customers] ([customer_id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
USE [master]
GO
ALTER DATABASE [Ship-shop] SET  READ_WRITE 
GO
