USE [master]
GO
/****** Object:  Database [RestaurantPOS]    Script Date: 9/10/2024 5:54:37 PM ******/
CREATE DATABASE [RestaurantPOS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RestaurantPOS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RestaurantPOS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RestaurantPOS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RestaurantPOS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RestaurantPOS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RestaurantPOS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RestaurantPOS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RestaurantPOS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RestaurantPOS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RestaurantPOS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RestaurantPOS] SET ARITHABORT OFF 
GO
ALTER DATABASE [RestaurantPOS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RestaurantPOS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RestaurantPOS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RestaurantPOS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RestaurantPOS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RestaurantPOS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RestaurantPOS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RestaurantPOS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RestaurantPOS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RestaurantPOS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RestaurantPOS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RestaurantPOS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RestaurantPOS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RestaurantPOS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RestaurantPOS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RestaurantPOS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RestaurantPOS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RestaurantPOS] SET RECOVERY FULL 
GO
ALTER DATABASE [RestaurantPOS] SET  MULTI_USER 
GO
ALTER DATABASE [RestaurantPOS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RestaurantPOS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RestaurantPOS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RestaurantPOS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RestaurantPOS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RestaurantPOS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'RestaurantPOS', N'ON'
GO
ALTER DATABASE [RestaurantPOS] SET QUERY_STORE = ON
GO
ALTER DATABASE [RestaurantPOS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [RestaurantPOS]
GO
/****** Object:  ColumnMasterKey [CMK_Auto1]    Script Date: 9/10/2024 5:54:38 PM ******/
CREATE COLUMN MASTER KEY [CMK_Auto1]
WITH
(
	KEY_STORE_PROVIDER_NAME = N'MSSQL_CERTIFICATE_STORE',
	KEY_PATH = N'CurrentUser/my/3F356BE7F8F760F6AF5E261E6F93A3A61DC57385'
)
GO
/****** Object:  ColumnEncryptionKey [CEK_Auto1]    Script Date: 9/10/2024 5:54:38 PM ******/
CREATE COLUMN ENCRYPTION KEY [CEK_Auto1]
WITH VALUES
(
	COLUMN_MASTER_KEY = [CMK_Auto1],
	ALGORITHM = 'RSA_OAEP',
	ENCRYPTED_VALUE = 0x016E000001630075007200720065006E00740075007300650072002F006D0079002F0033006600330035003600620065003700660038006600370036003000660036006100660035006500320036003100650036006600390033006100330061003600310064006300350037003300380035001B2D5CA1FC4BE8B2D82AF324D679CC92D3EB53155D3C132494CEBD540E2AB72C7800EDA29CF828C413E4FA02B80E6B6D2289247C292524547740C0BB81B980E51615CFBB737CF17FE29CBA4A6F2A1A891CD1DE986621D0C73C100DA8EEBE877750FBBF1BDD8EE3E58EFBB118A4F104ED044C8F8A8B9A48788E713717D33E67FC5C38A61AE8FBBDDA92A023E3E66CA80CD3045B1D32BCEDEF33AFBE5AB276D63ACC05DA0FD65DB3C2A9A9CD05EBEDCFE9BA0DF1A2239A176E454CC63F550F2CC45B2F0A39FE27715AD19FFCF04B1442B4BC91F6B72D8E95841D819080209DCD9024619FB4AE2C2F704B6BDDEAB5365AF0C2670007D481B1E1ED1F1C17FEA6D761B75322F2F09943CD11DD7A3F9603DF1D95FDFA6894E13FF8EBCE980C6AAB2B9FD11BA8501AD10AEC86998EF3CACAEC24BD85CB7A3335B0A628968D23135E800A5B77A0B5810092FE5FD91041D3821FE6031E4AACF808618638E9816A280301060CA4C8805FED050E78CCF745C0D59F22BDA80CC7C31650F308B9588FDC6E0130E8CAB1208A25564DB05429EB67118DFE485415289A651D34ADA91FF98D56B0D897DDCED7337C3B6A6208A53A9BF8BD1CBDC8F4827DE72B39B1075E2A71CE621E65D2A91EEA088A5A145705C0A2881088B81BFFB09A29A61B5ABACEE8183B3E66BD8FF1EDE5D964883299E6931DB891B2CD1ADDEF4D02858D004D77EB02DC81B4
)
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 9/10/2024 5:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 9/10/2024 5:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[OrderItemID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](10, 2) NOT NULL,
	[SubTotal] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 9/10/2024 5:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[TotalPrice] [decimal](10, 2) NOT NULL,
	[TableNumber] [int] NULL,
	[Username] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 9/10/2024 5:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](100) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/10/2024 5:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[PasswordHash] [nvarchar](64) NOT NULL,
	[AdminRights] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Coffee')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Cold Drinks')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Juices')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Desserts')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'Ice Cream')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (6, N'Grilled Food')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (7, N'Fish')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (8, N'Pizza')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (10, N'Salad')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (11, N'Risotto')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (12, N'Pasta')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderItems] ON 

INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (3, 5, 38, 1, CAST(13.00 AS Decimal(10, 2)), CAST(13.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (4, 5, 47, 1, CAST(10.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (5, 5, 39, 1, CAST(11.00 AS Decimal(10, 2)), CAST(11.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (6, 5, 48, 1, CAST(6.50 AS Decimal(10, 2)), CAST(6.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (7, 5, 40, 1, CAST(7.50 AS Decimal(10, 2)), CAST(7.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (8, 5, 49, 1, CAST(3.50 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (9, 5, 41, 1, CAST(6.50 AS Decimal(10, 2)), CAST(6.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (10, 5, 50, 1, CAST(3.50 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (11, 5, 42, 1, CAST(5.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (12, 5, 51, 1, CAST(3.50 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (13, 5, 43, 1, CAST(3.50 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (14, 5, 52, 1, CAST(3.00 AS Decimal(10, 2)), CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (15, 6, 65, 4, CAST(4.50 AS Decimal(10, 2)), CAST(18.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (16, 6, 66, 3, CAST(5.00 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (17, 7, 55, 1, CAST(5.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (18, 7, 64, 1, CAST(2.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (19, 7, 56, 1, CAST(5.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (20, 7, 65, 1, CAST(4.50 AS Decimal(10, 2)), CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (21, 7, 57, 1, CAST(4.50 AS Decimal(10, 2)), CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (22, 7, 66, 1, CAST(5.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (23, 7, 58, 1, CAST(5.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (24, 7, 67, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (25, 7, 59, 1, CAST(2.50 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (26, 7, 68, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (27, 7, 60, 1, CAST(2.50 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (28, 7, 69, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (29, 7, 61, 1, CAST(2.50 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (30, 7, 70, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (31, 7, 62, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (32, 7, 71, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (33, 7, 63, 1, CAST(3.50 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (34, 7, 72, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (35, 8, 37, 1, CAST(0.60 AS Decimal(10, 2)), CAST(0.60 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (36, 8, 46, 1, CAST(12.00 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (37, 8, 38, 1, CAST(13.00 AS Decimal(10, 2)), CAST(13.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (38, 8, 47, 1, CAST(10.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (39, 8, 39, 1, CAST(11.00 AS Decimal(10, 2)), CAST(11.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (40, 8, 48, 1, CAST(6.50 AS Decimal(10, 2)), CAST(6.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (41, 8, 40, 1, CAST(7.50 AS Decimal(10, 2)), CAST(7.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (42, 8, 49, 1, CAST(3.50 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (43, 8, 41, 1, CAST(6.50 AS Decimal(10, 2)), CAST(6.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (44, 8, 50, 1, CAST(3.50 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (45, 8, 42, 1, CAST(5.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (46, 8, 51, 1, CAST(3.50 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (47, 8, 43, 1, CAST(3.50 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (48, 8, 52, 1, CAST(3.00 AS Decimal(10, 2)), CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (49, 8, 44, 1, CAST(3.00 AS Decimal(10, 2)), CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (50, 8, 53, 1, CAST(3.50 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (51, 8, 45, 1, CAST(10.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (52, 8, 54, 1, CAST(5.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (53, 8, 63, 1, CAST(3.50 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (54, 8, 72, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (55, 8, 62, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (56, 8, 71, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (57, 8, 61, 1, CAST(2.50 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (58, 8, 70, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (59, 8, 60, 1, CAST(2.50 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (60, 8, 69, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (61, 8, 59, 1, CAST(2.50 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (62, 8, 68, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (63, 8, 58, 1, CAST(5.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (64, 8, 57, 1, CAST(4.50 AS Decimal(10, 2)), CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (65, 8, 66, 1, CAST(5.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (66, 8, 56, 1, CAST(5.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (67, 8, 65, 1, CAST(4.50 AS Decimal(10, 2)), CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (68, 8, 55, 1, CAST(5.00 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (69, 8, 64, 1, CAST(2.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (70, 9, 1, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (71, 9, 11, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (72, 9, 2, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (73, 9, 10, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (74, 9, 3, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (75, 9, 4, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (76, 9, 7, 2, CAST(1.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (77, 9, 9, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (78, 9, 8, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (79, 9, 12, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (80, 9, 13, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (81, 9, 14, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (82, 9, 15, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (83, 9, 16, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (84, 9, 17, 1, CAST(0.70 AS Decimal(10, 2)), CAST(0.70 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (85, 9, 18, 1, CAST(0.80 AS Decimal(10, 2)), CAST(0.80 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (86, 9, 19, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (87, 9, 20, 1, CAST(2.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (88, 9, 21, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (89, 9, 23, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (90, 9, 39, 1, CAST(11.00 AS Decimal(10, 2)), CAST(11.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (91, 10, 1, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (92, 10, 11, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (93, 10, 2, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (94, 10, 10, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (95, 10, 3, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (96, 10, 4, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (97, 10, 7, 2, CAST(1.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (98, 10, 9, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (99, 10, 8, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (100, 10, 12, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (101, 10, 13, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (102, 10, 14, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (103, 10, 15, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (104, 10, 16, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (105, 10, 17, 1, CAST(0.70 AS Decimal(10, 2)), CAST(0.70 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (106, 10, 18, 1, CAST(0.80 AS Decimal(10, 2)), CAST(0.80 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (107, 10, 19, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (108, 10, 20, 1, CAST(2.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (109, 10, 21, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (110, 10, 23, 1, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (111, 10, 39, 1, CAST(11.00 AS Decimal(10, 2)), CAST(11.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (112, 11, 61, 4, CAST(2.50 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (113, 11, 70, 4, CAST(4.00 AS Decimal(10, 2)), CAST(16.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (114, 11, 62, 3, CAST(4.00 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (115, 11, 71, 3, CAST(4.00 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (116, 11, 63, 3, CAST(3.50 AS Decimal(10, 2)), CAST(10.50 AS Decimal(10, 2)))
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity], [UnitPrice], [SubTotal]) VALUES (117, 11, 72, 1, CAST(4.00 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[OrderItems] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [OrderDate], [TotalPrice], [TableNumber], [Username]) VALUES (2, CAST(N'2024-09-08T14:17:23.977' AS DateTime), CAST(26.80 AS Decimal(10, 2)), 18, N'admin')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [TotalPrice], [TableNumber], [Username]) VALUES (3, CAST(N'2024-09-08T15:39:36.007' AS DateTime), CAST(215.60 AS Decimal(10, 2)), 17, N'admin')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [TotalPrice], [TableNumber], [Username]) VALUES (4, CAST(N'2024-09-08T15:51:02.417' AS DateTime), CAST(211.10 AS Decimal(10, 2)), 1, N'admin')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [TotalPrice], [TableNumber], [Username]) VALUES (5, CAST(N'2024-09-08T15:59:19.360' AS DateTime), CAST(76.50 AS Decimal(10, 2)), 1, N'admin')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [TotalPrice], [TableNumber], [Username]) VALUES (6, CAST(N'2024-09-08T16:04:32.910' AS DateTime), CAST(33.00 AS Decimal(10, 2)), 25, N'admin')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [TotalPrice], [TableNumber], [Username]) VALUES (7, CAST(N'2024-09-08T21:43:00.730' AS DateTime), CAST(70.00 AS Decimal(10, 2)), 10, N'alban')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [TotalPrice], [TableNumber], [Username]) VALUES (8, CAST(N'2024-09-09T12:16:06.303' AS DateTime), CAST(176.60 AS Decimal(10, 2)), 1, N'alban')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [TotalPrice], [TableNumber], [Username]) VALUES (9, CAST(N'2024-09-10T11:11:51.003' AS DateTime), CAST(32.50 AS Decimal(10, 2)), 1, N'admin')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [TotalPrice], [TableNumber], [Username]) VALUES (10, CAST(N'2024-09-10T11:12:34.840' AS DateTime), CAST(32.50 AS Decimal(10, 2)), 1, N'admin')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [TotalPrice], [TableNumber], [Username]) VALUES (11, CAST(N'2024-09-10T17:44:42.163' AS DateTime), CAST(64.50 AS Decimal(10, 2)), 9, N'admin')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (1, N'Macchiato', 1, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (2, N'Espresso', 1, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (3, N'Double Espresso', 1, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (4, N'Cappuccino', 1, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (5, N'Pa Plum', 1, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (6, N'Amerikane', 1, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (7, N'Ness Classic', 1, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (8, N'Ness Vanilla', 1, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (9, N'Latte', 1, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (10, N'Kafe Turke', 1, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (11, N'Qaj', 1, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (12, N'Coca Cola', 2, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (13, N'Sprite', 2, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (14, N'Fanta', 2, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (15, N'Schweppss', 2, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (16, N'Ice Tea', 2, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (17, N'Ujë Natyral', 2, CAST(0.70 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (18, N'Ujë Mineral', 2, CAST(0.80 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (19, N'Golden Eagle', 2, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (20, N'Red Bull', 2, CAST(2.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (21, N'Pjeshkë', 3, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (22, N'Dredhëz', 3, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (23, N'Vishnje', 3, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (24, N'Boronicë', 3, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (25, N'Mollë', 3, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (26, N'Karrot', 3, CAST(1.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (27, N'Trileqe', 4, CAST(1.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (28, N'Mallaga', 4, CAST(1.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (29, N'Fruta Mali', 4, CAST(1.70 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (30, N'Raffaelo', 4, CAST(1.70 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (31, N'Qokolladë', 5, CAST(0.60 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (32, N'Vanillë', 5, CAST(0.60 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (33, N'Dredhëz', 5, CAST(0.60 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (34, N'Fruta Mali', 5, CAST(0.60 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (35, N'Jogurt', 5, CAST(0.60 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (36, N'Kivi', 5, CAST(0.60 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (37, N'Banane', 5, CAST(0.60 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (38, N'Biftek', 6, CAST(13.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (39, N'Ramstek', 6, CAST(11.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (40, N'Mish Viçi', 6, CAST(7.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (41, N'Mish i Përzier', 6, CAST(6.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (42, N'File Pule', 6, CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (43, N'Pleskavicë', 6, CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (44, N'Hamburger', 6, CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (45, N'Levrek', 7, CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (46, N'Salmon', 7, CAST(12.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (47, N'Koc', 7, CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (48, N'Trofta', 7, CAST(6.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (49, N'Pizza e Shpisë e vogël', 8, CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (50, N'Pizza Përshutë e vogël', 8, CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (51, N'Pizza Suxhuk e vogël', 8, CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (52, N'Pizza Margarita e vogël', 8, CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (53, N'Pizza Tuna e vogël', 8, CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (54, N'Pizza e Shpisë e madhe', 8, CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (55, N'Pizza Përshutë e madhe', 8, CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (56, N'Pizza Suxhuk e madhe', 8, CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (57, N'Pizza Margarita e madhe', 8, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (58, N'Pizza Tuna e madhe', 8, CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (59, N'Sallatë Shope', 10, CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (60, N'Sallatë e Përzier', 10, CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (61, N'Sallatë Greke', 10, CAST(2.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (62, N'Sallatë Pule', 10, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (63, N'Sallatë Tuna', 10, CAST(3.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (64, N'Speca të fërguar', 10, CAST(2.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (65, N'Rizoto Pule', 11, CAST(4.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (66, N'Rizoto Viçi', 11, CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (67, N'Makarona Karbonara', 12, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (68, N'Makarona Bolonez', 12, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (69, N'Makarona Arabiata', 12, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (70, N'Shpageta Karbonara', 12, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (71, N'Shpageta Bolonez', 12, CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (72, N'Shpageta Arabiata', 12, CAST(4.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Username], [PasswordHash], [AdminRights]) VALUES (CAST(1 AS Numeric(18, 0)), N'admin', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 1)
INSERT [dbo].[Users] ([ID], [Username], [PasswordHash], [AdminRights]) VALUES (CAST(5 AS Numeric(18, 0)), N'alban', N'b89581cf975bb7dba41e1a5b52aa86c893ad858233d963325147121cd5cd171f', 0)
INSERT [dbo].[Users] ([ID], [Username], [PasswordHash], [AdminRights]) VALUES (CAST(8 AS Numeric(18, 0)), N'user', N'04f8996da763b7a969b1028ee3007569eaf3a635486ddab211d512c85b9df8fb', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
USE [master]
GO
ALTER DATABASE [RestaurantPOS] SET  READ_WRITE 
GO
