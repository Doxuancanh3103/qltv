using btl_qltv_ver2.repos;
using btl_qltv_ver2.repos.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class MediaRepoBean
    {
        private static MediaRepoServiceImpl mediaRepoServiceImpl;

        public static MediaRepoService getBean()
        {
            if (mediaRepoServiceImpl == null)
            {
                return new MediaRepoServiceImpl();
            }
            return mediaRepoServiceImpl;
        }
    }
}
