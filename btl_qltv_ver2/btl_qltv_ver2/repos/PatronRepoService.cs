﻿using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.repos
{
    interface PatronRepoService
    {
        List<Patron> getPatrons();

        Patron insertMedia(PatronInsertSdi patronInsertSdi);
        Patron getPatronByLibraryCardNumber(String libraryCardNumber);

        Patron updatePatron(PatronUpdateSdi sdi);

        List<Patron> searchPatrons(PatronSearchSdi patronSearchSdi);
        Boolean isExistAccount(String username);

        List<Patron> filterPatrons(String obj, String sender);

        PatronDetails getPatronDetailsById(String libraryCardNumber);

        String deletePatron(String libraryCardNumber);

        int sumOfMediaBorrowed(String libraryCardNumber);

        int sumOfDamageMedia(String libraryCardNumber);

        int sumOfMediaReturned(String libraryCardNumber);

        int sumOfMediaBorrowing(String libraryCardNumber);
    }
}
