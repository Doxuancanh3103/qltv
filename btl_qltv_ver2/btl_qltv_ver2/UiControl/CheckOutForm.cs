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
    public partial class CheckOutForm : UserControl
    {
        private CheckOutService checkOutService;
        public CheckOutForm()
        {
            InitializeComponent();
            checkOutService = CheckOutServiceBean.getBean();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            CheckOutInsertUpdateForm checkOutInsertUpdate = new CheckOutInsertUpdateForm(this);
            checkOutInsertUpdate.changeEnableUpdate(false);
            checkOutInsertUpdate.ShowDialog();
        }

        public void updateDataToTable(Object obj)
        {
            CheckOut checkOut = (CheckOut)obj;
            checkOutTable.CurrentRow.Cells[1].Value = checkOut.LibraryCardNumber;
            checkOutTable.CurrentRow.Cells[2].Value = checkOut.Isbn;
            checkOutTable.CurrentRow.Cells[3].Value = checkOut.Grade;
            checkOutTable.CurrentRow.Cells[4].Value = checkOut.Checker;
            checkOutTable.CurrentRow.Cells[5].Value = checkOut.CheckOutDate;
            checkOutTable.CurrentRow.Cells[6].Value = checkOut.CurrentCondition;
            checkOutTable.CurrentRow.Cells[7].Value = checkOut.Fee;
        }

        public void addDataToTable(Object obj)
        {
            CheckOut checkOut = (CheckOut)obj;
            checkOutTable.Rows.Add(new String[] {  "detail", checkOut.LibraryCardNumber,
                                                    checkOut.Isbn.ToString(),
                                                    checkOut.Grade,
                                                    checkOut.Checker,
                                                    checkOut.CheckOutDate.ToString(),
                                                    checkOut.CurrentCondition,
                                                    checkOut.Fee.ToString()});
        }

        public void loadDataToTable()
        {
            checkOutTable.Rows.Clear();
            List<CheckOut> checkOuts = checkOutService.getCheckOuts();
            for (int i = 0; i < checkOuts.Count(); i++)
            {
                checkOutTable.Rows.Add(new String[] {"detail",
                                                    checkOuts[i].LibraryCardNumber.ToString(),
                                                    checkOuts[i].Isbn.ToString(),
                                                    checkOuts[i].Grade,
                                                    checkOuts[i].Checker,
                                                    checkOuts[i].CheckOutDate.ToString(),
                                                    checkOuts[i].CurrentCondition,
                                                    checkOuts[i].Fee.ToString()});
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            CheckOutInsertUpdateForm checkOutInsertUpdate = new CheckOutInsertUpdateForm(this);
            checkOutInsertUpdate.changeEnableInsert(false);
            if (checkOutTable.CurrentRow != null)
            {
                String isbn = checkOutTable.CurrentRow.Cells[2].Value.ToString();
                String grade = checkOutTable.CurrentRow.Cells[3].Value.ToString();
                String checker = checkOutTable.CurrentRow.Cells[4].Value.ToString();
                String currentCondition = checkOutTable.CurrentRow.Cells[6].Value.ToString();
                String checkedInDate = checkOutTable.CurrentRow.Cells[5].Value.ToString();
                String libraryCardNumber = checkOutTable.CurrentRow.Cells[1].Value.ToString();
                checkOutInsertUpdate.changeEnableGradeIsbnLibraryCardNumberTextBox(false);
                checkOutInsertUpdate.setData(libraryCardNumber, isbn, grade, checker, checkedInDate, currentCondition);
            }
            checkOutInsertUpdate.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkOutService.deleteCheckOut(checkOutTable.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(checkOutTable.CurrentRow.Cells[2].Value.ToString()), checkOutTable.CurrentRow.Cells[3].Value.ToString());
            checkOutTable.Rows.Remove(checkOutTable.CurrentRow);
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
    }
}
