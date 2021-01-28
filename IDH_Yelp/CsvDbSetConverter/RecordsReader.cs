using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

namespace CsvDbSetConverter
{
    public static class RecordsReader<T>
    {
        public static IReadOnlyCollection<T> GetRecords(string name, ClassMap<T> classMap)
        {
            using (var reader = new StreamReader($@"C:\Users\neuab\Documents\IDH_Yelp\IDH_Yelp\CsvDbSetConverter\CsvData\{name}.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap(classMap);
                var records = csv.GetRecords<T>();
                return records.ToList();
            }
        }
    }
}
