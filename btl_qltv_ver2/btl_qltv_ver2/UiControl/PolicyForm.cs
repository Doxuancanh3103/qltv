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
    public partial class PolicyForm : UserControl
    {
        private PolicyService policyService;
        public PolicyForm()
        {
            InitializeComponent();
            policyService = PolicyServiceBean.getBean();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            PolicyInsertUpdateForm policyInsertUpdateForm = new PolicyInsertUpdateForm(this);
            policyInsertUpdateForm.changeEnableUpdate(false);
            policyInsertUpdateForm.ShowDialog();
        }

        public void updateDataToTable(Object obj)
        {
            Policy policy = (Policy)obj;
            policyTable.CurrentRow.Cells[0].Value = policy.Description;
            policyTable.CurrentRow.Cells[1].Value = policy.Value;
        }

        public void addDataToTable(Object obj)
        {
            Policy policy = (Policy)obj;
            policyTable.Rows.Add(new String[] {policy.Description,
                                                    policy.Value.ToString()});
        }

        public void loadDataToTable()
        {
            policyTable.Rows.Clear();
            List<Policy> policies = policyService.getPolicies();
            for (int i = 0; i < policies.Count(); i++)
            {
                policyTable.Rows.Add(new String[] {policies[i].Description,
                                                    policies[i].Value.ToString()});
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            PolicyInsertUpdateForm policyInsertUpdateForm = new PolicyInsertUpdateForm(this);
            policyInsertUpdateForm.changeEnableInsert(false);
            if (policyTable.CurrentRow != null)
            {
                String description = policyTable.CurrentRow.Cells[0].Value.ToString();
                String value = policyTable.CurrentRow.Cells[1].Value.ToString();
                policyInsertUpdateForm.changeEnableDescriptionTextBox(false);
                policyInsertUpdateForm.setData(description, value);
            }
            policyInsertUpdateForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            policyService.deletePolicy(policyTable.CurrentRow.Cells[0].Value.ToString());
            policyTable.Rows.Remove(policyTable.CurrentRow);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void policyTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void changeEnableInsert(bool change)
        {
            insert.Enabled = change;
        }

        public void changeEnableUpdate(bool change)
        {
            update.Enabled = change;
        }

        public void changeEnableDelete(bool change)
        {
            delete.Enabled = change;
        }
    }
}
