namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FigureClientAsObject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Figures", "Owner_Id", c => c.Int());
            CreateIndex("dbo.Figures", "Owner_Id");
            AddForeignKey("dbo.Figures", "Owner_Id", "dbo.Clients", "Id");
            DropColumn("dbo.Figures", "Owner");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Figures", "Owner", c => c.String());
            DropForeignKey("dbo.Figures", "Owner_Id", "dbo.Clients");
            DropIndex("dbo.Figures", new[] { "Owner_Id" });
            DropColumn("dbo.Figures", "Owner_Id");
        }
    }
}
