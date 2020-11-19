using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Service
{
    interface StockService
    {
        Stock getStockByCode(String grade,int isbn);
        List<Stock> getStocks();

        Boolean isExistStock(String grade,int isbn);
        Stock insertStock(StockInsertSdi stockInsertSdi);
        Stock updateStock(StockUpdateSdi stockUpdateSdi);

        Boolean isExistGradeInCondition(String grade);
        Boolean isExistIsbnInMedia(int isbn);
        String deleteStock(String grade,int isbn);
    }
}
