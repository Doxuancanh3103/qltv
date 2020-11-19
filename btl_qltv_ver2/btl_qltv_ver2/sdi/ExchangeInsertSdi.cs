using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.sdi
{
    class ExchangeInsertSdi
    {
        private String libraryCardNumber;
        private int isbn;
        private String grade;
        private DateTime checkedInDate;

        public string LibraryCardNumber { get => libraryCardNumber; set => libraryCardNumber = value; }
        public int Isbn { get => isbn; set => isbn = value; }
        public string Grade { get => grade; set => grade = value; }
        public DateTime CheckedInDate { get => checkedInDate; set => checkedInDate = value; }
    }
}
