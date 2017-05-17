namespace RegistrationSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cuscade_Delete : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false, maxLength: 50),
                        Street = c.String(nullable: false, maxLength: 50),
                        House = c.Int(nullable: false),
                        Apartment = c.Int(),
                        District = c.Int(),
                        KindergartenId = c.Int(),
                        ChildId = c.Int(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Child",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        MiddleName = c.String(nullable: false, maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        AddressId = c.Int(nullable: false),
                        KindergartenId = c.Int(),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Kindergarten", t => t.KindergartenId)
                .ForeignKey("dbo.User", t => t.User_UserId)
                .Index(t => t.AddressId)
                .Index(t => t.KindergartenId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.BirthCertificate",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Series = c.String(nullable: false, maxLength: 4),
                        Number = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 400),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Child", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Kindergarten",
                c => new
                    {
                        KindergartenId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Description = c.String(),
                        AddressId = c.Int(),
                    })
                .PrimaryKey(t => t.KindergartenId)
                .ForeignKey("dbo.Address", t => t.AddressId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        StaffPositionId = c.Int(),
                        KindergartenId = c.Int(),
                    })
                .PrimaryKey(t => t.StaffId)
                .ForeignKey("dbo.Kindergarten", t => t.KindergartenId)
                .ForeignKey("dbo.StaffPosition", t => t.StaffPositionId)
                .Index(t => t.StaffPositionId)
                .Index(t => t.KindergartenId);
            
            CreateTable(
                "dbo.StaffPosition",
                c => new
                    {
                        StaffPositionId = c.Int(nullable: false, identity: true),
                        PositionName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.StaffPositionId)
                .Index(t => t.PositionName, unique: true);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Login = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.UserId)
                .Index(t => t.Login, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Child", "User_UserId", "dbo.User");
            DropForeignKey("dbo.Staff", "StaffPositionId", "dbo.StaffPosition");
            DropForeignKey("dbo.Staff", "KindergartenId", "dbo.Kindergarten");
            DropForeignKey("dbo.Child", "KindergartenId", "dbo.Kindergarten");
            DropForeignKey("dbo.Kindergarten", "AddressId", "dbo.Address");
            DropForeignKey("dbo.BirthCertificate", "Id", "dbo.Child");
            DropForeignKey("dbo.Child", "AddressId", "dbo.Address");
            DropIndex("dbo.User", new[] { "Login" });
            DropIndex("dbo.StaffPosition", new[] { "PositionName" });
            DropIndex("dbo.Staff", new[] { "KindergartenId" });
            DropIndex("dbo.Staff", new[] { "StaffPositionId" });
            DropIndex("dbo.Kindergarten", new[] { "AddressId" });
            DropIndex("dbo.BirthCertificate", new[] { "Id" });
            DropIndex("dbo.Child", new[] { "User_UserId" });
            DropIndex("dbo.Child", new[] { "KindergartenId" });
            DropIndex("dbo.Child", new[] { "AddressId" });
            DropTable("dbo.User");
            DropTable("dbo.StaffPosition");
            DropTable("dbo.Staff");
            DropTable("dbo.Kindergarten");
            DropTable("dbo.BirthCertificate");
            DropTable("dbo.Child");
            DropTable("dbo.Address");
        }
    }
}
