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
    public partial class ConditionForm : UserControl
    {

        private ConditionService conditionService;
        public ConditionForm()
        {
            InitializeComponent();
            conditionService = ConditionServiceBean.getBean();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            ConditionInsertUpdateForm conditionInsertUpdateForm = new ConditionInsertUpdateForm(this);
            conditionInsertUpdateForm.changeEnableUpdate(false);
            conditionInsertUpdateForm.ShowDialog();
        }

        public void addDataToTable(Object obj)
        {
            Condition condition = (Condition)obj;
            conditionTable.Rows.Add(new String[] {condition.Grade,
                                                    condition.Percent.ToString()});
        }

        public void loadDataToTable()
        {
            if (conditionTable.Rows.Count == 1)
            {
                List<Condition> condtions = conditionService.getConditions();
                for (int i = 0; i < condtions.Count(); i++)
                {
                    conditionTable.Rows.Add(new String[] {condtions[i].Grade,
                                                    condtions[i].Percent.ToString()});
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            
            ConditionInsertUpdateForm conditionInsertUpdateForm = new ConditionInsertUpdateForm(this);
            conditionInsertUpdateForm.changeEnableInsert(false);
            if (conditionTable.CurrentRow != null)
            {
                String grade = conditionTable.CurrentRow.Cells[0].Value.ToString();
                String percent = conditionTable.CurrentRow.Cells[1].Value.ToString();
                conditionInsertUpdateForm.changeEnableGradeTextBox(false);
                conditionInsertUpdateForm.setData(grade, percent);
            }
            conditionInsertUpdateForm.ShowDialog();
        }

        public void updateDataToTable(Object obj)
        {
            Condition condition = (Condition)obj;
            conditionTable.CurrentRow.Cells[0].Value = condition.Grade;
            conditionTable.CurrentRow.Cells[1].Value = condition.Percent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conditionService.deleteCondition(conditionTable.CurrentRow.Cells[0].Value.ToString());
            conditionTable.Rows.Remove(conditionTable.CurrentRow);
        }
    }
}
