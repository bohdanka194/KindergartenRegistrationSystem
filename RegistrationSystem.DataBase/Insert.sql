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
		   (39,'Super 39 sadik',6),
		   (77,'Super 77 sadik',16)
GO

INSERT INTO [dbo].[Staff]
           ([FirstName],[LastName],[StaffPositionId],[KindergartenId])
     VALUES
           ('Marina','Petrova',2,7),
		   ('Marina','Ivanova',4,7),
		   ('Sveta','Petrova',1,7),
		   ('Sveta','Bo',5,7),
		   ('Katya','Sviridova',4,7),
		   ('Karina','Orlova',2,7),
		   ('Tanya','Ivanova',3,7),
		   ('Oksana','Zaiceva',4,7),
		   ('Steta','Bukina',4,7),
		   ('Andrey','Portnikov',5,7),
		   ('Sergey','bora',5,7),
		   ('Anton','Mirniy',5,7),
           ('Галина','Шмірна',1,1),
		   ('Ірина','Вороніна',3,1),
		   ('Марина','Жовуіна',3,1),
		   ('Наталя','Чорна',3,1),
		   ('Катерина','Хміль',2,1),
		   ('Анрій','Соколов',4,1),
		   ('Ольга','Петрова',1,2),
		   ('Наталя','Іванова',2,2),
		   ('Тетяна','Коліі',3,2),
		   ('Максим','Свікула',5,2),
		   ('Петро','Кунжа',4,2),
		   ('Антон','Бурда',1,3)
GO
