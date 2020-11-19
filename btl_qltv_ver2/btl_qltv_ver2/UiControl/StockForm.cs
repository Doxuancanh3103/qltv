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
    public partial class StockForm : UserControl
    {
        private StockService stockService;
        public StockForm()
        {
            InitializeComponent();
            stockService = StockServiceBean.getBean();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            StockInsertUpdateForm stockInsertUpdateForm = new StockInsertUpdateForm(this);
            stockInsertUpdateForm.changeEnableUpdate(false);
            stockInsertUpdateForm.ShowDialog();
        }

        public void updateDataToTable(Object obj)
        {
            Stock stock = (Stock)obj;
            stockTable.CurrentRow.Cells[0].Value = stock.Isbn;
            stockTable.CurrentRow.Cells[1].Value = stock.Grade;
            stockTable.CurrentRow.Cells[2].Value = stock.Amount;
            stockTable.CurrentRow.Cells[3].Value = stock.OrderCost;
        }

        public void addDataToTable(Object obj)
        {
            Stock stock = (Stock)obj;
            stockTable.Rows.Add(new String[] {stock.Isbn.ToString(),
                                                    stock.Grade,
                                                    stock.Amount.ToString(),
                                                    stock.OrderCost.ToString()});
        }

        public void loadDataToTable()
        {
            if (stockTable.Rows.Count == 1)
            {
                List<Stock> stocks = stockService.getStocks();
                for (int i = 0; i < stocks.Count(); i++)
                {
                    stockTable.Rows.Add(new String[] {stocks[i].Isbn.ToString(),
                                                    stocks[i].Grade,
                                                    stocks[i].Amount.ToString(),
                                                    stocks[i].OrderCost.ToString()});
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            StockInsertUpdateForm stockInsertUpdateForm = new StockInsertUpdateForm(this);
            stockInsertUpdateForm.changeEnableInsert(false);
            if (stockTable.CurrentRow != null)
            {
                String isbn = stockTable.CurrentRow.Cells[0].Value.ToString();
                String grade = stockTable.CurrentRow.Cells[1].Value.ToString();
                String amount = stockTable.CurrentRow.Cells[2].Value.ToString();
                String orderCost = stockTable.CurrentRow.Cells[3].Value.ToString();
                stockInsertUpdateForm.changeEnableGradeIsbnTextBox(false);
                stockInsertUpdateForm.setData(isbn, grade, amount, orderCost);
            }
            stockInsertUpdateForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stockService.deleteStock(stockTable.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(stockTable.CurrentRow.Cells[0].Value.ToString()));
            stockTable.Rows.Remove(stockTable.CurrentRow);
        }
    }
}
