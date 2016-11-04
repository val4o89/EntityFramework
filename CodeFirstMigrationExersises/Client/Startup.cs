using SalesDatabase;
using System.Data.Entity;
using SalesDatabase.Migrations;
using HospitalDb;
using UsersDbContext;

namespace Client
{
    public class Startup
    {
        static void Main()
        {
            var context = new UserContext();
            context.Database.Initialize(true);

        }
    }
}
