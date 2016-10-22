using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08IncreaseMinionsAge
{
    public class IncreaseMinionsAge
    {
        public static void Main()
        {
            int[] IDs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SqlConnection dbCon = new SqlConnection(Globals.ConnectionStringMinionsDB);

            dbCon.Open();

            for (int i = 0; i < IDs.Length; i++)
            {
                SqlCommand updateAgeAndName = new SqlCommand(Globals.UpdateAgeNameQuery, dbCon);

                SqlCommand selectCurrentName = new SqlCommand(Globals.SelectNamesQuery, dbCon);

                selectCurrentName.Parameters.AddWithValue("@MinionID", IDs[i]);

                string namesOfMinion = (string)selectCurrentName.ExecuteScalar();

                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                namesOfMinion = textInfo.ToTitleCase(namesOfMinion);

                updateAgeAndName.Parameters.AddWithValue("@Name", namesOfMinion);
                updateAgeAndName.Parameters.AddWithValue("@MinionID", IDs[i]);

                updateAgeAndName.ExecuteNonQuery();
            }

            SqlCommand selectAllNamesAges = new SqlCommand(Globals.SelectAllMinionNames, dbCon);

            SqlDataReader reader = selectAllNamesAges.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader["Name"]} {reader["Age"]}");
            }
        }
    }
}
