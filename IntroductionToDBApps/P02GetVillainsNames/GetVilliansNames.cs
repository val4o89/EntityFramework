using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02GetVillainsNames
{
    public class GetVilliansNames
    {
        public static void Main()
        {
            SqlConnection dbCon = new SqlConnection(Globals.ConnectionStringMinionsDB);
            SqlCommand command = new SqlCommand(Globals.GetVillansNameMinionsCount, dbCon);
            dbCon.Open();
            SqlDataReader reader = command.ExecuteReader();

            using (dbCon)
            {
                using (reader)
                {
                    while (reader.Read())
                    {
                        string villainName = (string)reader["Name"];
                        int countOfMinions = (int)reader["CountOfMinions"];
                        Console.WriteLine($"{villainName} {countOfMinions}");
                    }
                }
            }

        }
    }
}
