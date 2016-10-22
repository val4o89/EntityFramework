using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ChangeTownNamesCasing
{
    public static class Globals
    {
        public const string ConnectionStringMinionsDB = @"Server =.\SQLEXPRESS; Database = MinionsDB; " +
        "Integrated Security = true";
        
        public const string UpdateTownsQuery = @"UPDATE Towns " +
        "SET TownName = UPPER(TownName) " +
        "WHERE CountryID = ( " +
        "SELECT CountryID FROM Countries " +
        "WHERE CountryName = @Country)";

        public const string SelectTownsQuery = @"SELECT TownName FROM Towns " +
        "WHERE CountryID = ( " +
        "SELECT CountryID FROM Countries " +
        "WHERE CountryName = @Country)";
    }
}
