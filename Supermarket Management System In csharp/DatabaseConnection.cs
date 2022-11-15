using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Supermarket_Management_System_In_csharp
{
    public class DatabaseConnection
    {
        private SqlConnection connection;
        public DatabaseConnection() { 
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sasanka\OneDrive\Desktop\07\Supermarket Management System In csharp\Supermarket Management System In csharp\SMS.mdf"";Integrated Security=True");
        }

        public SqlConnection GetSqlConnection() { 
            return connection;
        }
    }
}
