using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.sdi
{
    class StockInsertSdi
    {
        private int isbn;
        private String grade;
        private long amount;
        private double orderCost;

        public int Isbn { get => isbn; set => isbn = value; }
        public string Grade { get => grade; set => grade = value; }
        public long Amount { get => amount; set => amount = value; }
        public double OrderCost { get => orderCost; set => orderCost = value; }
    }
}
