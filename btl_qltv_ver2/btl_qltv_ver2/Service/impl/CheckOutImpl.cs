using btl_qltv_ver2.Bean;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.repos;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Service.impl
{
    class CheckOutImpl : CheckOutService
    {
        private CheckOutRepoService checkOutRepoService;
        private EmployeeService employeeService;
        private ConditionService conditionService;
        private PatronService patronService;
        private MediaService mediaService;
        public CheckOutImpl()
        {
            checkOutRepoService = CheckOutRepoServiceBean.getBean();
            conditionService = ConditionServiceBean.getBean();
            patronService = PatronServiceBean.getBean();
            mediaService = MediaServiceBean.getBean();
            employeeService = EmployeeServiceBean.getBean();
        }
        public string deleteCheckOut(string libraryCardNumber, int isbn, string grade)
        {
            return checkOutRepoService.deleteCheckOut(libraryCardNumber,isbn,grade);
        }

        public CheckOut getCheckOutByKey(string libraryCardNumber, int isbn, string grade)
        {
            return checkOutRepoService.getCheckOutByKey(libraryCardNumber, isbn, grade);
        }

        public CheckOutStatisticDomain getCheckOutDetailsFee(int year)
        {
            return checkOutRepoService.getCheckOutDetailsFee(year);
        }

        public List<CheckOut> getCheckOuts()
        {
            return checkOutRepoService.getCheckOuts();
        }

        public double getDeposit()
        {
            return checkOutRepoService.getDeposit();
        }

        public double getFeeDefault(int isbn, string grade)
        {
            return checkOutRepoService.getFeeDefault(isbn, grade);
        }

        public double getFine(string libraryCardNumber, int isbn, string grade)
        {
            return checkOutRepoService.getFine(libraryCardNumber, isbn, grade);
        }

        public CheckOut insertCheckOut(CheckOutInsertSdi checkOutInsertSdi)
        {
            return checkOutRepoService.insertCheckOut(checkOutInsertSdi);
        }

        public bool isExistCheckOut(string libraryCardNumber, int isbn, string grade)
        {
            return checkOutRepoService.isExistCheckOut(libraryCardNumber, isbn, grade);
        }

        public bool isExistEmplIdInEmployee(string imployeeId)
        {
            return employeeService.getEmployeeById(imployeeId) != null ? true : false;
        }

        public bool isExistGradeInCondition(string grade)
        {
            return conditionService.isExistCondition(grade);
        }

        public bool isExistISBNInMedia(int isbn)
        {
            return mediaService.getMeidaByIsbn(isbn) != null ? true : false;
        }

        public bool isExistLibraryCardNumberInPatron(string libraryCardNumber)
        {
            return patronService.getPatronByLibraryCardNumber(libraryCardNumber) != null ? true : false;
        }

        public CheckOut updateCheckOut(CheckOutUpdateSdi checkOutUpdateSdi)
        {
            return checkOutRepoService.updateCheckOut(checkOutUpdateSdi);
        }
    }
}
