USE [master]
GO
/****** Object:  Database [QuanLyBanBanh]    Script Date: 29/12/2021 11:09:44 ******/
CREATE DATABASE [QuanLyBanBanh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanBanh', FILENAME = N'E:\LTCSDL\MYDATA\QuanLyBanBanh.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyBanBanh_log', FILENAME = N'E:\LTCSDL\MYDATA\QuanLyBanBanh_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyBanBanh] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanBanh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanBanh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanBanh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanBanh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanBanh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanBanh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyBanBanh] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanBanh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanBanh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanBanh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanBanh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyBanBanh] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyBanBanh]
GO
/****** Object:  Table [dbo].[T1_Bảng Loại Bánh]    Script Date: 29/12/2021 11:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T1_Bảng Loại Bánh](
	[Mã LB] [nvarchar](50) NOT NULL,
	[Tên] [nvarchar](50) NULL,
 CONSTRAINT [PK_T1_Bảng Loại Bánh] PRIMARY KEY CLUSTERED 
(
	[Mã LB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T2_Bảng Bánh]    Script Date: 29/12/2021 11:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T2_Bảng Bánh](
	[Mã Bánh] [nvarchar](50) NOT NULL,
	[Tên bánh] [nvarchar](50) NULL,
	[Mã LB] [nvarchar](50) NOT NULL,
	[Giá] [varchar](50) NULL,
 CONSTRAINT [PK_T2_Bảng Bánh] PRIMARY KEY CLUSTERED 
(
	[Mã Bánh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T3_Bảng KH]    Script Date: 29/12/2021 11:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T3_Bảng KH](
	[Mã KH] [nvarchar](50) NOT NULL,
	[Họ tên] [nvarchar](50) NULL,
	[Ngày sinh] [datetime] NULL,
	[Số ĐT] [nchar](10) NULL,
	[Địa chỉ] [nvarchar](50) NULL,
 CONSTRAINT [PK_T3_Bảng KH] PRIMARY KEY CLUSTERED 
(
	[Mã KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T4_Bảng NV]    Script Date: 29/12/2021 11:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T4_Bảng NV](
	[Mã NV] [nvarchar](50) NOT NULL,
	[Họ tên] [nvarchar](50) NULL,
	[Ngày sinh] [datetime] NULL,
	[Số DT] [nchar](10) NULL,
	[Địa chỉ] [nvarchar](50) NULL,
	[Giới Tính] [nvarchar](50) NULL,
	[Chức vụ] [nvarchar](50) NULL,
 CONSTRAINT [PK_T4_Bảng NV] PRIMARY KEY CLUSTERED 
(
	[Mã NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T5_hóa đơn]    Script Date: 29/12/2021 11:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T5_hóa đơn](
	[Mã HĐ] [nvarchar](50) NOT NULL,
	[Mã NV] [nvarchar](50) NOT NULL,
	[Mã KH] [nvarchar](50) NOT NULL,
	[Ngày đặt] [datetime] NULL,
	[Tổng tiền] [nchar](10) NULL,
	[Bánh mua] [nvarchar](50) NULL,
	[Mã Bánh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_T5_hóa đơn] PRIMARY KEY CLUSTERED 
(
	[Mã HĐ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_T2_Bảng Bánh]    Script Date: 29/12/2021 11:09:45 ******/
