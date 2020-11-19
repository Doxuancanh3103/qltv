using btl_qltv_ver2.Service;
using btl_qltv_ver2.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class PolicyServiceBean
    {
        private static PolicyService policyService;

        public static PolicyService getBean()
        {
            if (policyService == null)
            {
                policyService = new PolicyImpl();
            }
            return policyService;
        }
    }
}
