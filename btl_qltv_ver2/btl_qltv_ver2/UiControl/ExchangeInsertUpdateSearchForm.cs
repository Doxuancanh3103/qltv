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
    public partial class ExchangeInsertUpdateSearchForm : Form
    {
        private ExchangeForm exchangeForm;
        private ExchangeService exchangeService;
        public ExchangeInsertUpdateSearchForm(ExchangeForm exchangeForm)
        {
            InitializeComponent();
            this.exchangeForm = exchangeForm;
            exchangeService = ExchangeServiceBean.getBean();
        }

        private void insertCustom_Click(object sender, EventArgs e)
        {
            if (exchangeService.isExistExchange(lcnTextBox.Text, Convert.ToInt32(isbnTextBox.Text), gradeTextBox.Text))
            {
                MessageBox.Show("Exchange already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!exchangeService.isExistISBNInMedia(Convert.ToInt32(isbnTextBox.Text)))
            {
                MessageBox.Show("isbn does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!exchangeService.isExistGradeInCondition(gradeTextBox.Text))
            {
                MessageBox.Show("grade does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!exchangeService.isExistLibraryCardNumberInPatron(lcnTextBox.Text))
            {
                MessageBox.Show("library card number does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ExchangeInsertSdi exchangeInsertSdi = new ExchangeInsertSdi();
                exchangeInsertSdi.LibraryCardNumber = lcnTextBox.Text;
                exchangeInsertSdi.Isbn = Convert.ToInt32(isbnTextBox.Text);
                exchangeInsertSdi.Grade = gradeTextBox.Text;
                exchangeInsertSdi.CheckedInDate = cidTextBox.Value;
                Exchange exchange = exchangeService.insertExchange(exchangeInsertSdi);
                if (exchange != null)
                {
                    this.Close();
                    exchangeForm.addDataToTable(exchange);
                }
            }
        }

        public void setData(String libraryCardNumber,String isbn, String grade, String checkedInDate)
        {
            lcnTextBox.Text = libraryCardNumber;
            isbnTextBox.Text = isbn;
            gradeTextBox.Text = grade;
            cidTextBox.Text = checkedInDate;
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
            ExchangeUpdateSdi exchangeUpdateSdi = new ExchangeUpdateSdi();
            exchangeUpdateSdi.Isbn = Convert.ToInt32(isbnTextBox.Text);
            exchangeUpdateSdi.Grade = gradeTextBox.Text;
            exchangeUpdateSdi.CheckedInDate = cidTextBox.Value;
            exchangeUpdateSdi.LibraryCardNumber = lcnTextBox.Text;
            Exchange exchange = exchangeService.updateExchange(exchangeUpdateSdi);
            if (exchange != null)
            {
                this.Close();
                exchangeForm.updateDataToTable(exchange);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
