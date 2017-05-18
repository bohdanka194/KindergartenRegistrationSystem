namespace RegistrationSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reg_time : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Child", "RegistrationTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Child", "RegistrationTime");
        }
    }
}
