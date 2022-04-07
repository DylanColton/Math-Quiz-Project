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
    public partial class frmQ1B : Form
    {
        public frmQ1B()
        {
            InitializeComponent();
            lblName.Text = "Name: " + frmLogin.GetPlayer().GetUserName();
            lblScore.Text = "Score: "+ frmLogin.GetPlayer().GetScore().ToString();
            CenterToParent();
        }

        private void frmQ1B_Load(object sender, EventArgs e)
        {
            btn1BNext.Visible = false;
            picAvatar.BackgroundImage = frmLogin.Avatar;
            picAvatar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnCheck1A_Click(object sender, EventArgs e)
        {
            if ((rbnA1Ans1.Checked == false && rbnA1Ans2.Checked == false && rbnA1Ans3.Checked == false && rbnA1Ans4.Checked == false) || (rbnA2Ans1.Checked == false && rbnA2Ans2.Checked == false && rbnA2Ans3.Checked == false && rbnA2Ans4.Checked == false) || (rbnA3Ans1.Checked == false && rbnA3Ans2.Checked == false && rbnA3Ans3.Checked == false && rbnA3Ans4.Checked == false))
            {
                MessageBox.Show("You haven't answered all the question. Please select an answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                btnCheck1A.Visible = false;
                btn1BNext.Visible = true;

                if (rbnA1Ans2.Checked == true)
                {
                    rbnA1Ans2.ForeColor = Color.LimeGreen;
                    rbnA1Ans1.Visible = false;
                    rbnA1Ans3.Visible = false;
                    rbnA1Ans4.Visible = false;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    rbnA1Ans1.Visible = false;
                    rbnA1Ans3.Visible = false;
                    rbnA1Ans4.Visible = false;
                    
                }

                if (rbnA2Ans1.Checked == true)
                {
                    rbnA2Ans1.ForeColor = Color.LimeGreen;
                    rbnA2Ans2.Visible = false;
                    rbnA2Ans3.Visible = false;
                    rbnA2Ans4.Visible = false;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    rbnA2Ans2.Visible = false;
                    rbnA2Ans3.Visible = false;
                    rbnA2Ans4.Visible = false;
                    
                }

                if (rbnA3Ans4.Checked == true)
                { 
                    rbnA3Ans4.ForeColor = Color.LimeGreen;
                    rbnA3Ans1.Visible = false;
                    rbnA3Ans2.Visible = false;
                    rbnA3Ans3.Visible = false;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    rbnA3Ans1.Visible = false;
                    rbnA3Ans2.Visible = false;
                    rbnA3Ans3.Visible = false;
                    
                }

                lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();
            }
        }

        private void btn1ANext_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int V = rnd.Next(1, 3);
            switch (V)
            {
                case 1:
                    frmQ2A frmQ2A = new frmQ2A();
                    frmQ2A.Show();
                    frmQ2A.Activate();
                    this.Hide();
                    break;
                case 2:
                    frmQ2B frmQ2B = new frmQ2B();
                    frmQ2B.Show();
                    frmQ2B.Activate();
                    this.Hide();
                    break;
            }
        }

        private void btnQ1Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use expansion of brakets to find each answer.\nFor each question, select one answer that you think is correct.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}
