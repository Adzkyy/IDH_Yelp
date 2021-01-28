using JsonDbSetConverter.Data;
using JsonDbSetConverter.Helpers;
using Newtonsoft.Json;
using System;
using System.IO;

namespace JsonDbSetConverter.Deserialization
{
    public static class BusinessDeserializator
    {
        public static void DeserializeFromPath(string table, YelpContext context)
        {
            Console.WriteLine();
            Console.WriteLine("\nŁaduje do bazy Business");
            (var top, var left) = CursorHelper.GetCurPos();

            using (var streamReader = new StreamReader($@"C:\Users\neuab\Documents\IDH_Yelp\IDH_Yelp\DbSetJson\yelp_academic_dataset_{table}.json"))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                jsonReader.SupportMultipleContent = true;
                var serializer = new JsonSerializer();

                int counter = 0;
                int recordLoaded = 0;

                while (jsonReader.Read())
                {
                    var jsonObject = serializer.Deserialize<Business>(jsonReader);
                    context.Businesses.Add(jsonObject);

                    recordLoaded++;
                    counter++;

                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(recordLoaded);

                    if (counter == 5000)
                    {
                        context.SaveChanges();
                        counter = 0;
                    }
                }
                context.SaveChanges();

                Console.SetCursorPosition(left, top);
                Console.WriteLine("Załadowałem Business");
            }
        }
    }
}
