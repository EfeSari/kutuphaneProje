USE [master]
GO
/****** Object:  Database [kutuphaneProjem]    Script Date: 16.03.2022 03:39:11 ******/
CREATE DATABASE [kutuphaneProjem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kutuphaneProjem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\kutuphaneProjem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'kutuphaneProjem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\kutuphaneProjem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [kutuphaneProjem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [kutuphaneProjem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [kutuphaneProjem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET ARITHABORT OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [kutuphaneProjem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [kutuphaneProjem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [kutuphaneProjem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [kutuphaneProjem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [kutuphaneProjem] SET  MULTI_USER 
GO
ALTER DATABASE [kutuphaneProjem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [kutuphaneProjem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [kutuphaneProjem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [kutuphaneProjem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [kutuphaneProjem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [kutuphaneProjem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [kutuphaneProjem] SET QUERY_STORE = OFF
GO
USE [kutuphaneProjem]
GO
/****** Object:  Table [dbo].[emanetKitap]    Script Date: 16.03.2022 03:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emanetKitap](
	[TCno] [nvarchar](50) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[barkodNo] [nvarchar](50) NOT NULL,
	[kitapAd] [nvarchar](50) NOT NULL,
	[yazar] [nvarchar](50) NOT NULL,
	[yayinevi] [nvarchar](50) NOT NULL,
	[sayfaSayisi] [nvarchar](50) NOT NULL,
	[kitapSayisi] [int] NOT NULL,
	[teslimTarihi] [nvarchar](50) NOT NULL,
	[iadeTarihi] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kitap]    Script Date: 16.03.2022 03:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kitap](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[barkodNo] [nvarchar](50) NULL,
	[ad] [nvarchar](50) NULL,
	[yazar] [nvarchar](50) NULL,
	[yayinevi] [nvarchar](50) NULL,
	[sayfaSayisi] [nvarchar](50) NULL,
	[turu] [nvarchar](50) NULL,
	[stokSayisi] [int] NULL,
	[rafNo] [nvarchar](50) NULL,
	[aciklama] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sepet]    Script Date: 16.03.2022 03:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sepet](
	[barkodNo] [nvarchar](50) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[yazar] [nvarchar](50) NOT NULL,
	[yayinevi] [nvarchar](50) NOT NULL,
	[sayfaSayisi] [nvarchar](50) NOT NULL,
	[kitapSayisi] [int] NOT NULL,
	[teslimTarihi] [nvarchar](50) NOT NULL,
	[iadeTarihi] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uye]    Script Date: 16.03.2022 03:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uye](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](50) NULL,
	[soyad] [varchar](50) NULL,
	[TCno] [varchar](50) NULL,
	[telefon] [varchar](50) NULL,
	[cinsiyet] [char](5) NULL,
	[mail] [varchar](50) NULL,
	[kitapSayisi] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[yetkili]    Script Date: 16.03.2022 03:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yetkili](
	[id] [smallint] NULL,
	[ad] [varchar](30) NULL,
	[soyad] [varchar](30) NULL,
	[TCno] [varchar](30) NULL,
	[telefon] [varchar](30) NULL,
	[sifre] [varchar](30) NULL,
	[cinsiyet] [char](5) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [kutuphaneProjem] SET  READ_WRITE 
GO
