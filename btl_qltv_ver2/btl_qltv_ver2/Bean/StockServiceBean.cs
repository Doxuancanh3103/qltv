using btl_qltv_ver2.Service;
using btl_qltv_ver2.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class StockServiceBean
    {
        private static StockService stockService;

        public static StockService getBean()
        {
            if (stockService == null)
            {
                stockService = new StockImpl();
            }
            return stockService;
        }
    }
}
