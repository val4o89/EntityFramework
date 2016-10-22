using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORMProject
{
    using Core;
    using Entities;
    using Interfaces;

    public class MiniORMMain
    {
        
        public static void Main()
        {
            string connectionString = new ConnectionStringBuilder("MiniORM").ConnectionString;

            IDbContext context = new EntityManager(connectionString, true);

            User user = new User("Pencho", "0000", 12, DateTime.Now, 1);

            context.Persist(user);
        }
    }
}
