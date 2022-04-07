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
    public partial class frmLogin : Form
    {
        // This is to instance the Avatar the player will have throughout the game
        public static System.Drawing.Image Avatar;

        // Retrieves the field player from the player class
        private static Player Player;
        // Takes the method "GetPlayer()" to read or write information on the player
        public static Player GetPlayer()
        {
            return Player;
        }

        public frmLogin()
        {
            InitializeComponent();
            // Puts the centre of this form to the centre of the screen
            CenterToScreen();
            // Hides the button to progress to the next screen to force the player into entering a username and a password
            btnLNext.Enabled = false;
            btnRegister.Visible = false;
            btnLogin.Visible = false;
            txtUsername.Enabled = false;
            label1.ForeColor = SystemColors.ControlDarkDark;
            txtPassword.Enabled = false;
            label3.ForeColor = SystemColors.ControlDarkDark;
            txtConfirmPassword.Enabled = false;
            label4.ForeColor = SystemColors.ControlDarkDark;
        }
        // Makes the previously private Player, public to other forms
        // For the computer not to mix up the public and private, I made the private field have a capitalised 'P', and the public field have a non-capitalised 'p'
        public static Player player;

        private void btnLNext_Click(object sender, EventArgs e)
        {
            if (Avatar1.Visible == true && Avatar2.Visible == true && Avatar3.Visible == true && Avatar4.Visible == true)
            {
                MessageBox.Show("You haven't selected an avatar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Gives the public player field values to display throughout the quiz
                player = new Player(txtUsername.Text, txtPassword.Text);
                // Creates a local random variable to generate random numbers, as demonstrated in lines 44
                Random rnd = new Random();
                int V = rnd.Next(1, 3);
                // The switch statement takes the randomly generated 'V' value and dependant on what it is, will perform different functions
                // If 'V' = 1, the switch statemnt will perform case 1, and equally for 'V' = 2
                switch (V)
                {
                    case 1:
                        frmQ1A frmQ1a = new frmQ1A();
                        frmQ1a.Show();
                        frmQ1a.Activate();
                        this.Hide();
                        break;
                    case 2:
                        frmQ1B frmQ1B = new frmQ1B();
                        frmQ1B.Activate();
                        frmQ1B.Show();
                        this.Hide();
                        break;
                }
            }
        }


        private void Avatar1_Click(object sender, EventArgs e)
        {
            // When Avatar1 is clicked, it will increase the avatars width and height to highlight the image (Lines 69 & 70)
            Avatar1.Width = 200;
            Avatar1.Height = 200;
            // (Lines 72-74) Hides the other avatars to further show which avater has been selected
            Avatar2.Visible = false;
            Avatar3.Visible = false;
            Avatar4.Visible = false;
            // The "Avatar" field (Made back on line 17) is now Avatar1, and anywhere where the "Avatar" field is used, the image Avatar1 will be displayed
            Avatar = Properties.Resources.Avatar_1;
        }

        private void Avatar2_Click(object sender, EventArgs e)
        {
            Avatar2.Width = 200;
            Avatar2.Height = 200;
            Avatar1.Visible = false;
            Avatar3.Visible = false;
            Avatar4.Visible = false;

            Avatar = Properties.Resources.Avatar_2;
        }

        private void Avatar3_Click(object sender, EventArgs e)
        {
            Avatar3.Width = 200;
            Avatar3.Height = 200;
            Avatar1.Visible = false;
            Avatar2.Visible = false;
            Avatar4.Visible = false;

            Avatar = Properties.Resources.Avatar_3;
        }

        private void Avatar4_Click(object sender, EventArgs e)
        {
            Avatar4.Width = 200;
            Avatar4.Height = 200;
            Avatar1.Visible = false;
            Avatar2.Visible = false;
            Avatar3.Visible = false;

            Avatar = Properties.Resources.Avatar_4;
        }

        private void btnResetLogin_Click(object sender, EventArgs e)
        {
            // Displays all the Avatars again, as well as returning the avatar's sizes to normal
            // If an avatar is chosen and then this button pressed, and another avatar is selected, the avatar highlighted is the only one that will be passed through to the field Avatar
            Avatar1.Visible = true;
            Avatar1.Height = 150;
            Avatar1.Width = 150;
            Avatar2.Visible = true;
            Avatar2.Height = 150;
            Avatar2.Width = 150;
            Avatar3.Visible = true;
            Avatar3.Height = 150;
            Avatar3.Width = 150;
            Avatar4.Visible = true;
            Avatar4.Height = 150;
            Avatar4.Width = 150;
        }

        private void RegisterNewPlayer(string username, string password)
        {
            FileStream fs;

            if (File.Exists("ExistingPlayers.txt"))
            {
                fs = new FileStream("ExistingPlayers.txt", FileMode.Append);
            }
            else
            {
                fs = new FileStream("ExistingPlayers.txt", FileMode.Create);
            }
            StreamWriter sw = new StreamWriter(fs);

            frmLogin.Player = new Player(username, password);


            sw.WriteLine(frmLogin.GetPlayer().GetUserName() + "~" + frmLogin.GetPlayer().GetPassword());
            sw.Close();
            fs.Close();
        }
        private void LoginExistingPlayer(string username, string password)
        {
            Player = new Player(username, password);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty || txtConfirmPassword.Text == string.Empty)
            {
                MessageBox.Show("One or more of the above fields have been left empty. Please fill in the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                RegisterNewPlayer(txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Your username \n\n" + txtUsername.Text);
                btnLNext.Enabled = true;
            }
            else
            {
                MessageBox.Show("Passwords don't match, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtUsername.TextLength >= 16 || txtPassword.TextLength >= 16 || txtConfirmPassword.TextLength >= 16)
            {
                MessageBox.Show("You have enetered a username or password that is too long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("One or more of the fields are empty", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            string[] Players = File.ReadAllLines("ExistingPlayers.txt").ToArray();
            bool found = false;
            for (int i = 0; i < Players.Length; i++)
            {
                string[] usernameandpass = Players[i].Split('~');
                string Username = usernameandpass[0];
                string Password = usernameandpass[1];

                if ((Username == txtUsername.Text) && (Password == txtPassword.Text))
                {
                    found = true;
                    break;
                }
            }
            if (found == true)
            {
                LoginExistingPlayer(txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Welcome Back\n" + txtUsername.Text);
                btnLNext.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sorry, but we couldn't retrieve your data, as it is not within our database...", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (txtUsername.TextLength >= 16 || txtPassword.TextLength >= 16)
            {
                MessageBox.Show("You have enetered a username or password that is too long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void rbnRegister_CheckedChanged(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            txtPassword.Enabled = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            txtConfirmPassword.Enabled = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            btnRegister.Visible = true;
            btnLogin.Visible = false;
        }

        private void rbnLogin_CheckedChanged(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            txtPassword.Enabled = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            txtConfirmPassword.Enabled = false;
            label4.ForeColor = SystemColors.ControlDarkDark;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            btnRegister.Visible = false;
            btnLogin.Visible = true;
        }
    }
}