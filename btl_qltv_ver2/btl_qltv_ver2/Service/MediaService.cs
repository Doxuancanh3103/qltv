using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using btl_qltv_ver2.sdo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Service
{
    interface MediaService
    {
        Media insertMedia(MediaInsertSdi mediaInsertSdi);
        Media getMeidaByIsbn(int isbn);

        List<Media> getMedias();
        Media updateMedia(MediaUpdateSdi mediaUpdateSdi);
        List<Media> SearchMedia(MediaSearchSdi mediaSearchSdi);

        int deleteMedia(int isbn);

        List<Media> filterMedias(String obj, String sender);
    }
}
