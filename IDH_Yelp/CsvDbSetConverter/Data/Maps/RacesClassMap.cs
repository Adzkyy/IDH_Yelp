using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class RacesClassMap : ClassMap<Races>
    {
        public RacesClassMap()
        {
            Map(m => m.RaceId).Name("raceId");
            Map(m => m.Year).Name("year");
            Map(m => m.Round).Name("round");
            Map(m => m.CircuitId).Name("circuitId");
            Map(m => m.Name).Name("name");
            Map(m => m.Date).Name("date");
            Map(m => m.Time).Name("time");
            Map(m => m.Url).Name("url");
        }
    }
}