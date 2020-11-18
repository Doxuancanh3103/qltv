using btl_qltv_ver2.Service;
using btl_qltv_ver2.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class EmployeeServiceBean
    {
        private static EmployeeService employeeService;
        public static EmployeeService getBean()
        {
            if (employeeService == null)
            {
                employeeService = new EmployeeImpl();
            }
            return employeeService;
        }
    }
}
