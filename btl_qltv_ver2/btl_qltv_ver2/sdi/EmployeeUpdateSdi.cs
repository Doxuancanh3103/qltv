﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.sdi
{
    class EmployeeUpdateSdi
    {
        private String EmployeeId;
        private String SSN;
        private String fname;
        private String mname;
        private String lname;
        private Double salary;
        private String DOB;
        private String address;
        private String phoneNumber;
        private String roleType;

        public string EmployeeId1 { get => EmployeeId; set => EmployeeId = value; }
        public string SSN1 { get => SSN; set => SSN = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Mname { get => mname; set => mname = value; }
        public string Lname { get => lname; set => lname = value; }
        public double Salary { get => salary; set => salary = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string RoleType { get => roleType; set => roleType = value; }
    }
}
