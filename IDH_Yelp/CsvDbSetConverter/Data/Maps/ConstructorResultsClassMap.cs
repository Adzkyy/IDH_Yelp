using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class ConstructorResultsClassMap : ClassMap<ConstructorResults>
    {
        public ConstructorResultsClassMap()
        {
            Map(m => m.ConstructorResultsId).Name("constructorResultsId");
            Map(m => m.RaceId).Name("raceId");
            Map(m => m.ConstructorId).Name("constructorId");
            Map(m => m.Points).Name("points");
            Map(m => m.Status).Name("status");
        }
    }
}