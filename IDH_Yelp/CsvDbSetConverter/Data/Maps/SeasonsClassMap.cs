using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class SeasonsClassMap : ClassMap<Seasons>
    {
        public SeasonsClassMap()
        {
            Map(m => m.Year).Name("year");
            Map(m => m.Url).Name("url");
        }
    }
}