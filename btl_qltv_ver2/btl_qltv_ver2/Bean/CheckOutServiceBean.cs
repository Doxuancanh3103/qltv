using btl_qltv_ver2.Service;
using btl_qltv_ver2.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class CheckOutServiceBean
    {
        private static CheckOutService checkOutService;

        public static CheckOutService getBean()
        {
            if (checkOutService == null)
            {
                checkOutService = new CheckOutImpl();
            }
            return checkOutService;
        }
    }
}
