namespace DBRepository.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class posisionatedModels : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.Clients",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					Username = c.String(),
					Password = c.String(),
					DefaultFov = c.Int(nullable: false),
					DefaultLookFrom_X = c.Double(nullable: false),
					DefaultLookFrom_Y = c.Double(nullable: false),
					DefaultLookFrom_Z = c.Double(nullable: false),
					DefaultLookAt_X = c.Double(nullable: false),
					DefaultLookAt_Y = c.Double(nullable: false),
					DefaultLookAt_Z = c.Double(nullable: false),
				})
				.PrimaryKey(t => t.Id);

			CreateTable(
				"dbo.Figures",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					Owner = c.String(),
					Name = c.String(),
					Radius = c.Double(),
				})
				.PrimaryKey(t => t.Id);

			CreateTable(
				"dbo.Materials",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					Owner = c.String(),
					Name = c.String(),
					Color_Red = c.Int(nullable: false),
					Color_Green = c.Int(nullable: false),
					Color_Blue = c.Int(nullable: false),
					Type = c.Int(nullable: false),
					Blur = c.Double(),
					Discriminator = c.String(nullable: false, maxLength: 128),
				})
				.PrimaryKey(t => t.Id);

			CreateTable(
				"dbo.Models",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					Preview = c.Binary(),
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

			CreateTable(
				"dbo.PosisionatedModels",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					SceneId = c.Int(nullable: false),
					Position_X = c.Double(nullable: false),
					Position_Y = c.Double(nullable: false),
					Position_Z = c.Double(nullable: false),
					Model_Id = c.Int(),
				})
				.PrimaryKey(t => t.Id)
				.ForeignKey("dbo.Models", t => t.Model_Id)
				.ForeignKey("dbo.Scenes", t => t.SceneId, cascadeDelete: true)
				.Index(t => t.SceneId)
				.Index(t => t.Model_Id);

			CreateTable(
				"dbo.Scenes",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					Preview = c.Binary(),
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
			DropForeignKey("dbo.PosisionatedModels", "SceneId", "dbo.Scenes");
			DropForeignKey("dbo.PosisionatedModels", "Model_Id", "dbo.Models");
			DropForeignKey("dbo.Models", "Material_Id", "dbo.Materials");
			DropForeignKey("dbo.Models", "Figure_Id", "dbo.Figures");
			DropIndex("dbo.PosisionatedModels", new[] { "Model_Id" });
			DropIndex("dbo.PosisionatedModels", new[] { "SceneId" });
			DropIndex("dbo.Models", new[] { "Material_Id" });
			DropIndex("dbo.Models", new[] { "Figure_Id" });
			DropTable("dbo.Scenes");
			DropTable("dbo.PosisionatedModels");
			DropTable("dbo.Models");
			DropTable("dbo.Materials");
			DropTable("dbo.Figures");
			DropTable("dbo.Clients");
		}
	}
}
