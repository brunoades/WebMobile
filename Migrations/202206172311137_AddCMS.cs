namespace WebMobile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCMS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CMS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Slogan = c.String(),
                        SloganAppend = c.String(),
                        BigPicText = c.String(),
                        FirstFeature = c.String(),
                        SecondFeature = c.String(),
                        ThirdFeature = c.String(),
                        FirstTeamMemberText = c.String(),
                        FirstTeamMemberName = c.String(),
                        FirstTeamMemberRa = c.String(),
                        SecondTeamMemberText = c.String(),
                        SecondTeamMemberName = c.String(),
                        SecondTeamMemberRa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CMS");
        }
    }
}
