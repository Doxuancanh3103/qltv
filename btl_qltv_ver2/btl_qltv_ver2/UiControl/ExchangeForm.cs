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
    public partial class ExchangeForm : UserControl
    {

        private ExchangeService exchangeService;
        public ExchangeForm()
        {
            InitializeComponent();
            exchangeService = ExchangeServiceBean.getBean();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            ExchangeInsertUpdateSearchForm exchangeInsertUpdateSearch = new ExchangeInsertUpdateSearchForm(this);
            exchangeInsertUpdateSearch.changeEnableUpdate(false);
            exchangeInsertUpdateSearch.ShowDialog();
        }

        public void updateDataToTable(Object obj)
        {
            Exchange exchange = (Exchange)obj;
            exchangeTable.CurrentRow.Cells[1].Value = exchange.LibraryCardNumber;
            exchangeTable.CurrentRow.Cells[2].Value = exchange.Isbn;
            exchangeTable.CurrentRow.Cells[3].Value = exchange.Grade;
            exchangeTable.CurrentRow.Cells[4].Value = exchange.CheckedInDate;
            exchangeTable.CurrentRow.Cells[5].Value = exchange.Term;
        }

        public void addDataToTable(Object obj)
        {
            Exchange exchange = (Exchange)obj;
            exchangeTable.Rows.Add(new String[] {  "detail", exchange.LibraryCardNumber,
                                                    exchange.Isbn.ToString(),
                                                    exchange.Grade,
                                                    exchange.CheckedInDate.ToString(),
                                                    exchange.Term.ToString()});
        }

        public void loadDataToTable()
        {
            exchangeTable.Rows.Clear();
            List<Exchange> exchanges = exchangeService.getExchanges();
            for (int i = 0; i < exchanges.Count(); i++)
            {
                exchangeTable.Rows.Add(new String[] {"detail",
                                                    exchanges[i].LibraryCardNumber.ToString(),
                                                    exchanges[i].Isbn.ToString(),
                                                    exchanges[i].Grade,
                                                    exchanges[i].CheckedInDate.ToString(),
                                                    exchanges[i].Term.ToString()});
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            ExchangeInsertUpdateSearchForm exchangeInsertUpdateSearchForm = new ExchangeInsertUpdateSearchForm(this);
            exchangeInsertUpdateSearchForm.changeEnableInsert(false);
            if (exchangeTable.CurrentRow != null)
            {
                String isbn = exchangeTable.CurrentRow.Cells[2].Value.ToString();
                String grade = exchangeTable.CurrentRow.Cells[3].Value.ToString();
                String checkedInDate = exchangeTable.CurrentRow.Cells[4].Value.ToString();
                String libraryCardNumber = exchangeTable.CurrentRow.Cells[1].Value.ToString();
                exchangeInsertUpdateSearchForm.changeEnableGradeIsbnLibraryCardNumberTextBox(false);
                exchangeInsertUpdateSearchForm.setData(libraryCardNumber, isbn, grade, checkedInDate);
            }
            exchangeInsertUpdateSearchForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exchangeService.deleteExchange(exchangeTable.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(exchangeTable.CurrentRow.Cells[2].Value.ToString()), exchangeTable.CurrentRow.Cells[3].Value.ToString());
            exchangeTable.Rows.Remove(exchangeTable.CurrentRow);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exchangeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
