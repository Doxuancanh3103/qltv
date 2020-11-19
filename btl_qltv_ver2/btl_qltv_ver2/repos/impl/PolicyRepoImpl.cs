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
    class PolicyRepoImpl : PolicyRepoService
    {
        private SqlConnection con;
        public string deletePolicy(string description)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from Policies where description = @description");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("description", description);
            command.ExecuteNonQuery();
            con.Close();
            return description;
        }

        public List<Policy> getPolicies()
        {
            con = SqlServerConnection.getConnnection();
            List<Policy> policies = new List<Policy>();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select description,value from policies");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                Policy policy = new Policy();
                policy.Description = data.GetString(0);
                policy.Value = data.GetSqlDecimal(1).ToDouble();
                policies.Add(policy);
            }
            data.Close();
            con.Close();
            return policies;
        }

        public Policy getPolicyByDescription(string description)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            Policy policy = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("select description,value from policies where description = @description ");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("description", description);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                policy = new Policy();
                policy.Description = data.GetString(0);
                policy.Value = data.GetSqlDecimal(1).ToDouble();
            }
            data.Close();
            con.Close();
            if (policy != null)
            {
                policy.Description = description;
            }
            return policy;
        }

        public Policy insertPolicy(PolicyInsertSdi policyInsertSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into Policies values(@description,@value)");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("description", policyInsertSdi.Description);
            command.Parameters.AddWithValue("value", policyInsertSdi.Value);
            command.ExecuteNonQuery();
            con.Close();
            return this.getPolicyByDescription(policyInsertSdi.Description);
        }

        public bool isExistPolicy(string description)
        {
            if (this.getPolicyByDescription(description) != null)
            {
                return true;
            }
            return false;
        }

        public Policy updatePolicy(PolicyUpdateSdi policyUpdateSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append(" update Policies  set " +
                                         " value = @value ");
            sql.Append(" where description = @description");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("value", policyUpdateSdi.Value);
            command.Parameters.AddWithValue("description", policyUpdateSdi.Description);
            command.ExecuteNonQuery();
            con.Close();
            return this.getPolicyByDescription(policyUpdateSdi.Description);
        }
    }
}