CREATE NONCLUSTERED INDEX [IX_T2_Bảng Bánh] ON [dbo].[T2_Bảng Bánh]
(
	[Mã Bánh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[T2_Bảng Bánh]  WITH CHECK ADD  CONSTRAINT [FK_T2_Bảng Bánh_T1_Bảng Loại Bánh] FOREIGN KEY([Mã LB])
REFERENCES [dbo].[T1_Bảng Loại Bánh] ([Mã LB])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[T2_Bảng Bánh] CHECK CONSTRAINT [FK_T2_Bảng Bánh_T1_Bảng Loại Bánh]
GO
ALTER TABLE [dbo].[T5_hóa đơn]  WITH CHECK ADD  CONSTRAINT [FK_T5_hóa đơn_T2_Bảng Bánh] FOREIGN KEY([Mã Bánh])
REFERENCES [dbo].[T2_Bảng Bánh] ([Mã Bánh])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[T5_hóa đơn] CHECK CONSTRAINT [FK_T5_hóa đơn_T2_Bảng Bánh]
GO
ALTER TABLE [dbo].[T5_hóa đơn]  WITH CHECK ADD  CONSTRAINT [FK_T5_hóa đơn_T3_Bảng KH] FOREIGN KEY([Mã KH])
REFERENCES [dbo].[T3_Bảng KH] ([Mã KH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[T5_hóa đơn] CHECK CONSTRAINT [FK_T5_hóa đơn_T3_Bảng KH]
GO
ALTER TABLE [dbo].[T5_hóa đơn]  WITH CHECK ADD  CONSTRAINT [FK_T5_hóa đơn_T4_Bảng NV] FOREIGN KEY([Mã NV])
REFERENCES [dbo].[T4_Bảng NV] ([Mã NV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[T5_hóa đơn] CHECK CONSTRAINT [FK_T5_hóa đơn_T4_Bảng NV]
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanBanh] SET  READ_WRITE 
GO
USE QuanLyBanBanh
GO
INSERT INTO [T1_Bảng Loại Bánh] ([Mã LB], Tên) VALUES
(
	'LB01', N'Bánh mặn'
),
(
	'LB02', N'Bánh ngọt'
),
(
	'LB03', N'Bánh cookie'
)

USE QuanLyBanBanh
GO
INSERT INTO [T2_Bảng Bánh] ([Mã Bánh], [Tên bánh], [Mã LB], Giá) VALUES
(
	'B001', N'Chà Bông phô mai', 'LB01', '25.000'
),
(
	'B002', N'Hambuger', 'LB01', '45.000'
),
(
	'B003', N'Bông lan trứng muối', 'LB01', '30.000'
),
(
	'B004', N'Phô mai trứng muối', 'LB01', '50.000'
),
(
	'B005', N'Tart tôm rau củ', 'LB01', '50.000'
),
(
	'B006', N'Su kem', 'LB02', '10.000'
),
(
	'B007', N'Su trứng muối', 'LB02', '10.000'
),
(
	'B008', N'Su matcha', 'LB02', '15.000'
),
(
	'B009', N'Tart dừa', 'LB02', '20.000'
),
(
	'B010', N'Tart dâu', 'LB02', '20.000'
),
(
	'B011', N'Dừa hạnh nhân', 'LB03', '15.000'
),
(
	'B012', N'Bơ chanh', 'LB03', '15.000'
),
(
	'B013', N'Hạnh nhân xay', 'LB03', '20.000'
),
(
	'B014', N'Chocochips', 'LB03', '25.000'
),
(
	'B015', N'Biscosti', 'LB03', '30.000'
)
USE QuanLyBanBanh
GO
INSERT INTO [T3_Bảng KH] ([Mã KH], [Họ tên], [Ngày sinh], [Số ĐT], [Địa chỉ] ) VALUES
(
	'KH01', N'Nguyễn Hoàng Huy',  '1985-01-01' , 1111111, 'HCM'
),
(
	'KH02', N'Trần Kiều Mỹ', '1999-01-01', 222222, 'HCM'
),
(
	'KH03', N'Lý Thành Loan', '2000-01-01', 999999, 'HCM'
),
(
	'KH04', N'Nguyễn Thanh Hải', '2001-01-01', 888888, 'HCM' 
),
(
	'KH05', N'Trần Hoài Phúc', '2005-01-01', 4444433, 'HCM'
)
USE QuanLyBanBanh
GO
INSERT INTO [T4_Bảng NV] ([Mã NV], [Họ tên], [Ngày sinh], [Số DT], [Địa chỉ], [Giới Tính], [Chức vụ] ) VALUES
(
	'NV01', N'Nguyễn Minh Lam',  '1999-01-01' , 333333, 'HCM', N'Nữ', N'Nhân viên bán hàng'
),
(
	'NV02', N'Cao Hoàng Ly', '2002-01-01', 444444, 'HCM', N'Nữ', N'Nhân viên bán hàng'
),
(
	'NV03', N'Nguyễn Thị Thanh', '2000-01-01', 555555, 'HCM', N'Nữ', N'Nhân viên bán hàng'
),
(
	'NV04', N'Trần Phát Đạt', '1997-01-01', 666666, 'HCM' , N'Nam', N'Nhân viên bán hàng'
),
(
	'NV05', N'Ngô Hoài An', '1999-01-01', 777777, 'HCM', N'Nam', N'Nhân viên bán hàng'
)

USE QuanLyBanBanh
GO
INSERT INTO [T5_hóa đơn] ([Mã HĐ], [Mã NV], [Mã KH], [Ngày đặt], [Tổng tiền], [Bánh mua], [Mã Bánh]) VALUES
(
	'HD01', 'NV02', 'KH01', '2021-12-24', 50.000, N'2 bánh chà bông phô mai', 'B001'
),
(
	'HD02', 'NV05', 'KH02', '2021-12-24', 100.000, N'5 bánh su kem + 5 bánh su trứng muối', 'B006'
),
(
	'HD03', 'NV01', 'KH03', '2021-12-25', 225.000, N'5 bánh chocochips + 5 bánh tart dâu', 'B014'
),
(
	'HD04', 'NV03', 'KH04', '2021-12-26', 175.000, N'2 bánh tart tôm rau củ + 3 bánh bơ chanh + 2 bánh su matcha', 'B005'
),
(
	'HD05', 'NV04', 'KH05', '2021-12-26', 180.000, N'2 phô mai trứng muối + 4 hạnh nhân xay', 'B004'
)
