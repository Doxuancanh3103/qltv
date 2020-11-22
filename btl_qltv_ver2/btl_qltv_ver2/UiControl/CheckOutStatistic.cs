using btl_qltv_ver2.Bean;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.Service;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
    public partial class CheckOutStatistic : Form
    {
        private CheckOutService checkOutService;
        public CheckOutStatistic()
        {
            InitializeComponent();
            checkOutService = CheckOutServiceBean.getBean();
        }

        private void CheckOutStatistic_Load(object sender, EventArgs e)
        {
            CheckOutStatisticDomain checkOutStatisticDomain = checkOutService.getCheckOutDetailsFee(DateTime.Now.Year);
            List<ObservablePoint> observablePoints = new List<ObservablePoint>();
            if (checkOutStatisticDomain.January != -1)
            {
                observablePoints.Add(new ObservablePoint(1, checkOutStatisticDomain.January));
            }else
            {
                goto A;
            }
            if (checkOutStatisticDomain.February != -1)
            {
                observablePoints.Add(new ObservablePoint(2, checkOutStatisticDomain.February));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.March != -1)
            {
                observablePoints.Add(new ObservablePoint(3, checkOutStatisticDomain.March));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.April != -1)
            {
                observablePoints.Add(new ObservablePoint(4, checkOutStatisticDomain.April));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.May != -1)
            {
                observablePoints.Add(new ObservablePoint(5, checkOutStatisticDomain.May));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.June != -1)
            {
                observablePoints.Add(new ObservablePoint(6, checkOutStatisticDomain.June));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.July != -1)
            {
                observablePoints.Add(new ObservablePoint(7, checkOutStatisticDomain.July));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.August != -1)
            {
                observablePoints.Add(new ObservablePoint(8, checkOutStatisticDomain.August));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.September != -1)
            {
                observablePoints.Add(new ObservablePoint(9, checkOutStatisticDomain.September));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.October != -1)
            {
                observablePoints.Add(new ObservablePoint(10, checkOutStatisticDomain.October));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.November != -1)
            {
                observablePoints.Add(new ObservablePoint(11, checkOutStatisticDomain.November));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.December != -1)
            {
                observablePoints.Add(new ObservablePoint(12, checkOutStatisticDomain.December));
            }
            else
            {
                goto A;
            }
        A: cartesianChart1.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>(observablePoints),
                    PointGeometrySize = 15
                }
            };
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckOutStatisticDomain checkOutStatisticDomain = checkOutService.getCheckOutDetailsFee(Convert.ToInt32(comboBox1.SelectedItem.ToString()));
            List<ObservablePoint> observablePoints = new List<ObservablePoint>();
            if (checkOutStatisticDomain.January != -1)
            {
                observablePoints.Add(new ObservablePoint(1, checkOutStatisticDomain.January));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.February != -1)
            {
                observablePoints.Add(new ObservablePoint(2, checkOutStatisticDomain.February));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.March != -1)
            {
                observablePoints.Add(new ObservablePoint(3, checkOutStatisticDomain.March));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.April != -1)
            {
                observablePoints.Add(new ObservablePoint(4, checkOutStatisticDomain.April));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.May != -1)
            {
                observablePoints.Add(new ObservablePoint(5, checkOutStatisticDomain.May));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.June != -1)
            {
                observablePoints.Add(new ObservablePoint(6, checkOutStatisticDomain.June));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.July != -1)
            {
                observablePoints.Add(new ObservablePoint(7, checkOutStatisticDomain.July));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.August != -1)
            {
                observablePoints.Add(new ObservablePoint(8, checkOutStatisticDomain.August));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.September != -1)
            {
                observablePoints.Add(new ObservablePoint(9, checkOutStatisticDomain.September));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.October != -1)
            {
                observablePoints.Add(new ObservablePoint(10, checkOutStatisticDomain.October));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.November != -1)
            {
                observablePoints.Add(new ObservablePoint(11, checkOutStatisticDomain.November));
            }
            else
            {
                goto A;
            }
            if (checkOutStatisticDomain.December != -1)
            {
                observablePoints.Add(new ObservablePoint(12, checkOutStatisticDomain.December));
            }
            else
            {
                goto A;
            }
        A: cartesianChart1.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>(observablePoints),
                    PointGeometrySize = 15
                }
            };
        }
    }
}
