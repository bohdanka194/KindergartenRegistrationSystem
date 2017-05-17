namespace RegistrationSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAll1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Child", "BirthCertificateId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Child", "BirthCertificateId");
        }
    }
}
