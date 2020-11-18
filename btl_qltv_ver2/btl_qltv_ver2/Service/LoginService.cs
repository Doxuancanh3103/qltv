using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace btl_qltv_ver2.Service
{
    interface LoginService
    {
        int checkLogin(LoginSdi loginSdi);
    }
}
