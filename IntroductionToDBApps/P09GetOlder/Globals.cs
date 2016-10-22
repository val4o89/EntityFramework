using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09GetOlder
{
    public static class Globals
    {
        public const string ConnectionStringMinionsDB = @"Server =.\SQLEXPRESS; Database = MinionsDB; " +
        "Integrated Security = true";

        public const string SelectUpdatedMinion = @"SELECT Name, Age FROM Minions WHERE MinionID = @ID";
    }
}
