using btl_qltv_ver2.Bean;
using btl_qltv_ver2.domain;
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

namespace btl_qltv_ver2
{
    public partial class ExchangeStatistic : Form
    {
        private ExchangeService exchangeService;
        public ExchangeStatistic()
        {
            InitializeComponent();
            exchangeService = ExchangeServiceBean.getBean();
        }

        private void ExchangeStatistic_Load(object sender, EventArgs e)
        {
            ExchangeStatisticDomain exchangeDetails = exchangeService.getExchangeDetails();

            if (exchangeDetails == null)
            {
                MessageBox.Show("Not found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                exchangeStatisticTable.Series["amount"].Points.AddXY("January", exchangeDetails.January);
                exchangeStatisticTable.Series["amount"].Points.AddXY("February", exchangeDetails.February);
                exchangeStatisticTable.Series["amount"].Points.AddXY("March", exchangeDetails.March);
                exchangeStatisticTable.Series["amount"].Points.AddXY("April", exchangeDetails.April);
                exchangeStatisticTable.Series["amount"].Points.AddXY("May", exchangeDetails.May);
                exchangeStatisticTable.Series["amount"].Points.AddXY("June", exchangeDetails.June);
                exchangeStatisticTable.Series["amount"].Points.AddXY("July", exchangeDetails.July);
                exchangeStatisticTable.Series["amount"].Points.AddXY("August", exchangeDetails.August);
                exchangeStatisticTable.Series["amount"].Points.AddXY("September", exchangeDetails.September);
                exchangeStatisticTable.Series["amount"].Points.AddXY("October", exchangeDetails.October);
                exchangeStatisticTable.Series["amount"].Points.AddXY("November", exchangeDetails.November);
                exchangeStatisticTable.Series["amount"].Points.AddXY("December", exchangeDetails.December);
            }
        }

        private void exchangeStatisticTable_Click(object sender, EventArgs e)
        {

        }
    }
}
