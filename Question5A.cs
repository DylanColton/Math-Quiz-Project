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
    public partial class FrmQ5A : Form
    {

        public FrmQ5A()
        {
            InitializeComponent();
            lblName.Text = "Name: " + frmLogin.GetPlayer().GetUserName();
            lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();
            CenterToParent();
        }

        private void FrmQ5A_Load(object sender, EventArgs e)
        {
            btn5ANext.Visible = false;
            picAvatar.BackgroundImage = frmLogin.Avatar;
            picAvatar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn5ANext_Click(object sender, EventArgs e)
        {
            frmLeader frmLeader = new frmLeader();
            frmLeader.Show();
            frmLeader.Activate();
            this.Hide();
        }

        private void btnCheck5A_Click(object sender, EventArgs e)
        {
            btnCheck5A.Visible = false;
            btn5ANext.Visible = true;

            if (txtAboveC1.Text == string.Empty || txtAboveA1.Text == string.Empty || txtAboveB1.Text == string.Empty || txtExpansion1.Text == string.Empty || txtAboveC2.Text == string.Empty || txtBelowC2.Text == string.Empty || txtAboveA2.Text == string.Empty || txtExpansion2.Text == string.Empty)
            {
                MessageBox.Show("You haven't answered all the questions. Please select an answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (txtAboveC1.Text == "6")
                {
                    txtAboveC1.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAboveC1.Text = "6";
                    txtAboveC1.BackColor = Color.Red;
                    
                }
                if (txtAboveA1.Text == "2")
                {
                    txtAboveA1.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAboveA1.Text = "2";
                    txtAboveA1.BackColor = Color.Red;
                    
                }
                if (txtAboveB1.Text == "4")
                {
                    txtAboveB1.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAboveB1.Text = "4";
                    txtAboveB1.BackColor = Color.Red;
                    
                }
                if (txtExpansion1.Text == "135x^2" || txtExpansion1.Text == "135x2")
                {
                    txtExpansion1.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtExpansion1.Text = "135x^2";
                    txtExpansion1.BackColor = Color.Red;
                    
                    
                }
                


                if (txtAboveC2.Text == "4")
                {
                    txtAboveC2.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAboveC1.Text = "4";
                    txtAboveC2.BackColor = Color.Red;
                    
                }
                if (txtBelowC2.Text == "1")
                {
                    txtBelowC2.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtBelowC2.Text = "1";
                    txtBelowC2.BackColor = Color.Red;
                    
                }
                if (txtAboveA2.Text == "3")
                {
                    txtAboveA2.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtAboveA2.Text = "3";
                    txtAboveA2.BackColor = Color.Red;
                }
                if (txtExpansion2.Text == "-8x")
                {
                    txtExpansion2.BackColor = Color.LimeGreen;
                    frmLogin.GetPlayer().IncreaseScore();
                    frmLogin.GetPlayer().IncreaseScore();
                }
                else
                {
                    txtExpansion2.Text = "-8x";
                    txtExpansion2.BackColor = Color.Red;
                }

                lblScore.Text = "Score: " + frmLogin.GetPlayer().GetScore().ToString();
            }
        }

        private void btn2_1_MouseDown(object sender, MouseEventArgs e)
        {
            btn2_1.DoDragDrop(btn2_1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btn6_1_MouseDown(object sender, MouseEventArgs e)
        {
            btn6_1.DoDragDrop(btn6_1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btn4_1_MouseDown(object sender, MouseEventArgs e)
        {
            btn4_1.DoDragDrop(btn4_1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btn3_2_MouseDown(object sender, MouseEventArgs e)
        {
            btn3_2.DoDragDrop(btn3_2.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btn4_2_MouseDown(object sender, MouseEventArgs e)
        {
            btn4_2.DoDragDrop(btn4_2.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btn1_2_MouseDown(object sender, MouseEventArgs e)
        {
            btn1_2.DoDragDrop(btn1_2.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void txtAboveC1_DragDrop(object sender, DragEventArgs e)
        {
            txtAboveC1.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
        private void txtAboveC1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void txtAboveA1_DragDrop(object sender, DragEventArgs e)
        {
            txtAboveA1.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
        private void txtAboveA1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void txtAboveB1_DragDrop(object sender, DragEventArgs e)
        {
            txtAboveB1.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
        private void txtAboveB1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void txtAboveC2_DragDrop(object sender, DragEventArgs e)
        {
            txtAboveC2.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
        private void txtAboveC2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void txtBelowC2_DragDrop(object sender, DragEventArgs e)
        {
            txtBelowC2.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
        private void txtBelowC2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void txtAboveB2_DragDrop(object sender, DragEventArgs e)
        {
            txtAboveA2.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
        private void txtAboveB2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnQ5Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Drag and drop the correct numbers on to the binomial expansion formula to answer the expansion of it!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calculator Calculator = new Calculator();
            Calculator.Activate();
            Calculator.Show();
        }

        private void btnNCRValue_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt16(txtNValue.Text);
            int R = Convert.ToInt16(txtRValue.Text);
            int n = Convert.ToInt16(txtNValue.Text);
            int r = Convert.ToInt16(txtRValue.Text);

            int Rfactorial = r;
            
            while (Rfactorial != 1)
            {
                Rfactorial--;
                r = r * Rfactorial;
            }

            int Nfactorial = n;

            while (Nfactorial != 1)
            {
                Nfactorial--;
                n = n * Nfactorial;
            }

            N = Convert.ToInt16(txtNValue.Text);
            R = Convert.ToInt16(txtRValue.Text);
            int x = N - R;
            int X = N - R;

            while (X != 1)
            {
                X--;
                x = x * X;
            }

            int nCr = 0;

            nCr = n / (r * x);

            txtnCrValue.Text = Convert.ToString(nCr);
        }
    }
}