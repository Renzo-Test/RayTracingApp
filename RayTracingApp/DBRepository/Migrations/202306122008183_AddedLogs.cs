namespace DBRepository.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class AddedLogs : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.Logs",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					RenderTime = c.Int(nullable: false),
					Username = c.String(),
					RenderDate = c.String(),
					TimeSpan = c.Time(nullable: false, precision: 7),
					SceneName = c.String(),
					RenderedElements = c.Int(nullable: false),
				})
				.PrimaryKey(t => t.Id);

		}

		public override void Down()
		{
			DropTable("dbo.Logs");
		}
	}
}
