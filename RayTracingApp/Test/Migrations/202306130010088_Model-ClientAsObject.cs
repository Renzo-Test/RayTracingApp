namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
	using System.Diagnostics.CodeAnalysis;

	[ExcludeFromCodeCoverage]
	public partial class ModelClientAsObject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Models", "Owner_Id", c => c.Int());
            CreateIndex("dbo.Models", "Owner_Id");
            AddForeignKey("dbo.Models", "Owner_Id", "dbo.Clients", "Id");
            DropColumn("dbo.Models", "Owner");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Models", "Owner", c => c.String());
            DropForeignKey("dbo.Models", "Owner_Id", "dbo.Clients");
            DropIndex("dbo.Models", new[] { "Owner_Id" });
            DropColumn("dbo.Models", "Owner_Id");
        }
    }
}
