using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.domain
{
    class Condition
    {
        private String grade;
        private int percent;

        public string Grade { get => grade; set => grade = value; }
        public int Percent { get => percent; set => percent = value; }
    }
}
