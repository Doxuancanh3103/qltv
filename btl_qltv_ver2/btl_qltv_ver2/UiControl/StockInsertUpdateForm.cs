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
    public partial class StockInsertUpdateForm : Form
    {
        private StockForm stockForm;
        private StockService stockService;
        public StockInsertUpdateForm(StockForm stockForm)
        {
            InitializeComponent();
            this.stockForm = stockForm;
            stockService = StockServiceBean.getBean();
        }

        private void insertCustom_Click(object sender, EventArgs e)
        {
            if (stockService.isExistStock(gradeTextBox.Text,Convert.ToInt32(isbnTextBox.Text)))
            {
                MessageBox.Show("stock already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!stockService.isExistIsbnInMedia(Convert.ToInt32(isbnTextBox.Text)))
            {
                MessageBox.Show("isbn does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!stockService.isExistGradeInCondition(gradeTextBox.Text))
            {
                MessageBox.Show("grade does not exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StockInsertSdi stockInsertSdi = new StockInsertSdi();
                stockInsertSdi.Isbn = Convert.ToInt32(isbnTextBox.Text);
                stockInsertSdi.Grade = gradeTextBox.Text;
                stockInsertSdi.Amount = Convert.ToInt64(amountTextBox.Text);
                stockInsertSdi.OrderCost = Convert.ToDouble(amountTextBox.Text);
                Stock stock = stockService.insertStock(stockInsertSdi);
                if (stock != null)
                {
                    this.Close();
                    stockForm.addDataToTable(stock);
                }
            }
        }

        public void setData(String isbn, String grade, String amount, String orderCost)
        {
            isbnTextBox.Text = isbn;
            gradeTextBox.Text = grade;
            amountTextBox.Text = amount;
            orderCostTextBox.Text = orderCost;
        }

        public void changeEnableInsert(Boolean change)
        {
            insertCustom.Visible = change;
        }

        public void changeEnableUpdate(Boolean change)
        {
            updateCustom.Visible = change;
        }


        public void changeEnableGradeIsbnTextBox(Boolean change)
        {
            gradeTextBox.Enabled = change;
            isbnTextBox.Enabled = change;
        }

        private void updateCustom_Click(object sender, EventArgs e)
        {
            StockUpdateSdi stockUpdateSdi = new StockUpdateSdi();
            stockUpdateSdi.Isbn = Convert.ToInt32(isbnTextBox.Text);
            stockUpdateSdi.Grade = gradeTextBox.Text;
            stockUpdateSdi.Amount = Convert.ToInt32(amountTextBox.Text);
            stockUpdateSdi.OrderCost = Convert.ToInt32(orderCostTextBox.Text);
            Stock stock = stockService.updateStock(stockUpdateSdi);
            if (stock != null)
            {
                this.Close();
                stockForm.updateDataToTable(stock);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
