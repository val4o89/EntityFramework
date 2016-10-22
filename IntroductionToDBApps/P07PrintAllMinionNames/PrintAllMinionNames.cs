using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07PrintAllMinionNames
{
    public class PrintAllMinionNames
    {
        public static void Main()
        {
            int decreasingCounter = 1;
            int increasingCounter = 0;

            SqlConnection dbCon = new SqlConnection(Globals.ConnectionStringMinionsDB);

            SqlCommand getCountOfMinions = new SqlCommand(Globals.CountOfMinionsQuery, dbCon);

            SqlCommand getNamesOfMinionsAsc = new SqlCommand(Globals.GetMinionsNameAsc, dbCon);

            IList<string> minionNamesList = new List<string>();

            dbCon.Open();

            int countOfMinions = (int)getCountOfMinions.ExecuteScalar();

            SqlDataReader readerNamesAsc = getNamesOfMinionsAsc.ExecuteReader();

            while (readerNamesAsc.Read())
            {
                minionNamesList.Add((string)readerNamesAsc["Name"]);
            }

            for (int i = 0; i < minionNamesList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(minionNamesList[increasingCounter]);
                    increasingCounter++;
                }
                else
                {
                    Console.WriteLine(minionNamesList[minionNamesList.Count - decreasingCounter]);
                    decreasingCounter++;
                }
            }
        }
    }
}
