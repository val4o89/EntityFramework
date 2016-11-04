namespace UsersDb.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using UsersDbContext;
    using UsersDbContext.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(UserContext context)
        {
            var town = new Town { Name = "Godech" };

            var country = new Country { Name = "Bulgaria" };

            country.Towns.Add(town);

            var user = new User
            {
                Username = "Gencho",
                Password = "1wlL!f",
                Email = "genata@abv.bg",
                ProfilePicture = File.ReadAllBytes(@"C:\Users\VALENTIN\Desktop\a.jpg"),
                BirthTown = town,
                LivingTown = town
            };

            context.Users.AddOrUpdate(x => x.Username, user);
            context.Countries.AddOrUpdate(x => x.Name, country);
        }
    }
}
