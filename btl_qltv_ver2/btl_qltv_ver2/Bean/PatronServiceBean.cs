using btl_qltv_ver2.Service;
using btl_qltv_ver2.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class PatronServiceBean
    {
        private static PatronService patronService;
        public static PatronService getBean()
        {
            if (patronService == null)
            {
                patronService = new PatronImpl();
            }
            return patronService;
        }
    }
}
