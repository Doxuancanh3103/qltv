using btl_qltv_ver2.repos;
using btl_qltv_ver2.repos.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class ExchangeRepoServiceBean
    {
        private static ExchangeRepoService exchangeRepoService;

        public static ExchangeRepoService getBean()
        {
            if (exchangeRepoService == null)
            {
                exchangeRepoService = new ExchangeRepoImpl();
            }
            return exchangeRepoService;
        }
    }
}
