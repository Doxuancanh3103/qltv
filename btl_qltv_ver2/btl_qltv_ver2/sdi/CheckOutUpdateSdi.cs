using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.sdi
{
    class CheckOutUpdateSdi
    {
        private String libraryCardNumber;
        private int isbn;
        private String grade;
        private String checker;
        private DateTime checkOutDate;
        private String currentCondition;

        public string LibraryCardNumber { get => libraryCardNumber; set => libraryCardNumber = value; }
        public int Isbn { get => isbn; set => isbn = value; }
        public string Grade { get => grade; set => grade = value; }
        public string Checker { get => checker; set => checker = value; }
        public DateTime CheckOutDate { get => checkOutDate; set => checkOutDate = value; }
        public string CurrentCondition { get => currentCondition; set => currentCondition = value; }
    }
}
