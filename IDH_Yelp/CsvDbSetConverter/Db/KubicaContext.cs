using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvDbSetConverter.Data;

namespace CsvDbSetConverter.Db
{
    public class KubicaContext : DbContext
    {
        public KubicaContext() : base("KubicaContext")
        {
        }

        public DbSet<Circuits> Circuits { get; set; }
        public DbSet<ConstructorResults> ConstructorResults { get; set; }
        public DbSet<Constructors> Constructors { get; set; }
        public DbSet<ConstructorStandings> ConstructorStandings { get; set; }
        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<DriverStandings> DriverStandings { get; set; }
        public DbSet<LapTimes> LapTimes { get; set; }
        public DbSet<PitStops> PitStops { get; set; }
        public DbSet<Qualifying> Qualifyings { get; set; }
        public DbSet<Races> Races { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Seasons> Seasons { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
