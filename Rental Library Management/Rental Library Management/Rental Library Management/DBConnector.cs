using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Library_Management
{
    class DBConnector
    {
        string connectionString = @"server=(local)\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=LibraryManagementSystemDB";

        SqlConnection connection = null;

        public DBConnector()
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection Connection
        {
            get => connection;
        }
    }
}
