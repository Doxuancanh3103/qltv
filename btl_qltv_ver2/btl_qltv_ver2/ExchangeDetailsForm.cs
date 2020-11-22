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
    public partial class ExchangeDetailsForm : Form
    {
        private PatronService patronService;
        private EmployeeService employeeService;
        private MediaService mediaService;
        private CheckOutService checkOutService;
        private Exchange exchange;

        internal Exchange Exchange { get => exchange; set => exchange = value; }

        public ExchangeDetailsForm()
        {
            InitializeComponent();
            patronService = PatronServiceBean.getBean();
            employeeService = EmployeeServiceBean.getBean();
            mediaService = MediaServiceBean.getBean();
            checkOutService = CheckOutServiceBean.getBean();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ExchangeDetailsForm_Load(object sender, EventArgs e)
        {
            Patron patron = patronService.getPatronByLibraryCardNumber(exchange.LibraryCardNumber);
            Media media = mediaService.getMeidaByIsbn(exchange.Isbn);
            CheckOut checkOut = checkOutService.getCheckOutByKey(exchange.LibraryCardNumber, exchange.Isbn, exchange.Grade);
            lcnLabel.Text += " " + patron.LibraryCardNumber;
            nameLabel.Text += " " + patron.Name;
            dobLabel.Text += " " + patron.DOB1.ToString();
            phoneNumberLabel.Text += " " + patron.PhoneNumber;
            addressLabel.Text += " " + patron.Address;
            if (checkOut != null)
            {
                paidStatusLabel.Text += " " + "Paid the fee";
                currentConditionLabel.Text += " " + checkOut.CurrentCondition;
                Employee employee = employeeService.getEmployeeById(checkOut.Checker);
                emplIdLabel.Text += " " + employee.EmployeeId1;
                nameCheckerLabel.Text += " " + employee.Name;
                ssnLabel.Text += " " + employee.SSN1;
                salaryLabel.Text += " " + employee.Salary.ToString();
                dobCheckerLabel.Text += " " + employee.DOB1.ToString();
                addressCheckerLabel.Text += " " + employee.Address;
                phoneNumberCheckerLabel.Text += " " + employee.PhoneNumber;
                roleTypeLabel.Text += " " + employee.RoleType;
                checkerPanel.Visible = true;
            }
            else
            {
                paidStatusLabel.Text += " " + "Not paid yet";
            }

            isbnLabel.Text += " " + media.Isbn.ToString();
            titleLabel.Text += " " + media.Title;
            publishingYearLabel.Text += " " + media.Year.ToString();
            publisherLabel.Text += " " + media.Publisher;
            typeLabel.Text += " " + media.Type;
            subjectLabel.Text += " " + media.Subject;
            initialConditionLabel.Text += " " + exchange.Grade;
        }

        private void detailPatron_Click(object sender, EventArgs e)
        {
            PatronStatistic patronStatistic = new PatronStatistic();
            patronStatistic.Patron = patronService.getPatronByLibraryCardNumber(exchange.LibraryCardNumber);
            patronStatistic.ShowDialog();
        }
    }
}
