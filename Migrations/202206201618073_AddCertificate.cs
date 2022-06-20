namespace WebMobile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCertificate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Client_Id = c.Int(nullable: false),
                        Md5sum = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Certificates");
        }
    }
}
