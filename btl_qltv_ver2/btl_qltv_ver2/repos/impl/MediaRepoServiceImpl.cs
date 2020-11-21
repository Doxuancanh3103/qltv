using btl_qltv_ver2.common;
using btl_qltv_ver2.DBConnection;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using btl_qltv_ver2.sdo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.repos.impl
{
    class MediaRepoServiceImpl : MediaRepoService
    {
        SqlConnection con;

        public int deleteMedia(int isbn)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from Media where isbn = " + isbn);
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.ExecuteNonQuery();
            con.Close();
            return isbn;
        }

        public List<Media> filterMedias(string obj, string sender)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            List<Media> medias = new List<Media>();
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> param = new Dictionary<String, Object>();
            sql.Append("select isbn,title,year,publisher,type,subject from Media ");
            sql.Append(" where 1 = 1 ");
            if ("1".Equals(sender))
            {
                obj = "%" + obj + "%";
                sql.Append(" and title like @obj");
                param.Add("obj", obj);
            }
            else if ("2".Equals(sender))
            {
                obj = "%" + obj + "%";
                sql.Append(" and publisher like @obj");
                param.Add("obj", obj);
            }
            else if ("3".Equals(sender))
            {
                obj = "%" + obj + "%";
                sql.Append(" and type like @obj");
                param.Add("obj", obj);
            }
            else
            {
                obj = "%" + obj + "%";
                sql.Append(" and subject like @obj");
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
                Media media = new Media();
                media.Isbn = data.GetInt32(0);
                media.Title = data.GetString(1);
                media.Year = data.GetDateTime(2);
                media.Publisher = data.GetString(3);
                media.Type = data.GetString(4);
                media.Subject = data.GetString(5);
                medias.Add(media);
            }
            data.Close();
            con.Close();
            return medias;
        }

        public Media getMediaByIsbn(int isbn)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            Media media = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("select title,year,publisher,type,subject from Media where isbn = " + isbn);
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                media = new Media();
                media.Title = data.GetString(0);
                media.Year = data.GetDateTime(1);
                media.Publisher = data.GetString(2);
                media.Type = data.GetString(3);
                media.Subject = data.GetString(4);
            }
            data.Close();
            con.Close();
            if (media != null)
            {
                media.Isbn = isbn;
            }
            return media;
        }

        public List<Media> getMedias()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select isbn,title,year,publisher,type,subject from Media");
            List<Media> medias = new List<Media>();
            con = SqlServerConnection.getConnnection();
            con.Open();
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                Media media = new Media();
                media.Isbn = data.GetInt32(0);
                media.Title = data.GetString(1);
                media.Year = data.GetDateTime(2);
                media.Publisher = data.GetString(3);
                media.Type = data.GetString(4);
                media.Subject = data.GetString(5);
                medias.Add(media);
            }
            data.Close();
            con.Close();
            return medias;
        }

        public Media insertMedia(MediaInsertSdi mediaInsertSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into Media values(@isbn,@title,@year,@publisher,@type,@subject)");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("isbn", mediaInsertSdi.Isbn);
            command.Parameters.AddWithValue("title", mediaInsertSdi.Title);
            command.Parameters.AddWithValue("year", DateTime.Parse(mediaInsertSdi.Year));
            command.Parameters.AddWithValue("publisher", mediaInsertSdi.Publisher);
            command.Parameters.AddWithValue("type", mediaInsertSdi.Type);
            command.Parameters.AddWithValue("subject", mediaInsertSdi.Subject);
            command.ExecuteNonQuery();
            con.Close();
            return this.getMediaByIsbn(mediaInsertSdi.Isbn);
        }

        public List<Media> searchMedia(MediaSearchSdi mediaSearchSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            List<Media> medias = new List<Media>();
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> param = new Dictionary<String, Object>();
            sql.Append(" select isbn,title,year,publisher,type,subject from Media ");
            sql.Append(" where 1 = 1 ");
            if (mediaSearchSdi.Isbn != -1)
            {
                sql.Append(" and isbn = @isbn ");
                param.Add("isbn", mediaSearchSdi.Isbn);
            }

            if (mediaSearchSdi.Title != null && !"".Equals(mediaSearchSdi.Title))
            {
                sql.Append(" and title = @title ");
                param.Add("title", mediaSearchSdi.Title);
            }
            if (mediaSearchSdi.Publisher != null && !"".Equals(mediaSearchSdi.Publisher))
            {
                sql.Append(" and publisher = @publisher ");
                param.Add("publisher", mediaSearchSdi.Publisher);
            }

            if (mediaSearchSdi.Type != null && !"".Equals(mediaSearchSdi.Type))
            {
                sql.Append(" and type = @type ");
                param.Add("type", mediaSearchSdi.Type);
            }

            if (mediaSearchSdi.Subject != null && !"".Equals(mediaSearchSdi.Subject))
            {
                sql.Append(" and subject = @subject ");
                param.Add("subject", mediaSearchSdi.Subject);
            }

            SqlCommand command = new SqlCommand(sql.ToString(), con);
            foreach (KeyValuePair<String, Object> item in param)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                Media media = new Media();
                media.Isbn = data.GetInt32(0);
                media.Title = data.GetString(1);
                media.Year = data.GetDateTime(2);
                media.Publisher = data.GetString(3);
                media.Type = data.GetString(4);
                media.Subject = data.GetString(5);
                medias.Add(media);
            }
            data.Close();
            con.Close();
            return medias;
        }

        public Media updateMedia(MediaUpdateSdi mediaUpdateSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append(" update Media  set title = @title," +
                                         "year = @year," +
                                         "publisher = @publisher," +
                                         "type = @type," +
                                         "subject = @subject");
            sql.Append(" where isbn = @isbn");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("isbn", mediaUpdateSdi.Isbn);
            command.Parameters.AddWithValue("title", mediaUpdateSdi.Title);
            command.Parameters.AddWithValue("year", DateTime.Parse(mediaUpdateSdi.Year));
            command.Parameters.AddWithValue("publisher", mediaUpdateSdi.Publisher);
            command.Parameters.AddWithValue("type", mediaUpdateSdi.Type);
            command.Parameters.AddWithValue("subject", mediaUpdateSdi.Subject);
            command.ExecuteNonQuery();
            con.Close();
            return this.getMediaByIsbn(mediaUpdateSdi.Isbn);
        }
    }
}
