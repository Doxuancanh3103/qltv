using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using btl_qltv_ver2.sdo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.repos
{
    interface MediaRepoService
    {
        Media insertMedia(MediaInsertSdi mediaInsertSdi);
        Media getMediaByIsbn(int isbn);

        List<Media> getMedias();

        Media updateMedia(MediaUpdateSdi mediaUpdateSdi);

        List<Media> searchMedia(MediaSearchSdi mediaSearchSdi);

        int deleteMedia(int isbn);
    }
}
