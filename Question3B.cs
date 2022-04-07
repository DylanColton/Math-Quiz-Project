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
    public partial class frmQ3B : Form
    {
        public frmQ3B()
        {
            InitializeComponent();
            lblName.Text = "Name: " + frmLogin.GetPlayer().GetUserName();
            lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();
            CenterToScreen();
        }

        private void frmQ3B_Load(object sender, EventArgs e)
        {
            btn3ANext.Visible = false;
            btnSpecial.Visible = false;
            picAvatar.BackgroundImage = frmLogin.Avatar;
            picAvatar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnQ3Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use your understanding of indicies to find the equating expressions", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnCheck3A_Click(object sender, EventArgs e)
        {
            int A = frmLogin.GetPlayer().GetScore();
            if ((cbxQAAns1.Checked == false && cbxQAAns2.Checked == false && cbxQAAns3.Checked == false && cbxQAAns4.Checked == false) || (cbxQBAns1.Checked == false && cbxQBAns2.Checked == false && cbxQBAns3.Checked == false && cbxQBAns4.Checked == false) || (cbxQCAns1.Checked == false && cbxQCAns2.Checked == false && cbxQCAns3.Checked == false && cbxQCAns4.Checked == false))
            {
                MessageBox.Show("You haven't answered all the questions. Please select an answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cbxQAAns2.Checked == true && cbxQAAns4.Checked == true)
                {
                    cbxQAAns2.ForeColor = Color.LimeGreen;
                    cbxQAAns4.ForeColor = Color.LimeGreen;
                    cbxQAAns1.Visible = false;
                    cbxQAAns3.Visible = false;
                    frmLogin.GetPlayer().IncreaseScore();
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else if (cbxQAAns2.Checked == true && cbxQAAns4.Checked == false)
                {
                    cbxQAAns2.ForeColor = Color.LimeGreen;
                    cbxQAAns1.Visible = false;
                    cbxQAAns3.Visible = false;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else if (cbxQAAns4.Checked == true && cbxQAAns2.Checked == false)
                {
                    cbxQAAns4.ForeColor = Color.LimeGreen;
                    cbxQAAns1.Visible = false;
                    cbxQAAns3.Visible = false;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    cbxQAAns2.Visible = false;
                    cbxQAAns4.Visible = false;
                    
                    
                }


                if (cbxQBAns1.Checked == true && cbxQBAns4.Checked == true)
                {
                    cbxQBAns1.ForeColor = Color.LimeGreen;
                    cbxQBAns4.ForeColor = Color.LimeGreen;
                    cbxQBAns2.Visible = false;
                    cbxQBAns3.Visible = false;
                    frmLogin.GetPlayer().IncreaseScore();
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else if (cbxQBAns1.Checked == true && cbxQBAns4.Checked == false)
                {
                    cbxQBAns1.ForeColor = Color.LimeGreen;
                    cbxQBAns2.Visible = false;
                    cbxQBAns3.Visible = false;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else if (cbxQBAns4.Checked == true && cbxQBAns1.Checked == false)
                {
                    cbxQBAns4.ForeColor = Color.LimeGreen;
                    cbxQBAns2.Visible = false;
                    cbxQBAns3.Visible = false;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    cbxQBAns2.Visible = false;
                    cbxQBAns3.Visible = false;
                    
                    
                }


                if (cbxQCAns2.Checked == true && cbxQCAns3.Checked == true)
                {
                    cbxQCAns2.ForeColor = Color.LimeGreen;
                    cbxQCAns3.ForeColor = Color.LimeGreen;
                    cbxQCAns1.Visible = false;
                    cbxQCAns4.Visible = false;
                    frmLogin.GetPlayer().IncreaseScore();
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else if (cbxQCAns2.Checked == true && cbxQCAns3.Checked == false)
                {
                    cbxQCAns2.ForeColor = Color.LimeGreen;
                    cbxQCAns1.Visible = false;
                    cbxQCAns4.Visible = false;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else if (cbxQCAns3.Checked == true && cbxQCAns2.Checked == false)
                {
                    cbxQCAns3.ForeColor = Color.LimeGreen;
                    cbxQCAns1.Visible = false;
                    cbxQCAns4.Visible = false;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    cbxQCAns1.Visible = false;
                    cbxQCAns4.Visible = false;
                    
                    
                }

                int B = frmLogin.GetPlayer().GetScore();
                lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();

                if (B == A + 6)
                {
                    btnCheck3A.Visible = false;
                    btnSpecial.Visible = true;
                }
                else
                {
                    btnCheck3A.Visible = false;
                    btn3ANext.Visible = true;
                }
            }
        }

        private void btn3ANext_Click(object sender, EventArgs e)
        {
                Random rnd = new Random();
                int V = rnd.Next(1, 3);
            switch (V)
            {
                case 1:
                    frmQ4A frmQ4A = new frmQ4A();
                    frmQ4A.Show();
                    frmQ4A.Activate();
                    this.Hide();
                    break;
                case 2:
                    frmQ4B frmQ4B = new frmQ4B();
                    frmQ4B.Show();
                    frmQ4B.Activate();
                    this.Hide();
                    break;
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Calculator Calculator = new Calculator();
            Calculator.Activate();
            Calculator.Show();
            System.Diagnostics.Process.Start("Calc");
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            frmQC2 frmQC2 = new frmQC2();
            frmQC2.Activate();
            frmQC2.Show();
            this.Hide();
        }
    }
}
