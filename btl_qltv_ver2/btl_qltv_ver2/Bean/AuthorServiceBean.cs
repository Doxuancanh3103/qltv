using btl_qltv_ver2.Service;
using btl_qltv_ver2.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class AuthorServiceBean
    {

        private static AuthorService authorService;
        public static AuthorService getBean()
        {
            if (authorService == null)
            {
                authorService = new AuthorImpl();
            }
            return authorService;
        }
    }
}
