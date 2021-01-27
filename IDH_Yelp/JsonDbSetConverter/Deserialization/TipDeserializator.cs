﻿using JsonDbSetConverter.Data;
using Newtonsoft.Json;
using System;
using System.IO;

namespace JsonDbSetConverter.Deserialization
{
    public class TipDeserializator
    {
        public static void DeserializeFromPath(string table, YelpContext context)
        {
            Console.WriteLine("Ładuje do bazy: Tips");
            using (var streamReader = new StreamReader($@"C:\Users\neuab\Documents\IDH_Yelp\IDH_Yelp\DbSetJson\yelp_academic_dataset_{table}.json"))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                jsonReader.SupportMultipleContent = true;
                var serializer = new JsonSerializer();

                int counter = 0;
                int recordLoaded = 0;

                while (jsonReader.Read() && recordLoaded < 50000)
                {
                    var jsonObject = serializer.Deserialize<Tip>(jsonReader);
                    context.Tips.Add(jsonObject);

                    recordLoaded++;
                    counter++;

                    Console.SetCursorPosition(1, 1);
                    Console.WriteLine(recordLoaded);

                    if (counter == 5000)
                    {
                        context.SaveChanges();
                        counter = 0;
                    }
                }
                Console.WriteLine("Załadowałem Tipy");
            }
        }
    }
}
