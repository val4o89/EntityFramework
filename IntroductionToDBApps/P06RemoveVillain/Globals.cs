using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06RemoveVillain
{
    public static class Globals
    {
        public const string ConnectionStringMinionsDB = @"Server =.\SQLEXPRESS; Database = MinionsDB; " +
        "Integrated Security = true";

        public const string RemoveFromMinionsVilains = @"DELETE FROM MinionsVillains WHERE VillainID = @ID";

        public const string RemoveFromVilains = @"DELETE FROM Villains WHERE VillainID = @ID";

        public const string SelectVillain = @"SELECT Name FROM Villains WHERE VillainID = @ID";

        public const string SelectCountOfMinions = @"SELECT COUNT(*) FROM MinionsVillains WHERE VillainID = @ID";

    }
}
