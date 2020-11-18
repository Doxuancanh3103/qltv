using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Service
{
    interface EmployeeService
    {
        Employee insertEmployee(EmployeeInsertSdi employeeInsertSdi);
        Employee getEmployeeById(String employeeId);
        Boolean isExistAccount(String username);
        Boolean isExistSSN(String ssn);

        Employee updateEmployee(EmployeeUpdateSdi employeeUpdateSdi);
        List<Employee> getEmployees();

        List<Employee> searchEmployees(EmployeeSearchSdi employeeSearchSdi);

        String deleteEmployee(String employeeid);
    }
}
