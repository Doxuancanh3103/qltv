using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.Service;
using btl_qltv_ver2.Bean;

namespace btl_qltv_ver2.UiControl
{
    public partial class AuthorForm : UserControl
    {
        private AuthorService authorService;
        public AuthorForm()
        {
            InitializeComponent();
            authorService = AuthorServiceBean.getBean();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            AuthorInsertUpdateSearchForm authorInsertUpdateSearchForm = new AuthorInsertUpdateSearchForm(this);
            authorInsertUpdateSearchForm.changeEnableUpdate(false);
            authorInsertUpdateSearchForm.changeEnableSearch(false);
            authorInsertUpdateSearchForm.ShowDialog();
        }

        public void loadDataToTableFilter(Object authors)
        {
            authorTable.Rows.Clear();
            List<Author> listAuthor = (List<Author>)authors;
            for (int i = 0; i < listAuthor.Count(); i++)
            {
                authorTable.Rows.Add(new String[] {listAuthor[i].AuthorId,
                                                    listAuthor[i].Name,
                                                    listAuthor[i].DOB1.ToString() });
            }
        }
        public void loadDataToTable()
        {
            authorTable.Rows.Clear();
            List<Author> authors = authorService.getAuthors();
            for (int i = 0; i < authors.Count(); i++)
            {
                authorTable.Rows.Add(new String[] {authors[i].AuthorId,
                                                    authors[i].Name,
                                                    authors[i].DOB1.ToString() });
            }

        }

        public void addDataToTable(Object obj)
        {
            Author author = (Author)obj;
            authorTable.Rows.Add(new String[] {author.AuthorId,
                                                    author.Name,
                                                    author.DOB1.ToString()});
        }

        private void update_Click(object sender, EventArgs e)
        {
            AuthorInsertUpdateSearchForm authorInsertUpdateSearchForm = new AuthorInsertUpdateSearchForm(this);
            authorInsertUpdateSearchForm.changeEnableInsert(false);
            authorInsertUpdateSearchForm.changeEnableSearch(false);
            if (authorTable.CurrentRow != null)
            {
                String authorId = authorTable.CurrentRow.Cells[0].Value.ToString();
                String name = authorTable.CurrentRow.Cells[1].Value.ToString();
                String dob = authorTable.CurrentRow.Cells[2].Value.ToString();
                authorInsertUpdateSearchForm.changeEnableAuthorIdTextBox(false);
                authorInsertUpdateSearchForm.setData(authorId, name, dob);
            }
            authorInsertUpdateSearchForm.ShowDialog();
        }

        public void updateDataToTable(Object obj)
        {
            Author author = (Author)obj;
            authorTable.CurrentRow.Cells[0].Value = author.AuthorId;
            authorTable.CurrentRow.Cells[1].Value = author.Name;
            authorTable.CurrentRow.Cells[2].Value = author.DOB1.ToString();
        }

        private void search_Click(object sender, EventArgs e)
        {

            AuthorInsertUpdateSearchForm authorInsertUpdateSearch = new AuthorInsertUpdateSearchForm(this);
            authorInsertUpdateSearch.changeEnableInsert(false);
            authorInsertUpdateSearch.changeEnableUpdate(false);
            authorInsertUpdateSearch.changeEnableDateTimePicker(false);
            authorInsertUpdateSearch.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authorService.deleteAuthor(authorTable.CurrentRow.Cells[0].Value.ToString());
            authorTable.Rows.Remove(authorTable.CurrentRow);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void authorTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void changeEnableInsert(bool change)
        {
            insert.Enabled = change;
        }

        public void changeEnableUpdate(bool change)
        {
            update.Enabled = change;
        }

        public void changeEnableDelete(bool change)
        {
            delete.Enabled = change;
        }

        private void filterTextBox_MouseEnter(object sender, EventArgs e)
        {

        }

        private void filterTextBox_MouseLeave(object sender, EventArgs e)
        {
        }

        private void filterTextBox_OnValueChanged(object sender, EventArgs e)
        {
            String firstName = "";
            String midName = "";
            String lastName = "";
            if (filterOptionForm1.isFirstName())
            {
                firstName = filterTextBox.Text;
            }

            if (filterOptionForm1.isLastName())
            {
                lastName = filterTextBox.Text;
            }

            if (filterOptionForm1.isMidName())
            {
                midName = filterTextBox.Text;
            }

            List<Author> authors = authorService.filterAuthors(firstName, midName, lastName);
            this.loadDataToTableFilter(authors);
        }

        private void filterOptionForm1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void filterOptionForm1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void filterTextBox_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void filterTextBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void filterTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            filterOptionForm1.Location = new Point(filterButton.Location.X - 150, tableLayoutPanel1.Location.Y - 150);

            filterOptionForm1.Visible = true;
        }

        private void filterButton_MouseLeave(object sender, EventArgs e)
        {

        }

        private void filterOptionForm1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
