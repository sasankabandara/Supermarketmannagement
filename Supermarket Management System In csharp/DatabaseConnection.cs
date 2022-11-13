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
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\ERP assignment\Supermarket Management System in csharp\Supermarket Management System In csharp\Supermarket Management System In csharp\SMS.mdf"";Integrated Security=True;Connect Timeout=30");
        }

        public SqlConnection GetSqlConnection() { 
            return connection;
        }
    }
}
