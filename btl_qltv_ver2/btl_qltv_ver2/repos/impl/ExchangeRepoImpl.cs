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
    class ExchangeRepoImpl : ExchangeRepoService
    {
        private SqlConnection con;
        public string deleteExchange(string libraryCardNumber, int isbn, string grade)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from Exchange where grade = @grade and isbn = @isbn and libraryCardNumber = @librarycardnumber");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("grade", grade);
            command.Parameters.AddWithValue("isbn", isbn);
            command.Parameters.AddWithValue("librarycardnumber", libraryCardNumber);
            command.ExecuteNonQuery();
            con.Close();
            return libraryCardNumber + grade + isbn.ToString();
        }

        public Exchange getExchangeByKey(string libraryCardNumber, int isbn, string grade)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            Exchange exchange = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("select libraryCardNumber,isbn,grade,checkedInDate,term from Exchange where isbn = @isbn and grade = @grade and libraryCardNumber = @librarycardnumber");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("isbn", isbn);
            command.Parameters.AddWithValue("grade", grade);
            command.Parameters.AddWithValue("librarycardnumber", libraryCardNumber);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                exchange = new Exchange();
                exchange.LibraryCardNumber = data.GetString(0);
                exchange.Isbn = data.GetInt32(1);
                exchange.Grade = data.GetString(2);
                exchange.CheckedInDate = data.GetDateTime(3);
                exchange.Term = data.GetDateTime(4);
            }
            data.Close();
            con.Close();
            if (exchange != null)
            {
                exchange.Isbn = isbn;
                exchange.Grade = grade;
                exchange.LibraryCardNumber = libraryCardNumber;
            }
            return exchange;
        }

        public ExchangeStatisticDomain getExchangeDetails()
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            ExchangeStatisticDomain exchangeStatisticDomain = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("select" +
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
              " from Exchange e " +
              " where YEAR(e.CheckedInDate) = YEAR(GETDATE()) "
              );
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                exchangeStatisticDomain = new ExchangeStatisticDomain();
                exchangeStatisticDomain.January = data.GetInt32(0);
                exchangeStatisticDomain.February = data.GetInt32(1);
                exchangeStatisticDomain.March = data.GetInt32(2);
                exchangeStatisticDomain.April = data.GetInt32(3);
                exchangeStatisticDomain.May = data.GetInt32(4);
                exchangeStatisticDomain.June = data.GetInt32(5);
                exchangeStatisticDomain.July = data.GetInt32(6);
                exchangeStatisticDomain.August = data.GetInt32(7);
                exchangeStatisticDomain.September = data.GetInt32(8);
                exchangeStatisticDomain.October = data.GetInt32(9);
                exchangeStatisticDomain.November = data.GetInt32(10);
                exchangeStatisticDomain.December = data.GetInt32(11);
            }
            data.Close();
            con.Close();
            return exchangeStatisticDomain;
        }

        public List<Exchange> getExchanges()
        {
            con = SqlServerConnection.getConnnection();
            List<Exchange> exchanges = new List<Exchange>();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select libraryCardNumber,isbn,grade,checkedInDate,term from Exchange");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                Exchange exchange = new Exchange();
                exchange.LibraryCardNumber = data.GetString(0);
                exchange.Isbn = data.GetInt32(1);
                exchange.Grade = data.GetString(2);
                exchange.CheckedInDate = data.GetDateTime(3);
                exchange.Term = data.GetDateTime(4);
                exchanges.Add(exchange);
            }
            data.Close();
            con.Close();
            return exchanges;
        }

        public Exchange insertExchange(ExchangeInsertSdi exchangeInsertSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into Exchange (libraryCardNumber,isbn,grade,checkedInDate) values(@librarycardnumber,@isbn,@grade,@checkedindate)");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("librarycardnumber", exchangeInsertSdi.LibraryCardNumber);
            command.Parameters.AddWithValue("isbn", exchangeInsertSdi.Isbn);
            command.Parameters.AddWithValue("grade", exchangeInsertSdi.Grade);
            command.Parameters.AddWithValue("checkedindate", exchangeInsertSdi.CheckedInDate);
            command.ExecuteNonQuery();
            con.Close();
            return this.getExchangeByKey(exchangeInsertSdi.LibraryCardNumber,exchangeInsertSdi.Isbn, exchangeInsertSdi.Grade);
        }

        public bool isExistExchange(string libraryCardNumber, int isbn, string grade)
        {
            if (this.getExchangeByKey(libraryCardNumber, isbn,grade) != null)
            {
                return true;
            }
            return false;
        }

        public bool isPaid(string libraryCardNumber, int isbn, string grade)
        {
            return true;
        }

        public Exchange updateExchange(ExchangeUpdateSdi exchangeUpdateSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append(" update Exchange  set " +
                                         " checkedInDate = @checkedindate ");
            sql.Append(" where isbn = @isbn and grade = @grade and libraryCardNumber = @librarycardnumber");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("checkedindate", exchangeUpdateSdi.CheckedInDate);
            command.Parameters.AddWithValue("isbn", exchangeUpdateSdi.Isbn);
            command.Parameters.AddWithValue("grade", exchangeUpdateSdi.Grade);
            command.Parameters.AddWithValue("librarycardnumber", exchangeUpdateSdi.LibraryCardNumber);
            command.ExecuteNonQuery();
            con.Close();
            return this.getExchangeByKey(exchangeUpdateSdi.LibraryCardNumber, exchangeUpdateSdi.Isbn, exchangeUpdateSdi.Grade);
        }
    }
}
