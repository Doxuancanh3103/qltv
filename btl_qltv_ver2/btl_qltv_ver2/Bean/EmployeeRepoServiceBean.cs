using btl_qltv_ver2.repos;
using btl_qltv_ver2.repos.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class EmployeeRepoServiceBean
    {
        private static EmployeeRepoService employeeRepoService;

        public static EmployeeRepoService getBean()
        {
            if (employeeRepoService == null)
            {
                employeeRepoService = new EmployeeRepoImpl();
            }
            return employeeRepoService;
        }
    }
}
