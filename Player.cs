using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    public class Player
    {
        private string Username;
        private string Password;
        private int Score;

        public Player(string username, string password)
        {
            Username = username;
            Password = password;
            Score = 0;
        }

        public string GetUserName()
        {
            return Username;
        }
        public string GetPassword()
        {
            return Password;
        }
        public int GetScore()
        {
            return Score;
        }
        public void IncreaseScore()
        {
            Score++;
        }
        public void DecreaseScore()
        {
            Score--;
        }
    }
}
