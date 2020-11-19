using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.Service;
using btl_qltv_ver2.Bean;

namespace btl_qltv_ver2.UiControl
{
    public partial class MediaForm : UserControl
    {
        private MediaInsertCustomForm mediaInsertUpdateCustom;
        private MediaService mediaService;
        public MediaForm()
        {
            InitializeComponent();
            mediaService = MediaServiceBean.getBean();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            mediaInsertUpdateCustom = new MediaInsertCustomForm(this);
            mediaInsertUpdateCustom.changeEnableUpdate(false);
            mediaInsertUpdateCustom.ShowDialog();
        }

        public void addDataToTable(Object obj)
        {

            Media media = (Media)obj;
            mediaTable.Rows.Add(new String[] {"detail",media.Isbn.ToString(),
                                                    media.Title,
                                                    media.Year.ToString(),
                                                    media.Publisher,
                                                    media.Type,
                                                    media.Subject });
        }

        public void loadDataToTable()
        {
            mediaTable.Rows.Clear();
            List<Media> medias = mediaService.getMedias();
            for (int i = 0; i < medias.Count(); i++)
            {
                mediaTable.Rows.Add(new String[] {"detail",medias[i].Isbn.ToString(),
                                                    medias[i].Title,
                                                    medias[i].Year.ToString(),
                                                    medias[i].Publisher,
                                                    medias[i].Type,
                                                    medias[i].Subject });
            }

        }

        private void update_Click(object sender, EventArgs e)
        {

            mediaInsertUpdateCustom = new MediaInsertCustomForm(this);
            mediaInsertUpdateCustom.changeEnableInsert(false);
            if (mediaTable.CurrentRow != null)
            {
                String isbn = mediaTable.CurrentRow.Cells[1].Value.ToString();
                String title = mediaTable.CurrentRow.Cells[2].Value.ToString();
                String datetime = mediaTable.CurrentRow.Cells[3].Value.ToString();
                String publisher = mediaTable.CurrentRow.Cells[4].Value.ToString();
                String type = mediaTable.CurrentRow.Cells[5].Value.ToString();
                String subject = mediaTable.CurrentRow.Cells[6].Value.ToString();
                mediaInsertUpdateCustom.changeEnableIsbnTextBox(false);
                mediaInsertUpdateCustom.setData(isbn, title, datetime, publisher, type, subject);
            }
            mediaInsertUpdateCustom.ShowDialog();
        }

        public void updateDataToTable(Object obj)
        {
            Media media = (Media)obj;
            mediaTable.CurrentRow.Cells[2].Value = media.Title;
            mediaTable.CurrentRow.Cells[3].Value = media.Year.ToString();
            mediaTable.CurrentRow.Cells[4].Value = media.Publisher;
            mediaTable.CurrentRow.Cells[5].Value = media.Type;
            mediaTable.CurrentRow.Cells[6].Value = media.Subject;
        }

        private void search_Click(object sender, EventArgs e)
        {
            MediaSearchForm mediaSearchForm = new MediaSearchForm();
            mediaSearchForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mediaService.deleteMedia(Convert.ToInt32(mediaTable.CurrentRow.Cells[1].Value.ToString()));
            mediaTable.Rows.Remove(mediaTable.CurrentRow);
        }
    }
}
