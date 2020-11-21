using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.repos
{
    interface EmployeeRepoService
    {
        Employee insertEmployee(EmployeeInsertSdi employeeInsertSdi);
        Employee getEmployeeById(String employeeId);
        Boolean isExistAccount(String username);
        Boolean isExistSSN(String ssn);
        List<Employee> getEmployees();
        Employee updateEmployee(EmployeeUpdateSdi employeeUpdateSdi);

        List<Employee> searchEmployees(EmployeeSearchSdi employeeSearchSdi);

        List<Employee> filterEmployees(String obj,String sender);

        String deleteEmployee(String employeeid);
    }
}
