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
    public partial class filterPatronForm : UserControl
    {
        public filterPatronForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        public String selected()
        {
            if (name.Checked) return "1";
            if (address.Checked) return "2";
            return "3";
        }
    }
}
