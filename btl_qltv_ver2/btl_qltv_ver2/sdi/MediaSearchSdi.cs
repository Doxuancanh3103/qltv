using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.sdi
{
    class MediaSearchSdi
    {
        private int isbn;
        private String title;
        private String publisher;
        private String type;
        private String subject;

        public int Isbn { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Type { get => type; set => type = value; }
        public string Subject { get => subject; set => subject = value; }
    }
}
