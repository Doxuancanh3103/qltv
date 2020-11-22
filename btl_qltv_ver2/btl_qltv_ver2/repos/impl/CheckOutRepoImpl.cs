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
    class CheckOutRepoImpl : CheckOutRepoService
    {
        private SqlConnection con;
        public string deleteCheckOut(string libraryCardNumber, int isbn, string grade)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from Check_Out where grade = @grade and isbn = @isbn and libraryCardNumber = @librarycardnumber");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("grade", grade);
            command.Parameters.AddWithValue("isbn", isbn);
            command.Parameters.AddWithValue("librarycardnumber", libraryCardNumber);
            command.ExecuteNonQuery();
            con.Close();
            return libraryCardNumber + grade + isbn.ToString();
        }

        public CheckOut getCheckOutByKey(string libraryCardNumber, int isbn, string grade)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            CheckOut checkOut = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("select libraryCardNumber,isbn,grade,checker,checkoutdate,currentCondition,fee from Check_Out where isbn = @isbn and grade = @grade and libraryCardNumber = @librarycardnumber");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("isbn", isbn);
            command.Parameters.AddWithValue("grade", grade);
            command.Parameters.AddWithValue("librarycardnumber", libraryCardNumber);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                checkOut = new CheckOut();
                checkOut.LibraryCardNumber = data.GetString(0);
                checkOut.Isbn = data.GetInt32(1);
                checkOut.Grade = data.GetString(2);
                checkOut.Checker = data.GetString(3);
                checkOut.CheckOutDate = data.GetDateTime(4);
                checkOut.CurrentCondition = data.GetString(5);
                checkOut.Fee = data.GetSqlMoney(6).ToDouble();
            }
            data.Close();
            con.Close();
            if (checkOut != null)
            {
                checkOut.Isbn = isbn;
                checkOut.Grade = grade;
                checkOut.LibraryCardNumber = libraryCardNumber;
            }
            return checkOut;
        }

        public CheckOutStatisticDomain getCheckOutDetailsFee(int year)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            CheckOutStatisticDomain checkOutStatisticDomain = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("select" + 
              " ( " +
			  " case when 1 <= MONTH(GETDATE()) then isnull(sum(case when month(c.CheckOutDate) = 1 then isnull(c.fee, 0) end), 0) " +

              " else -1 end " +
			  " ) as thang1, " +
			  " ( " +
			  " case when 2 <= MONTH(GETDATE()) then isnull(sum(case when month(c.CheckOutDate) = 2 then isnull(c.fee,0) end),0) " +

              " else -1 end " + 
			  " ) as thang2, " +
			  " ( " +
			  " case when 3 <= MONTH(GETDATE()) then isnull(sum(case when month(c.CheckOutDate) = 3 then isnull(c.fee,0) end),0) " +

              " else -1 end " +
			  " ) as thang3, " +
			  " ( " +
			  " case when 4 <= MONTH(GETDATE()) then isnull(sum(case when month(c.CheckOutDate) = 4 then isnull(c.fee,0) end),0) " +

              " else -1 end " +
			  " ) as thang4, "+
			  " ( " +
			  " case when 5 <= MONTH(GETDATE()) then isnull(sum(case when month(c.CheckOutDate) = 5 then isnull(c.fee,0) end),0) " +

              " else -1 end " +
			  " ) as thang5, " +
			  " ( " +
			  " case when 6 <= MONTH(GETDATE()) then isnull(sum(case when month(c.CheckOutDate) = 6 then isnull(c.fee,0) end),0) " +

              " else -1 end " +
			  " ) as thang6, " +
			  " ( " +
			  " case when 7 <= MONTH(GETDATE()) then isnull(sum(case when month(c.CheckOutDate) = 7 then isnull(c.fee,0) end),0) " +

              " else -1 end " +
			  " ) as thang7, " +
			  " ( " +
			  " case when 8 <= MONTH(GETDATE()) then isnull(sum(case when month(c.CheckOutDate) = 8 then isnull(c.fee,0) end),0) " +

              " else -1 end " +
			  " ) as thang8, " +
			  " ( " +
			  " case when 9 <= MONTH(GETDATE()) then isnull(sum(case when month(c.CheckOutDate) = 9 then isnull(c.fee,0) end),0) " +

              " else -1 end " +
			  " ) as thang9, "+
			  " ( " +
			  " case when 10 <= MONTH(GETDATE()) then isnull(sum(case when month(c.CheckOutDate) = 10 then isnull(c.fee,0) end),0) " +

              " else -1 end " +
			  " ) as thang10, " +
			  " ( " +
			  " case when 11 <= MONTH(GETDATE()) then isnull(sum(case when month(c.CheckOutDate) = 11 then isnull(c.fee,0) end),0) " +

              " else -1 end " +
			  " ) as thang11, " +
			  " ( " +
			  " case when 12 <= MONTH(GETDATE()) then isnull(sum(case when month(c.CheckOutDate) = 12 then isnull(c.fee,0) end),0) " +

              " else -1 end " +
			  " ) as thang12 " +
              " from Check_Out c " +
              " where YEAR(c.CheckOutDate) = @year "
              );
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("year", year);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                checkOutStatisticDomain = new CheckOutStatisticDomain();
                checkOutStatisticDomain.January = data.GetSqlMoney(0).ToDouble();
                checkOutStatisticDomain.February = data.GetSqlMoney(1).ToDouble();
                checkOutStatisticDomain.March = data.GetSqlMoney(2).ToDouble();
                checkOutStatisticDomain.April = data.GetSqlMoney(3).ToDouble();
                checkOutStatisticDomain.May = data.GetSqlMoney(4).ToDouble();
                checkOutStatisticDomain.June = data.GetSqlMoney(5).ToDouble();
                checkOutStatisticDomain.July = data.GetSqlMoney(6).ToDouble();
                checkOutStatisticDomain.August = data.GetSqlMoney(7).ToDouble();
                checkOutStatisticDomain.September = data.GetSqlMoney(8).ToDouble();
                checkOutStatisticDomain.October = data.GetSqlMoney(9).ToDouble();
                checkOutStatisticDomain.November = data.GetSqlMoney(10).ToDouble();
                checkOutStatisticDomain.December = data.GetSqlMoney(11).ToDouble();
            }
            data.Close();
            con.Close();
            return checkOutStatisticDomain;
        }

        public List<CheckOut> getCheckOuts()
        {
            con = SqlServerConnection.getConnnection();
            List<CheckOut> checkOuts = new List<CheckOut>();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select libraryCardNumber,isbn,grade,checker,checkoutdate,currentCondition,fee from Check_Out");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                CheckOut checkOut = new CheckOut();
                checkOut.LibraryCardNumber = data.GetString(0);
                checkOut.Isbn = data.GetInt32(1);
                checkOut.Grade = data.GetString(2);
                checkOut.Checker = data.GetString(3);
                checkOut.CheckOutDate = data.GetDateTime(4);
                checkOut.CurrentCondition = data.GetString(5);
                checkOut.Fee = data.GetSqlMoney(6).ToDouble();
                checkOuts.Add(checkOut);
            }
            data.Close();
            con.Close();
            return checkOuts;
        }

        public CheckOut insertCheckOut(CheckOutInsertSdi checkOutInsertSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into Check_Out (libraryCardNumber,isbn,grade,checker,checkoutdate,currentCondition) values(@librarycardnumber,@isbn,@grade,@checker,@checkoutdate,@currentcondition)");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("librarycardnumber", checkOutInsertSdi.LibraryCardNumber);
            command.Parameters.AddWithValue("isbn", checkOutInsertSdi.Isbn);
            command.Parameters.AddWithValue("grade", checkOutInsertSdi.Grade);
            command.Parameters.AddWithValue("checkoutdate", checkOutInsertSdi.CheckOutDate);
            command.Parameters.AddWithValue("checker", checkOutInsertSdi.Checker);
            command.Parameters.AddWithValue("currentCondition", checkOutInsertSdi.CurrentCondition);
            command.ExecuteNonQuery();
            con.Close();
            return this.getCheckOutByKey(checkOutInsertSdi.LibraryCardNumber, checkOutInsertSdi.Isbn, checkOutInsertSdi.Grade);
        }

        public bool isExistCheckOut(string libraryCardNumber, int isbn, string grade)
        {
            return this.getCheckOutByKey(libraryCardNumber, isbn, grade) != null ? true : false;
        }

        public CheckOut updateCheckOut(CheckOutUpdateSdi checkOutUpdateSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append(" update Check_Out  set " +
                                         " checker = @checker," +
                                         " currentCondition = @currentcondition," +                                            
                                         " checkoutDate = @checkoutdate ");
            sql.Append(" where isbn = @isbn and grade = @grade and libraryCardNumber = @librarycardnumber");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("checker", checkOutUpdateSdi.Checker);
            command.Parameters.AddWithValue("currentCondition", checkOutUpdateSdi.CurrentCondition);
            command.Parameters.AddWithValue("checkoutdate", checkOutUpdateSdi.CheckOutDate);
            command.Parameters.AddWithValue("isbn", checkOutUpdateSdi.Isbn);
            command.Parameters.AddWithValue("grade", checkOutUpdateSdi.Grade);
            command.Parameters.AddWithValue("librarycardnumber", checkOutUpdateSdi.LibraryCardNumber);
            command.ExecuteNonQuery();
            con.Close();
            return this.getCheckOutByKey(checkOutUpdateSdi.LibraryCardNumber, checkOutUpdateSdi.Isbn, checkOutUpdateSdi.Grade);
        }
    }
}
