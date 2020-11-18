using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.sdi
{
    class AuthorUpdateSdi
    {
        private String authorId;
        private String fname;
        private String mname;
        private String lname;
        private String DOB;

        public string AuthorId { get => authorId; set => authorId = value; }
        public String DOB1 { get => DOB; set => DOB = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Mname { get => mname; set => mname = value; }
        public string Lname { get => lname; set => lname = value; }
    }
}
