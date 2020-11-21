using btl_qltv_ver2.DBConnection;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_qltv_ver2.repos.impl
{
    class AuthorRepoImpl : AuthorRepoService
    {
        private SqlConnection con;

        public string deleteAuthor(string authorId)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from Author where AuthorId = @authorid");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("authorid", authorId);
            command.ExecuteNonQuery();
            con.Close();
            return authorId;
        }

        public List<Author> filterAuthors(string firstName, string midName, string lastName)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            List<Author> authors = new List<Author>();
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> param = new Dictionary<String, Object>();
            sql.Append("select  AuthorId," +
                                " CONCAT(fName,' ',mName,' ',lName) as name," +
                               " DOB from Author");
            sql.Append(" where 1 = 1 ");

            if ((firstName == null || "".Equals(firstName)) &&
                (lastName == null || "".Equals(lastName)) &&
                (midName == null || "".Equals(midName)))
            {
                
            }
            else
            {
                sql.Append("and ( 1 = 2");
            }
            if ((firstName != null && !"".Equals(firstName)) )
            {
                firstName = "%" + firstName + "%";
                sql.Append("or fname like @fname ");
                param.Add("fname", firstName );
            }
            else
            {

            }

            if (midName != null && !"".Equals(midName))
            {
                midName = "%" + midName + "%";
                sql.Append(" or mName like @mname ");
                param.Add("mname", midName);
            }
            if (lastName != null && !"".Equals(lastName))
            {
                lastName = "%" + lastName + "%";
                sql.Append(" or lName like @lname ");
                param.Add("lname", lastName);
            }



            if ((firstName == null || "".Equals(firstName)) &&
                (lastName == null || "".Equals(lastName)) &&
                (midName == null || "".Equals(midName)))
            {

            }
            else
            {
                sql.Append(")");
            }

            SqlCommand command = new SqlCommand(sql.ToString(), con);
            foreach (KeyValuePair<String, Object> item in param)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                Author author = new Author();
                author.AuthorId = data.GetString(0);
                author.Name = data.GetString(1);
                author.DOB1 = data.GetDateTime(2);
                authors.Add(author);
            }
            data.Close();
            con.Close();
            return authors;
        }

        public List<string> filterById(string authorId)
        {
            return null;
        }

        public Author getAuthorById(string AuthorId)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            Author author = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("select  " +
                               " CONCAT(fName,' ',mName,' ',lName) as name," +
                               " DOB from Author where AuthorId = @authorid");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("authorid", AuthorId);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                author = new Author();
                author.Name = data.GetString(0);
                author.DOB1 = data.GetDateTime(1);
            }
            data.Close();
            con.Close();
            if (author != null)
            {
                author.AuthorId = AuthorId;
            }
            return author;
        }

        public List<Author> getAuthors()
        {
            con = SqlServerConnection.getConnnection();
            List<Author> authors = new List<Author>();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select  AuthorId," +
                                " CONCAT(fName,' ',mName,' ',lName) as name," +
                               " DOB from Author");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                Author author = new Author();
                author.AuthorId = data.GetString(0);
                author.Name = data.GetString(1);
                author.DOB1 = data.GetDateTime(2);
                authors.Add(author);
            }
            data.Close();
            con.Close();
            return authors;
        }

        public Author insertAuthor(AuthorInsertSdi authorInsertSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into Author values(@authorid,@fname,@mname,@lname,@dob)");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("authorid", authorInsertSdi.AuthorId);
            command.Parameters.AddWithValue("fname", authorInsertSdi.Fname);
            command.Parameters.AddWithValue("mname", authorInsertSdi.Mname);
            command.Parameters.AddWithValue("lname", authorInsertSdi.Lname);
            command.Parameters.AddWithValue("dob", DateTime.Parse(authorInsertSdi.DOB1));
            command.ExecuteNonQuery();
            con.Close();
            return this.getAuthorById(authorInsertSdi.AuthorId);
        }

        public bool isExistAuthor(string authorId)
        {
            if (this.getAuthorById(authorId) != null)
            {
                return true;
            }
            return false;
        }

        public List<Author> searchAuthors(AuthorSearchSdi authorSearchSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            List<Author> authors = new List<Author>();
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> param = new Dictionary<String, Object>();
            sql.Append("select  AuthorId," +
                                " CONCAT(fName,' ',mName,' ',lName) as name," +
                               " DOB from Author");
            sql.Append(" where 1 = 1 ");
            if (authorSearchSdi.AuthorId != null && !"".Equals(authorSearchSdi.AuthorId))
            {
                sql.Append(" and AuthorId = @authorid ");
                param.Add("authorid", authorSearchSdi.AuthorId);
            }

            if (authorSearchSdi.Fname != null && !"".Equals(authorSearchSdi.Fname))
            {
                sql.Append(" and fName = @fname ");
                param.Add("fname", authorSearchSdi.Fname);
            }
            if (authorSearchSdi.Lname != null && !"".Equals(authorSearchSdi.Lname))
            {
                sql.Append(" and lName = @lname ");
                param.Add("lname", authorSearchSdi.Lname);
            }

            if (authorSearchSdi.Mname != null && !"".Equals(authorSearchSdi.Mname))
            {
                sql.Append(" and mName = @mname ");
                param.Add("mname", authorSearchSdi.Mname);
            }

            SqlCommand command = new SqlCommand(sql.ToString(), con);
            foreach (KeyValuePair<String, Object> item in param)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                Author author = new Author();
                author.AuthorId = data.GetString(0);
                author.Name = data.GetString(1);
                author.DOB1 = data.GetDateTime(2);
                authors.Add(author);
            }
            data.Close();
            con.Close();
            return authors;
        }

        public Author updateAuthor(AuthorUpdateSdi sdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append(" update Author  set " +
                                         "fName = @fname," +
                                         "lName = @lname," +
                                         "mName = @mname," +
                                         "DOB = @dob ");
            sql.Append(" where AuthorId = @authorid");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("fname", sdi.Fname);
            command.Parameters.AddWithValue("mname", sdi.Mname);
            command.Parameters.AddWithValue("lname", sdi.Lname);
            command.Parameters.AddWithValue("dob", DateTime.Parse(sdi.DOB1));
            command.Parameters.AddWithValue("authorid", sdi.AuthorId);
            command.ExecuteNonQuery();
            con.Close();
            return this.getAuthorById(sdi.AuthorId);
        }
    }
}
