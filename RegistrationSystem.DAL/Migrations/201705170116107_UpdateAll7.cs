namespace RegistrationSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAll7 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.BirthCertificate", new[] { "BirthCertificateId" });
            DropPrimaryKey("dbo.BirthCertificate");
            AlterColumn("dbo.BirthCertificate", "BirthCertificateId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.BirthCertificate", "BirthCertificateId");
            CreateIndex("dbo.BirthCertificate", "BirthCertificateId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.BirthCertificate", new[] { "BirthCertificateId" });
            DropPrimaryKey("dbo.BirthCertificate");
            AlterColumn("dbo.BirthCertificate", "BirthCertificateId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.BirthCertificate", "BirthCertificateId");
            CreateIndex("dbo.BirthCertificate", "BirthCertificateId");
        }
    }
}
