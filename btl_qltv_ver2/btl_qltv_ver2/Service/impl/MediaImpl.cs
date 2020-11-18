using btl_qltv_ver2.Bean;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.repos;
using btl_qltv_ver2.repos.impl;
using btl_qltv_ver2.sdi;
using btl_qltv_ver2.sdo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_qltv_ver2.Service.impl
{
    class MediaImpl : MediaService
    {
        private MediaRepoService mediaRepoService;

        public MediaImpl()
        {
            mediaRepoService = MediaRepoBean.getBean();
        }
        internal MediaRepoService MediaRepoService1 { get => mediaRepoService; set => mediaRepoService = value; }

        public int deleteMedia(int isbn)
        {
           return mediaRepoService.deleteMedia(isbn);
        }

        public List<Media> getMedias()
        {
            return mediaRepoService.getMedias();
        }

        public Media getMeidaByIsbn(int isbn)
        {
            return mediaRepoService.getMediaByIsbn(isbn);
        }

        public Media insertMedia(MediaInsertSdi mediaInsertSdi)
        {
            if (this.getMeidaByIsbn(mediaInsertSdi.Isbn) != null)
            {
                MessageBox.Show("already exists isbn", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (!this.isNumber(mediaInsertSdi.Isbn))
            {
                MessageBox.Show("isbn is not valid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return mediaRepoService.insertMedia(mediaInsertSdi);
        }

        public List<Media> SearchMedia(MediaSearchSdi mediaSearchSdi)
        {
            return mediaRepoService.searchMedia(mediaSearchSdi);
        }

        public Media updateMedia(MediaUpdateSdi mediaUpdateSdi)
        {
            if (!this.isNumber(mediaUpdateSdi.Isbn))
            {
                MessageBox.Show("isbn is not valid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return mediaRepoService.updateMedia(mediaUpdateSdi);
        }


        private Boolean isNumber(int isbn)
        {
            int k = -1;
            try
            {
                k = Convert.ToInt32(isbn);
            }catch(Exception e)
            {

            }

            if (k == -1)
            {
                return false;
            }
            return true;
        }
    }
}
