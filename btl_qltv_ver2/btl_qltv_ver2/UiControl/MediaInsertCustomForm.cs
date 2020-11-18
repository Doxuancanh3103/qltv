using btl_qltv_ver2.Bean;
using btl_qltv_ver2.common;
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
    public partial class MediaInsertCustomForm : Form
    {
        MediaService mediaService;
        MediaForm mediaForm;
        public MediaInsertCustomForm(MediaForm mediaForm)
        {
            InitializeComponent();
            mediaService = MediaServiceBean.getBean();
            this.mediaForm = mediaForm;
        }

        private void isbnTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void titleTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void insertCustom_Click(object sender, EventArgs e)
        {

            if (this.isNumber(isbnTextBox.Text))
            {
                MediaInsertSdi mediaInsertSdi = new MediaInsertSdi();
                mediaInsertSdi.Isbn = Convert.ToInt32(isbnTextBox.Text);
                mediaInsertSdi.Title = titleTextBox.Text;
                mediaInsertSdi.Year = yearTextBox.Text;
                mediaInsertSdi.Publisher = publisherTextBox.Text;
                mediaInsertSdi.Subject = subjectTextBox.Text;
                mediaInsertSdi.Type = typeTextBox.Text;
                Media media = mediaService.insertMedia(mediaInsertSdi);
                if (media != null)
                {
                    this.Close();
                    mediaForm.addDataToTable(media);
                }
            }
            else
            {
                MessageBox.Show("isbn is not valid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh()
        {
            isbnTextBox.Text = "";
            titleTextBox.Text = "";
            publisherTextBox.Text = "";
            typeTextBox.Text = "";
            subjectTextBox.Text = "";
        }

        public void changeEnableInsert(Boolean change)
        {
            insertCustom.Enabled = change;
        }

        public void changeEnableUpdate(Boolean change)
        {
            updateCustom.Enabled = change;
        }

        public void setData(String isbn,String title,String datetime,String publisher,String type,String subject)
        {
            isbnTextBox.Text = isbn;
            titleTextBox.Text = title;
            yearTextBox.Value = DateTime.Parse(datetime);
            publisherTextBox.Text = publisher;
            typeTextBox.Text = type;
            subjectTextBox.Text = subject;
        }

        public void changeEnableIsbnTextBox(Boolean change)
        {
            isbnTextBox.Enabled = change;
        }

        private void updateCustom_Click(object sender, EventArgs e)
        {
            if (this.isNumber(isbnTextBox.Text))
            {
                MediaUpdateSdi mediaUpdateSdi = new MediaUpdateSdi();
                mediaUpdateSdi.Isbn = Convert.ToInt32(isbnTextBox.Text);
                mediaUpdateSdi.Title = titleTextBox.Text;
                mediaUpdateSdi.Year = yearTextBox.Text;
                mediaUpdateSdi.Publisher = publisherTextBox.Text;
                mediaUpdateSdi.Subject = subjectTextBox.Text;
                mediaUpdateSdi.Type = typeTextBox.Text;
                Media media = mediaService.updateMedia(mediaUpdateSdi);
                if (media != null)
                {
                    this.Close();
                    mediaForm.updateDataToTable(media);
                }
            }
            else
            {
                MessageBox.Show("isbn is not valid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
