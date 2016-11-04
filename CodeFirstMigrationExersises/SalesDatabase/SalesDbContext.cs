using SalesDatabase.Migrations;
using SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext() : base("SalesDatabase")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SalesDbContext, Configuration>());
        }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StoreLocation> StoreLocations { get; set; }
    }
}
