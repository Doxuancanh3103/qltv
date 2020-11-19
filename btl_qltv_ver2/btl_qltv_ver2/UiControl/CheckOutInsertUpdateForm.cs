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
    public partial class CheckOutInsertUpdateForm : Form
    {
        private CheckOutForm checkOutForm;
        private CheckOutService checkOutService;
        public CheckOutInsertUpdateForm(CheckOutForm checkOutForm)
        {
            InitializeComponent();
            this.checkOutForm = checkOutForm;
            checkOutService = CheckOutServiceBean.getBean();
        }

        private void isbnTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void insertCustom_Click(object sender, EventArgs e)
        {
            if (checkOutService.isExistCheckOut(lcnTextBox.Text, Convert.ToInt32(isbnTextBox.Text), gradeTextBox.Text))
            {
                MessageBox.Show("Exchange already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkOutService.isExistISBNInMedia(Convert.ToInt32(isbnTextBox.Text)))
            {
                MessageBox.Show("isbn does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkOutService.isExistGradeInCondition(gradeTextBox.Text))
            {
                MessageBox.Show("grade does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkOutService.isExistLibraryCardNumberInPatron(lcnTextBox.Text))
            {
                MessageBox.Show("library card number does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!checkOutService.isExistEmplIdInEmployee(checkerTextBox.Text))
            {
                MessageBox.Show("imployeeId does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CheckOutInsertSdi checkOutInsertSdi = new CheckOutInsertSdi();
                checkOutInsertSdi.LibraryCardNumber = lcnTextBox.Text;
                checkOutInsertSdi.Isbn = Convert.ToInt32(isbnTextBox.Text);
                checkOutInsertSdi.Grade = gradeTextBox.Text;
                checkOutInsertSdi.CheckOutDate = codTextBox.Value;
                checkOutInsertSdi.Checker = checkerTextBox.Text;
                checkOutInsertSdi.CurrentCondition = currentConditionTextBox.Text;
                CheckOut checkout = checkOutService.insertCheckOut(checkOutInsertSdi);
                if (checkout != null)
                {
                    this.Close();
                    checkOutForm.addDataToTable(checkout);
                }
            }
        }

        public void setData(String libraryCardNumber, String isbn, String grade, String checker,String checkOutDate,String currentCondition)
        {
            lcnTextBox.Text = libraryCardNumber;
            isbnTextBox.Text = isbn;
            gradeTextBox.Text = grade;
            checkerTextBox.Text = checker;
            codTextBox.Text = checkOutDate;
            currentConditionTextBox.Text = currentCondition;
        }

        public void changeEnableInsert(Boolean change)
        {
            insertCustom.Visible = change;
        }

        public void changeEnableUpdate(Boolean change)
        {
            updateCustom.Visible = change;
        }


        public void changeEnableGradeIsbnLibraryCardNumberTextBox(Boolean change)
        {
            gradeTextBox.Enabled = change;
            isbnTextBox.Enabled = change;
            lcnTextBox.Enabled = change;
        }

        private void updateCustom_Click(object sender, EventArgs e)
        {
            CheckOutUpdateSdi checkOutUpdateSdi = new CheckOutUpdateSdi();
            checkOutUpdateSdi.Isbn = Convert.ToInt32(isbnTextBox.Text);
            checkOutUpdateSdi.Grade = gradeTextBox.Text;
            checkOutUpdateSdi.CheckOutDate = codTextBox.Value;
            checkOutUpdateSdi.LibraryCardNumber = lcnTextBox.Text;
            checkOutUpdateSdi.Checker = checkerTextBox.Text;
            checkOutUpdateSdi.CurrentCondition = currentConditionTextBox.Text;
            CheckOut checkOut = checkOutService.updateCheckOut(checkOutUpdateSdi);
            if (checkOut != null)
            {
                this.Close();
                checkOutForm.updateDataToTable(checkOut);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
