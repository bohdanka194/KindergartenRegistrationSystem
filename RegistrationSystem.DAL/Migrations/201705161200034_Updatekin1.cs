namespace RegistrationSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatekin1 : DbMigration
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
                .PrimaryKey(t => t.StaffPositionId);
            
            CreateTable(
                "dbo.Child",
                c => new
                    {
                        ChildId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        MiddleName = c.String(nullable: false, maxLength: 50),
                        SexOfChild = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        AddressId = c.Int(nullable: false),
                        Kindergarten_KindergartenId = c.Int(),
                    })
                .PrimaryKey(t => t.ChildId)
                .ForeignKey("dbo.Order", t => t.ChildId)
                .ForeignKey("dbo.Kindergarten", t => t.Kindergarten_KindergartenId)
                .ForeignKey("dbo.Address", t => t.AddressId, cascadeDelete: true)
                .Index(t => t.ChildId)
                .Index(t => t.AddressId)
                .Index(t => t.Kindergarten_KindergartenId);
            
            CreateTable(
                "dbo.BirthCertificate",
                c => new
                    {
                        BirthCertificateId = c.Int(nullable: false, identity: true),
                        Series = c.String(nullable: false, maxLength: 4),
                        Number = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 400),
                    })
                .PrimaryKey(t => t.BirthCertificateId)
                .ForeignKey("dbo.Child", t => t.BirthCertificateId)
                .Index(t => t.BirthCertificateId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ChildId = c.Int(nullable: false),
                        RegistrationTime = c.DateTime(nullable: false),
                        KindergartenId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => new { t.UserId, t.ChildId }, unique: true, name: "IX_UserIdAndChildId");
            
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
            DropForeignKey("dbo.Order", "UserId", "dbo.User");
            DropForeignKey("dbo.Child", "AddressId", "dbo.Address");
            DropForeignKey("dbo.Child", "Kindergarten_KindergartenId", "dbo.Kindergarten");
            DropForeignKey("dbo.Child", "ChildId", "dbo.Order");
            DropForeignKey("dbo.BirthCertificate", "BirthCertificateId", "dbo.Child");
            DropForeignKey("dbo.Staff", "StaffPositionId", "dbo.StaffPosition");
            DropForeignKey("dbo.Staff", "KindergartenId", "dbo.Kindergarten");
            DropForeignKey("dbo.Kindergarten", "AddressId", "dbo.Address");
            DropIndex("dbo.User", new[] { "Login" });
            DropIndex("dbo.Order", "IX_UserIdAndChildId");
            DropIndex("dbo.BirthCertificate", new[] { "BirthCertificateId" });
            DropIndex("dbo.Child", new[] { "Kindergarten_KindergartenId" });
            DropIndex("dbo.Child", new[] { "AddressId" });
            DropIndex("dbo.Child", new[] { "ChildId" });
            DropIndex("dbo.Staff", new[] { "KindergartenId" });
            DropIndex("dbo.Staff", new[] { "StaffPositionId" });
            DropIndex("dbo.Kindergarten", new[] { "AddressId" });
            DropTable("dbo.User");
            DropTable("dbo.Order");
            DropTable("dbo.BirthCertificate");
            DropTable("dbo.Child");
            DropTable("dbo.StaffPosition");
            DropTable("dbo.Staff");
            DropTable("dbo.Kindergarten");
            DropTable("dbo.Address");
        }
    }
}
