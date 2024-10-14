using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ChronoLog {
    class DatabaseConnection {

        SqlConnection connection;

        public SqlConnection GetConnection() {

            connection = new SqlConnection("Data Source=YanJi13;Initial Catalog=ChronoLogDB;Integrated Security=True;Encrypt=False");
            return connection;
        }
    }
}
