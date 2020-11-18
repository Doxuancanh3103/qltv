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
    public partial class PatronInsertUpdateForm : Form
    {
        private PatronService patronService;
        private PatronForm patronForm;
        public PatronInsertUpdateForm(PatronForm patronForm)
        {
            InitializeComponent();
            patronService = PatronServiceBean.getBean();
            this.patronForm = patronForm;
        }

        private void insertCustom_Click(object sender, EventArgs e)
        {
            if (!passwordTextBox.Text.Equals(retypePasswordTextBox.Text))
            {
                MessageBox.Show("retype password does not match", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (patronService.isExistAccount(usernameTextBox.Text))
            {
                MessageBox.Show("username already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PatronInsertSdi patronInsertSdi = new PatronInsertSdi();
                patronInsertSdi.LibraryCardNumber = lcnTextBox.Text;
                patronInsertSdi.Fname = fnameTextBox.Text;
                patronInsertSdi.Lname = lnameTextBox.Text;
                patronInsertSdi.Mname = mnameTextBox.Text;
                patronInsertSdi.DOB1 = dobTextBox.Value.ToString();
                patronInsertSdi.PhoneNumber = phoneNumberTextBox.Text;
                patronInsertSdi.Username = usernameTextBox.Text;
                patronInsertSdi.Address = addressTextBox.Text;
                patronInsertSdi.Password = passwordTextBox.Text;
                Patron patron = patronService.insertPatron(patronInsertSdi);
                if (patron != null)
                {
                    this.Close();
                    patronForm.addDataToTable(patron);
                }
            }
        }

        private void updateCustom_Click(object sender, EventArgs e)
        {
            PatronUpdateSdi patronUpdateSdi = new PatronUpdateSdi();
            patronUpdateSdi.LibraryCardNumber = lcnTextBox.Text;
            patronUpdateSdi.Fname = fnameTextBox.Text;
            patronUpdateSdi.Mname = mnameTextBox.Text;
            patronUpdateSdi.Lname = lnameTextBox.Text;
            patronUpdateSdi.DOB1 = dobTextBox.Value.ToString();
            patronUpdateSdi.PhoneNumber = phoneNumberTextBox.Text;
            patronUpdateSdi.Address = addressTextBox.Text;
            Patron patron = patronService.updatePatron(patronUpdateSdi);
            if (patron != null)
            {
                this.Close();
                patronForm.updateDataToTable(patron);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void changeEnableInsert(Boolean change)
        {
            insertCustom.Visible = change;
        }

        public void changeEnableUpdate(Boolean change)
        {
            updateCustom.Visible = change;
        }

        private void bunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {
            passwordTextBox.isPassword = true;
        }

        private void retypePasswordTextBox_OnValueChanged(object sender, EventArgs e)
        {
            retypePasswordTextBox.isPassword = true;
        }

        public void changeEnableLibraryCardNumberTextBox(Boolean change)
        {
            lcnTextBox.Enabled = change;
        }

        public void changeEnableSearch(Boolean change)
        {
            search.Visible = change;
        }

        public void changeEnableDateTimePicker(Boolean change)
        {
            dobTextBox.Visible = change;
            dobLabel.Visible = change;
        }

        public void setData(String libraryCarNumber, String name, String dob, String phoneNumber, String address)
        {
            String[] names = name.Split(' ');
            String _mName = names[1];
            for (int i = 2; i < names.Length-1; i++)
            {
                _mName += " "+names[i];
            }
            lcnTextBox.Text = libraryCarNumber;
            fnameTextBox.Text = names[0];
            mnameTextBox.Text = _mName;
            lnameTextBox.Text = names[names.Length - 1];
            dobTextBox.Text = dob;
            phoneNumberTextBox.Text = phoneNumber;
            addressTextBox.Text = address;
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

        private void search_Click(object sender, EventArgs e)
        {
            PatronSearchSdi patronSearchSdi = new PatronSearchSdi();
            if ("".Equals(lcnTextBox.Text.Trim()))
            {
                patronSearchSdi.LibraryCardNumber = null;
            }
            else
            {
                patronSearchSdi.LibraryCardNumber = lcnTextBox.Text.Trim();
            }

            if ("".Equals(fnameTextBox.Text.Trim()))
            {
                patronSearchSdi.Fname = null;
            }
            else
            {
                patronSearchSdi.Fname = fnameTextBox.Text.Trim();
            }

            if ("".Equals(mnameTextBox.Text.Trim()))
            {
                patronSearchSdi.Mname = null;
            }
            else
            {
                patronSearchSdi.Mname = mnameTextBox.Text.Trim();
            }

            if ("".Equals(lnameTextBox.Text.Trim()))
            {
                patronSearchSdi.Lname = null;
            }
            else
            {
                patronSearchSdi.Lname = lnameTextBox.Text.Trim();
            }

            if ("".Equals(phoneNumberTextBox.Text.Trim()))
            {
                patronSearchSdi.PhoneNumber = null;
            }
            else
            {
                patronSearchSdi.PhoneNumber = phoneNumberTextBox.Text.Trim();
            }

            if ("".Equals(usernameTextBox.Text.Trim()))
            {
                patronSearchSdi.Username = null;
            }
            else
            {
                patronSearchSdi.Username = usernameTextBox.Text.Trim();
            }

            if ("".Equals(addressTextBox.Text.Trim()))
            {
                patronSearchSdi.Address = null;
            }
            else
            {
                patronSearchSdi.Address = addressTextBox.Text.Trim();
            }

            List<Patron> patrons = patronService.searchPatrons(patronSearchSdi);

            PatronSearchResultForm patronSearchResultForm = new PatronSearchResultForm();
            patronSearchResultForm.Patrons = patrons;
            patronSearchResultForm.ShowDialog();
        }
    }
}
