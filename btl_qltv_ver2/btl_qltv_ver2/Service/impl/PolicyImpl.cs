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
    class PolicyImpl : PolicyService
    {
        private PolicyRepoService policyRepoService;

        public PolicyImpl()
        {
            policyRepoService = PolicyRepoServiceBean.getBean();
        }
        public string deletePolicy(string description)
        {
            return policyRepoService.deletePolicy(description);
        }

        public List<Policy> getPolicies()
        {
            return policyRepoService.getPolicies();
        }

        public Policy getPolicyByDescription(string description)
        {
            return policyRepoService.getPolicyByDescription(description);
        }

        public Policy insertPolicy(PolicyInsertSdi conditionInsertSdi)
        {
            return policyRepoService.insertPolicy(conditionInsertSdi);
        }

        public bool isExistPolicy(string description)
        {
            return policyRepoService.isExistPolicy(description);
        }

        public Policy updatePolicy(PolicyUpdateSdi policyUpdateSdi)
        {
            return policyRepoService.updatePolicy(policyUpdateSdi);
        }
    }
}
