using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class ConstructorsClassMap : ClassMap<Constructors>
    {
        public ConstructorsClassMap()
        {
            Map(m => m.ConstructorId).Name("constructorId");
            Map(m => m.ConstructorRef).Name("constructorRef");
            Map(m => m.Name).Name("name");
            Map(m => m.Nationality).Name("nationality");
            Map(m => m.Url).Name("url");
        }
    }
}