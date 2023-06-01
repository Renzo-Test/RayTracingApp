namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncludedPreview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scenes", "Preview", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scenes", "Preview");
        }
    }
}
