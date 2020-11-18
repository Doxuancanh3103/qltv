﻿using btl_qltv_ver2.repos;
using btl_qltv_ver2.repos.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class PatronRepoServiceBean
    {
        private static PatronRepoService patronRepoService;
        public static PatronRepoService getBean()
        {
            if (patronRepoService == null)
            {
                patronRepoService = new PatronRepoImpl();
            }
            return patronRepoService;
        }
    }
}
