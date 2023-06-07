namespace DBRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class preview_model : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE dbo.Models ADD Preview_New VARBINARY(MAX)");
            Sql("UPDATE dbo.Models SET Preview_New = CONVERT(VARBINARY(MAX), Preview)");
            Sql("ALTER TABLE dbo.Models DROP COLUMN Preview");
            Sql("EXEC sp_rename 'dbo.Models.Preview_New', 'Preview', 'COLUMN'");
        }

        public override void Down()
        {
            Sql("ALTER TABLE dbo.Models ADD Preview_New NVARCHAR(MAX)");
            Sql("UPDATE dbo.Models SET Preview_New = CONVERT(NVARCHAR(MAX), Preview)");
            Sql("ALTER TABLE dbo.Models DROP COLUMN Preview");
            Sql("EXEC sp_rename 'dbo.Models.Preview_New', 'Preview', 'COLUMN'");
        }
    }
}
