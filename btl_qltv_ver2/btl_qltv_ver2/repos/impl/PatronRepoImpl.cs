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
                               " Address from Patron where libraryCardNumber = @librarycardnumber" );
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("librarycardnumber", libraryCardNumber);
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

        public PatronDetails getPatronDetailsById(string libraryCardNumber)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            PatronDetails patronDetails = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("select " +
              " p.libraryCardNumber, " +
              " count(case when month(e.CheckedInDate) = 1 then 1 end) as thang1, " +
              " count(case when month(e.CheckedInDate) = 2 then 2 end) as thang2, " +
              " count(case when month(e.CheckedInDate) = 3 then 3 end) as thang3, " +
              " count(case when month(e.CheckedInDate) = 4 then 4 end) as thang4, " +
              " count(case when month(e.CheckedInDate) = 5 then 5 end) as thang5, " +
              " count(case when month(e.CheckedInDate) = 6 then 6 end) as thang6, " +
              " count(case when month(e.CheckedInDate) = 7 then 7 end) as thang7, " +
              " count(case when month(e.CheckedInDate) = 8 then 8 end) as thang8, " +
              " count(case when month(e.CheckedInDate) = 9 then 9 end) as thang9, " +
              " count(case when month(e.CheckedInDate) = 10 then 10 end) as thang10, " +
              " count(case when month(e.CheckedInDate) = 11 then 11 end) as thang11, " +
              " count(case when month(e.CheckedInDate) = 12 then 12 end) as thang12 " +
              " from Patron p inner "+ 
              " join Exchange e on p.libraryCardNumber = e.LibraryCardNumber " +
              " where e.LibraryCardNumber = @librarycardnumber and YEAR(e.CheckedInDate) = YEAR(GETDATE()) " +
              " group by p.libraryCardNumber"
              );
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("librarycardnumber", libraryCardNumber);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                patronDetails = new PatronDetails();
                patronDetails.LibraryCardNumber = data.GetString(0);
                patronDetails.January = data.GetInt32(1);
                patronDetails.February = data.GetInt32(2);
                patronDetails.March = data.GetInt32(3);
                patronDetails.April = data.GetInt32(4);
                patronDetails.May = data.GetInt32(5);
                patronDetails.June = data.GetInt32(6);
                patronDetails.July = data.GetInt32(7);
                patronDetails.August = data.GetInt32(8);
                patronDetails.September = data.GetInt32(9);
                patronDetails.October = data.GetInt32(10);
                patronDetails.November = data.GetInt32(11);
                patronDetails.December = data.GetInt32(12);
            }
            data.Close();
            con.Close();
            if (patronDetails != null)
            {
                patronDetails.LibraryCardNumber = libraryCardNumber;
            }
            return patronDetails;
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
            SqlCommand command = new SqlCommand(sql.ToString(), con);
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

        public int sumOfDamageMedia(string libraryCardNumber)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(c.ISBN) as amount from Check_Out c " +
                             " where c.CurrentCondition != c.Grade and c.LibraryCardNumber = @libraryCardNumber");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("libraryCardNumber", libraryCardNumber);
            int amount = 0;
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                amount = data.GetInt32(0);
            }
            data.Close();
            con.Close();
            return amount;
        }

        public int sumOfMediaBorrowed(string libraryCardNumber)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(ISBN) as amount from Exchange where LibraryCardNumber = @libraryCardNumber");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("libraryCardNumber", libraryCardNumber);
            int amount = 0;
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                amount = data.GetInt32(0);
            }
            data.Close();
            con.Close();
            return amount;
        }

        public int sumOfMediaBorrowing(string libraryCardNumber)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(e.ISBN) from Exchange e " +
                       "where e.LibraryCardNumber = @libraryCardNumber and  not exists(select ISBN, Grade from Check_Out c where e.ISBN = c.ISBN and e.Grade = c.Grade and c.LibraryCardNumber = @libraryCardNumber)");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("libraryCardNumber", libraryCardNumber);
            int amount = 0;
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                amount = data.GetInt32(0);
            }
            data.Close();
            con.Close();
            return amount;
        }

        public int sumOfMediaReturned(string libraryCardNumber)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(ISBN) as amount from Check_Out where LibraryCardNumber = @libraryCardNumber");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("libraryCardNumber", libraryCardNumber);
            int amount = 0;
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                amount = data.GetInt32(0);
            }
            data.Close();
            con.Close();
            return amount;
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
