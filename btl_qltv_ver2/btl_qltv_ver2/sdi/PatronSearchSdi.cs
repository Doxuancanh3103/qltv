using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.sdi
{
    class PatronSearchSdi
    {
        private String libraryCardNumber;
        private String fname;
        private String mname;
        private String lname;
        private String phoneNumber;
        private String address;
        private String username;

        public string LibraryCardNumber { get => libraryCardNumber; set => libraryCardNumber = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Mname { get => mname; set => mname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Username { get => username; set => username = value; }
    }
}
