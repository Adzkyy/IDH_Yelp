using System;
using JsonDbSetConverter.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JsonDbSetConverter.Deserialization;

namespace JsonDbSetConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new YelpContext();
            context.Configuration.AutoDetectChangesEnabled = false;

            try
            {
                BusinessDeserializator.DeserializeFromPath("business", context);
                UserDeserializator.DeserializeFromPath("user", context);
                ReviewDeserializator.DeserializeFromPath("review", context);
                CheckInDeserializator.DeserializeFromPath("checkin", context);
                TipDeserializator.DeserializeFromPath("tip", context);
            }
            catch (Exception e)
            {
                Console.WriteLine("Błąd:");
                Console.WriteLine(e);
                throw;
            }
            Console.WriteLine("Ładowanie zakończone sukcesem");
        }
    }
}
