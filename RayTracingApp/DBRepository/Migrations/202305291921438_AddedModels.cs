namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Preview = c.String(),
                        showPreview = c.Boolean(nullable: false),
                        Owner = c.String(),
                        Name = c.String(),
                        Figure_Id = c.Int(),
                        Material_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Figures", t => t.Figure_Id)
                .ForeignKey("dbo.Materials", t => t.Material_Id)
                .Index(t => t.Figure_Id)
                .Index(t => t.Material_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Models", "Material_Id", "dbo.Materials");
            DropForeignKey("dbo.Models", "Figure_Id", "dbo.Figures");
            DropIndex("dbo.Models", new[] { "Material_Id" });
            DropIndex("dbo.Models", new[] { "Figure_Id" });
            DropTable("dbo.Models");
        }
    }
}
