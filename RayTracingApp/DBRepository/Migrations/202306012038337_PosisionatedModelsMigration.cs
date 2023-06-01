namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PosisionatedModelsMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PosisionatedModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position_X = c.Double(nullable: false),
                        Position_Y = c.Double(nullable: false),
                        Position_Z = c.Double(nullable: false),
                        Model_Id = c.Int(),
                        Scene_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Models", t => t.Model_Id)
                .ForeignKey("dbo.Scenes", t => t.Scene_Id)
                .Index(t => t.Model_Id)
                .Index(t => t.Scene_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PosisionatedModels", "Scene_Id", "dbo.Scenes");
            DropForeignKey("dbo.PosisionatedModels", "Model_Id", "dbo.Models");
            DropIndex("dbo.PosisionatedModels", new[] { "Scene_Id" });
            DropIndex("dbo.PosisionatedModels", new[] { "Model_Id" });
            DropTable("dbo.PosisionatedModels");
        }
    }
}
