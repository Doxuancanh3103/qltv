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
    class ExchangeImpl : ExchangeService
    {
        private ExchangeRepoService exchangeRepoService;
        private ConditionService conditionService;
        private PatronService patronService;
        private MediaService mediaService;
        public ExchangeImpl()
        {
            exchangeRepoService = ExchangeRepoServiceBean.getBean();
            conditionService = ConditionServiceBean.getBean();
            patronService = PatronServiceBean.getBean();
            mediaService = MediaServiceBean.getBean();
        }
        public string deleteExchange(string libraryCardNumber, int isbn, string grade)
        {
            return exchangeRepoService.deleteExchange(libraryCardNumber, isbn, grade);
        }

        public Exchange getExchangeByKey(string libraryCardNumber, int isbn, string grade)
        {
            return exchangeRepoService.getExchangeByKey(libraryCardNumber, isbn, grade);
        }

        public List<Exchange> getExchanges()
        {
            return exchangeRepoService.getExchanges();
        }

        public ExchangeStatisticDomain getExchangeDetails()
        {
            return exchangeRepoService.getExchangeDetails();
        }

        public Exchange insertExchange(ExchangeInsertSdi exchangeInsertSdi)
        {
            return exchangeRepoService.insertExchange(exchangeInsertSdi);
        }

        public bool isExistExchange(string libraryCardNumber, int isbn, string grade)
        {
            return exchangeRepoService.isExistExchange(libraryCardNumber, isbn, grade);
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

        public Exchange updateExchange(ExchangeUpdateSdi exchangeUpdateSdi)
        {
            return exchangeRepoService.updateExchange(exchangeUpdateSdi);
        }
    }
}
