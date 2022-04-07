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
    public partial class frmLeader : Form
    {
        public frmLeader() 
        {
            InitializeComponent();
            // Sets the centre of this form to the centre of the previous form
            CenterToParent();
            // The next two methods creates file later in this code
            AttemptWriteScore();
            WritePlayerTextDoc();
            // Uses the text document made in the above method, and uses that to interact with the leaderboard
            GetPlayerHighScores();
        }

        private void frmLeader_Load(object sender, EventArgs e)
        {
            // Sets "lblFinalScore" to tell the player their score
            lblFinalScore.Text = "Your Score Is: " + frmLogin.GetPlayer().GetScore().ToString();
            if (frmLogin.GetPlayer().GetScore() == 0)
            {
                lblFinalScore.Text = "\nYou have completely failed.";
            }
            else if (frmLogin.GetPlayer().GetScore() >=1 && frmLogin.GetPlayer().GetScore() <= 10)
            {
                lblFinalScore.Text = "\nKeep going!";
            }
            else if (frmLogin.GetPlayer().GetScore() >= 11 && frmLogin.GetPlayer().GetScore() <= 20)
            {
                lblFinalScore.Text = "\nYou're getting there";
            }
            else if (frmLogin.GetPlayer().GetScore() >= 21 && frmLogin.GetPlayer().GetScore() <= 30)
            {
                lblFinalScore.Text = "You're doing very well!";
            }
            else if (frmLogin.GetPlayer().GetScore() >=31 && frmLogin.GetPlayer().GetScore() <= 37)
            {
                lblFinalScore.Text = "Very, very good!";
            }
            else if (frmLogin.GetPlayer().GetScore() == 38)
            {
                lblFinalScore.Text = "FULL MARKS";
            }
        }

        private static void AttemptWriteScore()
        {
            try
            {
                // Writes a file named "score.bin" to hold the player
                BinaryWriter b = new BinaryWriter(File.Open("score.bin", FileMode.Create));

                // Writes the Score into the file
                b.Write(frmLogin.GetPlayer().GetScore());

                // Closes the writer
                b.Close();
            }
            catch (Exception ex)
            {
                // If there is an exception, this will catch it and display an error
                Console.WriteLine("Exception: " + ex);
            }
        }

        private void btnLeadNext_Click(object sender, EventArgs e)
        {
            // Opens the next form, the next form, in this case, being the initial form
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
            frmMainMenu.Activate();
            this.Hide();
        }

        private void WritePlayerTextDoc()
        {
            // Opens FileStream, and gives it a name to write it faster
            FileStream fs;
            // If "PlayerScores.txt" exists, the following code will be executed
            if (File.Exists("PlayerScores.txt"))
            {
                // Adds a record of the player and their score to "PlayerScores.txt
                fs = new FileStream("PlayerScores.txt", FileMode.Append);
            }
            else
            {
                // Creates the file "PlayerScores.txt, then stores the record of the player and their score
                fs = new FileStream("PlayerScores.txt", FileMode.Create);
            }

            // Uses StreamWriter, giving it an easy name and gives it the uses of the FileStream fs
            StreamWriter sw = new StreamWriter(fs);
            // To avoid people with less than ten points being placed above people with ten or more, I add this if statement to force the code to add "0" just before the rest of the number
            // The StreamWriter doesn't discriminate on the whole string of numbers, and so a value of 9 would be read as larger than 10, 9>1
            // To avoid this, adding a 0 makes it like so: 09 < 10, because 0<1
            if (frmLogin.GetPlayer().GetScore() <= 9)
            {
                // The StreamWriter writes the username and score in the format "0(Score),(Username)"
                sw.WriteLine("0" +  frmLogin.GetPlayer().GetScore() + "," + frmLogin.GetPlayer().GetUserName());
                // the next two methods closes StreamWriter and FileStream
                sw.Close();
                fs.Close();
            }
            // When the score is greater than 10
            else
            {
                // The StreamWriter writes the username and score in the format "(Score), (Username)"
                sw.WriteLine(frmLogin.GetPlayer().GetScore() + "," + frmLogin.GetPlayer().GetUserName());
                // the next two methods closes StreamWriter and FileStream
                sw.Close();
                fs.Close();
            }
        }

        // The next method writes the "PlayerScores.txt" file in order from largest to smallest
        private void GetPlayerHighScores()
        {
            // Reads the "PlayerScore.txt" file, placing it in a list
            List<string> users = File.ReadLines("PlayerScores.txt").ToList();

            List<string> editedUsers = new List<string>();

            // Sorts the users into an order from smallest to largest
            users.Sort();
            // Reverses the previous sorted order
            users.Reverse();

            for (int i = 1; i < users.Count; i++)
            {
                // Writes into the leaderboard the list of players
                string[] userNameScore = users[i].Split(',');
                editedUsers.Add(" Position: " + i + "   Name: " + userNameScore[1] + "  Score: " + userNameScore[0]);
            }
            lstHighBoi.DataSource = editedUsers;
        }
    }
}
