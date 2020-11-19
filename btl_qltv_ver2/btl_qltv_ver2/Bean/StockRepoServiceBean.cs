using btl_qltv_ver2.repos;
using btl_qltv_ver2.repos.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class StockRepoServiceBean
    {
        private static StockRepoService stockRepoService;

        public static StockRepoService getBean()
        {
            if (stockRepoService == null)
            {
                stockRepoService = new StockRepoImpl();
            }
            return stockRepoService;
        }
    }
}
