namespace VechicleDatabase.Context
{
    using Models;
    using Models.MotorVechicles;
    using Models.NonMotorVechicle;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class VechicleContect : DbContext
    {
        public VechicleContect()
            : base("VechicleContect")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<VechicleContect>());
        }

        public IDbSet<Vechicle> Vechicles { get; set; }

        public IDbSet<Carriage> Carriages { get; set; }

        public IDbSet<Locomotive> locomotives { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Locomotive>().HasOptional(x => x.Train).WithRequired(x => x.Locomotive);
            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<CargoShip>().ToTable("CargoShips");
            modelBuilder.Entity<CruiseShip>().ToTable("CruiseShips");
            modelBuilder.Entity<Passenger>().ToTable("PassengerCarraiges");
            modelBuilder.Entity<Restaurant>().ToTable("RestaurantCarraiges");
            modelBuilder.Entity<Sleeping>().ToTable("SleepingCarraiges");
            modelBuilder.Entity<Plane>().ToTable("Plains");
            modelBuilder.Entity<Bike>().ToTable("Bikes");
            modelBuilder.Entity<Train>().ToTable("Trains");


            base.OnModelCreating(modelBuilder);
        }
    }
}