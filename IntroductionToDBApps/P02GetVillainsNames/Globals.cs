using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02GetVillainsNames
{
    class Globals
    {
        public const string ConnectionStringMinionsDB = @"Server =.\SQLEXPRESS; Database = MinionsDB; " +
        "Integrated Security = true";

        public const string GetVillansNameMinionsCount = 
            @"SELECT v.Name, COUNT(mv.MinionID) AS CountOfMinions FROM Villains AS v " +
            @"INNER JOIN MinionsVillains AS mv ON v.VillainID = mv.VillainID " +
            @"GROUP BY v.Name " +
            @"HAVING COUNT(mv.MinionID) > 3 ";
    }
}
