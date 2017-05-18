namespace RegistrationSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reg_time1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Child", "RegistrationTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Child", "RegistrationTime", c => c.DateTime(nullable: false));
        }
    }
}
