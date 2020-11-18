using btl_qltv_ver2.Service;
using btl_qltv_ver2.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Bean
{
    class MediaServiceBean
    {
        private static MediaImpl mediaImpl;

        public static MediaService getBean()
        {
            if (mediaImpl == null)
            {
                return new MediaImpl();
            }
            return mediaImpl;
        }

    }
}
