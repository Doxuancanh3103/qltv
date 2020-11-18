using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.repos
{
    interface LoginRepoService
    {
        int checkLogin(LoginSdi loginSdi);
    }
}
