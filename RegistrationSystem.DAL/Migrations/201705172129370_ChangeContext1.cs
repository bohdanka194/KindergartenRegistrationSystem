namespace RegistrationSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeContext1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Kindergarten", "Number", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Kindergarten", new[] { "Number" });
        }
    }
}
