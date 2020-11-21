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
using System.Windows.Forms.DataVisualization.Charting;

namespace btl_qltv_ver2
{
    public partial class PatronStatistic : Form
    {
        private Patron patron;
        private PatronService patronService;
        public PatronStatistic()
        {
            InitializeComponent();
            patronService = PatronServiceBean.getBean();
        }

        internal Patron Patron { get => patron; set => patron = value; }

        private void PatronStatistic_Load(object sender, EventArgs e)
        {
            PatronDetails patronDetails = patronService.getPatronDetailsById(patron.LibraryCardNumber);

            if (patronDetails == null)
            {
                MessageBox.Show("This year this patron does not borrow books", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                patronStatictisTable.Series["Borrowed"].Points.AddXY("January", patronDetails.January);
                patronStatictisTable.Series["Borrowed"].Points.AddXY("February", patronDetails.February);
                patronStatictisTable.Series["Borrowed"].Points.AddXY("March", patronDetails.March);
                patronStatictisTable.Series["Borrowed"].Points.AddXY("April", patronDetails.April);
                patronStatictisTable.Series["Borrowed"].Points.AddXY("May", patronDetails.May);
                patronStatictisTable.Series["Borrowed"].Points.AddXY("June", patronDetails.June);
                patronStatictisTable.Series["Borrowed"].Points.AddXY("July", patronDetails.July);
                patronStatictisTable.Series["Borrowed"].Points.AddXY("August", patronDetails.August);
                patronStatictisTable.Series["Borrowed"].Points.AddXY("September", patronDetails.September);
                patronStatictisTable.Series["Borrowed"].Points.AddXY("October", patronDetails.October);
                patronStatictisTable.Series["Borrowed"].Points.AddXY("November", patronDetails.November);
                patronStatictisTable.Series["Borrowed"].Points.AddXY("December", patronDetails.December);


            }

            pieDamage.Series["pie"].Points.AddXY("damage", patronService.sumOfDamageMedia(patron.LibraryCardNumber).ToString());
            pieDamage.Series["pie"].Points.AddXY("safe", (patronService.sumOfMediaBorrowed(patron.LibraryCardNumber)-patronService.sumOfDamageMedia(patron.LibraryCardNumber)).ToString());

            nameLabel.Text += " " + patron.Name;
            dobLabel.Text += " " + patron.DOB1.ToString();
            phoneNumberLabel.Text += " " + patron.PhoneNumber;
            addressLabel.Text += " " + patron.Address;
            borrowedLabel.Text += " " + patronService.sumOfMediaBorrowed(patron.LibraryCardNumber).ToString();
            damageLabel.Text += " " + patronService.sumOfDamageMedia(patron.LibraryCardNumber).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patronStatictisTable_Click(object sender, EventArgs e)
        {

        }
    }
}
