using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07PrintAllMinionNames
{
    public static class Globals
    {
        public const string ConnectionStringMinionsDB = @"Server =.\SQLEXPRESS; Database = MinionsDB; " +
        "Integrated Security = true";

        public const string CountOfMinionsQuery = @"SELECT COUNT(*) FROM Minions";

        public const string GetMinionsNameAsc = @"SELECT Name FROM Minions ORDER BY MinionID ASC";

        public const string GetMinionsNameDesc = @"SELECT Name FROM Minions ORDER BY MinionID DESC";
    }
}
