using btl_qltv_ver2.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_qltv_ver2.UiControl
{
    public partial class PatronSearchResultForm : Form
    {
        private List<Patron> patrons;
        public PatronSearchResultForm()
        {
            InitializeComponent();
        }

        internal List<Patron> Patrons { get => patrons; set => patrons = value; }

        private void PatronSearchResultForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < patrons.Count(); i++)
            {
                patronTableResultSearch.Rows.Add(new String[] {"detail",patrons[i].LibraryCardNumber,
                                                    patrons[i].Name,
                                                    patrons[i].DOB1.ToString(),
                                                    patrons[i].PhoneNumber,
                                                    patrons[i].Address});
            }
        }
    }
}
