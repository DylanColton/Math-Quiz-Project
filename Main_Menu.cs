using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Development
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMainMenu
            // 
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Name = "frmMainMenu";
            this.Text = "Maths Quiz";
            this.ResumeLayout(false);

        }
    }
}
