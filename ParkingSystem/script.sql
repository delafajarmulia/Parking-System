USE [master]
GO
/****** Object:  Database [parkingdb2]    Script Date: 02/03/2023 14:16:42 ******/
CREATE DATABASE [parkingdb2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'parkingdb2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\parkingdb2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'parkingdb2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\parkingdb2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [parkingdb2] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [parkingdb2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [parkingdb2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [parkingdb2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [parkingdb2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [parkingdb2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [parkingdb2] SET ARITHABORT OFF 
GO
ALTER DATABASE [parkingdb2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [parkingdb2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [parkingdb2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [parkingdb2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [parkingdb2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [parkingdb2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [parkingdb2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [parkingdb2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [parkingdb2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [parkingdb2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [parkingdb2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [parkingdb2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [parkingdb2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [parkingdb2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [parkingdb2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [parkingdb2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [parkingdb2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [parkingdb2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [parkingdb2] SET  MULTI_USER 
GO
ALTER DATABASE [parkingdb2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [parkingdb2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [parkingdb2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [parkingdb2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [parkingdb2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [parkingdb2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [parkingdb2] SET QUERY_STORE = ON
GO
ALTER DATABASE [parkingdb2] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [parkingdb2]
GO
/****** Object:  Table [dbo].[MemberShipTypes]    Script Date: 02/03/2023 14:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberShipTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_MemberShipTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 02/03/2023 14:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[TypeId] [int] NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[DateOfBirth] [nvarchar](max) NOT NULL,
	[Gender] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewMasterMember]    Script Date: 02/03/2023 14:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewMasterMember]
AS
SELECT dbo.Members.Name, dbo.Members.TypeId, dbo.Members.Email, dbo.Members.PhoneNumber, dbo.Members.Address, dbo.Members.DateOfBirth, dbo.Members.Gender, dbo.MemberShipTypes.Name AS MembershipName, 
                  dbo.Members.Id AS IdMember
FROM     dbo.Members LEFT OUTER JOIN
                  dbo.MemberShipTypes ON dbo.Members.TypeId = dbo.MemberShipTypes.Id
GO
/****** Object:  View [dbo].[vw_ViewMasterMember]    Script Date: 02/03/2023 14:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ViewMasterMember] AS SELECT m.Name AS NamaMember, 
	m.TypeId AS TypeId, 
	m.Id AS IdMember, 
	m.Email AS EmailMember, 
	m.PhoneNumber AS NomorHPMember, 
	m.Address AS AddressMember, 
	m.DateOfBirth AS DateOfBirthMember, 
	m.Gender AS GenderMember, 
               ms.Id AS IdMembership, ms.Name AS MembershipName
FROM     dbo.Members AS m LEFT OUTER JOIN
                  dbo.MemberShipTypes AS ms ON m.TypeId = ms.Id
GO
/****** Object:  Table [dbo].[VehicleTypes]    Script Date: 02/03/2023 14:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[LastUpdatedAt] [datetime] NULL,
	[DeletedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 02/03/2023 14:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VehicleTypeId] [int] NULL,
	[MemberId] [int] NULL,
	[LicensePlate] [varchar](15) NULL,
	[Notes] [varchar](100) NULL,
	[CreatedAt] [datetime] NULL,
	[LastUpdatedAt] [datetime] NULL,
	[DeletedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewMasterVehicle]    Script Date: 02/03/2023 14:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewMasterVehicle]
AS
SELECT dbo.VehicleTypes.Id AS IdVehicleType, dbo.VehicleTypes.Name AS NameVehicleType, dbo.Vehicles.Id AS VehicleId, dbo.Vehicles.VehicleTypeId, dbo.Vehicles.MemberId, dbo.Vehicles.LicensePlate, dbo.Vehicles.Notes, 
                  dbo.Members.Id AS IdMember, dbo.Members.Name AS MemberName
FROM     dbo.Vehicles INNER JOIN
                  dbo.VehicleTypes ON dbo.Vehicles.VehicleTypeId = dbo.VehicleTypes.Id INNER JOIN
                  dbo.Members ON dbo.Vehicles.MemberId = dbo.Members.Id
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 02/03/2023 14:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 02/03/2023 14:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HourlyRates]    Script Date: 02/03/2023 14:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HourlyRates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MembershipId] [int] NULL,
	[VehicleTypeId] [int] NULL,
	[Value] [varchar](100) NULL,
	[CreatedAt] [datetime] NULL,
	[LastUpdatedAt] [datetime] NULL,
	[DeletedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParkingData]    Script Date: 02/03/2023 14:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParkingData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LicensePlate] [varchar](15) NULL,
	[VehicleId] [int] NULL,
	[EmployeeId] [int] NULL,
	[HourlyRatesId] [int] NULL,
	[DatetimeIn] [datetime] NULL,
	[DatetimeOn] [datetime] NULL,
	[AmountToPay] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[LastUpdatedAt] [datetime] NULL,
	[DeletedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Members_TypeId]    Script Date: 02/03/2023 14:16:43 ******/
CREATE NONCLUSTERED INDEX [IX_Members_TypeId] ON [dbo].[Members]
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Members]  WITH CHECK ADD  CONSTRAINT [FK_Members_MemberShipTypes_TypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[MemberShipTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Members] CHECK CONSTRAINT [FK_Members_MemberShipTypes_TypeId]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Members"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MemberShipTypes"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 148
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewMasterMember'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewMasterMember'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "VehicleTypes"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Vehicles"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Members"
            Begin Extent = 
               Top = 7
               Left = 532
               Bottom = 170
               Right = 726
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1644
         Alias = 2088
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewMasterVehicle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewMasterVehicle'
GO
USE [master]
GO
ALTER DATABASE [parkingdb2] SET  READ_WRITE 
GO
