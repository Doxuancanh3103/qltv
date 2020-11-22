using btl_qltv_ver2.Bean;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.repos;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_qltv_ver2.Service.impl
{
    class PatronImpl : PatronService
    {
        private PatronRepoService patronRepoService;
        public PatronImpl()
        {
            patronRepoService = PatronRepoServiceBean.getBean();
        }

        public String deletePatron(string libraryCardNumber)
        {
            return patronRepoService.deletePatron(libraryCardNumber);
        }

        public List<Patron> filterPatrons(string obj, string sender)
        {
            return patronRepoService.filterPatrons(obj, sender);
        }

        public Patron getPatronByLibraryCardNumber(String libraryCardNumber)
        {
            return patronRepoService.getPatronByLibraryCardNumber(libraryCardNumber);
        }

        public PatronDetails getPatronDetailsById(string libraryCardNumber)
        {
            return patronRepoService.getPatronDetailsById(libraryCardNumber);
        }

        public List<Patron> getPatrons()
        {
            return patronRepoService.getPatrons();
        }

        public Patron insertPatron(PatronInsertSdi patronInsertSdi)
        {
            if (this.getPatronByLibraryCardNumber(patronInsertSdi.LibraryCardNumber) != null)
            {
                MessageBox.Show("already exists isbn", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return patronRepoService.insertMedia(patronInsertSdi);
        }

        public bool isExistAccount(string username)
        {
            return patronRepoService.isExistAccount(username);
        }

        public List<Patron> searchPatrons(PatronSearchSdi patronSearchSdi)
        {
            return patronRepoService.searchPatrons(patronSearchSdi);
        }

        public int sumOfDamageMedia(string libraryCardNumber)
        {
            return patronRepoService.sumOfDamageMedia(libraryCardNumber);
        }

        public int sumOfMediaBorrowed(string libraryCardNumber)
        {
            return patronRepoService.sumOfMediaBorrowed(libraryCardNumber);
        }

        public int sumOfMediaBorrowing(string libraryCardNumber)
        {
            return patronRepoService.sumOfMediaBorrowing(libraryCardNumber);
        }

        public int sumOfMediaReturned(string libraryCardNumber)
        {
            return patronRepoService.sumOfMediaReturned(libraryCardNumber);
        }

        public Patron updatePatron(PatronUpdateSdi patronUpdateSdi)
        {
            return patronRepoService.updatePatron(patronUpdateSdi);
        }
    }
}
