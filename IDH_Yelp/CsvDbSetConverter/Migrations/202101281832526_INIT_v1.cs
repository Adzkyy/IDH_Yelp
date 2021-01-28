namespace CsvDbSetConverter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INIT_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Circuits",
                c => new
                    {
                        CircuitId = c.String(nullable: false, maxLength: 128),
                        CircuitRef = c.String(),
                        Name = c.String(),
                        Location = c.String(),
                        Country = c.String(),
                        Lat = c.String(),
                        Lng = c.String(),
                        Alt = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.CircuitId);
            
            CreateTable(
                "dbo.ConstructorResults",
                c => new
                    {
                        ConstructorResultsId = c.String(nullable: false, maxLength: 128),
                        RaceId = c.String(),
                        ConstructorId = c.String(),
                        Points = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ConstructorResultsId);
            
            CreateTable(
                "dbo.Constructors",
                c => new
                    {
                        ConstructorId = c.String(nullable: false, maxLength: 128),
                        ConstructorRef = c.String(),
                        Name = c.String(),
                        Nationality = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.ConstructorId);
            
            CreateTable(
                "dbo.ConstructorStandings",
                c => new
                    {
                        ConstructorStandingsId = c.String(nullable: false, maxLength: 128),
                        RaceId = c.String(),
                        ConstructorId = c.String(),
                        Points = c.String(),
                        Position = c.String(),
                        PositionText = c.String(),
                        Wins = c.String(),
                        Filler1 = c.String(),
                    })
                .PrimaryKey(t => t.ConstructorStandingsId);
            
            CreateTable(
                "dbo.PitStops",
                c => new
                    {
                        RaceId = c.String(nullable: false, maxLength: 128),
                        DriverId = c.String(),
                        Stop = c.String(),
                        Lap = c.String(),
                        Time = c.String(),
                        Duration = c.String(),
                        Milliseconds = c.String(),
                    })
                .PrimaryKey(t => t.RaceId);
            
            CreateTable(
                "dbo.Qualifying",
                c => new
                    {
                        QualifyId = c.String(nullable: false, maxLength: 128),
                        RaceId = c.String(),
                        DriverId = c.String(),
                        ConstructorId = c.String(),
                        Number = c.String(),
                        Position = c.String(),
                        Q1 = c.String(),
                        Q2 = c.String(),
                        Q3 = c.String(),
                    })
                .PrimaryKey(t => t.QualifyId);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        RaceId = c.String(nullable: false, maxLength: 128),
                        Year = c.String(),
                        Round = c.String(),
                        CircuitId = c.String(),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        Time = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.RaceId);
            
            CreateTable(
                "dbo.Result",
                c => new
                    {
                        ResultId = c.String(nullable: false, maxLength: 128),
                        RaceId = c.String(),
                        DriverId = c.String(),
                        ConstructorId = c.String(),
                        Number = c.String(),
                        Grid = c.String(),
                        Position = c.String(),
                        PositionText = c.String(),
                        PositionOrder = c.String(),
                        Points = c.String(),
                        Laps = c.String(),
                        Time = c.String(),
                        Milliseconds = c.String(),
                        FastestLap = c.String(),
                        Rank = c.String(),
                        FastestLapTime = c.String(),
                        FastestLapSpeed = c.String(),
                        StatusId = c.String(),
                    })
                .PrimaryKey(t => t.ResultId);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverId = c.String(nullable: false, maxLength: 128),
                        DriverRef = c.String(),
                        Number = c.String(),
                        Code = c.String(),
                        Forename = c.String(),
                        Surname = c.String(),
                        Dob = c.String(),
                        Nationality = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.DriverId);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        Year = c.String(nullable: false, maxLength: 128),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Year);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.DriverStandings",
                c => new
                    {
                        DriverStandingsId = c.String(nullable: false, maxLength: 128),
                        RaceId = c.String(),
                        DriverId = c.String(),
                        Points = c.String(),
                        Position = c.String(),
                        PositionText = c.String(),
                        Wins = c.String(),
                    })
                .PrimaryKey(t => t.DriverStandingsId);
            
            CreateTable(
                "dbo.LapTimes",
                c => new
                    {
                        RaceId = c.String(nullable: false, maxLength: 128),
                        DriverId = c.String(),
                        Lap = c.String(),
                        Position = c.String(),
                        Time = c.String(),
                        Milliseconds = c.String(),
                    })
                .PrimaryKey(t => t.RaceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LapTimes");
            DropTable("dbo.DriverStandings");
            DropTable("dbo.Status");
            DropTable("dbo.Seasons");
            DropTable("dbo.Drivers");
            DropTable("dbo.Result");
            DropTable("dbo.Races");
            DropTable("dbo.Qualifying");
            DropTable("dbo.PitStops");
            DropTable("dbo.ConstructorStandings");
            DropTable("dbo.Constructors");
            DropTable("dbo.ConstructorResults");
            DropTable("dbo.Circuits");
        }
    }
}
