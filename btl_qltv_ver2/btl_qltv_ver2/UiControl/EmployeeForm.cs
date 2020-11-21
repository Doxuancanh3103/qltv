using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.Service;
using btl_qltv_ver2.Bean;

namespace btl_qltv_ver2.UiControl
{
    public partial class EmployeeForm : UserControl
    {
        EmployeeService employeeService;
        public EmployeeForm()
        {
            InitializeComponent();
            employeeService = EmployeeServiceBean.getBean();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            EmployeeInsertUpdateSearchForm employeeInsertUpdateSearchForm = new EmployeeInsertUpdateSearchForm(this);
            employeeInsertUpdateSearchForm.changeEnableUpdate(false);
            employeeInsertUpdateSearchForm.changeEnableSearch(false);
            employeeInsertUpdateSearchForm.visibleAccount();
            employeeInsertUpdateSearchForm.ShowDialog();
        }

        public void loadDataToTable()
        {
            employeeTable.Rows.Clear();
            List<Employee> employees = employeeService.getEmployees();
            for (int i = 0; i < employees.Count(); i++)
            {
                employeeTable.Rows.Add(new String[] {"detail",employees[i].EmployeeId1,
                                                    employees[i].SSN1,
                                                    employees[i].Name,
                                                    employees[i].Salary.ToString(),
                                                    employees[i].DOB1.ToString(),
                                                    employees[i].Address,
                                                    employees[i].PhoneNumber,
                                                    employees[i].RoleType });
            }

        }

        public void addDataToTable(Object obj)
        {
            Employee employee = (Employee)obj;
            employeeTable.Rows.Add(new String[] {"detail",employee.EmployeeId1,
                                                    employee.SSN1,
                                                    employee.Name,
                                                    employee.Salary.ToString(),
                                                    employee.DOB1.ToString(),
                                                    employee.Address,
                                                    employee.PhoneNumber,
                                                    employee.RoleType});
        }

        public void updateDataToTable(Object obj)
        {
            Employee employee = (Employee)obj;
            employeeTable.CurrentRow.Cells[2].Value = employee.SSN1;
            employeeTable.CurrentRow.Cells[3].Value = employee.Name;
            employeeTable.CurrentRow.Cells[4].Value = employee.Salary;
            employeeTable.CurrentRow.Cells[5].Value = employee.DOB1.ToString();
            employeeTable.CurrentRow.Cells[6].Value = employee.Address;
            employeeTable.CurrentRow.Cells[7].Value = employee.PhoneNumber;
            employeeTable.CurrentRow.Cells[8].Value = employee.RoleType;
        }

        private void update_Click(object sender, EventArgs e)
        {
            EmployeeInsertUpdateSearchForm employeeInsertUpdateSearch = new EmployeeInsertUpdateSearchForm(this);
            employeeInsertUpdateSearch.changeEnableInsert(false);
            employeeInsertUpdateSearch.changeEnableSearch(false);
            if (employeeTable.CurrentRow != null)
            {
                String employeeId = employeeTable.CurrentRow.Cells[1].Value.ToString();
                String ssn = employeeTable.CurrentRow.Cells[2].Value.ToString();
                String name = employeeTable.CurrentRow.Cells[3].Value.ToString();
                String salary = employeeTable.CurrentRow.Cells[4].Value.ToString();
                String dob = employeeTable.CurrentRow.Cells[5].Value.ToString();
                String address = employeeTable.CurrentRow.Cells[6].Value.ToString();
                String phoneNumber = employeeTable.CurrentRow.Cells[7].Value.ToString();
                String roletype = employeeTable.CurrentRow.Cells[8].Value.ToString();
                employeeInsertUpdateSearch.changeEnableLibraryCardNumberTextBox(false);
                employeeInsertUpdateSearch.setData(employeeId, ssn, name, salary, dob, address, phoneNumber, roletype);
            }
            employeeInsertUpdateSearch.hideAccount();
            employeeInsertUpdateSearch.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            EmployeeInsertUpdateSearchForm employeeInsertUpdateSearch = new EmployeeInsertUpdateSearchForm(this);
            employeeInsertUpdateSearch.changeEnableInsert(false);
            employeeInsertUpdateSearch.changeEnableUpdate(false);
            employeeInsertUpdateSearch.changeEnableDateTimePicker(false);
            employeeInsertUpdateSearch.hidePassword();
            employeeInsertUpdateSearch.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeeService.deleteEmployee(employeeTable.CurrentRow.Cells[1].Value.ToString());
            employeeTable.Rows.Remove(employeeTable.CurrentRow);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void changeEnableInsert(bool change)
        {
            insert.Enabled = change;
        }

        public void changeEnableUpdate(bool change)
        {
            update.Enabled = change;
        }

        public void changeEnableDelete(bool change)
        {
            delete.Enabled = change;
        }

        private void filterTextBox_OnValueChanged(object sender, EventArgs e)
        {
            List<Employee> employees = employeeService.filterEmployees(filterTextBox.Text, filterEmployeeForm1.selected());
            this.loadDataToTableFilter(employees);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filterEmployeeForm1.Location = new Point(filterButton.Location.X - 150, tableLayoutPanel1.Location.Y - 200);

            filterEmployeeForm1.Visible = true;
        }

        public void loadDataToTableFilter(Object obj)
        {
            employeeTable.Rows.Clear();

            List<Employee> employees = (List<Employee>)obj;
            for (int i = 0; i < employees.Count(); i++)
            {
                employeeTable.Rows.Add(new String[] {"detail",employees[i].EmployeeId1,
                                                    employees[i].SSN1,
                                                    employees[i].Name,
                                                    employees[i].Salary.ToString(),
                                                    employees[i].DOB1.ToString(),
                                                    employees[i].Address,
                                                    employees[i].PhoneNumber,
                                                    employees[i].RoleType });
            }

        }
    }
}
