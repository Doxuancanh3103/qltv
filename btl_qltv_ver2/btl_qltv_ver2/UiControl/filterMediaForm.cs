using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_qltv_ver2.UiControl
{
    public partial class filterMediaForm : UserControl
    {
        public filterMediaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public String selected()
        {
            if (title.Checked) return "1";
            if (publisher.Checked) return "2";
            if (type.Checked) return "3";
            return "4";
        }
    }
}
