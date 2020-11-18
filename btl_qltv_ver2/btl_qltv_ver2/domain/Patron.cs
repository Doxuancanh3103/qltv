using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.domain
{
    class Patron
    {
        private String libraryCardNumber;
        private String name;
        private DateTime DOB;
        private String phoneNumber;
        private String address;

        public string LibraryCardNumber { get => libraryCardNumber; set => libraryCardNumber = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DOB1 { get => DOB; set => DOB = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
    }
}
