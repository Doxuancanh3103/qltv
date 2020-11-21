using btl_qltv_ver2.DBConnection;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.repos.impl
{
    class PatronRepoImpl : PatronRepoService
    {
        SqlConnection con;

        public String deletePatron(string libraryCardNumber)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from Patron where libraryCardNumber = @librarycardnumber");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("librarycardnumber", libraryCardNumber);
            command.ExecuteNonQuery();
            con.Close();
            return libraryCardNumber;
        }

        public List<Patron> filterPatrons(string obj, string sender)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            List<Patron> patrons = new List<Patron>();
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> param = new Dictionary<String, Object>();
            sql.Append("select libraryCardNumber," +
                               " CONCAT(fName,' ',mName,' ',lName) as name," +
                               " DOB," +
                               "phoneNumber," +
                               "Address from Patron ");
            sql.Append(" where 1 = 1 ");
            if ("1".Equals(sender))
            {
                obj = "%" + obj + "%";
                sql.Append(" and CONCAT(fName,' ',mName,' ',lName) like @obj");
                param.Add("obj", obj);
            }
            else if ("2".Equals(sender))
            {
                obj = "%" + obj + "%";
                sql.Append(" and address like @obj");
                param.Add("obj", obj);
            }
            else
            {
                obj = "%" + obj + "%";
                sql.Append(" and phonenumber like @obj");
                param.Add("obj", obj);
            }


            SqlCommand command = new SqlCommand(sql.ToString(), con);
            foreach (KeyValuePair<String, Object> item in param)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                Patron patron = new Patron();
                patron.LibraryCardNumber = data.GetString(0);
                patron.Name = data.GetString(1);
                patron.DOB1 = data.GetDateTime(2);
                patron.PhoneNumber = data.GetString(3);
                patron.Address = data.GetString(4);
                patrons.Add(patron);
            }
            data.Close();
            con.Close();
            return patrons;
        }

        public Patron getPatronByLibraryCardNumber(string libraryCardNumber)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            Patron patron = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("select  CONCAT(fName,' ',mName,' ',lName) as name," +
                               " DOB," +
                               " phoneNumber," +
                               " Address from Patron where libraryCardNumber = " + libraryCardNumber);
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                patron = new Patron();
                patron.Name = data.GetString(0);
                patron.DOB1 = data.GetDateTime(1);
                patron.PhoneNumber = data.GetString(2);
                patron.Address = data.GetString(3);
            }
            data.Close();
            con.Close();
            if (patron != null)
            {
                patron.LibraryCardNumber = libraryCardNumber;
            }
            return patron;
        }

        public List<Patron> getPatrons()
        {
            con = SqlServerConnection.getConnnection();
            List<Patron> patrons = new List<Patron>();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select libraryCardNumber," +
                               " CONCAT(fName,' ',mName,' ',lName) as name," +
                               " DOB," +
                               "phoneNumber," +
                               "Address from Patron");
            SqlCommand command = new SqlCommand(sql.ToString(),con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                Patron patron = new Patron();
                patron.LibraryCardNumber = data.GetString(0);
                patron.Name = data.GetString(1);
                patron.DOB1 = data.GetDateTime(2);
                patron.PhoneNumber = data.GetString(3);
                patron.Address = data.GetString(4);
                patrons.Add(patron);
            }
            data.Close();
            con.Close();
            return patrons;
        }

        public Patron insertMedia(PatronInsertSdi patronInsertSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into Patron values(@librarycardnumber,@fname,@mname,@lname,@dob,@phonenumber,@address,@username,@password)");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("librarycardnumber", patronInsertSdi.LibraryCardNumber);
            command.Parameters.AddWithValue("fname", patronInsertSdi.Fname);
            command.Parameters.AddWithValue("mname", patronInsertSdi.Mname);
            command.Parameters.AddWithValue("lname", patronInsertSdi.Lname);
            command.Parameters.AddWithValue("dob", DateTime.Parse(patronInsertSdi.DOB1));
            command.Parameters.AddWithValue("phonenumber", patronInsertSdi.PhoneNumber);
            command.Parameters.AddWithValue("address", patronInsertSdi.Address);
            command.Parameters.AddWithValue("username", patronInsertSdi.Username);
            command.Parameters.AddWithValue("password", patronInsertSdi.Password);
            command.ExecuteNonQuery();
            con.Close();
            return this.getPatronByLibraryCardNumber(patronInsertSdi.LibraryCardNumber);
        }

        public bool isExistAccount(string username)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from Patron where Pusername = @username");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("username", username);
            SqlDataReader data = command.ExecuteReader();
            if (data.HasRows)
            {
                return true;
            }
            data.Close();
            con.Close();
            return false;
        }

        public List<Patron> searchPatrons(PatronSearchSdi patronSearchSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            List<Patron> patrons = new List<Patron>();
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> param = new Dictionary<String, Object>();
            sql.Append("select libraryCardNumber," +
                              " CONCAT(fName,' ',mName,' ',lName) as name," +
                              " DOB," +
                              "phoneNumber," +
                              "Address from Patron");
            sql.Append(" where 1 = 1 ");
            if (patronSearchSdi.LibraryCardNumber != null && !"".Equals(patronSearchSdi.LibraryCardNumber))
            {
                sql.Append(" and libraryCardNumber = @librarycardnumber ");
                param.Add("librarycardnumber", patronSearchSdi.LibraryCardNumber);
            }

            if (patronSearchSdi.Fname != null && !"".Equals(patronSearchSdi.Fname))
            {
                sql.Append(" and fName = @fname ");
                param.Add("fname", patronSearchSdi.Fname);
            }
            if (patronSearchSdi.Lname != null && !"".Equals(patronSearchSdi.Lname))
            {
                sql.Append(" and lName = @lname ");
                param.Add("lname", patronSearchSdi.Lname);
            }

            if (patronSearchSdi.Mname != null && !"".Equals(patronSearchSdi.Mname))
            {
                sql.Append(" and mName = @mname ");
                param.Add("mname", patronSearchSdi.Mname);
            }

            if (patronSearchSdi.Address != null && !"".Equals(patronSearchSdi.Address))
            {
                sql.Append(" and Address = @address ");
                param.Add("address", patronSearchSdi.Address);
            }

            if (patronSearchSdi.PhoneNumber != null && !"".Equals(patronSearchSdi.PhoneNumber))
            {
                sql.Append(" and phoneNumber = @phonenumber ");
                param.Add("phonenumber", patronSearchSdi.PhoneNumber);
            }

            if (patronSearchSdi.Username != null && !"".Equals(patronSearchSdi.Username))
            {
                sql.Append(" and Pusername = @username ");
                param.Add("username", patronSearchSdi.Username);
            }

            SqlCommand command = new SqlCommand(sql.ToString(), con);
            foreach (KeyValuePair<String, Object> item in param)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                Patron patron = new Patron();
                patron.LibraryCardNumber = data.GetString(0);
                patron.Name = data.GetString(1);
                patron.DOB1 = data.GetDateTime(2);
                patron.PhoneNumber = data.GetString(3);
                patron.Address = data.GetString(4);
                patrons.Add(patron);
            }
            data.Close();
            con.Close();
            return patrons;
        }

        public Patron updatePatron(PatronUpdateSdi sdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append(" update Patron  set fName = @fname," +
                                         "lName = @lname," +
                                         "mName = @mname," +
                                         "DOB = @dob," +
                                         "phoneNumber = @phonenumber," +
                                         "Address = @address");
            sql.Append(" where libraryCardNumber = @librarycardnumber");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("fname", sdi.Fname);
            command.Parameters.AddWithValue("mname", sdi.Mname);
            command.Parameters.AddWithValue("lname", sdi.Lname);
            command.Parameters.AddWithValue("dob", DateTime.Parse(sdi.DOB1));
            command.Parameters.AddWithValue("phonenumber", sdi.PhoneNumber);
            command.Parameters.AddWithValue("address", sdi.Address);
            command.Parameters.AddWithValue("librarycardnumber", sdi.LibraryCardNumber);
            command.ExecuteNonQuery();
            con.Close();
            return this.getPatronByLibraryCardNumber(sdi.LibraryCardNumber);
        }
    }
}
