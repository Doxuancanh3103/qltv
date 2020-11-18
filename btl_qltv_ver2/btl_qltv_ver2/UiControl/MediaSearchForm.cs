using btl_qltv_ver2.Bean;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using btl_qltv_ver2.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_qltv_ver2.UiControl
{
    public partial class MediaSearchForm : Form
    {
        private MediaService mediaService;
        public MediaSearchForm()
        {
            InitializeComponent();
            mediaService = MediaServiceBean.getBean();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchCustom_Click(object sender, EventArgs e)
        {
            MediaSearchSdi mediaSearchSdi = new MediaSearchSdi();
            if ("".Equals(isbnTextBox.Text.Trim()))
            {
                mediaSearchSdi.Isbn = -1;
            }
            else
            {
                if (this.isNumber(isbnTextBox.Text))
                {
                    mediaSearchSdi.Isbn = Convert.ToInt32(isbnTextBox.Text);
                }
                else
                {
                    MessageBox.Show("isbn is not valid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if ("".Equals(titleTextBox.Text.Trim()))
            {
                mediaSearchSdi.Title = null;
            }
            else
            {
                mediaSearchSdi.Title = titleTextBox.Text;
            }

            if ("".Equals(publisherTextBox.Text.Trim()))
            {
                mediaSearchSdi.Publisher = null;
            }
            else
            {
                mediaSearchSdi.Publisher = publisherTextBox.Text;
            }

            if ("".Equals(typeTextBox.Text.Trim()))
            {
                mediaSearchSdi.Type = null;
            }
            else
            {
                mediaSearchSdi.Type = typeTextBox.Text;
            }

            if ("".Equals(subjectTextBox.Text.Trim()))
            {
                mediaSearchSdi.Subject = null;
            }
            else
            {
                mediaSearchSdi.Subject = subjectTextBox.Text;
            }

            List<Media> medias = mediaService.SearchMedia(mediaSearchSdi);

            MediaResultSearchForm mediaResultSearchForm = new MediaResultSearchForm();
            mediaResultSearchForm.Medias = medias;
            mediaResultSearchForm.ShowDialog();
        }
        private Boolean isNumber(String isbn)
        {
            int k = -1;
            try
            {
                k = Convert.ToInt32(isbn);
            }
            catch (Exception e)
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
