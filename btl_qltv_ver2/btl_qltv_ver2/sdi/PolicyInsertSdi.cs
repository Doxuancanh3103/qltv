using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.sdi
{
    class PolicyInsertSdi
    {
        private String description;
        private Double value;

        public string Description { get => description; set => description = value; }
        public double Value { get => value; set => this.value = value; }
    }
}
