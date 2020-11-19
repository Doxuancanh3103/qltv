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
    class StockImpl : StockService
    {
        private StockRepoService stockRepoService;
        private MediaService mediaService;
        private ConditionService conditionService;
        public StockImpl()
        {
            stockRepoService = StockRepoServiceBean.getBean();
            mediaService = MediaServiceBean.getBean();
            conditionService = ConditionServiceBean.getBean();
        }
        public string deleteStock(string grade, int isbn)
        {
            return stockRepoService.deleteStock(grade, isbn);
        }

        public Stock getStockByCode(string grade, int isbn)
        {
            return stockRepoService.getStockByCode(grade, isbn);
        }

        public List<Stock> getStocks()
        {
            return stockRepoService.getStocks();
        }

        public Stock insertStock(StockInsertSdi stockInsertSdi)
        {
            return stockRepoService.insertStock(stockInsertSdi);
        }

        public bool isExistGradeInCondition(string grade)
        {
            return conditionService.isExistCondition(grade);
        }

        public bool isExistIsbnInMedia(int isbn)
        {
            if (mediaService.getMeidaByIsbn(isbn) != null)
            {
                return true;
            }
            return false;
        }

        public bool isExistStock(string grade, int isbn)
        {
            return stockRepoService.isExistStock(grade, isbn);
        }

        public Stock updateStock(StockUpdateSdi stockUpdateSdi)
        {
            return stockRepoService.updateStock(stockUpdateSdi);
        }
    }
}
