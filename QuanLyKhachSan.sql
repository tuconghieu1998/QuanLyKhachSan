USE [master]
GO
/****** Object:  Database [QuanLyKhachSan]    Script Date: 6/24/2019 11:39:12 PM ******/
CREATE DATABASE [QuanLyKhachSan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKhachSan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyKhachSan.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyKhachSan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyKhachSan_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyKhachSan] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKhachSan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKhachSan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKhachSan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET TRUSTWORTHY ON 
GO
ALTER DATABASE [QuanLyKhachSan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKhachSan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKhachSan] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKhachSan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKhachSan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKhachSan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyKhachSan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyKhachSan] SET QUERY_STORE = OFF
GO
USE [QuanLyKhachSan]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QuanLyKhachSan]
GO
/****** Object:  Table [dbo].[CHI_TIET_HOA_DON]    Script Date: 6/24/2019 11:39:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHI_TIET_HOA_DON](
	[ID_HoaDon] [int] NOT NULL,
	[STT] [int] NOT NULL,
	[ID_PhieuThue] [int] NULL,
	[SoNgay] [int] NULL,
	[DonGia] [float] NULL,
	[PhuThu] [float] NULL,
	[Tien] [float] NULL,
 CONSTRAINT [PK_CHI_TIET_HOA_DON] PRIMARY KEY CLUSTERED 
(
	[ID_HoaDon] ASC,
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHI_TIET_PHAN_QUYEN]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHI_TIET_PHAN_QUYEN](
	[ID] [int] NOT NULL,
	[ID_PhanQuyen] [int] NULL,
	[TenChucNang] [nvarchar](50) NULL,
	[MaChucNang] [nvarchar](50) NULL,
	[QuyenTruyCap] [bit] NULL,
 CONSTRAINT [PK_CHI_TIET_PHAN_QUYEN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHI_TIET_PHIEU_THUE]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHI_TIET_PHIEU_THUE](
	[ID_PhieuThue] [int] NOT NULL,
	[STT] [int] NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[LoaiKhach] [int] NULL,
	[CMND] [nvarchar](15) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_CHI_TIET_PHIEU_THUE] PRIMARY KEY CLUSTERED 
(
	[ID_PhieuThue] ASC,
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOA_DON]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOA_DON](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KhachHang] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[TongTien] [float] NULL,
	[ID_NhanVien] [int] NOT NULL,
 CONSTRAINT [PK_HOA_DON] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAI_KHACH]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAI_KHACH](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[PhuThu] [float] NULL,
 CONSTRAINT [PK_LOAI_KHACH] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAI_PHONG]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAI_PHONG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[DonGia] [money] NULL,
	[SL_KhachBinhThuong] [int] NULL,
	[SL_KhachToiDa] [int] NULL,
	[PhuThu] [float] NULL,
 CONSTRAINT [PK_LOAI_PHONG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUOI_DUNG]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOI_DUNG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[CMND] [nvarchar](15) NULL,
	[SDT] [nvarchar](15) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[TaiKhoan] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[TinhTrang] [int] NULL,
 CONSTRAINT [PK_NGUOI_DUNG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHAN_QUYEN]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHAN_QUYEN](
	[ID] [int] NOT NULL,
	[TenPhanQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHAN_QUYEN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHAN_QUYEN_NGUOI_DUNG]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHAN_QUYEN_NGUOI_DUNG](
	[ID] [int] NOT NULL,
	[ID_NguoiDung] [int] NULL,
	[ID_PhanQuyen] [int] NULL,
 CONSTRAINT [PK_PHAN_QUYEN_NGUOI_DUNG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEU_THUE]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEU_THUE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Phong] [int] NOT NULL,
	[NgayThue] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[TinhTrang] [int] NULL,
	[ID_NhanVien] [int] NOT NULL,
 CONSTRAINT [PK_PHIEU_THUE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](10) NULL,
	[LoaiPhong] [int] NULL,
	[GhiChu] [nvarchar](500) NULL,
	[TinhTrang] [int] NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHI_TIET_HOA_DON] ([ID_HoaDon], [STT], [ID_PhieuThue], [SoNgay], [DonGia], [PhuThu], [Tien]) VALUES (10, 1, 17, 2, 150000, 262500, 562500)
INSERT [dbo].[CHI_TIET_HOA_DON] ([ID_HoaDon], [STT], [ID_PhieuThue], [SoNgay], [DonGia], [PhuThu], [Tien]) VALUES (11, 1, 29, 9, 150000, 337500, 1687500)
INSERT [dbo].[CHI_TIET_HOA_DON] ([ID_HoaDon], [STT], [ID_PhieuThue], [SoNgay], [DonGia], [PhuThu], [Tien]) VALUES (11, 2, 23, 1, 200000, 175000, 375000)
INSERT [dbo].[CHI_TIET_HOA_DON] ([ID_HoaDon], [STT], [ID_PhieuThue], [SoNgay], [DonGia], [PhuThu], [Tien]) VALUES (11, 3, 31, 1, 200000, 50000, 250000)
INSERT [dbo].[CHI_TIET_HOA_DON] ([ID_HoaDon], [STT], [ID_PhieuThue], [SoNgay], [DonGia], [PhuThu], [Tien]) VALUES (12, 1, 22, 2, 150000, 75000, 375000)
INSERT [dbo].[CHI_TIET_HOA_DON] ([ID_HoaDon], [STT], [ID_PhieuThue], [SoNgay], [DonGia], [PhuThu], [Tien]) VALUES (12, 2, 26, 1, 300000, 75000, 375000)
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (17, 1, N'Từ Công Hiếu', 1, N'12355656545', N'trống')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (17, 2, N'Jone Kenedy', 2, N'12355656545', N'trống')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (18, 1, N'Nguyễn Văn Bình', 1, N'21548796321', N'12 Trần Phú, Quận 12, TP.HCM')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (18, 2, N'Phạm Thị Yến', 1, N'21548794587', N'12 Trần Phú, Quận 12, TP.HCM')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (19, 1, N'Võ Văn Kiệt', 1, N'2124542154', N'TP.HCM')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (19, 2, N'Võ Văn Thanh', 1, N'2124545487', N'TP.HCM')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (19, 3, N'Võ Văn La', 1, N'2124545548', N'TP.HCM')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (19, 4, N'Võ Văn Minh', 1, N'2124545582', N'TP.HCM')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (20, 1, N'Jone Kenedy', 2, N'54879895852', N'Chicago, Hoa Kỳ')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (20, 2, N'Romelu Lukaku', 2, N'54879895879', N'Bỉ')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (21, 1, N'David Degea', 2, N'5489866212', N'Marrid, Tây Ban Nha')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (21, 2, N'Nguyễn Văn Hiếu', 1, N'21548796523', N'Hà Nội')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (22, 1, N'Nguyễn Văn An', 1, N'54879858794', N'Sơn Tịnh, Quảng Ngãi')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (22, 2, N'Nguyễn Phú Bình', 1, N'54879858749', N'Sơn Tịnh, Quảng Ngãi')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (22, 3, N'Phạm Thị Tuyết', 1, N'54879858412', N'Sơn Tịnh, Quảng Ngãi')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (23, 1, N'Bill Gates', 2, N'5479654512', N' Seattle, Washington, Hoa Kỳ')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (24, 1, N'Nguyễn Văn Ánh', 1, N'215487965', N'Thanh Hóa')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (25, 1, N'Từ Công Hiếu', 1, N'21545879565', N'Quảng Ngãi')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (26, 1, N'Nguyễn Văn Ba', 1, N'215478965', N'TP.HCM')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (27, 1, N'Monkey D.Luffy', 2, N'54787521326', N'Biển Đông')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (27, 2, N'Boa HanCock', 2, N'547875215487', N'Amazon Lily')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (28, 1, N'Songoku ', 2, N'5487895656', N'Tokyo, Nhật Bản')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (29, 1, N'Nguyễn Khá Bảnh', 1, N'21548798', N'Hà Nội')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (30, 1, N'Nguyễn Văn Tý', 1, N'548798565', N'Thăng Long')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (31, 1, N'Nguyễn Quang Hải', 1, N'21548798656', N'TP.HCM')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (31, 2, N'Phạm Thị Yến Nhi', 1, N'21548798874', N'TP.HCM')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (32, 1, N'Đỗ Thánh', 2, N'2154879656', N'HongKong, Trung Quốc')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (32, 2, N'Châu Tinh Tinh', 2, N'2154878795', N'HongKong, Trung Quốc')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (33, 1, N'Từ Công Hiêu', 1, N'215478965', N'TP.HCM')
INSERT [dbo].[CHI_TIET_PHIEU_THUE] ([ID_PhieuThue], [STT], [TenKhachHang], [LoaiKhach], [CMND], [DiaChi]) VALUES (33, 2, N'Jone ', 2, N'215478987', N'Mỹ')
SET IDENTITY_INSERT [dbo].[HOA_DON] ON 

INSERT [dbo].[HOA_DON] ([ID], [KhachHang], [DiaChi], [TongTien], [ID_NhanVien]) VALUES (10, N'Công ty Toyota', N'TP.HCM', 562500, 1)
INSERT [dbo].[HOA_DON] ([ID], [KhachHang], [DiaChi], [TongTien], [ID_NhanVien]) VALUES (11, N'Tập đoàn Vingroup', N'TP.HCM', 2312500, 1)
INSERT [dbo].[HOA_DON] ([ID], [KhachHang], [DiaChi], [TongTien], [ID_NhanVien]) VALUES (12, N'Công ty Honda', N'TP.HCM', 750000, 1)
SET IDENTITY_INSERT [dbo].[HOA_DON] OFF
SET IDENTITY_INSERT [dbo].[LOAI_KHACH] ON 

INSERT [dbo].[LOAI_KHACH] ([ID], [TenLoai], [PhuThu]) VALUES (1, N'Nội địa', 1)
INSERT [dbo].[LOAI_KHACH] ([ID], [TenLoai], [PhuThu]) VALUES (2, N'Nước ngoài', 2)
SET IDENTITY_INSERT [dbo].[LOAI_KHACH] OFF
SET IDENTITY_INSERT [dbo].[LOAI_PHONG] ON 

INSERT [dbo].[LOAI_PHONG] ([ID], [TenLoai], [DonGia], [SL_KhachBinhThuong], [SL_KhachToiDa], [PhuThu]) VALUES (1, N'Bình thường', 150000.0000, 3, 4, 1.25)
INSERT [dbo].[LOAI_PHONG] ([ID], [TenLoai], [DonGia], [SL_KhachBinhThuong], [SL_KhachToiDa], [PhuThu]) VALUES (2, N'Cao cấp', 200000.0000, 3, 4, 1.25)
INSERT [dbo].[LOAI_PHONG] ([ID], [TenLoai], [DonGia], [SL_KhachBinhThuong], [SL_KhachToiDa], [PhuThu]) VALUES (3, N'Vip', 350000.0000, 3, 5, 1.25)
SET IDENTITY_INSERT [dbo].[LOAI_PHONG] OFF
SET IDENTITY_INSERT [dbo].[NGUOI_DUNG] ON 

INSERT [dbo].[NGUOI_DUNG] ([ID], [Ten], [CMND], [SDT], [DiaChi], [TaiKhoan], [MatKhau], [TinhTrang]) VALUES (1, N'Từ Công Hiếu', N'245678912', N'0356978452', N'TP.HCM', N'tuconghieu', N'123456789', 1)
INSERT [dbo].[NGUOI_DUNG] ([ID], [Ten], [CMND], [SDT], [DiaChi], [TaiKhoan], [MatKhau], [TinhTrang]) VALUES (2, N'HieuAdmin', N'215465841', N'0322646656', N'TP.HCM', N'admin', N'123456789', 1)
SET IDENTITY_INSERT [dbo].[NGUOI_DUNG] OFF
SET IDENTITY_INSERT [dbo].[PHIEU_THUE] ON 

INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (17, 30, CAST(N'2019-06-19T01:35:00.000' AS DateTime), CAST(N'2019-06-20T01:36:00.000' AS DateTime), 2, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (18, 5, CAST(N'2019-06-19T21:59:00.000' AS DateTime), NULL, 0, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (19, 18, CAST(N'2019-06-23T22:01:00.000' AS DateTime), NULL, 0, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (20, 14, CAST(N'2019-06-23T22:04:00.000' AS DateTime), NULL, 0, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (21, 40, CAST(N'2019-06-19T22:05:00.000' AS DateTime), NULL, 0, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (22, 28, CAST(N'2019-06-23T22:07:00.000' AS DateTime), CAST(N'2019-06-24T22:59:00.000' AS DateTime), 2, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (23, 24, CAST(N'2019-06-23T22:11:00.000' AS DateTime), CAST(N'2019-06-23T22:36:00.000' AS DateTime), 2, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (24, 35, CAST(N'2019-06-17T22:13:00.000' AS DateTime), NULL, 0, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (25, 12, CAST(N'2019-06-23T22:14:00.000' AS DateTime), NULL, 0, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (26, 9, CAST(N'2019-06-23T22:16:00.000' AS DateTime), CAST(N'2019-06-23T22:45:00.000' AS DateTime), 2, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (27, 39, CAST(N'2019-06-23T22:19:00.000' AS DateTime), NULL, 0, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (28, 21, CAST(N'2019-06-23T22:26:00.000' AS DateTime), CAST(N'2019-06-23T22:34:00.000' AS DateTime), 1, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (29, 30, CAST(N'2019-06-15T22:27:00.000' AS DateTime), CAST(N'2019-06-23T22:36:00.000' AS DateTime), 2, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (30, 36, CAST(N'2019-06-22T22:28:00.000' AS DateTime), NULL, 0, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (31, 8, CAST(N'2019-06-23T22:29:00.000' AS DateTime), CAST(N'2019-06-23T22:36:00.000' AS DateTime), 2, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (32, 32, CAST(N'2019-06-23T22:32:00.000' AS DateTime), NULL, 0, 1)
INSERT [dbo].[PHIEU_THUE] ([ID], [ID_Phong], [NgayThue], [NgayKetThuc], [TinhTrang], [ID_NhanVien]) VALUES (33, 17, CAST(N'2019-06-24T22:58:00.000' AS DateTime), NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[PHIEU_THUE] OFF
SET IDENTITY_INSERT [dbo].[PHONG] ON 

INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (1, N'101', 1, N'Có máy lạnh', -1)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (2, N'102', 1, N'Máy lạnh hư', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (3, N'103', 1, N'Có máy lạnh', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (4, N'104', 2, N'không có', -1)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (5, N'105', 2, N'không có', 1)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (6, N'106', 3, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (7, N'107', 1, N'Chị A đặt trước', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (8, N'108', 2, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (9, N'109', 3, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (10, N'201', 1, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (11, N'202', 1, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (12, N'203', 1, N'không có', 1)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (13, N'204', 2, N'Ti vi bị hỏng', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (14, N'205', 2, N'không có', 1)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (15, N'206', 2, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (16, N'207', 2, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (17, N'208', 3, N'không có', 1)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (18, N'209', 3, N'không có', 1)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (19, N'301', 1, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (20, N'302', 1, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (21, N'303', 1, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (22, N'304', 2, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (23, N'305', 2, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (24, N'306', 2, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (25, N'307', 2, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (26, N'308', 3, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (27, N'309', 3, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (28, N'401', 1, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (29, N'402', 1, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (30, N'403', 1, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (31, N'404', 1, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (32, N'405', 2, N'không có', 1)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (33, N'406', 2, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (34, N'407', 3, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (35, N'408', 3, N'không có', 1)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (36, N'409', 3, N'không có', 1)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (37, N'501', 1, N'không có', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (38, N'502', 2, N'Đặt trước cho công ty A', 0)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (39, N'101', 3, N'không có', 1)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (40, N'503', 3, N'không có', 1)
INSERT [dbo].[PHONG] ([ID], [TenPhong], [LoaiPhong], [GhiChu], [TinhTrang]) VALUES (41, N'504', 3, N'Máy lạnh, tivi', -1)
SET IDENTITY_INSERT [dbo].[PHONG] OFF
ALTER TABLE [dbo].[CHI_TIET_HOA_DON]  WITH CHECK ADD  CONSTRAINT [FK_CHI_TIET_HOA_DON_HOA_DON] FOREIGN KEY([ID_HoaDon])
REFERENCES [dbo].[HOA_DON] ([ID])
GO
ALTER TABLE [dbo].[CHI_TIET_HOA_DON] CHECK CONSTRAINT [FK_CHI_TIET_HOA_DON_HOA_DON]
GO
ALTER TABLE [dbo].[CHI_TIET_HOA_DON]  WITH CHECK ADD  CONSTRAINT [FK_CHI_TIET_HOA_DON_PHIEU_THUE] FOREIGN KEY([ID_PhieuThue])
REFERENCES [dbo].[PHIEU_THUE] ([ID])
GO
ALTER TABLE [dbo].[CHI_TIET_HOA_DON] CHECK CONSTRAINT [FK_CHI_TIET_HOA_DON_PHIEU_THUE]
GO
ALTER TABLE [dbo].[CHI_TIET_PHAN_QUYEN]  WITH CHECK ADD  CONSTRAINT [FK_CHI_TIET_PHAN_QUYEN_PHAN_QUYEN] FOREIGN KEY([ID_PhanQuyen])
REFERENCES [dbo].[PHAN_QUYEN] ([ID])
GO
ALTER TABLE [dbo].[CHI_TIET_PHAN_QUYEN] CHECK CONSTRAINT [FK_CHI_TIET_PHAN_QUYEN_PHAN_QUYEN]
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE]  WITH CHECK ADD  CONSTRAINT [FK_CHI_TIET_PHIEU_THUE_LOAI_KHACH] FOREIGN KEY([LoaiKhach])
REFERENCES [dbo].[LOAI_KHACH] ([ID])
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE] CHECK CONSTRAINT [FK_CHI_TIET_PHIEU_THUE_LOAI_KHACH]
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE]  WITH CHECK ADD  CONSTRAINT [FK_CHI_TIET_PHIEU_THUE_PHIEU_THUE] FOREIGN KEY([ID_PhieuThue])
REFERENCES [dbo].[PHIEU_THUE] ([ID])
GO
ALTER TABLE [dbo].[CHI_TIET_PHIEU_THUE] CHECK CONSTRAINT [FK_CHI_TIET_PHIEU_THUE_PHIEU_THUE]
GO
ALTER TABLE [dbo].[HOA_DON]  WITH CHECK ADD  CONSTRAINT [FK_HOA_DON_NGUOI_DUNG] FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NGUOI_DUNG] ([ID])
GO
ALTER TABLE [dbo].[HOA_DON] CHECK CONSTRAINT [FK_HOA_DON_NGUOI_DUNG]
GO
ALTER TABLE [dbo].[PHAN_QUYEN_NGUOI_DUNG]  WITH CHECK ADD  CONSTRAINT [FK_PHAN_QUYEN_NGUOI_DUNG_NGUOI_DUNG] FOREIGN KEY([ID_NguoiDung])
REFERENCES [dbo].[NGUOI_DUNG] ([ID])
GO
ALTER TABLE [dbo].[PHAN_QUYEN_NGUOI_DUNG] CHECK CONSTRAINT [FK_PHAN_QUYEN_NGUOI_DUNG_NGUOI_DUNG]
GO
ALTER TABLE [dbo].[PHAN_QUYEN_NGUOI_DUNG]  WITH CHECK ADD  CONSTRAINT [FK_PHAN_QUYEN_NGUOI_DUNG_PHAN_QUYEN] FOREIGN KEY([ID_PhanQuyen])
REFERENCES [dbo].[PHAN_QUYEN] ([ID])
GO
ALTER TABLE [dbo].[PHAN_QUYEN_NGUOI_DUNG] CHECK CONSTRAINT [FK_PHAN_QUYEN_NGUOI_DUNG_PHAN_QUYEN]
GO
ALTER TABLE [dbo].[PHIEU_THUE]  WITH CHECK ADD  CONSTRAINT [FK_PHIEU_THUE_NGUOI_DUNG] FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NGUOI_DUNG] ([ID])
GO
ALTER TABLE [dbo].[PHIEU_THUE] CHECK CONSTRAINT [FK_PHIEU_THUE_NGUOI_DUNG]
GO
ALTER TABLE [dbo].[PHIEU_THUE]  WITH CHECK ADD  CONSTRAINT [FK_PHIEU_THUE_PHONG] FOREIGN KEY([ID_Phong])
REFERENCES [dbo].[PHONG] ([ID])
GO
ALTER TABLE [dbo].[PHIEU_THUE] CHECK CONSTRAINT [FK_PHIEU_THUE_PHONG]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_LOAI_PHONG] FOREIGN KEY([LoaiPhong])
REFERENCES [dbo].[LOAI_PHONG] ([ID])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_LOAI_PHONG]
GO
/****** Object:  StoredProcedure [dbo].[pro_DSLoaiKhach]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_DSLoaiKhach] 
as
	Select lk.ID, lk.TenLoai, lk.PhuThu from LOAI_KHACH lk
GO
/****** Object:  StoredProcedure [dbo].[pro_DSLoaiPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_DSLoaiPhong] 
as
	Select * from LOAI_PHONG
GO
/****** Object:  StoredProcedure [dbo].[pro_DuyetDSPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_DuyetDSPhong] @loaiPhong int, @tinhTrang int
as
	Select PHONG.ID, TenPhong, TenLoai, GhiChu, TinhTrang
	from PHONG, LOAI_PHONG
	where PHONG.LoaiPhong = LOAI_PHONG.ID and TinhTrang != -1 and PHONG.LoaiPhong = @loaiPhong and PHONG.TinhTrang = @tinhTrang 
GO
/****** Object:  StoredProcedure [dbo].[pro_DuyetDSPhongTheoLoaiPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_DuyetDSPhongTheoLoaiPhong] @loaiPhong int
as
	Select PHONG.ID, TenPhong, TenLoai, GhiChu, TinhTrang
	from PHONG, LOAI_PHONG
	where PHONG.LoaiPhong = LOAI_PHONG.ID and TinhTrang != -1 and PHONG.LoaiPhong = @loaiPhong
GO
/****** Object:  StoredProcedure [dbo].[pro_DuyetDSPhongTheoTinhTrang]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_DuyetDSPhongTheoTinhTrang] @tinhTrang int
as
	Select PHONG.ID, TenPhong, TenLoai, GhiChu, TinhTrang
	from PHONG, LOAI_PHONG
	where PHONG.LoaiPhong = LOAI_PHONG.ID and TinhTrang != -1 and PHONG.TinhTrang = @tinhTrang
GO
/****** Object:  StoredProcedure [dbo].[pro_DuyetPhieuThueTheoNgayBatDau]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_DuyetPhieuThueTheoNgayBatDau] @dateFrom datetime, @dateTo datetime, @Limit int, @Offset int
as
	;WITH Results_CTE AS
	(
		SELECT pt.ID, p.TenPhong, pt.NgayThue, pt.NgayKetThuc, pt.TinhTrang, u.Ten,
			ROW_NUMBER() OVER (ORDER BY pt.ID DESC) AS RowNum
		FROM PHONG p, PHIEU_THUE pt, NGUOI_DUNG u
		WHERE p.ID = pt.ID_Phong and pt.ID_NhanVien = u.ID and pt.NgayThue >= @dateFrom and pt.NgayThue <= @dateTo
	)
	SELECT *
	FROM Results_CTE
	WHERE RowNum > @Offset*@Limit
	AND RowNum <= @Offset*@Limit + @Limit
GO
/****** Object:  StoredProcedure [dbo].[pro_DuyetPhieuThueTheoNgayBatDauVaTinhTrangThue]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_DuyetPhieuThueTheoNgayBatDauVaTinhTrangThue] @dateFrom datetime, @dateTo datetime, @tinhTrang int, @Limit int, @Offset int
as
	;WITH Results_CTE AS
	(
		SELECT pt.ID, p.TenPhong, pt.NgayThue, pt.NgayKetThuc, pt.TinhTrang, u.Ten,
			ROW_NUMBER() OVER (ORDER BY pt.ID DESC) AS RowNum
		FROM PHONG p, PHIEU_THUE pt, NGUOI_DUNG u
		WHERE p.ID = pt.ID_Phong and pt.ID_NhanVien = u.ID and pt.NgayThue >= @dateFrom and pt.NgayThue <= @dateTo and pt.TinhTrang = @tinhTrang
	)
	SELECT *
	FROM Results_CTE
	WHERE RowNum > @Offset*@Limit
	AND RowNum <= @Offset*@Limit + @Limit
GO
/****** Object:  StoredProcedure [dbo].[pro_getIDLoaiKhach]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_getIDLoaiKhach] @tenLoaiKhach nvarchar(50)
as
	select id
	from LOAI_KHACH
	where tenLoai = @tenLoaiKhach
GO
/****** Object:  StoredProcedure [dbo].[pro_getIDPhieuThueHienTai]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_getIDPhieuThueHienTai] @idPhong int
as
	Select PHIEU_THUE.ID
	from PHIEU_THUE
	where PHIEU_THUE.ID_Phong = @idPhong and PHIEU_THUE.TinhTrang = 0
GO
/****** Object:  StoredProcedure [dbo].[pro_getSLKhachToiDa]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_getSLKhachToiDa] @idPhong int
as
	Select LOAI_PHONG.SL_KhachToiDa
	from PHONG, LOAI_PHONG
	where PHONG.ID = @idPhong and PHONG.LoaiPhong = LOAI_PHONG.ID
GO
/****** Object:  StoredProcedure [dbo].[pro_getTenLoaiPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_getTenLoaiPhong] @id int
as
	select TenLoai
	from LOAI_PHONG
	where id = @id
GO
/****** Object:  StoredProcedure [dbo].[pro_getThoiGianThuePhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_getThoiGianThuePhong] @idPhieuThue int
as
	Select PHIEU_THUE.NgayThue, PHIEU_THUE.NgayKetThuc
	from PHIEU_THUE 
	where PHIEU_THUE.ID = @idPhieuThue
GO
/****** Object:  StoredProcedure [dbo].[pro_insertChiTietHoaDon]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_insertChiTietHoaDon] @idHoaDon int, @stt int, @idPhieuThue int, @soNgay int, @donGia float, @phuThu float, @tien float
as
	INSERT INTO CHI_TIET_HOA_DON(ID_HoaDon, STT, ID_PhieuThue, SoNgay, DonGia, PhuThu, Tien)
	VALUES (@idHoaDon, @stt, @idPhieuThue, @soNgay, @donGia, @phuThu, @tien);
GO
/****** Object:  StoredProcedure [dbo].[pro_insertChiTietPhieuThue]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_insertChiTietPhieuThue] @idPhieuThue int, @stt int, @tenKhachHang nvarchar(50), @loaiKhach int, @CMND nvarchar(15), @diaChi nvarchar(50)
as
	INSERT INTO CHI_TIET_PHIEU_THUE(ID_PhieuThue, STT, TenKhachHang, LoaiKhach, CMND, DiaChi)
	VALUES (@idPhieuThue, @stt, @tenKhachHang, @loaiKhach, @CMND, @diaChi);
GO
/****** Object:  StoredProcedure [dbo].[pro_insertHoaDon]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_insertHoaDon] @tenKhachHang nvarchar(50), @diaChi nvarchar(200), @tongTien float, @idNhanVien int
as 
	INSERT INTO HOA_DON(KhachHang, DiaChi, TongTien, ID_NhanVien)
	OUTPUT INSERTED.id
	VALUES (@tenKhachHang, @diaChi, @tongTien, @idNhanVien);
GO
/****** Object:  StoredProcedure [dbo].[pro_insertPhieuThue]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_insertPhieuThue] @idPhong int, @ngayThue datetime, @idNhanVien int
as
	INSERT INTO PHIEU_THUE(ID_Phong, NgayThue, NgayKetThuc, TinhTrang, ID_NhanVien)
	OUTPUT INSERTED.id
	VALUES (@idPhong, @ngayThue, null,0,@idNhanVien);
GO
/****** Object:  StoredProcedure [dbo].[pro_KiemTraDSKhachThue]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_KiemTraDSKhachThue] @idPhieuThue int
as
	Select ct.STT, ct.TenKhachHang, lk.TenLoai
	from CHI_TIET_PHIEU_THUE ct, LOAI_KHACH lk
	where ct.ID_PhieuThue = @idPhieuThue and ct.LoaiKhach = lk.ID
GO
/****** Object:  StoredProcedure [dbo].[pro_KiemTraPhieuThue]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_KiemTraPhieuThue] @idPhieuThue int
as
	Select p.TenPhong, pt.NgayThue, pt.TinhTrang
	from PHONG p, PHIEU_THUE pt
	where pt.ID = @idPhieuThue and p.ID = pt.ID_Phong
GO
/****** Object:  StoredProcedure [dbo].[pro_kiemTraTrungTenPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_kiemTraTrungTenPhong] @tenPhong nvarchar(10)
as
	SELECT COUNT(TenPhong) as SLPhong FROM PHONG where TenPhong = @tenPhong and PHONG.TinhTrang != '-1'
GO
/****** Object:  StoredProcedure [dbo].[pro_kiemTraTrungTenPhongKhiCapNhap]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_kiemTraTrungTenPhongKhiCapNhap] @id int, @tenPhong nvarchar(10)
as
	SELECT COUNT(TenPhong) as SLPhong FROM PHONG where TenPhong = @tenPhong and ID != @id and PHONG.TinhTrang != '-1'
GO
/****** Object:  StoredProcedure [dbo].[pro_LayChiTietHoaDon]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LayChiTietHoaDon] @idHoaDon int
as
	Select ct.STT, ct.ID_PhieuThue, p.TenPhong, ct.SoNgay, ct.DonGia, ct.PhuThu, ct.Tien
	from CHI_TIET_HOA_DON ct, PHIEU_THUE pt, PHONG p
	where ct.ID_HoaDon = @idHoaDon and ct.ID_PhieuThue = pt.ID and pt.ID_Phong = p.ID
GO
/****** Object:  StoredProcedure [dbo].[pro_LayChiTietPhieuThue]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LayChiTietPhieuThue] @idPhieuThue int
as
	Select ct.STT, ct.TenKhachHang, lk.TenLoai, ct.CMND, ct.DiaChi
	from CHI_TIET_PHIEU_THUE ct, LOAI_KHACH lk
	where ct.ID_PhieuThue = @idPhieuThue and ct.LoaiKhach = lk.ID
GO
/****** Object:  StoredProcedure [dbo].[pro_LayDanhSachHoaDon]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LayDanhSachHoaDon] @Limit int, @Offset int
as
	;WITH Results_CTE AS
	(
		SELECT hd.ID, hd.KhachHang, hd.DiaChi, hd.TongTien, u.Ten,
			ROW_NUMBER() OVER (ORDER BY hd.ID DESC) AS RowNum
		FROM HOA_DON hd, NGUOI_DUNG u
		WHERE hd.ID_NhanVien = u.ID
	)
	SELECT *
	FROM Results_CTE
	WHERE RowNum > @Offset*@Limit
	AND RowNum <= @Offset*@Limit + @Limit
GO
/****** Object:  StoredProcedure [dbo].[pro_LayDanhSachPhieuThue]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LayDanhSachPhieuThue] @Limit int, @Offset int
as
	;WITH Results_CTE AS
	(
		SELECT pt.ID, p.TenPhong, pt.NgayThue, pt.NgayKetThuc, pt.TinhTrang, u.Ten,
			ROW_NUMBER() OVER (ORDER BY pt.ID DESC) AS RowNum
		FROM PHONG p, PHIEU_THUE pt, NGUOI_DUNG u
		WHERE p.ID = pt.ID_Phong and pt.ID_NhanVien = u.ID
	)
	SELECT *
	FROM Results_CTE
	WHERE RowNum > @Offset*@Limit
	AND RowNum <= @Offset*@Limit + @Limit
GO
/****** Object:  StoredProcedure [dbo].[pro_LayDuLieuThuePhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LayDuLieuThuePhong] @idPhieuThue int
as
	Select phieu.ID, phieu.NgayThue, phieu.NgayKetThuc, l.DonGia, l.PhuThu, l.SL_KhachBinhThuong, l.SL_KhachToiDa, p.TenPhong, count(*) as SL_Khach
	from PHIEU_THUE phieu, CHI_TIET_PHIEU_THUE chiTiet, PHONG p, LOAI_PHONG l
	where phieu.ID = @idPhieuThue and phieu.ID = chiTiet.ID_PhieuThue and phieu.ID_Phong = p.ID and p.LoaiPhong = l.ID
	group by phieu.ID, phieu.NgayThue, phieu.NgayKetThuc, l.DonGia, l.PhuThu, l.SL_KhachBinhThuong, l.SL_KhachToiDa, p.TenPhong
GO
/****** Object:  StoredProcedure [dbo].[pro_LayPhuThuLoaiKhachCaoNhatTheoPhieuThue]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LayPhuThuLoaiKhachCaoNhatTheoPhieuThue] @idPhieuThue int
as
	Select DISTINCT lk.PhuThu
	from CHI_TIET_PHIEU_THUE chiTiet, LOAI_KHACH lk
	where chiTiet.ID_PhieuThue = @idPhieuThue and chiTiet.LoaiKhach = lk.ID and lk.PhuThu >= all(Select lk.PhuThu
	from CHI_TIET_PHIEU_THUE chiTiet, LOAI_KHACH lk
	where chiTiet.ID_PhieuThue = @idPhieuThue and chiTiet.LoaiKhach = lk.ID) 
GO
/****** Object:  StoredProcedure [dbo].[pro_LaySoLuongHoaDon]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LaySoLuongHoaDon]
as 
	Select COUNT(*) as total
	From HOA_DON
GO
/****** Object:  StoredProcedure [dbo].[pro_LaySoLuongPhieuThue]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LaySoLuongPhieuThue]
as 
	Select COUNT(*) as total
	From PHIEU_THUE
GO
/****** Object:  StoredProcedure [dbo].[pro_LaySoLuongPhieuThueTheoNgayBatDau]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LaySoLuongPhieuThueTheoNgayBatDau] @dateFrom datetime, @dateTo datetime
as 
	Select COUNT(*) as total
	From PHIEU_THUE pt
	where pt.NgayThue >= @dateFrom and pt.NgayThue <= @dateTo
GO
/****** Object:  StoredProcedure [dbo].[pro_LaySoLuongPhieuThueTheoNgayBatDauVaTinhTrangThue]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LaySoLuongPhieuThueTheoNgayBatDauVaTinhTrangThue] @dateFrom datetime, @dateTo datetime, @tinhTrang int
as 
	Select COUNT(*) as total
	From PHIEU_THUE pt
	where pt.NgayThue >= @dateFrom and pt.NgayThue <= @dateTo and pt.TinhTrang = @tinhTrang
GO
/****** Object:  StoredProcedure [dbo].[pro_LoadDSKhachThuePhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LoadDSKhachThuePhong] @id int
as
	Select phieu.ID as idPhieuThue, phieu.NgayThue, chiTiet.STT, chiTiet.TenKhachHang
	from PHONG p, PHIEU_THUE phieu, CHI_TIET_PHIEU_THUE chiTiet
	where phieu.ID = chiTiet.ID_PhieuThue and p.ID = phieu.ID_Phong and p.TinhTrang = 1 and p.ID = @id and phieu.TinhTrang = 0
GO
/****** Object:  StoredProcedure [dbo].[pro_LoadDSLoaiKhach]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LoadDSLoaiKhach] 
as
	Select ID, TenLoai
	from LOAI_KHACH
GO
/****** Object:  StoredProcedure [dbo].[pro_LoadDSLoaiPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LoadDSLoaiPhong] 
as
	Select ID, TenLoai
	from LOAI_PHONG
GO
/****** Object:  StoredProcedure [dbo].[pro_LoadDSPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LoadDSPhong] 
as
	Select PHONG.ID, TenPhong, TenLoai, GhiChu, TinhTrang
	from PHONG, LOAI_PHONG
	where PHONG.LoaiPhong = LOAI_PHONG.ID and TinhTrang != -1
	order by TenPhong ASC
GO
/****** Object:  StoredProcedure [dbo].[pro_LoadPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LoadPhong] @id int
as
	Select PHONG.ID, TenPhong, TenLoai, GhiChu, TinhTrang
	from PHONG, LOAI_PHONG
	where PHONG.LoaiPhong = LOAI_PHONG.ID and TinhTrang != -1 and PHONG.ID = @id
GO
/****** Object:  StoredProcedure [dbo].[pro_LoadThongTinChiTietPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_LoadThongTinChiTietPhong] @id int
as
	Select p.TinhTrang, p.GhiChu
	from PHONG p
	where p.ID = @id
GO
/****** Object:  StoredProcedure [dbo].[pro_setTinhTrangPhieuThue]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_setTinhTrangPhieuThue] @idPhieuThue int, @tinhTrang int
as
	update PHIEU_THUE
	set TinhTrang = @tinhTrang
	where ID = @idPhieuThue
GO
/****** Object:  StoredProcedure [dbo].[pro_setTinhTrangPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_setTinhTrangPhong] @idPhong int, @tinhTrang int
as
	update PHONG
	set TinhTrang = @tinhTrang
	where ID = @idPhong
GO
/****** Object:  StoredProcedure [dbo].[pro_SuaPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_SuaPhong] @id int, @tenPhong nvarchar(10), @loaiPhong int, @ghiChu nvarchar(500)
as 
	update PHONG
	set TenPhong = @tenPhong, LoaiPhong = @loaiPhong, GhiChu = @ghiChu
	where ID = @id
GO
/****** Object:  StoredProcedure [dbo].[pro_ThemPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_ThemPhong] @tenPhong nvarchar(10), @loaiPhong int, @ghiChu nvarchar(500)
as 
	INSERT INTO PHONG (TenPhong, LoaiPhong, GhiChu,TinhTrang)
	VALUES (@tenPhong, @loaiPhong, @ghiChu,0);
GO
/****** Object:  StoredProcedure [dbo].[pro_TKDoanhThuTungLoaiPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_TKDoanhThuTungLoaiPhong] @dateFrom datetime, @dateTo datetime
as 
	Select	lk.TenLoai, sum(ct.Tien) as DoanhThu
	from LOAI_PHONG lk Left join PHONG p on lk.ID = p.LoaiPhong left join PHIEU_THUE pt on p.ID = pt.ID_Phong left join CHI_TIET_HOA_DON ct on pt.ID = ct.ID_PhieuThue
	where pt.NgayKetThuc >= @dateFrom and pt.NgayKetThuc <= @dateTo
	group by lk.ID, lk.TenLoai
GO
/****** Object:  StoredProcedure [dbo].[pro_TKLuotThueTheoNgay]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_TKLuotThueTheoNgay] @start datetime, @end datetime
as
;with amonth(day) as
(
    select @start as day
        union all
    select day + 1
        from amonth
        where day < @end
)
select amonth.day, COUNT(pt.ID) as LuotThue
from amonth left join PHIEU_THUE pt on CONVERT(date, pt.NgayThue) = amonth.day
group by amonth.day
GO
/****** Object:  StoredProcedure [dbo].[pro_TKThoiGianThuePhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_TKThoiGianThuePhong] @dateFrom datetime, @dateTo datetime
as
declare @start int = '0'
;with amonth(hour) as
(
    select @start as hour
        union all
    select hour + 1
        from amonth
        where hour < 24
)
select amonth.hour, COUNT(pt.ID) as LuotThue
from amonth left join PHIEU_THUE pt on DATEPART(HOUR, pt.NgayThue) = amonth.hour and pt.NgayThue >= @dateFrom and pt.NgayThue <= @dateTo
group by amonth.hour
GO
/****** Object:  StoredProcedure [dbo].[pro_updateLoaiKhach]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_updateLoaiKhach] @idLoaiKhach int, @tenLoai nvarchar(50), @phuThu float
as
	update LOAI_KHACH
	set TenLoai = @tenLoai, PhuThu = @phuThu
	where ID = @idLoaiKhach
GO
/****** Object:  StoredProcedure [dbo].[pro_updateLoaiPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_updateLoaiPhong] @idLoaiPhong int, @tenLoai nvarchar(50), @SL_KhachBinhThuong int, @SL_KhachToiDa int, @donGia money, @phuThu float
as
	update LOAI_PHONG
	set TenLoai = @tenLoai, PhuThu = @phuThu, SL_KhachBinhThuong= @SL_KhachBinhThuong, SL_KhachToiDa = @SL_KhachToiDa, DonGia = @donGia
	where ID = @idLoaiPhong
GO
/****** Object:  StoredProcedure [dbo].[pro_updatePhieuThueKhiTraPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_updatePhieuThueKhiTraPhong] @idPhieuThue int, @ngayKetThuc datetime
as
	update PHIEU_THUE
	set TinhTrang = 1, NgayKetThuc = @ngayKetThuc
	where ID = @idPhieuThue
GO
/****** Object:  StoredProcedure [dbo].[pro_XoaPhong]    Script Date: 6/24/2019 11:39:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pro_XoaPhong] @id int
as
	update PHONG
	set TinhTrang = '-1'
	where ID = @id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0: Đang thuê, 1: Đã trả phòng, 2: Đã thanh toán' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PHIEU_THUE', @level2type=N'COLUMN',@level2name=N'TinhTrang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0: trống, 1: đã thuê, -1: bị xóa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PHONG', @level2type=N'COLUMN',@level2name=N'TinhTrang'
GO
USE [master]
GO
ALTER DATABASE [QuanLyKhachSan] SET  READ_WRITE 
GO
