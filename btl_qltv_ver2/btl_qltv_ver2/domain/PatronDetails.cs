using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.domain
{
    class PatronDetails
    {
        private String libraryCardNumber;
        private int january;
        private int february;
        private int march;
        private int april;
        private int may;
        private int june;
        private int july;
        private int august;
        private int september;
        private int october;
        private int november;
        private int december;

        public String LibraryCardNumber { get => libraryCardNumber; set => libraryCardNumber = value; }
        public int January { get => january; set => january = value; }
        public int February { get => february; set => february = value; }
        public int March { get => march; set => march = value; }
        public int April { get => april; set => april = value; }
        public int May { get => may; set => may = value; }
        public int June { get => june; set => june = value; }
        public int July { get => july; set => july = value; }
        public int August { get => august; set => august = value; }
        public int September { get => september; set => september = value; }
        public int October { get => october; set => october = value; }
        public int November { get => november; set => november = value; }
        public int December { get => december; set => december = value; }
    }
}
