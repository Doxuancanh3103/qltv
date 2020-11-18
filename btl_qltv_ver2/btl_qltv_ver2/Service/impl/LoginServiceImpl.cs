using btl_qltv_ver2.repos;
using btl_qltv_ver2.repos.impl;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_qltv_ver2.Service.impl
{
    class LoginServiceImpl : LoginService
    {
        LoginRepoService loginRepoService = new LoginRepoServiceImpl();
        public int checkLogin(LoginSdi loginSdi)
        {
            if (loginSdi.Username == null || "".Equals(loginSdi.Username))
            {
                MessageBox.Show("Username is required", "Error", MessageBoxButtons.OK);
            }

            else if (loginSdi.Password == null|| "".Equals(loginSdi.Password))
            {
                MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK);
            }

            else if (loginSdi.Username.Length > 20)
            {
                MessageBox.Show("Max Length of Username is 20", "Error", MessageBoxButtons.OK);
            }

            else if (loginSdi.Password.Length > 20)
            {
                MessageBox.Show("Max Length of Password is 20", "Error", MessageBoxButtons.OK);
            }

            return loginRepoService.checkLogin(loginSdi);
        }
    }
}
