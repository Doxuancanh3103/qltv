using btl_qltv_ver2.repos;
using btl_qltv_ver2.repos.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class PolicyRepoServiceBean
    {
        private static PolicyRepoService policyRepoService;

        public static PolicyRepoService getBean()
        {
            if (policyRepoService == null)
            {
                policyRepoService = new PolicyRepoImpl();
            }
            return policyRepoService;
        }
    }
}
