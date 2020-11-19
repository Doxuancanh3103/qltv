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
