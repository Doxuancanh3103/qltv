using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Service
{
    interface CheckOutService
    {
        List<CheckOut> getCheckOuts();
        CheckOut insertCheckOut(CheckOutInsertSdi checkOutInsertSdi);
        CheckOut getCheckOutByKey(String libraryCardNumber, int isbn, String grade);

        CheckOut updateCheckOut(CheckOutUpdateSdi checkOutUpdateSdi);

        //List<Exchange> searchAuthors(AuthorSearchSdi authorSearchSdi);

        String deleteCheckOut(String libraryCardNumber, int isbn, String grade);

        Boolean isExistCheckOut(String libraryCardNumber, int isbn, String grade);

        Boolean isExistLibraryCardNumberInPatron(String libraryCardNumber);
        Boolean isExistISBNInMedia(int isbn);
        Boolean isExistGradeInCondition(String grade);
        Boolean isExistEmplIdInEmployee(String imployeeId);

        CheckOutStatisticDomain getCheckOutDetailsFee(int year);

        double getFine(String libraryCardNumber, int isbn, String grade);
        double getDeposit();
        double getFeeDefault(int isbn, String grade);
    }
}
