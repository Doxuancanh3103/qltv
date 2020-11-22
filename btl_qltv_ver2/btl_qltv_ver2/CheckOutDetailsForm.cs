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

namespace btl_qltv_ver2.UiControl
{
    public partial class CheckOutDetailsForm : Form
    {

        private CheckOut checkedOut;
        private PatronService patronService;
        private EmployeeService employeeService;
        private MediaService mediaService;
        private ExchangeService exchangeService;
        private CheckOutService checkOutService;
        public CheckOutDetailsForm()
        {
            InitializeComponent();
            patronService = PatronServiceBean.getBean();
            employeeService = EmployeeServiceBean.getBean();
            mediaService = MediaServiceBean.getBean();
            exchangeService = ExchangeServiceBean.getBean();
            checkOutService = CheckOutServiceBean.getBean();
        }

        internal CheckOut CheckedOut { get => checkedOut; set => checkedOut = value; }

        private void CheckOutDetailsForm_Load(object sender, EventArgs e)
        {
            Patron patron = patronService.getPatronByLibraryCardNumber(checkedOut.LibraryCardNumber);
            Media media = mediaService.getMeidaByIsbn(checkedOut.Isbn);
            lcnLabel.Text += " " + patron.LibraryCardNumber;
            nameLabel.Text += " " + patron.Name;
            dobLabel.Text += " " + patron.DOB1.ToString();
            phoneNumberLabel.Text += " " + patron.PhoneNumber;
            addressLabel.Text += " " + patron.Address;



            currentConditionLabel.Text += " " + checkedOut.CurrentCondition;
            Employee employee = employeeService.getEmployeeById(checkedOut.Checker);
            emplIdLabel.Text += " " + employee.EmployeeId1;
            nameCheckerLabel.Text += " " + employee.Name;
            ssnLabel.Text += " " + employee.SSN1;
            salaryLabel.Text += " " + employee.Salary.ToString();
            dobCheckerLabel.Text += " " + employee.DOB1.ToString();
            addressCheckerLabel.Text += " " + employee.Address;
            phoneNumberCheckerLabel.Text += " " + employee.PhoneNumber;
            roleTypeLabel.Text += " " + employee.RoleType;


            isbnLabel.Text += " " + media.Isbn.ToString();
            titleLabel.Text += " " + media.Title;
            publishingYearLabel.Text += " " + media.Year.ToString();
            publisherLabel.Text += " " + media.Publisher;
            typeLabel.Text += " " + media.Type;
            subjectLabel.Text += " " + media.Subject;
            initialConditionLabel.Text += " " + checkedOut.Grade;

            Exchange exchange = exchangeService.getExchangeByKey(checkedOut.LibraryCardNumber, checkedOut.Isbn, checkedOut.Grade);
            cidLabel.Text += " " + exchange.CheckedInDate.ToString();
            codLabel.Text += " " + checkedOut.CheckOutDate.ToString();
            feeLabel.Text += " " + checkedOut.Fee.ToString() + "$";


            double fine = checkOutService.getFine(checkedOut.LibraryCardNumber, checkedOut.Isbn, checkedOut.Grade);
            double deposit = checkOutService.getDeposit();
            double feeDefault = checkOutService.getFeeDefault(checkedOut.Isbn, checkedOut.Grade);
            double compensation = checkedOut.Fee - fine - feeDefault + deposit;
            chart1.Series["pieFee"].Points.AddXY("fine", fine.ToString());
            chart1.Series["pieFee"].Points.AddXY("init fee", (feeDefault - 10).ToString());
            chart1.Series["pieFee"].Points.AddXY("compensation", compensation.ToString());
        }
    }
}
