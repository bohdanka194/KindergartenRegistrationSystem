namespace RegistrationSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeChhild : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Child", "KindergartenId", "dbo.Kindergarten");
            DropIndex("dbo.Child", new[] { "KindergartenId" });
            AlterColumn("dbo.Child", "KindergartenId", c => c.Int(nullable: false));
            CreateIndex("dbo.Child", "KindergartenId");
            AddForeignKey("dbo.Child", "KindergartenId", "dbo.Kindergarten", "KindergartenId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Child", "KindergartenId", "dbo.Kindergarten");
            DropIndex("dbo.Child", new[] { "KindergartenId" });
            AlterColumn("dbo.Child", "KindergartenId", c => c.Int());
            CreateIndex("dbo.Child", "KindergartenId");
            AddForeignKey("dbo.Child", "KindergartenId", "dbo.Kindergarten", "KindergartenId");
        }
    }
}
