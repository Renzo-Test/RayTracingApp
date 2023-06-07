namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddScene : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Scenes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Owner = c.String(),
                        Name = c.String(),
                        RegisterTime = c.String(),
                        LastModificationDate = c.String(),
                        LastRenderDate = c.String(),
                        Fov = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Scenes");
        }
    }
}
