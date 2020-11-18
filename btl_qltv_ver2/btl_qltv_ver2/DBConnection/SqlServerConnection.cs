using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.DBConnection
{
    class SqlServerConnection
    {
        public static SqlConnection getConnnection()
        {
            String connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-6899MB5\SQLEXPRESS;Initial Catalog=btl_qltv;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            return cnn;
        }
    }
}
