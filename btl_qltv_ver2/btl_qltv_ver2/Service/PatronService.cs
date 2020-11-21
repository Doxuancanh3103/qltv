using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Service
{
    interface PatronService
    {

        List<Patron> getPatrons();

        Patron insertPatron(PatronInsertSdi patronInsertSdi);
        Patron getPatronByLibraryCardNumber(String libraryCardNumber);

        Patron updatePatron(PatronUpdateSdi patronUpdateSdi);

        List<Patron> searchPatrons(PatronSearchSdi patronSearchSdi);

        String deletePatron(String libraryCardNumber);

        List<Patron> filterPatrons(String obj, String sender);
        Boolean isExistAccount(String username);
    }
}
