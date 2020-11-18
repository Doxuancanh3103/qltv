using btl_qltv_ver2.repos;
using btl_qltv_ver2.repos.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class ConditionRepoServiceBean
    {
        private static ConditionRepoService conditionRepoService;

        public static ConditionRepoService getBean()
        {
            if (conditionRepoService == null)
            {
                conditionRepoService = new ConditionRepoImpl();
            }
            return conditionRepoService;
        }
    }
}
