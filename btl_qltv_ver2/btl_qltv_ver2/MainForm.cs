using btl_qltv_ver2.information;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_qltv_ver2
{
    public partial class MainForm : Form
    {
        private FormLogin formLogin;
        private List<BunifuAnimatorNS.AnimationType> animationTypes;
        private List<UserControl> userControls;
        public FormLogin FormLogin { get => formLogin; set => formLogin = value; }

        public MainForm()
        {
            InitializeComponent();
            animationTypes = new List<BunifuAnimatorNS.AnimationType>();
            animationTypes.Add(BunifuAnimatorNS.AnimationType.Leaf);
            animationTypes.Add(BunifuAnimatorNS.AnimationType.Custom);
            animationTypes.Add(BunifuAnimatorNS.AnimationType.HorizBlind);
            animationTypes.Add(BunifuAnimatorNS.AnimationType.HorizSlide);
            animationTypes.Add(BunifuAnimatorNS.AnimationType.Mosaic);
            animationTypes.Add(BunifuAnimatorNS.AnimationType.Particles);
            animationTypes.Add(BunifuAnimatorNS.AnimationType.Rotate);
            animationTypes.Add(BunifuAnimatorNS.AnimationType.Scale);
            animationTypes.Add(BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide);
            animationTypes.Add(BunifuAnimatorNS.AnimationType.ScaleAndRotate);
            animationTypes.Add(BunifuAnimatorNS.AnimationType.Transparent);
            animationTypes.Add(BunifuAnimatorNS.AnimationType.VertBlind);
            animationTypes.Add(BunifuAnimatorNS.AnimationType.VertSlide);


            userControls = new List<UserControl>();
            userControls.Add(patronForm1);
            userControls.Add(mediaForm1);
            userControls.Add(employeeForm1);
            userControls.Add(authorForm1);
            userControls.Add(conditionForm1);
            userControls.Add(policyForm1);
            userControls.Add(stockForm1);
            userControls.Add(exchangeForm1);
            userControls.Add(checkOutForm1);
            userControls.Add(home1);
        }

        private BunifuAnimatorNS.AnimationType random()
        {
            Random random = new Random();
            int i = random.Next(0, 13);
            return animationTypes[i];
        }

        private void patronManagerButton_Click(object sender, EventArgs e)
        {
            bunifuTransition1.AnimationType = random();
            foreach (UserControl userControl in userControls)
            {
                if (userControl.Visible == true)
                {
                    bunifuTransition1.HideSync(userControl);
                    break;
                }
            }
            bunifuTransition1.Show(patronForm1);
            patronForm1.loadDataToTable();
        }

        private void mediaManagerButton_Click(object sender, EventArgs e)
        {
            bunifuTransition1.AnimationType = random();
            foreach (UserControl userControl in userControls)
            {
                if (userControl.Visible == true)
                {
                    bunifuTransition1.HideSync(userControl);
                    break;
                }
            }
            bunifuTransition1.Show(mediaForm1);
            mediaForm1.loadDataToTable();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin.Visible = true;
            formLogin.setPassword("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bunifuTransition1.AnimationType = random();
            foreach (UserControl userControl in userControls)
            {
                if (userControl.Visible == true)
                {
                    bunifuTransition1.HideSync(userControl);
                    break;
                }
            }
            bunifuTransition1.Show(employeeForm1);
            employeeForm1.loadDataToTable();
        }

        private void authorManagerButton_Click(object sender, EventArgs e)
        {
            bunifuTransition1.AnimationType = random();
            foreach (UserControl userControl in userControls)
            {
                if (userControl.Visible == true)
                {
                    bunifuTransition1.HideSync(userControl);
                    break;
                }
            }
            bunifuTransition1.Show(authorForm1);
            authorForm1.loadDataToTable();
        }

        private void conditionManagerButton_Click(object sender, EventArgs e)
        {
            bunifuTransition1.AnimationType = random();
            foreach (UserControl userControl in userControls)
            {
                if (userControl.Visible == true)
                {
                    bunifuTransition1.HideSync(userControl);
                    break;
                }
            }
            bunifuTransition1.Show(conditionForm1);
            conditionForm1.loadDataToTable();
        }

        private void policiesManagerButton_Click(object sender, EventArgs e)
        {
            bunifuTransition1.AnimationType = random();
            foreach (UserControl userControl in userControls)
            {
                if (userControl.Visible == true)
                {
                    bunifuTransition1.HideSync(userControl);
                    break;
                }
            }
            bunifuTransition1.Show(policyForm1);
            policyForm1.loadDataToTable();
        }

        private void stockManagerButton_Click(object sender, EventArgs e)
        {
            bunifuTransition1.AnimationType = random();
            foreach (UserControl userControl in userControls)
            {
                if (userControl.Visible == true)
                {
                    bunifuTransition1.HideSync(userControl);
                    break;
                }
            }
            bunifuTransition1.Show(stockForm1);
            stockForm1.loadDataToTable();
        }

        private void exchangeManagerButton_Click(object sender, EventArgs e)
        {
            bunifuTransition1.AnimationType = random();
            foreach (UserControl userControl in userControls)
            {
                if (userControl.Visible == true)
                {
                    bunifuTransition1.HideSync(userControl);
                    break;
                }
            }
            bunifuTransition1.Show(exchangeForm1);
            exchangeForm1.loadDataToTable();
        }

        private void checkOutManagerButton_Click(object sender, EventArgs e)
        {
            bunifuTransition1.AnimationType = random();
            foreach (UserControl userControl in userControls)
            {
                if (userControl.Visible == true)
                {
                    bunifuTransition1.HideSync(userControl);
                    break;
                }
            }
            bunifuTransition1.Show(checkOutForm1);
            checkOutForm1.loadDataToTable();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            usernameLabelInfor.Text += Information.Username;
            if ("P".Equals(Information.Type))
            {
                typeLabelInfor.Text += "Patron";
                patronManagerButton.Enabled = false;
                checkOutManagerButton.Enabled = false;
                exchangeManagerButton.Enabled = false;
                employeeManagerButton.Enabled = false;
                patronManagerButton.Enabled = false;
                stockManagerButton.Enabled = false;
            }else if ("E".Equals(Information.Type))
            {
                typeLabelInfor.Text += "Employee";
                employeeManagerButton.Enabled = false;
            }
            else
            {
                typeLabelInfor.Text += "Librian";
            }
        }

        private void checkOutForm1_Load(object sender, EventArgs e)
        {
           
        }

        private void exchangeForm1_Load(object sender, EventArgs e)
        {

        }

        private void stockForm1_Load(object sender, EventArgs e)
        {

        }

        private void policyForm1_Load(object sender, EventArgs e)
        {
            if ("P".Equals(Information.Type))
            {
                policyForm1.changeEnableDelete(false);
                policyForm1.changeEnableInsert(false);
                policyForm1.changeEnableUpdate(false);
            }
            else if ("E".Equals(Information.Type))
            {
                policyForm1.changeEnableDelete(false);
                policyForm1.changeEnableInsert(false);
                policyForm1.changeEnableUpdate(false);
            }
        }

        private void conditionForm1_Load(object sender, EventArgs e)
        {
            if ("P".Equals(Information.Type))
            {
                conditionForm1.changeEnableDelete(false);
                conditionForm1.changeEnableInsert(false);
                conditionForm1.changeEnableUpdate(false);
            }
        }

        private void authorForm1_Load(object sender, EventArgs e)
        {
            if ("P".Equals(Information.Type))
            {
                authorForm1.changeEnableDelete(false);
                authorForm1.changeEnableInsert(false);
                authorForm1.changeEnableUpdate(false);
            }
        }

        private void employeeForm1_Load(object sender, EventArgs e)
        {
            
        }

        private void mediaForm1_Load(object sender, EventArgs e)
        {
            if ("P".Equals(Information.Type))
            {
                mediaForm1.changeEnableDelete(false);
                mediaForm1.changeEnableInsert(false);
                mediaForm1.changeEnableUpdate(false);
            }
        }

        private void patronForm1_Load(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            bunifuTransition1.AnimationType = random();
            foreach (UserControl userControl in userControls)
            {
                if (userControl.Visible == true)
                {
                    bunifuTransition1.HideSync(userControl);
                    break;
                }
            }
            bunifuTransition1.Show(home1);
            checkOutForm1.loadDataToTable();
        }
    }
}
