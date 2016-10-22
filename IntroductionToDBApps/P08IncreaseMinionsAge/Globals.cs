using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08IncreaseMinionsAge
{
    public static class Globals
    {
        public const string ConnectionStringMinionsDB = @"Server =.\SQLEXPRESS; Database = MinionsDB; " +
        "Integrated Security = true";

        public const string UpdateAgeNameQuery = @"UPDATE Minions " +
        "SET Name = @Name " +
        "WHERE MinionID = @MinionID " +
         "UPDATE Minions SET Age += 1 WHERE MinionID = @MinionID";

        public const string SelectNamesQuery = @"SELECT Name FROM Minions WHERE MinionID = @MinionID";

        public const string SelectAllMinionNames = @"SELECT Name, Age FROM Minions";
    }
}
