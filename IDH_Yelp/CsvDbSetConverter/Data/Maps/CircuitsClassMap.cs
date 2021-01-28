using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class CircuitsClassMap : ClassMap<Circuits>
    {
        public CircuitsClassMap()
        {
            Map(m => m.CircuitId).Name("circuitId");
            Map(m => m.CircuitRef).Name("circuitRef");
            Map(m => m.Name).Name("name");
            Map(m => m.Location).Name("location");
            Map(m => m.Country).Name("country");
            Map(m => m.Lat).Name("lat");
            Map(m => m.Lng).Name("lng");
            Map(m => m.Alt).Name("alt");
            Map(m => m.Url).Name("url");
        }
    }
}