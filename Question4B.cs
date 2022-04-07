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
    public partial class frmQ4B : Form
    {
        public frmQ4B()
        {
            InitializeComponent();
            lblName.Text = "Name: " + frmLogin.GetPlayer().GetUserName();
            lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();
            CenterToParent();
        }

        private void frmQ4B_Load(object sender, EventArgs e)
        {
            btn4ANext.Visible = false;
            picAvatar.BackgroundImage = frmLogin.Avatar;
            picAvatar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnQ4Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For each question, select the correct answer from the drop down box", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnCheck4B_Click(object sender, EventArgs e)
        {
            if (CobxAns1.Text == string.Empty || CobxAns2.Text == string.Empty || CobxAns3.Text == string.Empty || CobxAns4.Text == string.Empty)
            {
                MessageBox.Show("You haven't answered all the questions. Please select an answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                btnCheck4A.Visible = false;
                btn4ANext.Visible = true;

                if (CobxAns1.Text == "(x+4)^2+(-25)")
                {
                    CobxAns1.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    CobxAns1.BackColor = Color.Red;
                    CobxAns1.Text = "(x+4)^2+(-25)";
                    
                    
                }

                if (CobxAns2.Text == "(x-3)^2+(-25)")
                {
                    CobxAns2.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    CobxAns2.BackColor = Color.Red;
                    CobxAns2.Text = "(x-3)^2+(-25)";
                    
                    
                }

                if (CobxAns3.Text == "(x+6)^2+(12)")
                {
                    CobxAns3.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    CobxAns3.BackColor = Color.Red;
                    CobxAns3.Text = "(x+6)^2+(12)";
                    
                    
                }

                if (CobxAns4.Text == "(x-5)^2+(-125)")
                {
                    CobxAns4.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    CobxAns4.BackColor = Color.Red;
                    CobxAns4.Text = "(x-5)^2+(-125)";
                    
                    
                }

                lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();
            }
        }

        private void btn4BNext_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int V = rnd.Next(1, 3);
            switch (V)
            {
                case 1:
                    FrmQ5A FrmQ5A = new FrmQ5A();
                    FrmQ5A.Show();
                    FrmQ5A.Activate();
                    this.Hide();
                    break;
                case 2:
                    frmQ5B FrmQ5B = new frmQ5B();
                    FrmQ5B.Show();
                    FrmQ5B.Activate();
                    this.Hide();
                    break;
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Calculator Calculator = new Calculator();
            Calculator.Activate();
            Calculator.Show();
        }
    }
}
