using btl_qltv_ver2.Service;
using btl_qltv_ver2.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class ConditionServiceBean
    {
        private static ConditionService conditionService;

        public static ConditionService getBean()
        {
            if (conditionService == null)
            {
                conditionService = new ConditionImpl();
            }
            return conditionService;
        }
    }
}
