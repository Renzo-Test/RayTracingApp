namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Materials");
            DropTable("dbo.Figures");
            DropTable("dbo.Clients");
        }
    }
}
