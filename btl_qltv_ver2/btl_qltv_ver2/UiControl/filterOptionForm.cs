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
    public partial class filterOptionForm : UserControl
    {
        public filterOptionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public bool isFirstName()
        {
            return fnameCheckBox.Checked;
        }

        public bool isLastName()
        {
            return lnameCheckBox.Checked;
        }

        public bool isMidName()
        {
            return mnameCheckBox.Checked;
        }
    }
}
