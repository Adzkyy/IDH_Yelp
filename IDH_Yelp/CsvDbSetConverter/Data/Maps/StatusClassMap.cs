using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class StatusClassMap : ClassMap<Status>
    {
        public StatusClassMap()
        {
            Map(m => m.StatusId).Name("statusId");
            Map(m => m.Name).Name("status");
        }
    }
}