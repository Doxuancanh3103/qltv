using btl_qltv_ver2.DBConnection;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.repos.impl
{
    class LoginRepoServiceImpl : LoginRepoService
    {
        SqlConnection con = SqlServerConnection.getConnnection();
        public int checkLogin(LoginSdi loginSdi)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT roleType,Eusername,Epassword FROM Employee");
            sql.Append(" WHERE Eusername = @username AND Epassword = @password");
            con.Open();
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("username", loginSdi.Username);
            command.Parameters.AddWithValue("password", loginSdi.Password);
            SqlDataReader reader = command.ExecuteReader();
            String roleType = null;
            while (reader.Read())
            {
                roleType = (String)reader["roleType"];
            }
            reader.Close();
            con.Close();
            
            if (roleType == null)
            {
                StringBuilder sql1 = new StringBuilder();
                sql1.Append(" SELECT Pusername,Ppassword FROM Patron");
                sql1.Append(" WHERE Pusername = @username AND Ppassword = @password");
                con.Open();
                SqlCommand command1 = new SqlCommand(sql1.ToString(), con);
                command1.Parameters.AddWithValue("username", loginSdi.Username);
                command1.Parameters.AddWithValue("password", loginSdi.Password);
                SqlDataReader reader1 = command1.ExecuteReader();
                if (reader1.Read())
                {
                    reader1.Close();
                    con.Close();
                    return 0;
                }
                else
                {
                    reader1.Close();
                    con.Close();
                    return -1;
                }
            }
            
            if ("Librian".Equals(roleType))
            {
                return 2;
            }
            return 1;
        }
    }
}
