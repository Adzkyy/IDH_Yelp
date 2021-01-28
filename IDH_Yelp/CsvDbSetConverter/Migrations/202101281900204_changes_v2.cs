namespace CsvDbSetConverter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes_v2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ConstructorStandings", "Filler1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ConstructorStandings", "Filler1", c => c.String());
        }
    }
}
