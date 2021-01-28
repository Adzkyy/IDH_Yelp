using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class PitStopsClassMap : ClassMap<PitStops>
    {
        public PitStopsClassMap()
        {
            Map(m => m.RaceId).Name("raceId");
            Map(m => m.DriverId).Name("driverId");
            Map(m => m.Stop).Name("stop");
            Map(m => m.Lap).Name("lap");
            Map(m => m.Time).Name("time");
            Map(m => m.Duration).Name("duration");
            Map(m => m.Milliseconds).Name("milliseconds");
        }
    }
}