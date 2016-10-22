using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORMProject
{
    public class ConnectionStringBuilder
    {
        private SqlConnectionStringBuilder builder;

        private string connectionString;

        public ConnectionStringBuilder(string databaseName)
        {
            this.builder = new SqlConnectionStringBuilder();
            builder["Data Source"] = @"DESKTOP-NFUJDOA\SQLEXPRESS";
            builder["Integrated Security"] = true;
            builder["Connect Timeout"] = 1000;
            builder["Trusted_Connection"] = true;
            builder["Initial Catalog"] = databaseName;
            this.connectionString = builder.ToString();
        }

        public string ConnectionString { get { return this.connectionString; } }
    }
}
