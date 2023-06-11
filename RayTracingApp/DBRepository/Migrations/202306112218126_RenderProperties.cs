namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenderProperties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RenderProperties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResolutionX = c.Int(nullable: false),
                        ResolutionY = c.Int(nullable: false),
                        AspectRatio = c.Double(nullable: false),
                        SamplesPerPixel = c.Int(nullable: false),
                        MaxDepth = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clients", "DefaultRenderProperties_Id", c => c.Int());
            CreateIndex("dbo.Clients", "DefaultRenderProperties_Id");
            AddForeignKey("dbo.Clients", "DefaultRenderProperties_Id", "dbo.RenderProperties", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "DefaultRenderProperties_Id", "dbo.RenderProperties");
            DropIndex("dbo.Clients", new[] { "DefaultRenderProperties_Id" });
            DropColumn("dbo.Clients", "DefaultRenderProperties_Id");
            DropTable("dbo.RenderProperties");
        }
    }
}
