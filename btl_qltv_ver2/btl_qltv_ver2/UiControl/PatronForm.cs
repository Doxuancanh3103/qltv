using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl_qltv_ver2.Service;
using btl_qltv_ver2.Bean;
using btl_qltv_ver2.domain;

namespace btl_qltv_ver2.UiControl
{
    public partial class PatronForm : UserControl
    {
        private PatronService patronService;
        public PatronForm()
        {
            InitializeComponent();
            patronService = PatronServiceBean.getBean();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            PatronInsertUpdateForm patronInsertUpdateForm = new PatronInsertUpdateForm(this);
            patronInsertUpdateForm.changeEnableUpdate(false);
            patronInsertUpdateForm.changeEnableSearch(false);
            patronInsertUpdateForm.visibleAccount();
            patronInsertUpdateForm.ShowDialog();
        }

        public void loadDataToTable()
        {
            patronTable.Rows.Clear();
            List<Patron> patrons = patronService.getPatrons();
            for (int i = 0; i < patrons.Count(); i++)
            {
                patronTable.Rows.Add(new String[] {"detail",patrons[i].LibraryCardNumber,
                                                    patrons[i].Name,
                                                    patrons[i].DOB1.ToString(),
                                                    patrons[i].PhoneNumber,
                                                    patrons[i].Address });
            }
        }

        public void addDataToTable(Object obj)
        {
            Patron patron = (Patron)obj;
            patronTable.Rows.Add(new String[] {"detail",patron.LibraryCardNumber,
                                                    patron.Name,
                                                    patron.DOB1.ToString(),
                                                    patron.PhoneNumber,
                                                    patron.Address});
        }

        public void updateDataToTable(Object obj)
        {
            Patron patron = (Patron)obj;
            patronTable.CurrentRow.Cells[2].Value = patron.Name;
            patronTable.CurrentRow.Cells[3].Value = patron.DOB1.ToString();
            patronTable.CurrentRow.Cells[4].Value = patron.PhoneNumber;
            patronTable.CurrentRow.Cells[5].Value = patron.Address;
        }

        private void update_Click(object sender, EventArgs e)
        {
            PatronInsertUpdateForm patronInsertUpdateForm = new PatronInsertUpdateForm(this);
            patronInsertUpdateForm.changeEnableInsert(false);
            patronInsertUpdateForm.changeEnableSearch(false);
            if (patronTable.CurrentRow != null)
            {
                String libraryCardNumber = patronTable.CurrentRow.Cells[1].Value.ToString();
                String name = patronTable.CurrentRow.Cells[2].Value.ToString();
                String dob = patronTable.CurrentRow.Cells[3].Value.ToString();
                String phoneNumber = patronTable.CurrentRow.Cells[4].Value.ToString();
                String address = patronTable.CurrentRow.Cells[5].Value.ToString();
                patronInsertUpdateForm.changeEnableLibraryCardNumberTextBox(false);
                patronInsertUpdateForm.setData(libraryCardNumber, name, dob, phoneNumber, address);
            }
            patronInsertUpdateForm.hideAccount();
            patronInsertUpdateForm.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            PatronInsertUpdateForm patronInsertUpdateForm = new PatronInsertUpdateForm(this);
            patronInsertUpdateForm.changeEnableInsert(false);
            patronInsertUpdateForm.changeEnableUpdate(false);
            patronInsertUpdateForm.changeEnableDateTimePicker(false);
            patronInsertUpdateForm.hidePassword();
            patronInsertUpdateForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patronService.deletePatron(patronTable.CurrentRow.Cells[1].Value.ToString());
            patronTable.Rows.Remove(patronTable.CurrentRow);
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

        private void filterButton_Click(object sender, EventArgs e)
        {
            filterPatronForm1.Location = new Point(filterButton.Location.X - 150, tableLayoutPanel1.Location.Y - 200);

            filterPatronForm1.Visible = true;
        }

        private void filterTextBox_OnValueChanged(object sender, EventArgs e)
        {
            List<Patron> patrons = patronService.filterPatrons(filterTextBox.Text, filterPatronForm1.selected());
            this.loadDataToTableFilter(patrons);
        }

        public void loadDataToTableFilter(Object obj)
        {
            patronTable.Rows.Clear();
            List<Patron> patrons = (List<Patron>)obj;
            for (int i = 0; i < patrons.Count(); i++)
            {
                patronTable.Rows.Add(new String[] {"detail",patrons[i].LibraryCardNumber,
                                                    patrons[i].Name,
                                                    patrons[i].DOB1.ToString(),
                                                    patrons[i].PhoneNumber,
                                                    patrons[i].Address });
            }

        }

        private void patronTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Patron patron = new Patron();
                patron.LibraryCardNumber = patronTable.CurrentRow.Cells[1].Value.ToString();
                patron.Name = patronTable.CurrentRow.Cells[2].Value.ToString();
                patron.DOB1 = DateTime.Parse(patronTable.CurrentRow.Cells[3].Value.ToString());
                patron.PhoneNumber = patronTable.CurrentRow.Cells[4].Value.ToString();
                patron.Address = patronTable.CurrentRow.Cells[5].Value.ToString();
                PatronStatistic patronStatistic = new PatronStatistic();
                patronStatistic.Patron = patron;
                patronStatistic.ShowDialog();
            }
        }
    }
}
