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
    public partial class ConditionInsertUpdateForm : Form
    {
        private ConditionForm conditionForm;
        private ConditionService conditionService;
        public ConditionInsertUpdateForm(ConditionForm conditionForm)
        {
            InitializeComponent();
            this.conditionForm = conditionForm;
            conditionService = ConditionServiceBean.getBean();
        }

        private void insertCustom_Click(object sender, EventArgs e)
        {
            if (conditionService.isExistCondition(gradeTextBox.Text))
            {
                MessageBox.Show("condition already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ConditionInsertSdi conditionInsertSdi = new ConditionInsertSdi();
                conditionInsertSdi.Grade = gradeTextBox.Text;
                conditionInsertSdi.Percent = Convert.ToInt32(percentTextBox.Text);
                Condition condition = conditionService.insertCondition(conditionInsertSdi);
                if (condition != null)
                {
                    this.Close();
                    conditionForm.addDataToTable(condition);
                }
            }
        }

        public void setData(String grade, String percent)
        {
            gradeTextBox.Text = grade;
            percentTextBox.Text = percent;
        }

        public void changeEnableInsert(Boolean change)
        {
            insertCustom.Visible = change;
        }

        public void changeEnableUpdate(Boolean change)
        {
            updateCustom.Visible = change;
        }


        public void changeEnableGradeTextBox(Boolean change)
        {
            gradeTextBox.Enabled = change;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateCustom_Click(object sender, EventArgs e)
        {
            ConditionUpdateSdi conditionUpdateSdi = new ConditionUpdateSdi();
            conditionUpdateSdi.Grade = gradeTextBox.Text;
            conditionUpdateSdi.Percent = Convert.ToInt32(percentTextBox.Text);
            Condition condition = conditionService.updateCondition(conditionUpdateSdi);
            if (condition != null)
            {
                this.Close();
                conditionForm.updateDataToTable(condition);
            }
        }
    }
}
