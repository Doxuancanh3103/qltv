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
    class ConditionRepoImpl : ConditionRepoService
    {
        private SqlConnection con;

        public string deleteCondition(string grade)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from Condition where grade = @grade");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("grade", grade);
            command.ExecuteNonQuery();
            con.Close();
            return grade;
        }

        public Condition getConditionByGrade(string grade)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            Condition condition = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("select grade,Cost_Percentage from Condition where grade = @grade ");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("grade", grade);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                condition = new Condition();
                condition.Grade = data.GetString(0);
                condition.Percent = data.GetInt32(1);
            }
            data.Close();
            con.Close();
            if (condition != null)
            {
                condition.Grade = grade;
            }
            return condition;
        }

        public List<Condition> getConditions()
        {
            con = SqlServerConnection.getConnnection();
            List<Condition> conditions = new List<Condition>();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select grade,Cost_Percentage from Condition");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                Condition condition = new Condition();
                condition.Grade = data.GetString(0);
                condition.Percent = data.GetInt32(1);
                conditions.Add(condition);
            }
            data.Close();
            con.Close();
            return conditions;
        }

        public Condition InsertCondition(ConditionInsertSdi conditionInsertSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into Condition values(@grade,@percent)");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("grade", conditionInsertSdi.Grade);
            command.Parameters.AddWithValue("percent", conditionInsertSdi.Percent);
            command.ExecuteNonQuery();
            con.Close();
            return this.getConditionByGrade(conditionInsertSdi.Grade);
        }

        public bool isExistCondition(string grade)
        {
            if (this.getConditionByGrade(grade) != null)
            {
                return true;
            }
            return false;
        }

        public Condition updateCondition(ConditionUpdateSdi conditionUpdateSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append(" update Condition  set " +
                                         " cost_percentage = @percent ");
            sql.Append(" where grade = @grade");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("percent", conditionUpdateSdi.Percent);
            command.Parameters.AddWithValue("grade", conditionUpdateSdi.Grade);
            command.ExecuteNonQuery();
            con.Close();
            return this.getConditionByGrade(conditionUpdateSdi.Grade);
        }
    }
}
