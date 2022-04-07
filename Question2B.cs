using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class frmQ2B : Form
    {
        public frmQ2B()
        {
            InitializeComponent();
            lblName.Text = "Name: "+ frmLogin.GetPlayer().GetUserName();
            lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();
            CenterToParent();
        }

        private void frmQ2B_Load(object sender, EventArgs e)
        {
            btn2ANext.Visible = false;
            btnSpecial.Visible = false;
            picAvatar.BackgroundImage = frmLogin.Avatar;
            picAvatar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnCheck2A_Click(object sender, EventArgs e)
        {
            if (txtAns1.Text == string.Empty || txtAns2.Text == string.Empty || txtAns3.Text == string.Empty)
            {
                MessageBox.Show("You haven't answered all the questions. Please select an answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int A = frmLogin.GetPlayer().GetScore();

                if (txtAns1.Text == "7.37")
                {
                    txtAns1.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAns1.BackColor = Color.Red;
                    txtAns1.Text = "7.37";
                }

                if (txtAns2.Text == "77.04")
                {
                    txtAns2.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAns2.BackColor = Color.Red;
                    txtAns2.Text = "77.04";
                }

                if (txtAns3.Text == "64.91")
                {
                    txtAns3.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAns3.BackColor = Color.Red;
                    txtAns3.Text = "64.91";
                }

                lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();
                int B = frmLogin.GetPlayer().GetScore();

                if (B == A + 3)
                {
                    btnCheck2A.Visible = false;
                    btnSpecial.Visible = true;
                }
                else
                {
                    btnCheck2A.Visible = false;
                    btn2ANext.Visible = true;
                }
            }
        }

        private void btn2ANext_Click(object sender, EventArgs e)
        {
                Random rnd = new Random();
                int V = rnd.Next(1, 3);
                switch (V)
                {
                    case 1:
                        frmQ3A frmQ3A = new frmQ3A();
                        frmQ3A.Show();
                        frmQ3A.Activate();
                        this.Hide();
                        break;
                    case 2:
                        frmQ3B frmQ3B = new frmQ3B();
                        frmQ3B.Show();
                        frmQ3B.Activate();
                        this.Hide();
                        break;
            }
        }

        private void btnQ2Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the Sin and Cos rules to find the answers in each triangle!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnMyCalc_Click(object sender, EventArgs e)
        {
            Calculator Calculator = new Calculator();
            Calculator.Activate();
            Calculator.Show();
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            frmQC1 frmQC1 = new frmQC1();
            frmQC1.Activate();
            frmQC1.Show();
            this.Hide();
        }

        private void btnTrigCalc_Click(object sender, EventArgs e)
        {
            TrigCalculator TrigCalculator = new TrigCalculator();
            TrigCalculator.Activate();
            TrigCalculator.Show();
        }
    }
}
