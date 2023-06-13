namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogClientAsObejct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Logs", "Owner_Id", c => c.Int());
            CreateIndex("dbo.Logs", "Owner_Id");
            AddForeignKey("dbo.Logs", "Owner_Id", "dbo.Clients", "Id");
            DropColumn("dbo.Logs", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Logs", "Username", c => c.String());
            DropForeignKey("dbo.Logs", "Owner_Id", "dbo.Clients");
            DropIndex("dbo.Logs", new[] { "Owner_Id" });
            DropColumn("dbo.Logs", "Owner_Id");
        }
    }
}
