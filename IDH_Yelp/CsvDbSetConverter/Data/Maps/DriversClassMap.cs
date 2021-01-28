using CsvHelper.Configuration;

namespace CsvDbSetConverter.Data.Maps
{
    public class DriversClassMap : ClassMap<Drivers>
    {
        public DriversClassMap()
        {
            Map(m => m.DriverId).Name("driverId");
            Map(m => m.DriverRef).Name("driverRef");
            Map(m => m.Number).Name("number");
            Map(m => m.Code).Name("code");
            Map(m => m.Forename).Name("forename");
            Map(m => m.Surname).Name("surname");
            Map(m => m.Dob).Name("dob");
            Map(m => m.Nationality).Name("nationality");
            Map(m => m.Url).Name("url");
        }
    }
}