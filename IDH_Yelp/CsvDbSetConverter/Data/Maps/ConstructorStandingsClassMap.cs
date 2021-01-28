using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class ConstructorStandingsClassMap : ClassMap<ConstructorStandings>
    {
        public ConstructorStandingsClassMap()
        {
            Map(m => m.ConstructorStandingsId).Name("constructorStandingsId");
            Map(m => m.RaceId).Name("raceId");
            Map(m => m.ConstructorId).Name("constructorId");
            Map(m => m.Points).Name("points");
            Map(m => m.Position).Name("position");
            Map(m => m.PositionText).Name("positionText");
            Map(m => m.Wins).Name("wins");
        }
    }
}