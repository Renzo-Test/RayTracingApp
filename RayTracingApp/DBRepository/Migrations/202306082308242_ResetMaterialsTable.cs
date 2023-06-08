namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResetMaterialsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        RenderDate = c.String(),
                        TimeSpan = c.Time(nullable: false, precision: 7),
                        SceneName = c.String(),
                        RenderedElements = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Materials", "Blur", c => c.Double());
            AddColumn("dbo.Materials", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materials", "Discriminator");
            DropColumn("dbo.Materials", "Blur");
            DropTable("dbo.Logs");
        }
    }
}
