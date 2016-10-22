using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06RemoveVillain
{
    public class RemoveVillain
    {
        public static void Main()
        {
            Stopwatch a = new Stopwatch();
            SqlConnection dbCon = new SqlConnection(Globals.ConnectionStringMinionsDB);

            SqlCommand removeFromMinionsVillains = new SqlCommand(Globals.RemoveFromMinionsVilains, dbCon);

            SqlCommand removeFromVillains = new SqlCommand(Globals.RemoveFromVilains, dbCon);

            SqlCommand selectCountOfMinions = new SqlCommand(Globals.SelectCountOfMinions, dbCon);

            SqlCommand selectVillainName = new SqlCommand(Globals.SelectVillain, dbCon);

            int ID = int.Parse(Console.ReadLine());
            a.Start();
            int countOfMinions = 0;

            string nameOfVillain = string.Empty;

            selectCountOfMinions.Parameters.AddWithValue("@ID", ID);

            selectVillainName.Parameters.AddWithValue("@ID", ID);

            removeFromMinionsVillains.Parameters.AddWithValue("@ID", ID);

            removeFromVillains.Parameters.AddWithValue("@ID", ID);

            using (dbCon)
            {
                dbCon.Open();

                countOfMinions = (int)selectCountOfMinions.ExecuteScalar();

                nameOfVillain = (string)selectVillainName.ExecuteScalar();

                removeFromMinionsVillains.ExecuteNonQuery();

                removeFromVillains.ExecuteNonQuery();
            }

            if (nameOfVillain == null)
            {
                Console.WriteLine("No such villain was found");
                return;
            }

            Console.WriteLine($"{nameOfVillain} was deleted {countOfMinions} minions released");
            a.Stop();
            Console.WriteLine(a.ElapsedMilliseconds);
        }
    }
}
