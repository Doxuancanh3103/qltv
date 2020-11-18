using btl_qltv_ver2.DBConnection;
using btl_qltv_ver2.sdi;
using btl_qltv_ver2.Service;
using btl_qltv_ver2.Service.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_qltv_ver2
{
    public partial class FormLogin : Form
    {
        private MainForm mainForm;
        private SqlConnection con;
        private LoginService loginService = new LoginServiceImpl();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            con = SqlServerConnection.getConnnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginSdi loginSdi = new LoginSdi();
            loginSdi.Username = username.Text.Trim();
            loginSdi.Password = password.Text.Trim();
            int check = loginService.checkLogin(loginSdi);
            if (check == -1)
            {
                errorLogin.Text = "Password or username is incorrect";
                return;
            }
            else if(check == 0)
            {
                MessageBox.Show("Patron", "Error", MessageBoxButtons.OK);
            }else if (check == 1)
            {
                MessageBox.Show("Employee", "Error", MessageBoxButtons.OK);
            }
            else
            {
                this.Visible = false;
                mainForm = new MainForm();
                mainForm.FormLogin = this;
                mainForm.Show();
            }
        }

        private void username_MouseClick(object sender, MouseEventArgs e)
        {
            errorLogin.Text = "";
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            errorLogin.Text = "";
        }

        public void setPassword(String pass)
        {
            password.Text = pass.Trim();
        }
    }
}
