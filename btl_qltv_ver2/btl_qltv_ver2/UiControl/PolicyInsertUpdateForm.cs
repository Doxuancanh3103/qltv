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
    public partial class PolicyInsertUpdateForm : Form
    {

        private PolicyForm policyForm;
        private PolicyService policyService;
        public PolicyInsertUpdateForm(PolicyForm policyForm)
        {
            InitializeComponent();
            this.policyForm = policyForm;
            policyService = PolicyServiceBean.getBean();
        }

        private void insertCustom_Click(object sender, EventArgs e)
        {
            if (policyService.isExistPolicy(descriptionTextBox.Text))
            {
                MessageBox.Show("description already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PolicyInsertSdi policyInsertSdi = new PolicyInsertSdi();
                policyInsertSdi.Description = descriptionTextBox.Text;
                policyInsertSdi.Value = Convert.ToInt32(valueTextBox.Text);
                Policy policy = policyService.insertPolicy(policyInsertSdi);
                if (policy != null)
                {
                    this.Close();
                    policyForm.addDataToTable(policy);
                }
            }
        }


        public void setData(String description, String value)
        {
            descriptionTextBox.Text = description;
            valueTextBox.Text = value;
        }

        public void changeEnableInsert(Boolean change)
        {
            insertCustom.Visible = change;
        }

        public void changeEnableUpdate(Boolean change)
        {
            updateCustom.Visible = change;
        }


        public void changeEnableDescriptionTextBox(Boolean change)
        {
            descriptionTextBox.Enabled = change;
        }

        private void updateCustom_Click(object sender, EventArgs e)
        {
            PolicyUpdateSdi policyUpdateSdi = new PolicyUpdateSdi();
            policyUpdateSdi.Description = descriptionTextBox.Text;
            policyUpdateSdi.Value = Convert.ToInt32(valueTextBox.Text);
            Policy policy = policyService.updatePolicy(policyUpdateSdi);
            if (policy != null)
            {
                this.Close();
                policyForm.updateDataToTable(policy);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
