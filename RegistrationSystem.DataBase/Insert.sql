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
           ([City],[Street],[House])
     VALUES
           ('Львов','городоцька',345),
		   ('Львов','патона',3),
		   ('Львов','Висока',2),
		   ('Львов','Мира',45),
		   ('Львов','жовтнева',37),
		   ('Львов','випасова',24)
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
           ([Number],[Description],[AddressId])
     VALUES
           (128,'Super 128 sadik',1),
		   (114,'Super 114 sadik',2),
		   (39,'Super 39 sadik',6)
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