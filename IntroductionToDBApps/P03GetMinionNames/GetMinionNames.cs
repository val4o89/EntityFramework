using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03GetMinionNames
{
    public class GetMinionNames
    {
        public static void Main()
        {
            SqlConnection dbCon = new SqlConnection(Globals.ConnectionStringMinionsDB);
            SqlCommand commandGetVillain = new SqlCommand(Globals.GetVillan, dbCon);
            SqlCommand commandGetMinionsNameAge = new SqlCommand(Globals.GetNameAgeMinions, dbCon);

            int villainID = int.Parse(Console.ReadLine());
            commandGetMinionsNameAge.Parameters.AddWithValue("VillainID", villainID);
            commandGetVillain.Parameters.AddWithValue("VillainID", villainID);

            dbCon.Open();

            int rowCounter = 1;
            if (commandGetVillain.ExecuteScalar() == null)
            {
                Console.WriteLine($"No villain with ID {villainID} exists in the database.");
                return;
            }

            Console.WriteLine(commandGetVillain.ExecuteScalar());
            SqlDataReader readerMinions = commandGetMinionsNameAge.ExecuteReader();

            while (readerMinions.Read())
            {
                string minionNameAndAge = $"{rowCounter}. {(string)readerMinions["MinionName"]} {(int)readerMinions["Age"]}";
                Console.WriteLine(minionNameAndAge);
                rowCounter++;
            }

            if (rowCounter == 1)
            {
                Console.WriteLine("<no minions>");
            }

        }
    }
}
