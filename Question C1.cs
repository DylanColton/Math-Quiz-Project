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
    public partial class frmQC1 : Form
    {
        public frmQC1()
        {
            InitializeComponent();
            // To show the name entered at the Login form
            lblName.Text = "Name: " + frmLogin.GetPlayer().GetUserName();
            // To show the score accumulated throughout the game
            lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();
            // To set the center of the form to the centre of the previous form upon load
            CenterToParent();
        }

        private void frmQC1_Load(object sender, EventArgs e)
        {
            // Upon loading the form the corresponding code takes effect
            btnC1Next.Visible = false;
            picAvatar.BackgroundImage = frmLogin.Avatar;
            picAvatar.BackgroundImageLayout = ImageLayout.Stretch;

            // Randomization of numbers (To allow further replayability
            Random rnd = new Random();
            int A1 = rnd.Next(1, 11);
            lblQ1A.Text = Convert.ToString(A1);
            int A2 = rnd.Next(1, 11);
            lblQ1B.Text = Convert.ToString(A2);
            int A3 = rnd.Next(1, 11);
            lblQ1C.Text = Convert.ToString(A3);
            int A4 = rnd.Next(1, 11);
            lblQ1D.Text = Convert.ToString(A4);
            int B1 = rnd.Next(1, 11);
            lblQ2A.Text = Convert.ToString(B1);
            int B2 = rnd.Next(1, 11);
            lblQ2B.Text = Convert.ToString(B2);
            int B3 = rnd.Next(1, 11);
            lblQ2C.Text = Convert.ToString(B3);
            int B4 = rnd.Next(1, 11);
            lblQ2D.Text = Convert.ToString(B4);
            int C1 = rnd.Next(1, 11);
            lblQ3A.Text = Convert.ToString(C1);
            int C2 = rnd.Next(1, 11);
            lblQ3B.Text = Convert.ToString(C2);
            int C3 = rnd.Next(1, 11);
            lblQ3C.Text = Convert.ToString(C3);
            int C4 = rnd.Next(1, 11);
            lblQ3D.Text = Convert.ToString(C4);
            int D1 = rnd.Next(1, 11);
            lblQ4A.Text = Convert.ToString(D1);
            int D2 = rnd.Next(1, 11);
            lblQ4B.Text = Convert.ToString(D2);
            int D3 = rnd.Next(1, 11);
            lblQ4C.Text = Convert.ToString(D3);
            int D4 = rnd.Next(1, 11);
            lblQ4D.Text = Convert.ToString(D4);
        }

        private void BtnC1Help_Click(object sender, EventArgs e)
        {
            // Prevention of an error, in case the player fails to answer all the questions
            MessageBox.Show("Use your knowledge of the order of operations to answer the questions.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnCheckC1_Click(object sender, EventArgs e)
        {
            // Retrieving the numbers necessary for equations for validation 
            double A1 = Convert.ToDouble(lblQ1A.Text);
            double A2 = Convert.ToDouble(lblQ1B.Text);
            double A3 = Convert.ToDouble(lblQ1C.Text);
            double A4 = Convert.ToDouble(lblQ1D.Text);
            double B1 = Convert.ToDouble(lblQ2A.Text);
            double B2 = Convert.ToDouble(lblQ2B.Text);
            double B3 = Convert.ToDouble(lblQ2C.Text);
            double B4 = Convert.ToDouble(lblQ2D.Text);
            double C1 = Convert.ToDouble(lblQ3A.Text);
            double C2 = Convert.ToDouble(lblQ3B.Text);
            double C3 = Convert.ToDouble(lblQ3C.Text);
            double C4 = Convert.ToDouble(lblQ3D.Text);
            double D1 = Convert.ToDouble(lblQ4A.Text);
            double D2 = Convert.ToDouble(lblQ4B.Text);
            double D3 = Convert.ToDouble(lblQ4C.Text);
            double D4 = Convert.ToDouble(lblQ4D.Text);

            // Doing the equations for Question 1
            double A = A2 - A3;
            A = A * A;
            A = A1 * A;
            A = A + A4;
            A = Math.Round(A, 2);

            // Doing the equations for Question 2
            B1 = B1 * B1;
            double B = B3 / B4;
            B = B * B2;
            B = B1 - B;
            B = Math.Round(B, 2);

            // Doing the equations for Question 3
            double C = C3 / C4;
            C1 = C1 + C2;
            C = C1 - C;
            C = Math.Round(C, 2);

            // Doing the equations for Question 4
            double D = D1 - D2;
            D = D / D3;
            D = D * D4;
            D = Math.Round(D, 2);

            // If at least field is left unanswered
            if (txtAns1.Text == string.Empty || txtAns2.Text == string.Empty || txtAns3.Text == string.Empty || txtAns4.Text == string.Empty)
            {
                MessageBox.Show("You haven't answered all the question. Please select an answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // If all fields are answered
            else
            {
                // Hiding the Check Button and showing the button for the next form
                btnCheckC1.Visible = false;
                btnC1Next.Visible = true;

                // Verifying the answers given, and awarding or deducting points accordingly
                if (txtAns1.Text == Convert.ToString(A))
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
                    txtAns1.Text = Convert.ToString(A);
                }

                if (txtAns2.Text == Convert.ToString(B))
                {
                    txtAns2.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAns2.BackColor = Color.Red;
                    txtAns2.Text = Convert.ToString(B);
                }

                if (txtAns3.Text == Convert.ToString(C))
                {
                    txtAns3.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAns3.BackColor = Color.Red;
                    txtAns3.Text = Convert.ToString(C);
                }

                if (txtAns4.Text == Convert.ToString(D))
                {
                    txtAns4.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAns4.BackColor = Color.Red;
                    txtAns4.Text = Convert.ToString(D);
                }

                lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();
            }
        }

        private void btnC1Next_Click(object sender, EventArgs e)
        {
            // Randomizing which form will be loaded next
            Random rnd = new Random();
            int V = rnd.Next(1, 3);

            switch (V)
            {
                case 1:
                    frmQ3A frmQ3A = new frmQ3A();
                    frmQ3A.Activate();
                    frmQ3A.Show();
                    this.Hide();
                    break;

                case 2:
                    frmQ3B frmQ3B = new frmQ3B();
                    frmQ3B.Activate();
                    frmQ3B.Show();
                    this.Hide();
                    break;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Loading a calculator I created for the player
            Calculator Calculator = new Calculator();
            Calculator.Activate();
            Calculator.Show();
        }
    }
}
