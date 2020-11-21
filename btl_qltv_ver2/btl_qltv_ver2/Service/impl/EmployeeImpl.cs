using btl_qltv_ver2.Bean;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.repos;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Service.impl
{
    class EmployeeImpl : EmployeeService
    {
        private EmployeeRepoService employeeRepoService;
        public EmployeeImpl()
        {
            employeeRepoService = EmployeeRepoServiceBean.getBean();
        }

        public List<Employee> filterEmployees(string obj,string sender)
        {
            return employeeRepoService.filterEmployees(obj, sender);
        }

        public Employee getEmployeeById(string employeeId)
        {
            return employeeRepoService.getEmployeeById(employeeId);
        }

        public List<Employee> getEmployees()
        {
            return employeeRepoService.getEmployees();
        }

        public Employee insertEmployee(EmployeeInsertSdi employeeInsertSdi)
        {
            return employeeRepoService.insertEmployee(employeeInsertSdi);
        }

        public bool isExistAccount(string username)
        {
            return employeeRepoService.isExistAccount(username);
        }

        public bool isExistSSN(string ssn)
        {
            return employeeRepoService.isExistSSN(ssn);
        }

        public List<Employee> searchEmployees(EmployeeSearchSdi employeeSearchSdi)
        {
            return employeeRepoService.searchEmployees(employeeSearchSdi);
        }

        public Employee updateEmployee(EmployeeUpdateSdi employeeUpdateSdi)
        {
            return employeeRepoService.updateEmployee(employeeUpdateSdi);
        }

        String EmployeeService.deleteEmployee(string employeeid)
        {
            return employeeRepoService.deleteEmployee(employeeid);
        }
    }
}
