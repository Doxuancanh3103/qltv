﻿using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.repos
{
    interface ConditionRepoService
    {
        Condition getConditionByGrade(String grade);
        List<Condition> getConditions();

        Boolean isExistCondition(String grade);
        Condition InsertCondition(ConditionInsertSdi conditionInsertSdi);
        Condition updateCondition(ConditionUpdateSdi conditionUpdateSdi);

        String deleteCondition(String grade);
    }
}
