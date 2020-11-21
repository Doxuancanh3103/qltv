using btl_qltv_ver2.Bean;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using btl_qltv_ver2.Service;
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
    public partial class EmployeeInsertUpdateSearchForm : Form
    {
        EmployeeService employeeService;
        EmployeeForm employeeForm;
        PatronService patronService;
        public EmployeeInsertUpdateSearchForm(EmployeeForm employeeForm)
        {
            InitializeComponent();
            employeeService = EmployeeServiceBean.getBean();
            this.employeeForm = employeeForm;
            patronService = PatronServiceBean.getBean();
        }

        internal PatronInsertSdi EmployeeInsertSdi { get; private set; }

        private void insertCustom_Click(object sender, EventArgs e)
        {
            if (!passwordTextBox.Text.Equals(retypePasswordTextBox.Text))
            {
                MessageBox.Show("retype password does not match", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (employeeService.isExistAccount(usernameTextBox.Text))
            {
                MessageBox.Show("username already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (employeeService.isExistSSN(ssnTextBox.Text))
            {
                MessageBox.Show("ssn already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (patronService.isExistAccount(usernameTextBox.Text))
            {
                MessageBox.Show("username already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EmployeeInsertSdi employeeInsertSdi = new EmployeeInsertSdi();
                employeeInsertSdi.EmployeeId1 = employeeIdTextBox.Text;
                employeeInsertSdi.Fname = fnameTextBox.Text;
                employeeInsertSdi.Lname = lnameTextBox.Text;
                employeeInsertSdi.Mname = mnameTextBox.Text;
                employeeInsertSdi.DOB1 = dobTextBox.Value.ToString();
                employeeInsertSdi.PhoneNumber = phoneNumberTextBox.Text;
                employeeInsertSdi.Username = usernameTextBox.Text;
                employeeInsertSdi.Address = addressTextBox.Text;
                employeeInsertSdi.Password = passwordTextBox.Text;
                employeeInsertSdi.RoleType = roleTypeTextBox.Text;
                employeeInsertSdi.SSN1 = ssnTextBox.Text;
                employeeInsertSdi.Salary = Convert.ToDouble(salaryTextBox.Text);
                Employee employee = employeeService.insertEmployee(employeeInsertSdi);
                if (employee != null)
                {
                    this.Close();
                    employeeForm.addDataToTable(employee);
                }
            }
        }

        private void passwordTextBox_OnValueChanged(object sender, EventArgs e)
        {
            passwordTextBox.isPassword = true;
        }

        private void retypePasswordTextBox_OnValueChanged(object sender, EventArgs e)
        {
            retypePasswordTextBox.isPassword = true;
        }

        public void changeEnableInsert(Boolean change)
        {
            insertCustom.Visible = change;
        }

        public void changeEnableUpdate(Boolean change)
        {
            updateCustom.Visible = change;
        }

        public void changeEnableDateTimePicker(Boolean change)
        {
            dobLabel.Visible = change;
            dobTextBox.Visible = change;
        }

        private void bunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {
            passwordTextBox.isPassword = true;
        }


        public void changeEnableLibraryCardNumberTextBox(Boolean change)
        {
            employeeIdTextBox.Enabled = change;
        }

        public void changeEnableSearch(Boolean change)
        {
            search.Visible = change;
        }

        public void setData(String employeeId,String ssn, String name,String salary, String dob, String address,String phoneNumber, String roletype)
        {
            String[] names = name.Split(' ');
            String _mName = names[1];
            for (int i = 2; i < names.Length - 1; i++)
            {
                _mName += " " + names[i];
            }
            employeeIdTextBox.Text = employeeId;
            fnameTextBox.Text = names[0];
            mnameTextBox.Text = _mName;
            lnameTextBox.Text = names[names.Length - 1];
            dobTextBox.Text = dob;
            phoneNumberTextBox.Text = phoneNumber;
            addressTextBox.Text = address;
            salaryTextBox.Text = salary;
            ssnTextBox.Text = ssn;
            roleTypeTextBox.Text = roletype;
        }

        public void hideAccount()
        {
            usernameLabel.Visible = false;
            passwordLabel.Visible = false;
            retypePasswordLabel.Visible = false;
            usernameTextBox.Visible = false;
            passwordTextBox.Visible = false;
            retypePasswordTextBox.Visible = false;
        }

        public void visibleAccount()
        {
            usernameLabel.Visible = true;
            passwordLabel.Visible = true;
            retypePasswordLabel.Visible = true;
            usernameTextBox.Visible = true;
            passwordTextBox.Visible = true;
            retypePasswordTextBox.Visible = true;
        }

        public void hidePassword()
        {
            passwordLabel.Visible = false;
            retypePasswordLabel.Visible = false;
            passwordTextBox.Visible = false;
            retypePasswordTextBox.Visible = false;
        }

        private void updateCustom_Click(object sender, EventArgs e)
        {
           if (employeeService.isExistSSN(ssnTextBox.Text))
            {
                MessageBox.Show("ssn already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EmployeeUpdateSdi employeeUpdateSdi = new EmployeeUpdateSdi();
                employeeUpdateSdi.EmployeeId1 = employeeIdTextBox.Text;
                employeeUpdateSdi.SSN1 = ssnTextBox.Text;
                employeeUpdateSdi.Fname = fnameTextBox.Text;
                employeeUpdateSdi.Mname = mnameTextBox.Text;
                employeeUpdateSdi.Lname = lnameTextBox.Text;
                employeeUpdateSdi.Salary = Convert.ToDouble(salaryTextBox.Text);
                employeeUpdateSdi.DOB1 = dobTextBox.Value.ToString();
                employeeUpdateSdi.RoleType = roleTypeTextBox.Text;
                employeeUpdateSdi.PhoneNumber = phoneNumberTextBox.Text;
                employeeUpdateSdi.Address = addressTextBox.Text;
                Employee employee = employeeService.updateEmployee(employeeUpdateSdi);
                if (employee != null)
                {
                    this.Close();
                    employeeForm.updateDataToTable(employee);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            EmployeeSearchSdi employeeSearch = new EmployeeSearchSdi();
            if ("".Equals(employeeIdTextBox.Text.Trim()))
            {
                employeeSearch.EmployeeId1 = null;
            }
            else
            {
                employeeSearch.EmployeeId1 = employeeIdTextBox.Text.Trim();
            }

            if ("".Equals(fnameTextBox.Text.Trim()))
            {
                employeeSearch.Fname = null;
            }
            else
            {
                employeeSearch.Fname = fnameTextBox.Text.Trim();
            }

            if ("".Equals(mnameTextBox.Text.Trim()))
            {
                employeeSearch.Mname = null;
            }
            else
            {
                employeeSearch.Mname = mnameTextBox.Text.Trim();
            }

            if ("".Equals(lnameTextBox.Text.Trim()))
            {
                employeeSearch.Lname = null;
            }
            else
            {
                employeeSearch.Lname = lnameTextBox.Text.Trim();
            }

            if ("".Equals(phoneNumberTextBox.Text.Trim()))
            {
                employeeSearch.PhoneNumber = null;
            }
            else
            {
                employeeSearch.PhoneNumber = phoneNumberTextBox.Text.Trim();
            }

            if ("".Equals(usernameTextBox.Text.Trim()))
            {
                employeeSearch.Username = null;
            }
            else
            {
                employeeSearch.Username = usernameTextBox.Text.Trim();
            }

            if ("".Equals(addressTextBox.Text.Trim()))
            {
                employeeSearch.Address = null;
            }
            else
            {
                employeeSearch.Address = addressTextBox.Text.Trim();
            }

            if ("".Equals(ssnTextBox.Text.Trim()))
            {
                employeeSearch.SSN1 = null;
            }
            else
            {
                employeeSearch.Address = ssnTextBox.Text.Trim();
            }

            if ("".Equals(roleTypeTextBox.Text.Trim()))
            {
                employeeSearch.RoleType = null;
            }
            else
            {
                employeeSearch.RoleType = roleTypeTextBox.Text.Trim();
            }

            List<Employee> employees = employeeService.searchEmployees(employeeSearch);

            EmployeeSearchResult employeeSearchResult = new EmployeeSearchResult();
            employeeSearchResult.Employees = employees;
            employeeSearchResult.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void retypePasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void roleTypeTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void salaryTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void lnameTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void mnameTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void fnameTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel19_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel17_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void employeeIdTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ssnTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dobTextBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
