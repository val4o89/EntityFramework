using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace P05ChangeTownNamesCasing
{
    public class ChangeTownNamesCasing
    {
        public static void Main()
        {
            SqlConnection dbCon = new SqlConnection(Globals.ConnectionStringMinionsDB);

            SqlCommand updateCommand = new SqlCommand(Globals.UpdateTownsQuery, dbCon);
            SqlCommand selectCommand = new SqlCommand(Globals.SelectTownsQuery, dbCon);

            List<string> collectionOfTowns = new List<string>();

            string country = Console.ReadLine();

            updateCommand.Parameters.AddWithValue("@Country", country);
            selectCommand.Parameters.AddWithValue("@Country", country);

            using (dbCon)
            {
                dbCon.Open();

                updateCommand.ExecuteNonQuery();

                SqlDataReader reader = selectCommand.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        collectionOfTowns.Add(reader["TownName"] as string);
                    }
                }
                string resultTowns = string.Join(", ", collectionOfTowns);

                if (collectionOfTowns.Count > 0)
                {
                    Console.WriteLine($"{collectionOfTowns.Count} town names were affected. \n[{resultTowns}]");
                }
                else
                {
                    Console.WriteLine("No town names were affected.");
                }

                dbCon.Close();
            }
        }
    }
}
