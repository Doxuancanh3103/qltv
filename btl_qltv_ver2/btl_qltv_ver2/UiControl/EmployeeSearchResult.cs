using btl_qltv_ver2.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_qltv_ver2.UiControl
{
    public partial class EmployeeSearchResult : Form
    {
        private List<Employee> employees;
        public EmployeeSearchResult()
        {
            InitializeComponent();
        }

        internal List<Employee> Employees { get => employees; set => employees = value; }

        private void EmployeeSearchResult_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < employees.Count(); i++)
            {
                employeeTable.Rows.Add(new String[] {"detail",employees[i].EmployeeId1,
                                                    employees[i].SSN1,
                                                    employees[i].Name,
                                                    employees[i].Salary.ToString(),
                                                    employees[i].DOB1.ToString(),
                                                    employees[i].Address,
                                                    employees[i].PhoneNumber,
                                                    employees[i].RoleType});
            }
        }
    }
}
