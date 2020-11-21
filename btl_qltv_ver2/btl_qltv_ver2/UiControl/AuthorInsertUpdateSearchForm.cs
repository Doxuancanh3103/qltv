using btl_qltv_ver2.Bean;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using btl_qltv_ver2.Service;
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
    public partial class AuthorInsertUpdateSearchForm : Form
    {
        private AuthorForm authorForm;
        private AuthorService authorService;
        public AuthorInsertUpdateSearchForm(AuthorForm authorForm)
        {
            InitializeComponent();
            this.authorForm = authorForm;
            authorService = AuthorServiceBean.getBean();
        }

        private void insertCustom_Click(object sender, EventArgs e)
        {
            if (authorService.isExistAuthor(authorIdTextBox.Text))
            {
                MessageBox.Show("Author already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AuthorInsertSdi authorInsertSdi = new AuthorInsertSdi();
                authorInsertSdi.AuthorId = authorIdTextBox.Text;
                authorInsertSdi.Fname = fnameTextBox.Text;
                authorInsertSdi.Lname = lnameTextBox.Text;
                authorInsertSdi.Mname = mnameTextBox.Text;
                authorInsertSdi.DOB1 = dobTextBox.Value.ToString();
                Author author = authorService.insertAuthor(authorInsertSdi);
                if (author != null)
                {
                    this.Close();
                    authorForm.addDataToTable(author);
                }
            }
        }
        public void changeEnableInsert(Boolean change)
        {
            insertCustom.Visible = change;
        }

        public void changeEnableUpdate(Boolean change)
        {
            updateCustom.Visible = change;
        }


        public void changeEnableAuthorIdTextBox(Boolean change)
        {
            authorIdTextBox.Enabled = change;
        }

        public void changeEnableSearch(Boolean change)
        {
            search.Visible = change;
        }

        public void changeEnableDateTimePicker(Boolean change)
        {
            dobTextBox.Visible = change;
            dobLabel.Visible = change;
        }

        public void setData(String authorId, String name, String dob)
        {
            String[] names = name.Split(' ');
            String _mName = names[1];
            for (int i = 2; i < names.Length - 1; i++)
            {
                _mName += " " + names[i];
            }
            authorIdTextBox.Text = authorId;
            fnameTextBox.Text = names[0];
            mnameTextBox.Text = _mName;
            lnameTextBox.Text = names[names.Length - 1];
            dobTextBox.Text = dob;
        }

        private void updateCustom_Click(object sender, EventArgs e)
        {
            AuthorUpdateSdi authorUpdateSdi = new AuthorUpdateSdi();
            authorUpdateSdi.AuthorId = authorIdTextBox.Text;
            authorUpdateSdi.Fname = fnameTextBox.Text;
            authorUpdateSdi.Mname = mnameTextBox.Text;
            authorUpdateSdi.Lname = lnameTextBox.Text;
            authorUpdateSdi.DOB1 = dobTextBox.Value.ToString();
            Author author = authorService.updateAuthor(authorUpdateSdi);
            if (author != null)
            {
                this.Close();
                authorForm.updateDataToTable(author);
            }

        }

        private void search_Click(object sender, EventArgs e)
        {
            AuthorSearchSdi authorSearchSdi = new AuthorSearchSdi();
            if ("".Equals(authorIdTextBox.Text.Trim()))
            {
                authorSearchSdi.AuthorId = null;
            }
            else
            {
                authorSearchSdi.AuthorId = authorIdTextBox.Text.Trim();
            }

            if ("".Equals(fnameTextBox.Text.Trim()))
            {
                authorSearchSdi.Fname = null;
            }
            else
            {
                authorSearchSdi.Fname = fnameTextBox.Text.Trim();
            }

            if ("".Equals(mnameTextBox.Text.Trim()))
            {
                authorSearchSdi.Mname = null;
            }
            else
            {
                authorSearchSdi.Mname = mnameTextBox.Text.Trim();
            }

            if ("".Equals(lnameTextBox.Text.Trim()))
            {
                authorSearchSdi.Lname = null;
            }
            else
            {
                authorSearchSdi.Lname = lnameTextBox.Text.Trim();
            }

            List<Author> authors = authorService.searchAuthors(authorSearchSdi);

            AuthorSearchResult authorSearchResult = new AuthorSearchResult();
            authorSearchResult.Authors = authors;
            authorSearchResult.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void authorIdTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
