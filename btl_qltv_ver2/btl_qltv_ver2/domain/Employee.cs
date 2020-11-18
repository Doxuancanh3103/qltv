using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.domain
{
    class Employee
    {
        private String EmployeeId;
        private String SSN;
        private String name;
        private Double salary;
        private DateTime DOB;
        private String address;
        private String phoneNumber;
        private String roleType;

        public string EmployeeId1 { get => EmployeeId; set => EmployeeId = value; }
        public string SSN1 { get => SSN; set => SSN = value; }
        public string Name { get => name; set => name = value; }
        public Double Salary { get => salary; set => salary = value; }
        public DateTime DOB1 { get => DOB; set => DOB = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string RoleType { get => roleType; set => roleType = value; }
    }
}
