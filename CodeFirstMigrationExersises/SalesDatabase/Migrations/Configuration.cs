namespace SalesDatabase.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<SalesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SalesDbContext context)
        {
            if (!context.StoreLocations.Any())
            {
                StoreLocation sl = new StoreLocation { LocationName = "Casablanca" };
                context.StoreLocations.Add(sl);
            }

            if (!context.Sales.Any())
            {

            }

            if (!context.Products.Any())
            {

            }

            if (!context.Customers.Any())
            {

            }
        }
    }
}
