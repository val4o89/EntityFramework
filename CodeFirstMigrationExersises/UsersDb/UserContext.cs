using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersDb.Migrations;
using UsersDb.Models;
using UsersDbContext.Models;

namespace UsersDbContext
{
    public class UserContext : DbContext
    {
        public UserContext() 
            : base("UsersDatabase")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<UserContext, Configuration>());
        }

        public DbSet<Town> Towns { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
