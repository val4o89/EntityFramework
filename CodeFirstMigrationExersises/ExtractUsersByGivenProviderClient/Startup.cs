using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersDbContext;

namespace ExtractUsersByGivenProviderClient
{
    public class Startup
    {
        static void Main()
        {
            var context = new UserContext();

            string domain = Console.ReadLine();

            var users = context.Users.Where(x => x.Email.EndsWith(domain))
                .Select
                (x => new
                {
                    Name = x.Username,
                    Email = x.Email
                });

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name} {user.Email}");
            }
        }
    }
}
