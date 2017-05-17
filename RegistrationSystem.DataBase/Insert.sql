USE [RegistrationSystem]
GO

SET IDENTITY_INSERT [dbo].[User] OFF
INSERT INTO [dbo].[User]
           ([FirstName],[LastName],[Login],[Password])
     VALUES
           ('Marina','Voron','mar25','csdgdsl4kj5tj43oterknfg'),
		   ('Dasha','Grigorieva','da34','csdgdsl4dsfsfkj5tj43oterknfg'),
		   ('Sergey','Pashin','sergey','csdgdsl4kj5tj32443oterknfg'),
		   ('Marina','Ziber','zib','csdgdsl4kj5tj43oterknfg'),
		   ('Tanja','Ostrova','tttt','csdgdsl4kj5tj43oterknfg'),
		   ('admin','admin','admin','2daceebc4e31654d326ae7889b397ed50ff7e5afff374d1f89525865fd87efe0')
SET IDENTITY_INSERT [dbo].[User] ON
GO

INSERT INTO [dbo].[Address]
           ([City],[Street],[House],[Apartment],[District])
     VALUES
           ('Львов','городоцька',345,23,3),
		   ('Львов','патона',3,12,3),
		   ('Львов','Висока',2,23,2),
		   ('Львов','Мира',45,18,1),
		   ('Львов','жовтнева',37,12,3),
		   ('Львов','випасова',24,24,1)
GO

USE [RegistrationSystem]
GO
INSERT INTO [dbo].[StaffPosition]
           ([PositionName])
     VALUES
           ('Директор1'),
		   ('Повар1'),
		   ('Вихователь1'),
		   ('Робітник1'),
		   ('Робітник2')
GO

INSERT INTO [dbo].[Kindergarten]
           ([AddressId],[Description],[Number])
     VALUES
           (1,'просто садик',1),
		   (3,'просто садик',4),
		   (4,'просто садик',6),
		   (2,'просто садик',8),
		   (5,'просто садик',23),
		   (6,'просто садик',32),
		   (7,'просто садик',145)
GO

INSERT INTO [dbo].[Staff]
           ([FirstName],[LastName],[StaffPositionId],[KindergartenId])
     VALUES
           ('Marina','Petrova',2,9),
		   ('Marina','Ivanova',4,9),
		   ('Sveta','Petrova',4,9),
		   ('Sveta','Bo',5,9),
		   ('Katya','Sviridova',4,9),
		   ('Karina','Orlova',2,8),
		   ('Tanya','Ivanova',4,8),
		   ('Oksana','Zaiceva',4,8),
		   ('Steta','Bukina',4,8),
		   ('Andrey','Portnikov',5,8),
		   ('Sergey','bora',5,8),
		   ('Anton','Mirniy',5,8)
GO