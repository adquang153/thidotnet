USE [LeCongTueQuang]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 23/12/2019 8:41:25 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HocSinhs]    Script Date: 23/12/2019 8:41:25 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinhs](
	[MaHS] [nvarchar](128) NOT NULL,
	[Ho] [nvarchar](max) NULL,
	[Ten] [nvarchar](max) NULL,
	[GioiTinh] [int] NOT NULL,
	[NoiSinh] [nvarchar](max) NULL,
	[QueQuan] [nvarchar](max) NULL,
	[MaLH] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.HocSinhs] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LopHocs]    Script Date: 23/12/2019 8:41:25 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHocs](
	[TenLH] [nvarchar](max) NULL,
	[PhongHoc] [nvarchar](max) NULL,
	[NamHoc] [nvarchar](max) NULL,
	[KhoiHoc] [nvarchar](max) NULL,
	[MaLH] [nvarchar](128) NOT NULL DEFAULT (''),
 CONSTRAINT [PK_dbo.LopHocs] PRIMARY KEY CLUSTERED 
(
	[MaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[HocSinhs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HocSinhs_dbo.LopHocs_MaLH] FOREIGN KEY([MaLH])
REFERENCES [dbo].[LopHocs] ([MaLH])
GO
ALTER TABLE [dbo].[HocSinhs] CHECK CONSTRAINT [FK_dbo.HocSinhs_dbo.LopHocs_MaLH]
GO
