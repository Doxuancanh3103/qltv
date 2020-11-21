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
    class EmployeeRepoImpl : EmployeeRepoService
    {
        private SqlConnection con;

        public String deleteEmployee(string employeeid)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from Employee where EmplID = @employeeid");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("employeeid", employeeid);
            command.ExecuteNonQuery();
            con.Close();
            return employeeid;
        }

        public List<Employee> filterEmployees(string obj,string sender)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            List<Employee> employees = new List<Employee>();
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> param = new Dictionary<String, Object>();
            sql.Append("select  ssn," +
                                 " CONCAT(fName,' ',mName,' ',lName) as name," +
                                " DOB," +
                                " salary," +
                                " roletype," +
                                " phoneNumber," +
                                " Address from Employee ");
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
                Employee employee = new Employee();
                employee.SSN1 = data.GetString(0);
                employee.Name = data.GetString(1);
                employee.DOB1 = data.GetDateTime(2);
                employee.Salary = data.GetSqlMoney(3).ToDouble();
                employee.RoleType = data.GetString(4);
                employee.PhoneNumber = data.GetString(5);
                employee.Address = data.GetString(6);
                employees.Add(employee);
            }
            data.Close();
            con.Close();
            return employees;
        }

        public Employee getEmployeeById(string employeeId)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            Employee employee = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("select  ssn," +
                                " CONCAT(fName,' ',mName,' ',lName) as name," +
                               " DOB," +
                               " salary," +
                               " roletype," +
                               " phoneNumber," +
                               " Address from Employee where EmplID = @employeeid" );
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("employeeid", employeeId);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                employee = new Employee();
                employee.SSN1 = data.GetString(0);
                employee.Name = data.GetString(1);
                employee.DOB1 = data.GetDateTime(2);
                employee.Salary = data.GetSqlMoney(3).ToDouble();
                employee.RoleType = data.GetString(4);
                employee.PhoneNumber = data.GetString(5);
                employee.Address = data.GetString(6);
            }
            data.Close();
            con.Close();
            if (employee != null)
            {
                employee.EmployeeId1 = employeeId;
            }
            return employee;
        }

        public List<Employee> getEmployees()
        {
            con = SqlServerConnection.getConnnection();
            List<Employee> employees = new List<Employee>();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select  emplID," +
                                " ssn," +
                                " CONCAT(fName,' ',mName,' ',lName) as name," +
                               " DOB," +
                               " salary," +
                               " roletype," +
                               " phoneNumber," +
                               " Address from Employee");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId1 = data.GetString(0);
                employee.SSN1 = data.GetString(1);
                employee.Name = data.GetString(2);
                employee.DOB1 = data.GetDateTime(3);
                employee.Salary = data.GetSqlMoney(4).ToDouble();
                employee.RoleType = data.GetString(5);
                employee.PhoneNumber = data.GetString(6);
                employee.Address = data.GetString(7);
                employees.Add(employee);
            }
            data.Close();
            con.Close();
            return employees;
        }

        public Employee insertEmployee(EmployeeInsertSdi employeeInsertSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into Employee values(@employeeid,@ssn,@fname,@mname,@lname,@salary,@dob,@address,@phonenumber,@roletype,@username,@password)");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("employeeid", employeeInsertSdi.EmployeeId1);
            command.Parameters.AddWithValue("ssn", employeeInsertSdi.SSN1);
            command.Parameters.AddWithValue("fname", employeeInsertSdi.Fname);
            command.Parameters.AddWithValue("mname", employeeInsertSdi.Mname);
            command.Parameters.AddWithValue("lname", employeeInsertSdi.Lname);
            command.Parameters.AddWithValue("dob", DateTime.Parse(employeeInsertSdi.DOB1));
            command.Parameters.AddWithValue("phonenumber", employeeInsertSdi.PhoneNumber);
            command.Parameters.AddWithValue("address", employeeInsertSdi.Address);
            command.Parameters.AddWithValue("username", employeeInsertSdi.Username);
            command.Parameters.AddWithValue("password", employeeInsertSdi.Password);
            command.Parameters.AddWithValue("salary", employeeInsertSdi.Salary);
            command.Parameters.AddWithValue("roletype", employeeInsertSdi.RoleType);
            command.ExecuteNonQuery();
            con.Close();
            return this.getEmployeeById(employeeInsertSdi.EmployeeId1);
        }

        public bool isExistAccount(string username)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from Employee where Eusername = @username");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("username", username);
            SqlDataReader data = command.ExecuteReader();

            StringBuilder sql1 = new StringBuilder();
            if (data.HasRows)
            {
                return true;
            }
            data.Close();
            con.Close();
            return false;
        }

        public bool isExistSSN(string ssn)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append("select ssn from employee where ssn = @ssn");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("ssn", ssn);
            SqlDataReader data = command.ExecuteReader();
            if (data.HasRows)
            {
                con.Close();
                data.Close();
                return true;
            }
            con.Close();
            data.Close();
            return false;
        }

        public List<Employee> searchEmployees(EmployeeSearchSdi employeeSearchSdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            List<Employee> employees = new List<Employee>();
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> param = new Dictionary<String, Object>();
            sql.Append("select  emplID," +
                                " ssn," +
                                " CONCAT(fName,' ',mName,' ',lName) as name," +
                               " DOB," +
                               " salary," +
                               " roletype," +
                               " phoneNumber," +
                               " Address from Employee");
            sql.Append(" where 1 = 1 ");
            if (employeeSearchSdi.EmployeeId1 != null && !"".Equals(employeeSearchSdi.EmployeeId1))
            {
                sql.Append(" and libraryCardNumber = @librarycardnumber ");
                param.Add("librarycardnumber", employeeSearchSdi.EmployeeId1);
            }

            if (employeeSearchSdi.Fname != null && !"".Equals(employeeSearchSdi.Fname))
            {
                sql.Append(" and fName = @fname ");
                param.Add("fname", employeeSearchSdi.Fname);
            }
            if (employeeSearchSdi.Lname != null && !"".Equals(employeeSearchSdi.Lname))
            {
                sql.Append(" and lName = @lname ");
                param.Add("lname", employeeSearchSdi.Lname);
            }

            if (employeeSearchSdi.Mname != null && !"".Equals(employeeSearchSdi.Mname))
            {
                sql.Append(" and mName = @mname ");
                param.Add("mname", employeeSearchSdi.Mname);
            }

            if (employeeSearchSdi.Address != null && !"".Equals(employeeSearchSdi.Address))
            {
                sql.Append(" and Address = @address ");
                param.Add("address", employeeSearchSdi.Address);
            }

            if (employeeSearchSdi.PhoneNumber != null && !"".Equals(employeeSearchSdi.PhoneNumber))
            {
                sql.Append(" and phoneNumber = @phonenumber ");
                param.Add("phonenumber", employeeSearchSdi.PhoneNumber);
            }

            if (employeeSearchSdi.Username != null && !"".Equals(employeeSearchSdi.Username))
            {
                sql.Append(" and Pusername = @username ");
                param.Add("username", employeeSearchSdi.Username);
            }

            if (employeeSearchSdi.SSN1 != null && !"".Equals(employeeSearchSdi.SSN1))
            {
                sql.Append(" and ssn = @ssn ");
                param.Add("ssn", employeeSearchSdi.SSN1);
            }

            if (employeeSearchSdi.RoleType != null && !"".Equals(employeeSearchSdi.RoleType))
            {
                sql.Append(" and roletype = @roletype ");
                param.Add("roletype", employeeSearchSdi.RoleType);
            }

            SqlCommand command = new SqlCommand(sql.ToString(), con);
            foreach (KeyValuePair<String, Object> item in param)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId1 = data.GetString(0);
                employee.SSN1 = data.GetString(1);
                employee.Name = data.GetString(2);
                employee.DOB1 = data.GetDateTime(3);
                employee.Salary = data.GetSqlMoney(4).ToDouble();
                employee.RoleType = data.GetString(5);
                employee.PhoneNumber = data.GetString(6);
                employee.Address = data.GetString(7);
                employees.Add(employee);
            }
            data.Close();
            con.Close();
            return employees;
        }

        public Employee updateEmployee(EmployeeUpdateSdi sdi)
        {
            con = SqlServerConnection.getConnnection();
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.Append(" update Employee  set ssn = @ssn," +
                                         "fName = @fname," +
                                         "lName = @lname," +
                                         "mName = @mname," +
                                         "Salary = @salary," +
                                         "DOB = @dob," +
                                         "Address = @address," +
                                         "phoneNumber = @phonenumber," +
                                         "roleType = @roletype ");
            sql.Append(" where EmplID = @employeeid");
            SqlCommand command = new SqlCommand(sql.ToString(), con);
            command.Parameters.AddWithValue("ssn", sdi.SSN1);
            command.Parameters.AddWithValue("roletype", sdi.RoleType);
            command.Parameters.AddWithValue("fname", sdi.Fname);
            command.Parameters.AddWithValue("mname", sdi.Mname);
            command.Parameters.AddWithValue("lname", sdi.Lname);
            command.Parameters.AddWithValue("dob", DateTime.Parse(sdi.DOB1));
            command.Parameters.AddWithValue("phonenumber", sdi.PhoneNumber);
            command.Parameters.AddWithValue("address", sdi.Address);
            command.Parameters.AddWithValue("employeeid", sdi.EmployeeId1);
            command.Parameters.AddWithValue("salary", sdi.Salary);
            command.ExecuteNonQuery();
            con.Close();
            return this.getEmployeeById(sdi.EmployeeId1);
        }
    }
}
