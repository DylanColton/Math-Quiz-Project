using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MainMenu
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            // Centres the form (as it is the first form) for the player
            CenterToScreen();
            // Gets the score the last person had achieved
            GetLastScore();
            // Doesn't allow the Last Score to be displayed (until there is a value to give it that will be rectified later)
            lblLastScore.Visible = false;
        }

        private void btnMainNext_Click(object sender, EventArgs e)
        {
            // Opens the next form
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            frmLogin.Activate();
            this.Hide();
        }

        private void GetLastScore()
        {
            try
            {
                // Binary Reader searches through the "score" file to retrieve the last score
                BinaryReader b = new BinaryReader(File.Open("score.bin", FileMode.Open));

                int pos = 0;
                int length = (int)b.BaseStream.Length;

                while (pos < length)
                {
                    // Assigns a value to the score, then adds on the score, without taking away the text that was there prior
                    int score = b.ReadInt32();
                    lblLastScore.Text += " " + score;
                    lblLastScore.Visible = true;
                    pos += sizeof(int);
                }

                b.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("General Exception: " + ex);
                lblLastScore.Visible = false;
            }
        }
    }
}