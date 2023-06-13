namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaterialClientAsObject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "Owner_Id", c => c.Int());
            CreateIndex("dbo.Materials", "Owner_Id");
            AddForeignKey("dbo.Materials", "Owner_Id", "dbo.Clients", "Id");
            DropColumn("dbo.Materials", "Owner");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Materials", "Owner", c => c.String());
            DropForeignKey("dbo.Materials", "Owner_Id", "dbo.Clients");
            DropIndex("dbo.Materials", new[] { "Owner_Id" });
            DropColumn("dbo.Materials", "Owner_Id");
        }
    }
}
