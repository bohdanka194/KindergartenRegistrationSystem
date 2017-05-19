CREATE DATABASE [RegistrationSystem]
GO

/****** Object:  Table [dbo].[Address]    Script Date: 19.05.2017 17:15:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
USE [RegistrationSystem];

CREATE TABLE [dbo].[Address](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](50) NOT NULL,
	[House] [int] NOT NULL,
	[Apartment] [int] NULL,
	[District] [int] NULL,
	[KindergartenId] [int] NULL,
	[ChildId] [int] NULL,
 CONSTRAINT [PK_dbo.Address] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[BirthCertificate]    Script Date: 19.05.2017 17:15:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BirthCertificate](
	[Id] [int] NOT NULL,
	[Series] [nvarchar](20) NOT NULL,
	[Number] [int] NOT NULL,
	[Description] [nvarchar](400) NOT NULL,
 CONSTRAINT [PK_dbo.BirthCertificate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


/****** Object:  Table [dbo].[Child]    Script Date: 19.05.2017 17:16:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Child](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[RegistrationTime] [datetime] NOT NULL,
	[AddressId] [int] NOT NULL,
	[KindergartenId] [int] NOT NULL,
	[User_UserId] [int] NULL,
 CONSTRAINT [PK_dbo.Child] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Kindergarten]    Script Date: 19.05.2017 17:16:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Kindergarten](
	[KindergartenId] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[AddressId] [int] NULL,
 CONSTRAINT [PK_dbo.Kindergarten] PRIMARY KEY CLUSTERED 
(
	[KindergartenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Staff]    Script Date: 19.05.2017 17:17:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Staff](
	[StaffId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[StaffPositionId] [int] NULL,
	[KindergartenId] [int] NULL,
 CONSTRAINT [PK_dbo.Staff] PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[StaffPosition]    Script Date: 19.05.2017 17:17:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StaffPosition](
	[StaffPositionId] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dbo.StaffPosition] PRIMARY KEY CLUSTERED 
(
	[StaffPositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[User]    Script Date: 19.05.2017 17:18:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Login] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](80) NOT NULL,
 CONSTRAINT [PK_dbo.User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[BirthCertificate]  WITH CHECK ADD  CONSTRAINT [FK_dbo.BirthCertificate_dbo.Child_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[Child] ([Id])
GO

ALTER TABLE [dbo].[BirthCertificate] CHECK CONSTRAINT [FK_dbo.BirthCertificate_dbo.Child_Id]
GO

ALTER TABLE [dbo].[Child]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Child_dbo.Address_AddressId] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([AddressId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Child] CHECK CONSTRAINT [FK_dbo.Child_dbo.Address_AddressId]
GO

ALTER TABLE [dbo].[Child]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Child_dbo.Kindergarten_KindergartenId] FOREIGN KEY([KindergartenId])
REFERENCES [dbo].[Kindergarten] ([KindergartenId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Child] CHECK CONSTRAINT [FK_dbo.Child_dbo.Kindergarten_KindergartenId]
GO

ALTER TABLE [dbo].[Child]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Child_dbo.User_User_UserId] FOREIGN KEY([User_UserId])
REFERENCES [dbo].[User] ([UserId])
GO

ALTER TABLE [dbo].[Child] CHECK CONSTRAINT [FK_dbo.Child_dbo.User_User_UserId]
GO

ALTER TABLE [dbo].[Kindergarten]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Kindergarten_dbo.Address_AddressId] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([AddressId])
GO

ALTER TABLE [dbo].[Kindergarten] CHECK CONSTRAINT [FK_dbo.Kindergarten_dbo.Address_AddressId]
GO

ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Staff_dbo.Kindergarten_KindergartenId] FOREIGN KEY([KindergartenId])
REFERENCES [dbo].[Kindergarten] ([KindergartenId])
GO

ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_dbo.Staff_dbo.Kindergarten_KindergartenId]
GO

ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Staff_dbo.StaffPosition_StaffPositionId] FOREIGN KEY([StaffPositionId])
REFERENCES [dbo].[StaffPosition] ([StaffPositionId])
GO

ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_dbo.Staff_dbo.StaffPosition_StaffPositionId]
GO
