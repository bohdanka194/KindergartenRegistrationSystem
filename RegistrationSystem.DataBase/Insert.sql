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
           ('Директор'),
		   ('Повар'),
		   ('Вихователь'),
		   ('Робітник'),
		   ('Робітник')
GO

INSERT INTO [dbo].[Kindergarten]
           ([Number],[Description],[AddressId])
     VALUES
           (127,'Заклад засновано
на підставі рішення Львівської міської ради №764 від 29.12.1968р. «Про затвердження
акту Державної прийомки дитячого садку-ясла на 280 місць
 у Люблінському жилому мікрорайоні».',1),
		   (166,'Львівський дошкільний навчальний заклад  ясла-садок №166 компенсуючого типу  Львівської міської Ради Львівської області, 
 створено на підставі рішення виконавчого  комітету Львівської
  міської ради №297 від  18.06.1970 р. "Про закріплення за Управлінням  капітального будівництва міськвиконкому  житлового кварталу по вул. Кульчицької,  Артема".',2),
		   (180,'ДОШКІЛЬНИЙ  НАВЧАЛЬНИЙ  ЗАКЛАД  №180 створено на підставі рішення виконавчого комітету Залізничної районної адміністрації Львівської міської ради від 30 вересня 
		   1988 року.Офіційне відкриття закладу було 1 листопада 1988 року.                                                                                                                                                                                                                         Засновником закладу є Львівська міська рада, уповноважений орган - управління освіти Львівської міської ради, яке делегує повноваження управління відділу освіти Залізничного району УО ДГП Львівської міської ради, згідно з рішенням виконавчого комітету щодо розмежування повноважень між виконавчими органами Львівської міської ради.',6),
		   (51,'Львівський дошкільний навчальний заклад ясла-садок № 51 Львівської міської ради Львівської області створено на підставі рішення виконкому Львівської міської ради 
		   від 1.11.1973 р. № 507
 Дошкільний навчальний заклад є юридичною особою, має печатку, штамп встановленого зразка, бланки з власними реквізитами, реєстраційний рахунок в органах Державного 
 казначейства, ідентифікаційний код.
 Засновником дошкільного навчального закладу є Львівська міська рада, уповноважений орган – управління  освіти Львівської міської ради.',4)
GO

INSERT INTO [dbo].[Staff]
           ([FirstName],[LastName],[StaffPositionId],[KindergartenId])
     VALUES
           ('Marina','Petrova',2,1),
		   ('Marina','Ivanova',4,1),
		   ('Sveta','Petrova',1,1),
		   ('Sveta','Bo',5,1),
		   ('Katya','Sviridova',4,1),
		   ('Karina','Orlova',2,1),
		   ('Tanya','Ivanova',3,1),
		   ('Oksana','Zaiceva',4,1),
		   ('Steta','Bukina',4,1),
		   ('Andrey','Portnikov',5,1),
		   ('Sergey','bora',5,1),
		   ('Anton','Mirniy',5,1),
           ('Галина','Шмірна',1,2),
		   ('Ірина','Вороніна',3,2),
		   ('Марина','Жовуіна',3,2),
		   ('Наталя','Чорна',3,2),
		   ('Катерина','Хміль',2,3),
		   ('Анрій','Соколов',4,3),
		   ('Ольга','Петрова',1,3),
		   ('Наталя','Іванова',2,4),
		   ('Тетяна','Коліі',3,4),
		   ('Максим','Свікула',5,4),
		   ('Петро','Кунжа',4,4),
		   ('Антон','Бурда',1,4)
GO

INSERT INTO [dbo].[Child]
           ([FirstName],[LastName],[MiddleName],[DateOfBirth],[RegistrationTime],[AddressId],[KindergartenId],[User_UserId])
     VALUES
           ('Marina','Sviridova','Denisivna','2015.03.02','2017.01.02',1,1,1),
		   ('Oksana','Paluh','Viktorivna','2014.03.02','2017.01.01',2,1,2),
		   ('Marina','KaBAEVA','Denisivna','2012.03.01','2017.02.02',3,2,3),
		   ('Irina','Olegivna','Denisivna','2014.03.03','2017.03.02',4,2,3)
GO

INSERT INTO [dbo].[BirthCertificate]
           ([Id],[Series],[Number],[Description])
     VALUES
           (1,'bb',4523453,'Zaliznihnim RV UMVS u Lvivskij oblasti'),
		   (2,'aa',5465464,'Zaliznihnim RV UMVS u Lvivskij oblasti'),
		   (3,'cc',234234,'Zaliznihnim RV UMVS u Lvivskij oblasti'),
		   (4,'dd',234324,'Zaliznihnim RV UMVS u Lvivskij oblasti')
GO
