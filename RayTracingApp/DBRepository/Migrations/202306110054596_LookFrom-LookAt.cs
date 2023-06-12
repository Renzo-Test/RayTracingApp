namespace DBRepository.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class LookFromLookAt : DbMigration
	{
		public override void Up()
		{
			AddColumn("dbo.Scenes", "LookFrom_X", c => c.Double(nullable: false));
			AddColumn("dbo.Scenes", "LookFrom_Y", c => c.Double(nullable: false));
			AddColumn("dbo.Scenes", "LookFrom_Z", c => c.Double(nullable: false));
			AddColumn("dbo.Scenes", "LookAt_X", c => c.Double(nullable: false));
			AddColumn("dbo.Scenes", "LookAt_Y", c => c.Double(nullable: false));
			AddColumn("dbo.Scenes", "LookAt_Z", c => c.Double(nullable: false));
		}

		public override void Down()
		{
			DropColumn("dbo.Scenes", "LookAt_Z");
			DropColumn("dbo.Scenes", "LookAt_Y");
			DropColumn("dbo.Scenes", "LookAt_X");
			DropColumn("dbo.Scenes", "LookFrom_Z");
			DropColumn("dbo.Scenes", "LookFrom_Y");
			DropColumn("dbo.Scenes", "LookFrom_X");
		}
	}
}
