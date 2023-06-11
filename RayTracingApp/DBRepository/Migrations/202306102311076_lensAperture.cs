namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lensAperture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scenes", "LensAperture", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scenes", "LensAperture");
        }
    }
}
