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
    public partial class MediaResultSearchForm : Form
    {
        private List<Media> medias;

        internal List<Media> Medias { get => medias; set => medias = value; }

        public MediaResultSearchForm()
        {
            InitializeComponent();
        }

        private void MediaResultSearchForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < medias.Count(); i++)
            {
                mediaTable.Rows.Add(new String[] {"detail",medias[i].Isbn.ToString(),
                                                    medias[i].Title,
                                                    medias[i].Year.ToString(),
                                                    medias[i].Publisher,
                                                    medias[i].Type,
                                                    medias[i].Subject });
            }
        }

        private void mediaTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
