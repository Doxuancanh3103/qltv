using btl_qltv_ver2.Service;
using btl_qltv_ver2.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class ExchangeServiceBean
    {

        private static ExchangeService exchangeService;

        public static ExchangeService getBean()
        {
            if (exchangeService == null)
            {
                exchangeService = new ExchangeImpl();
            }
            return exchangeService;
        }
    }
}
