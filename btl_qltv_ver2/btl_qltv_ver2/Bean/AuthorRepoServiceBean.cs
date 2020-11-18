using btl_qltv_ver2.repos;
using btl_qltv_ver2.repos.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class AuthorRepoServiceBean
    {
        private static AuthorRepoService authorRepoService;
        public static AuthorRepoService getBean()
        {
            if (authorRepoService == null)
            {
                authorRepoService = new AuthorRepoImpl();
            }
            return authorRepoService;
        }
    }
}
