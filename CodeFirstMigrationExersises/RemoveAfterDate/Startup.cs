using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersDbContext;

namespace RemoveBeforeDate
{
    class Startup
    {
        static void Main()
        {
            var context = new UserContext();

            DateTime date = DateTime.Parse(Console.ReadLine());

            var users = context.Users.Where(x => x.LastTimeLoggedIn < date);

            foreach (var user in users)
            {
                user.IsDeleted = true;
            }
        }
    }
}
