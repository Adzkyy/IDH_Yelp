using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class LapTimesClassMap : ClassMap<LapTimes>
    {
        public LapTimesClassMap()
        {
            Map(m => m.RaceId).Name("raceId");
            Map(m => m.DriverId).Name("driverId");
            Map(m => m.Lap).Name("lap");
            Map(m => m.Position).Name("position");
            Map(m => m.Time).Name("time");
            Map(m => m.Milliseconds).Name("milliseconds");
        }
    }
}