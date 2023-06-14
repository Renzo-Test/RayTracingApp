namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
	using System.Diagnostics.CodeAnalysis;

	[ExcludeFromCodeCoverage]
	public partial class changeLogTimeSpanType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logs", "TimeSpan", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logs", "TimeSpan", c => c.Time(nullable: false, precision: 7));
        }
    }
}
