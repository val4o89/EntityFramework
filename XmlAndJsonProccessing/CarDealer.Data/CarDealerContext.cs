namespace CarDealer.Data
{
    using Models.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarDealerContext : DbContext
    {
        public CarDealerContext()
            : base("CarDealerContext")
        {
        }

        public DbSet<Car> Cars { get; set; }

        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<PartSupplier> Supliers { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }

    }
}