using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace P09GetOlder
{
    public class GetOlder
    {
        public static void Main()
        {
            SqlConnection dbCon = new SqlConnection(Globals.ConnectionStringMinionsDB);

            SqlCommand procedureCommand = new SqlCommand("usp_GetOlder", dbCon);

            SqlCommand selectUpdatedMinion = new SqlCommand(Globals.SelectUpdatedMinion, dbCon);

            int ID = int.Parse(Console.ReadLine());

            using (dbCon)
            {
                dbCon.Open();

                procedureCommand.Parameters.AddWithValue("@ID", ID);

                procedureCommand.CommandType = CommandType.StoredProcedure;

                procedureCommand.ExecuteNonQuery();

                selectUpdatedMinion.Parameters.AddWithValue("@ID", ID);

                SqlDataReader reader = selectUpdatedMinion.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Name"]} {reader["Age"]}");
                }
            }
        }
    }
}
