using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace rtkios
{
    class koneksi
    {
        public System.Data.SqlClient.SqlConnection GetConn()
        {
            System.Data.SqlClient.SqlConnection conn = newSystem.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source= Toufik-PC; Initial Catalog=db_latihan;user=sa; Password=123456";
            return conn;
        }
    }
}
