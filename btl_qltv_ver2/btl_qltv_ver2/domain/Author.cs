using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.domain
{
    class Author
    {
        private String authorId;
        private String name;
        private DateTime DOB;

        public string AuthorId { get => authorId; set => authorId = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DOB1 { get => DOB; set => DOB = value; }
    }
}
