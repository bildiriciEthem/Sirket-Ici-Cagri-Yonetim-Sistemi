USE [cagri]
GO
/****** Object:  Table [dbo].[admin_guncelleme]    Script Date: 12/07/2019 13:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin_guncelleme](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_sicil] [nchar](10) NULL,
	[mesaj] [nchar](1000) NULL,
	[tarih] [datetime] NULL,
	[siralama_tarih] [date] NULL,
	[cagri_id] [int] NULL,
	[guncelleyen_sicil] [int] NULL,
	[guncelleyen_bolum] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[admin_mesaj]    Script Date: 12/07/2019 13:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin_mesaj](
	[admin_guncelleme] [nchar](500) NULL,
	[cagri_id] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bilgi]    Script Date: 12/07/2019 13:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bilgi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[cagri_no] [nvarchar](max) NULL,
	[cagri_sahibi] [nchar](25) NULL,
	[cagri_aciliyet] [nchar](25) NULL,
	[cagri_tarih] [date] NULL,
	[cagri_durum] [nchar](25) NULL,
	[cagri_aciklama] [nchar](500) NULL,
	[cagri_güncelleme] [nchar](500) NULL,
	[cagri_güncelleme2] [nchar](700) NULL,
	[tarih] [date] NULL,
	[siralama_tarih] [date] NULL,
	[admin_aciklama] [nchar](500) NULL,
	[bolum_id] [int] NULL,
	[bolum_ad] [nchar](20) NULL,
	[ilgili_sicil] [int] NULL,
	[cagri_uzanti] [varchar](5) NULL,
	[cagri_icerik] [varbinary](max) NULL,
	[cagri_icerik2] [varbinary](max) NULL,
	[cagri_icerik3] [varbinary](max) NULL,
	[cagri_icerik4] [varbinary](max) NULL,
	[cagri_adi] [nchar](50) NULL,
	[cagri_adi2] [nchar](50) NULL,
	[cagri_adi3] [nchar](50) NULL,
	[cagri_adi4] [nchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bolum]    Script Date: 12/07/2019 13:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bolum](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[bolum_ad] [nchar](15) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kullanici_bilgi]    Script Date: 12/07/2019 13:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici_bilgi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_ad] [nchar](15) NULL,
	[kullanici_sifre] [nchar](15) NULL,
	[kullanici_sicil] [int] NULL,
	[ozel_id] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kullanici_güncelleme]    Script Date: 12/07/2019 13:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici_güncelleme](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_güncelleme] [nchar](700) NULL,
	[tarih] [date] NULL,
	[kullanici_sicil] [nchar](15) NULL,
	[siralama_tarih] [datetime] NULL,
	[cagri_id] [int] NULL,
	[bolum_id] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kullanici_Menu_Yetki]    Script Date: 12/07/2019 13:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici_Menu_Yetki](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici_Sicil] [int] NULL,
	[Menu] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kullanici_sekme]    Script Date: 12/07/2019 13:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici_sekme](
	[adi] [ntext] NULL,
	[sicil] [int] NULL,
	[bolum_id] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kullanici_Yetki]    Script Date: 12/07/2019 13:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici_Yetki](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici_Sicil] [int] NULL,
	[Yetki] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Menuler]    Script Date: 12/07/2019 13:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menuler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MenuID] [int] NULL,
	[Form] [nvarchar](50) NULL
) ON [PRIMARY]

GO
