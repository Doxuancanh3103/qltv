using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Service
{
    interface PolicyService
    {
        Policy getPolicyByDescription(String description);
        List<Policy> getPolicies();

        Boolean isExistPolicy(String description);
        Policy insertPolicy(PolicyInsertSdi conditionInsertSdi);
        Policy updatePolicy(PolicyInsertSdi conditionUpdateSdi);

        String deletePolicy(String description);
    }
}
