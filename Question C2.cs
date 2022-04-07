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
    public partial class frmQC2 : Form
    {
        public frmQC2()
        {
            InitializeComponent();
            // To show the name entered at the Login form
            lblName.Text = "Name: " + frmLogin.GetPlayer().GetUserName();
            // To show the score accumulated throughout the game
            lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();
            // To set the center of the form to the centre of the previous form upon load
            CenterToParent();
        }

        private void frmQC2_Load(object sender, EventArgs e)
        {
            // Upon loading the form the corresponding code takes effect
            btnC2Next.Visible = false;
            picAvatar.BackgroundImage = frmLogin.Avatar;
            picAvatar.BackgroundImageLayout = ImageLayout.Stretch;

            // Randomization of base numbers (To allow further replayability)
            Random rnd = new Random();
            int ABase = rnd.Next(1, 11);
            lblABase.Text = Convert.ToString(ABase);
            int BBase = rnd.Next(1, 11);
            lblBBase.Text = Convert.ToString(BBase);
            int CBase = rnd.Next(1, 11);
            lblCBase.Text = Convert.ToString(CBase);
            int DBase = rnd.Next(1, 11);
            lblDBase.Text = Convert.ToString(DBase);

            //Randomisation of powers
            int A = rnd.Next(2, 6);
            lblAPower.Text = Convert.ToString(A);
            int B = rnd.Next(2, 6);
            lblBPower.Text = Convert.ToString(B);
            int C = rnd.Next(2, 6);
            lblCPower.Text = Convert.ToString(C);
            int D = rnd.Next(2, 6);
            lblDPower.Text = Convert.ToString(D);
        }

        private void BtnC2Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use your knowledge of indices to answer the question", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnCheckC2_Click(object sender, EventArgs e)
        {
            // If at least one field is left unanswered
            if (txtAns1.Text == string.Empty || txtAns2.Text == string.Empty || txtAns3.Text == string.Empty || txtAns4.Text == string.Empty)
            {
                // Prevention of an error, in case the player fails to answer all the questions
                MessageBox.Show("You haven't answered all the questions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // If all fields are answered
            else
            {
                // Hiding the Check Button and showing the button for the next form
                btnC2Next.Visible = true;
                btnCheckC2.Visible = false;

                // Retrieving the numbers necessary for equations for validation 
                double ABase = Convert.ToDouble(lblABase.Text);
                double a1 = ABase;
                double BBase = Convert.ToDouble(lblBBase.Text);
                double b1 = BBase;
                double CBase = Convert.ToDouble(lblCBase.Text);
                double c1 = CBase;
                double DBase = Convert.ToDouble(lblDBase.Text);
                double d1 = DBase;

                double A = Convert.ToDouble(lblAPower.Text);
                double B = Convert.ToDouble(lblBPower.Text);
                double C = Convert.ToDouble(lblCPower.Text);
                double D = Convert.ToDouble(lblDPower.Text);

                // Doing the equations for Question 1
                while (A != 1)
                {
                    A--;
                    ABase = ABase * a1;
                }
                Math.Round(A, 2);

                // Doing the equations for Question 2
                while (B != 1)
                {
                    B--;
                    BBase = BBase * b1;
                }
                BBase = Math.Sqrt(BBase);
                Math.Round(B, 2);

                // Doing the equations for Question 3
                while (C != 1)
                {
                    C--;
                    CBase = CBase * c1;
                }
                Math.Round(C, 2);

                // Doing the equations for Question 4
                while (D != 1)
                {
                    D--;
                    DBase = DBase * d1;
                }
                DBase = Math.Sqrt(DBase);
                Math.Round(D, 2);

                if (txtAns1.Text == Convert.ToString(ABase))
                {
                    // Colour "Highlight" appears in the background of the textbox to demonstrate the answer given by player is correct
                    txtAns1.BackColor = Color.LimeGreen;
                    // Retrieves the IncreaseScore method to award points to the player
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    // Colour "ControlDark" appears in the background of the textbox to demonstrate the answer given by player is incorrect
                    txtAns1.BackColor = Color.Red;
                    // Retrieves the DecreaseScore method to penalise player by taking away a point
                    
                    // Displays correct answer in the textbox to show player the correct answer
                    txtAns1.Text = Convert.ToString(ABase);
                }

                if (txtAns2.Text == Convert.ToString(BBase))
                {
                    txtAns2.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAns2.BackColor = Color.Red;
                    
                }

                if (txtAns3.Text == Convert.ToString(CBase))
                {
                    txtAns3.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAns3.BackColor = Color.Red;
                    
                    txtAns3.Text = Convert.ToString(CBase);
                }

                if (txtAns4.Text == Convert.ToString(DBase))
                {
                    txtAns4.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAns4.BackColor = Color.Red;
                    
                    txtAns4.Text = Convert.ToString(DBase);
                }

                lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();
            }
        }

        private void btnC2Next_Click(object sender, EventArgs e)
        {
            // Randomizing which form will be loaded next
            Random rnd = new Random();
            int V = rnd.Next(1, 3);

            switch (V)
            {
                case 1:
                    frmQ4A frmQ4A = new frmQ4A();
                    frmQ4A.Activate();
                    frmQ4A.Show();
                    this.Hide();
                    break;

                case 2:
                    frmQ4B frmQ4B = new frmQ4B();
                    frmQ4B.Activate();
                    frmQ4B.Show();
                    this.Hide();
                    break;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Loads calculator I made for the player
            Calculator Calculator = new Calculator();
            Calculator.Activate();
            Calculator.Show();
            //System.Diagnostics.Process.Start("Calc");
        }
    }
}
