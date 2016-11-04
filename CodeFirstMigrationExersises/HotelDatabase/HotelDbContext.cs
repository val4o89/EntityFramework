using HotelDatabase.Migrations;
using HotelDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabase
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext() : base("Hotel")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HotelDbContext, Configuration>());
        }
        public IDbSet<BedType> BedTypes { get; set; }
        public IDbSet<Customer> Custometrs { get; set; }
        public IDbSet<Employee> Employees { get; set; }
        public IDbSet<Occupancy> Occupancies { get; set; }
        public IDbSet<Payment> Payments { get; set; }
        public IDbSet<Room> Rooms { get; set; }
        public IDbSet<RoomStatus> RoomStatus { get; set; }
        public IDbSet<RoomType> RoomTypes { get; set; }

    }
}
