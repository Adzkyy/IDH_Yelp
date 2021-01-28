using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class DriverStandingsClassMap : ClassMap<DriverStandings>
    {
        public DriverStandingsClassMap()
        {
            Map(m => m.DriverStandingsId).Name("driverStandingsId");
            Map(m => m.RaceId).Name("raceId");
            Map(m => m.DriverId).Name("driverId");
            Map(m => m.Points).Name("points");
            Map(m => m.Position).Name("position");
            Map(m => m.PositionText).Name("positionText");
            Map(m => m.Wins).Name("wins");
        }
    }
}