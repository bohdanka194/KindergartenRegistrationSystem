use [RegistrationSystem];
GO

ALTER TABLE [dbo].[Child] DROP CONSTRAINT [FK_dbo.Child_dbo.Address_AddressId];
ALTER TABLE [dbo].[Child] DROP CONSTRAINT [FK_dbo.Child_dbo.Kindergarten_KindergartenId];
ALTER TABLE [dbo].[Child] DROP CONSTRAINT [FK_dbo.Child_dbo.User_User_UserId];
ALTER TABLE [dbo].[BirthCertificate] DROP CONSTRAINT [FK_dbo.BirthCertificate_dbo.Child_Id];
ALTER TABLE [dbo].[Kindergarten] DROP CONSTRAINT [FK_dbo.Kindergarten_dbo.Address_AddressId];
ALTER TABLE [dbo].[Staff] DROP CONSTRAINT [FK_dbo.Staff_dbo.Kindergarten_KindergartenId];
ALTER TABLE [dbo].[Staff] DROP CONSTRAINT [FK_dbo.Staff_dbo.StaffPosition_StaffPositionId];	

DROP TABLE [dbo].[Address]
GO
DROP TABLE [dbo].[BirthCertificate]
GO
DROP TABLE [dbo].[Child]
GO
DROP TABLE [dbo].[Kindergarten]
GO
DROP TABLE [dbo].[Staff]
GO
DROP TABLE [dbo].[StaffPosition]
GO
DROP TABLE [dbo].[User]
GO


