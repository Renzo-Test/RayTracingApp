namespace DBRepository.Migrations
{
	using System.Data.Entity.Migrations;
	using System.Diagnostics.CodeAnalysis;

	[ExcludeFromCodeCoverage]
	public partial class RemovedRenderProperties : DbMigration
	{
		public override void Up()
		{
			DropForeignKey("dbo.Clients", "DefaultRenderProperties_Id", "dbo.RenderProperties");
			DropIndex("dbo.Clients", new[] { "DefaultRenderProperties_Id" });
			AddColumn("dbo.Clients", "DefaultRenderProperties_ResolutionX", c => c.Int(nullable: false));
			AddColumn("dbo.Clients", "DefaultRenderProperties_ResolutionY", c => c.Int(nullable: false));
			AddColumn("dbo.Clients", "DefaultRenderProperties_AspectRatio", c => c.Double(nullable: false));
			AddColumn("dbo.Clients", "DefaultRenderProperties_SamplesPerPixel", c => c.Int(nullable: false));
			AddColumn("dbo.Clients", "DefaultRenderProperties_MaxDepth", c => c.Int(nullable: false));
		}

		public override void Down()
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
			DropColumn("dbo.Clients", "DefaultRenderProperties_MaxDepth");
			DropColumn("dbo.Clients", "DefaultRenderProperties_SamplesPerPixel");
			DropColumn("dbo.Clients", "DefaultRenderProperties_AspectRatio");
			DropColumn("dbo.Clients", "DefaultRenderProperties_ResolutionY");
			DropColumn("dbo.Clients", "DefaultRenderProperties_ResolutionX");
		}
	}
}
