namespace CsvDbSetConverter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes_v4 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PitStops");
            AddColumn("dbo.PitStops", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.PitStops", "RaceId", c => c.String());
            AddPrimaryKey("dbo.PitStops", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PitStops");
            AlterColumn("dbo.PitStops", "RaceId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.PitStops", "Id");
            AddPrimaryKey("dbo.PitStops", "RaceId");
        }
    }
}
