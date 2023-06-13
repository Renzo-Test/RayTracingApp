namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SceneClientAsObject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scenes", "Owner_Id", c => c.Int());
            CreateIndex("dbo.Scenes", "Owner_Id");
            AddForeignKey("dbo.Scenes", "Owner_Id", "dbo.Clients", "Id");
            DropColumn("dbo.Scenes", "Owner");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Scenes", "Owner", c => c.String());
            DropForeignKey("dbo.Scenes", "Owner_Id", "dbo.Clients");
            DropIndex("dbo.Scenes", new[] { "Owner_Id" });
            DropColumn("dbo.Scenes", "Owner_Id");
        }
    }
}
