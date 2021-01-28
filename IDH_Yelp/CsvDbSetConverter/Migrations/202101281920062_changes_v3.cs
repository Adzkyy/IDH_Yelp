namespace CsvDbSetConverter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes_v3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.LapTimes");
            AddColumn("dbo.LapTimes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.LapTimes", "RaceId", c => c.String());
            AddPrimaryKey("dbo.LapTimes", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.LapTimes");
            AlterColumn("dbo.LapTimes", "RaceId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.LapTimes", "Id");
            AddPrimaryKey("dbo.LapTimes", "RaceId");
        }
    }
}
