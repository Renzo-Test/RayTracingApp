﻿namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaterialInheritance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "Blur", c => c.Int());
            AddColumn("dbo.Materials", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materials", "Discriminator");
            DropColumn("dbo.Materials", "Blur");
        }
    }
}
