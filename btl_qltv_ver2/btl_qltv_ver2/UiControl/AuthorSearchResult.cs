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
    public partial class AuthorSearchResult : Form
    {

        private List<Author> authors;
        public AuthorSearchResult()
        {
            InitializeComponent();
        }

        internal List<Author> Authors { get => authors; set => authors = value; }

        private void AuthorSearchResult_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < authors.Count(); i++)
            {
                authorTable.Rows.Add(new String[] {authors[i].AuthorId,
                                                    authors[i].Name,
                                                    authors[i].DOB1.ToString()});
            }
        }
    }
}
