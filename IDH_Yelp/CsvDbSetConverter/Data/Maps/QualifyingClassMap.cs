using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class QualifyingClassMap : ClassMap<Qualifying>
    {
        public QualifyingClassMap()
        {
            Map(m => m.QualifyId).Name("qualifyId");
            Map(m => m.RaceId).Name("raceId");
            Map(m => m.DriverId).Name("driverId");
            Map(m => m.ConstructorId).Name("constructorId");
            Map(m => m.Number).Name("number");
            Map(m => m.Position).Name("position");
            Map(m => m.Q1).Name("q1");
            Map(m => m.Q2).Name("q2");
            Map(m => m.Q3).Name("q3");
        }
    }
}