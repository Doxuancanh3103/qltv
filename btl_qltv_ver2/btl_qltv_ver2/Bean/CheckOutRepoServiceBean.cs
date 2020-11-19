using btl_qltv_ver2.repos;
using btl_qltv_ver2.repos.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class CheckOutRepoServiceBean
    {

        private static CheckOutRepoService checkOutRepoService;
        public static CheckOutRepoService getBean()
        {
            if (checkOutRepoService == null)
            {
                checkOutRepoService = new CheckOutRepoImpl();
            }
            return checkOutRepoService;
        }
    }
}
