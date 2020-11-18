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
    class ConditionImpl : ConditionService
    {
        private ConditionRepoService conditionRepoService;
        public ConditionImpl()
        {
            conditionRepoService = ConditionRepoServiceBean.getBean();
        }

        public string deleteCondition(string grade)
        {
            return conditionRepoService.deleteCondition(grade);
        }

        public Condition getConditionByGrade(string grade)
        {
            return conditionRepoService.getConditionByGrade(grade);
        }

        public List<Condition> getConditions()
        {
            return conditionRepoService.getConditions();
        }

        public Condition insertCondition(ConditionInsertSdi conditionInsertSdi)
        {
            return conditionRepoService.InsertCondition(conditionInsertSdi);
        }

        public bool isExistCondition(string grade)
        {
            return conditionRepoService.isExistCondition(grade);
        }

        public Condition updateCondition(ConditionUpdateSdi conditionUpdateSdi)
        {
            return conditionRepoService.updateCondition(conditionUpdateSdi);
        }
    }
}
