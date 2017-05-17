use [RegistrationSystem];
GO


ALTER TABLE [dbo].[Child] DROP CONSTRAINT [FK_dbo.Child_dbo.Address_AddressId];
ALTER TABLE [dbo].[Child] DROP CONSTRAINT [FK_dbo.Child_dbo.Kindergarten_KindergartenId];
ALTER TABLE [dbo].[Child] DROP CONSTRAINT [FK_dbo.Child_dbo.User_User_UserId];
ALTER TABLE [dbo].[BirthCertificate] DROP CONSTRAINT [FK_dbo.BirthCertificate_dbo.Child_Id];
ALTER TABLE [dbo].[Kindergarten] DROP CONSTRAINT [FK_dbo.Kindergarten_dbo.Address_AddressId];
ALTER TABLE [dbo].[Staff] DROP CONSTRAINT [FK_dbo.Staff_dbo.Kindergarten_KindergartenId];
ALTER TABLE [dbo].[Staff] DROP CONSTRAINT [FK_dbo.Staff_dbo.StaffPosition_StaffPositionId];		
