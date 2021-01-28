using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class ResultClassMap : ClassMap<Result>
    {
        public ResultClassMap()
        {
            Map(m => m.ResultId).Name("resultId");
            Map(m => m.RaceId).Name("raceId");
            Map(m => m.DriverId).Name("driverId");
            Map(m => m.ConstructorId).Name("constructorId");
            Map(m => m.Number).Name("number");
            Map(m => m.Grid).Name("grid");
            Map(m => m.Position).Name("position");
            Map(m => m.PositionText).Name("positionText");
            Map(m => m.PositionOrder).Name("positionOrder");
            Map(m => m.Points).Name("points");
            Map(m => m.Laps).Name("laps");
            Map(m => m.Time).Name("time");
            Map(m => m.Milliseconds).Name("milliseconds");
            Map(m => m.FastestLap).Name("fastestLap");
            Map(m => m.Rank).Name("rank");
            Map(m => m.FastestLapTime).Name("fastestLapTime");
            Map(m => m.FastestLapSpeed).Name("fastestLapSpeed");
            Map(m => m.StatusId).Name("statusId");
        }
    }
}