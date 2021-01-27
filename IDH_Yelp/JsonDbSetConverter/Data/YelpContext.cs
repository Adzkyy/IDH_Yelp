using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDbSetConverter.Data
{
    public class YelpContext : DbContext
    {
        public YelpContext() : base("YelpContext")
        {
        }

        public DbSet<Attributes> Attributes { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<CheckIn> CheckIns { get; set; }
        public DbSet<Hours> Hours { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tip> Tips { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
