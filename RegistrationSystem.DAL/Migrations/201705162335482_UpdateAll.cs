namespace RegistrationSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAll : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Child", "ChildId", "dbo.Order");
            DropForeignKey("dbo.Child", "Kindergarten_KindergartenId", "dbo.Kindergarten");
            DropIndex("dbo.Kindergarten", new[] { "Number" });
            DropIndex("dbo.Child", new[] { "ChildId" });
            DropIndex("dbo.Child", new[] { "Kindergarten_KindergartenId" });
            AddColumn("dbo.Child", "Kindergarten_KindergartenId1", c => c.Int());
            AlterColumn("dbo.Order", "RegistrationTime", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Child", "Kindergarten_KindergartenId1");
            CreateIndex("dbo.StaffPosition", "PositionName", unique: true);
            CreateIndex("dbo.Order", "OrderId");
            AddForeignKey("dbo.Order", "OrderId", "dbo.Child", "ChildId");
            AddForeignKey("dbo.Child", "Kindergarten_KindergartenId1", "dbo.Kindergarten", "KindergartenId");
            DropColumn("dbo.Child", "SexOfChild");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Child", "SexOfChild", c => c.Int(nullable: false));
            DropForeignKey("dbo.Child", "Kindergarten_KindergartenId1", "dbo.Kindergarten");
            DropForeignKey("dbo.Order", "OrderId", "dbo.Child");
            DropIndex("dbo.Order", new[] { "OrderId" });
            DropIndex("dbo.StaffPosition", new[] { "PositionName" });
            DropIndex("dbo.Child", new[] { "Kindergarten_KindergartenId1" });
            AlterColumn("dbo.Order", "RegistrationTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Child", "Kindergarten_KindergartenId1");
            CreateIndex("dbo.Child", "Kindergarten_KindergartenId");
            CreateIndex("dbo.Child", "ChildId");
            CreateIndex("dbo.Kindergarten", "Number", unique: true);
            AddForeignKey("dbo.Child", "Kindergarten_KindergartenId", "dbo.Kindergarten", "KindergartenId");
            AddForeignKey("dbo.Child", "ChildId", "dbo.Order", "OrderId");
        }
    }
}
