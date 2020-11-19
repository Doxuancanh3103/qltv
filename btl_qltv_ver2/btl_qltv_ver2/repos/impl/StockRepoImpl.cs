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
    class StockRepoImpl : StockRepoService
    {
        private SqlConnection con;
        public string deleteStock(string grade, int isbn)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from Stock where grade = @grade and isbn = @isbn");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("grade", grade);
            command.Parameters.AddWithValue("isbn", isbn);
            command.ExecuteNonQuery();
            con.Close();
            return grade + isbn.ToString();
        }

        public Stock getStockByCode(string grade, int isbn)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            Stock stock = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("select isbn,grade,amount,ordercost from Stock where isbn = @isbn and grade = @grade ");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("isbn", isbn);
            command.Parameters.AddWithValue("grade", grade);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                stock = new Stock();
                stock.Isbn = data.GetInt32(0);
                stock.Grade = data.GetString(1);
                stock.Amount = data.GetInt64(2);
                stock.OrderCost = data.GetSqlMoney(3).ToDouble();
            }
            data.Close();
            con.Close();
            if (stock != null)
            {
                stock.Isbn = isbn;
                stock.Grade = grade;
            }
            return stock;
        }

        public List<Stock> getStocks()
        {
            con = SqlServerConnection.getConnnection();
            List<Stock> stocks = new List<Stock>();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select isbn,grade,amount,ordercost from Stock");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                Stock stock = new Stock();
                stock.Isbn = data.GetInt32(0);
                stock.Grade = data.GetString(1);
                stock.Amount = data.GetInt64(2);
                stock.OrderCost = data.GetSqlMoney(3).ToDouble();
                stocks.Add(stock);
            }
            data.Close();
            con.Close();
            return stocks;
        }

        public Stock insertStock(StockInsertSdi stockInsertSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into Stock values(@isbn,@grade,@amount,@ordercost)");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("isbn", stockInsertSdi.Isbn);
            command.Parameters.AddWithValue("grade", stockInsertSdi.Grade);
            command.Parameters.AddWithValue("amount", stockInsertSdi.Amount);
            command.Parameters.AddWithValue("ordercost", stockInsertSdi.OrderCost);
            command.ExecuteNonQuery();
            con.Close();
            return this.getStockByCode(stockInsertSdi.Grade, stockInsertSdi.Isbn);
        }

        public bool isExistStock(string grade, int isbn)
        {
            if (this.getStockByCode(grade,isbn) != null)
            {
                return true;
            }
            return false;
        }

        public Stock updateStock(StockUpdateSdi stockUpdateSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append(" update Stock  set " +
                                         " amount = @amount, " +
                                         " ordercost = @ordercost ");
            sql.Append(" where isbn = @isbn and grade = @grade");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("amount", stockUpdateSdi.Amount);
            command.Parameters.AddWithValue("ordercost", stockUpdateSdi.OrderCost);
            command.Parameters.AddWithValue("isbn", stockUpdateSdi.Isbn);
            command.Parameters.AddWithValue("grade", stockUpdateSdi.Grade);
            command.ExecuteNonQuery();
            con.Close();
            return this.getStockByCode(stockUpdateSdi.Grade, stockUpdateSdi.Isbn);
        }
    }
}
