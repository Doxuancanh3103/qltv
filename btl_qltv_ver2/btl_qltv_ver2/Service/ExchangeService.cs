using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Service
{
    interface ExchangeService
    {

        List<Exchange> getExchanges();
        Exchange insertExchange(ExchangeInsertSdi exchangeInsertSdi);
        Exchange getExchangeByKey(String libraryCardNumber,int isbn,String grade);

        Exchange updateExchange(ExchangeUpdateSdi exchangeUpdateSdi);

        //List<Exchange> searchAuthors(AuthorSearchSdi authorSearchSdi);

        String deleteExchange(String libraryCardNumber, int isbn, String grade);

        Boolean isExistExchange(String libraryCardNumber, int isbn, String grade);

        Boolean isExistLibraryCardNumberInPatron(String libraryCardNumber);
        Boolean isExistISBNInMedia(int isbn);
        Boolean isExistGradeInCondition(String grade);
    }
}
