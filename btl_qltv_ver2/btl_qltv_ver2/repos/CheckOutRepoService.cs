using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.repos
{
    interface CheckOutRepoService
    {
        List<CheckOut> getCheckOuts();
        CheckOut insertCheckOut(CheckOutInsertSdi checkOutInsertSdi);
        CheckOut getCheckOutByKey(String libraryCardNumber, int isbn, String grade);

        CheckOut updateCheckOut(CheckOutUpdateSdi checkOutUpdateSdi);

        //List<Exchange> searchAuthors(AuthorSearchSdi authorSearchSdi);

        String deleteCheckOut(String libraryCardNumber, int isbn, String grade);

        Boolean isExistCheckOut(String libraryCardNumber, int isbn, String grade);

        CheckOutStatisticDomain getCheckOutDetailsFee(int year);

        double getFine(String libraryCardNumber, int isbn, String grade);
        double getDeposit();

        double getFeeDefault(int isbn, String grade);
    }
}
