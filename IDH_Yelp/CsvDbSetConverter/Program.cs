using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using CsvDbSetConverter.Data;
using CsvDbSetConverter.Data.Maps;
using CsvDbSetConverter.Db;
using CsvHelper;

namespace CsvDbSetConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            KubicaContext kubicaContext = new KubicaContext();

            //var records1 = RecordsReader<Circuits>.GetRecords("circuits", new CircuitsClassMap());
            //kubicaContext.Circuits.AddRange(records);

            //var records2 = RecordsReader<ConstructorResults>.GetRecords("constructorResults", new ConstructorResultsClassMap());
            //kubicaContext.ConstructorResults.AddRange(records2);
            //kubicaContext.SaveChanges();

            //var records3 = RecordsReader<Constructors>.GetRecords("constructors", new ConstructorsClassMap());
            //kubicaContext.Constructors.AddRange(records3);
            //kubicaContext.SaveChanges();

            //var records4 = RecordsReader<ConstructorStandings>.GetRecords("constructorStandings", new ConstructorStandingsClassMap());
            //kubicaContext.ConstructorStandings.AddRange(records4);
            //kubicaContext.SaveChanges();
            //Console.WriteLine("ConstructorStandings");

            //var records5 = RecordsReader<Drivers>.GetRecords("drivers", new DriversClassMap());
            //kubicaContext.Drivers.AddRange(records5);
            //kubicaContext.SaveChanges();
            //Console.WriteLine("Drivers");

            //var records6 = RecordsReader<DriverStandings>.GetRecords("driverStandings", new DriverStandingsClassMap());
            //kubicaContext.DriverStandings.AddRange(records6);
            //kubicaContext.SaveChanges();
            //Console.WriteLine("DriverStandings");

            //var records7 = RecordsReader<LapTimes>.GetRecords("lapTimes", new LapTimesClassMap());
            //kubicaContext.LapTimes.AddRange(records7);
            //kubicaContext.SaveChanges();
            //Console.WriteLine("LapTimes");

            //var records8 = RecordsReader<PitStops>.GetRecords("pitStops", new PitStopsClassMap());
            //kubicaContext.PitStops.AddRange(records8);
            //kubicaContext.SaveChanges();
            //Console.WriteLine("PitStops");

            //var records9 = RecordsReader<Qualifying>.GetRecords("qualifying", new QualifyingClassMap());
            //kubicaContext.Qualifyings.AddRange(records9);
            //kubicaContext.SaveChanges();
            //Console.WriteLine("Quali");

            //var records10 = RecordsReader<Races>.GetRecords("races", new RacesClassMap());
            //kubicaContext.Races.AddRange(records10);
            //kubicaContext.SaveChanges();
            //Console.WriteLine("Races");

            var records11 = RecordsReader<Result>.GetRecords("results", new ResultClassMap());
            kubicaContext.Results.AddRange(records11);
            kubicaContext.SaveChanges();
            Console.WriteLine("Results");

            var records12 = RecordsReader<Seasons>.GetRecords("seasons", new SeasonsClassMap());
            kubicaContext.Seasons.AddRange(records12);
            kubicaContext.SaveChanges();
            Console.WriteLine("Seasons");

            var records13 = RecordsReader<Status>.GetRecords("status", new StatusClassMap());
            kubicaContext.Status.AddRange(records13);
            kubicaContext.SaveChanges();
            Console.WriteLine("Status");

            kubicaContext.SaveChanges();
        }
    }
}
