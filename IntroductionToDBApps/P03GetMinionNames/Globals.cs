
namespace P03GetMinionNames
{
    public static class Globals
    {
        public const string ConnectionStringMinionsDB = @"Server =.\SQLEXPRESS; Database = MinionsDB; " +
        "Integrated Security = true";

        public const string GetNameAgeMinions =
            "SELECT m.Name AS MinionName, m.Age FROM Minions AS m " +
            "INNER JOIN MinionsVillains AS mv ON mv.MinionID = m.MinionID " +
            "WHERE mv.VillainID = @VillainID";

        public const string GetVillan =
            "SELECT v.Name AS VillainName FROM Villains AS v " +
            "WHERE v.VillainID = @VillainID";
    }
}



