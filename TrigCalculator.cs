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
    public partial class TrigCalculator : Form
    {
        public TrigCalculator()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnSineAngle_Click(object sender, EventArgs e)
        {
            if (txtLengtha.Text == string.Empty || txtAngleA.Text == string.Empty || txtLengthb.Text == string.Empty)
            {
                MessageBox.Show("One of the fields required (Length A, Angle A and/or Length B) are left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                double A = Convert.ToDouble(txtAngleA.Text);
                double a = Convert.ToDouble(txtLengtha.Text);
                double B = 0;
                double b = Convert.ToDouble(txtLengthb.Text);
                A = (Math.PI / 180) * A;
                A = Math.Sin(A);
                B = (b * A);
                B = B / a;
                B = Math.Asin(B);
                B = (180 / Math.PI) * B;
                Math.Round(B, 2);
                txtAngleB.Text = Convert.ToString(B);
            }
        }

        private void btnSineLength_Click(object sender, EventArgs e)
        {
            if (txtLengtha.Text == string.Empty || txtAngleA.Text == string.Empty || txtAngleB.Text == string.Empty)
            {
                MessageBox.Show("One of the fields required (Length A, Angle A and/or Angle B) are left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                double A = Convert.ToDouble(txtAngleA.Text);
                double a = Convert.ToDouble(txtLengtha.Text);
                double B = Convert.ToDouble(txtAngleB.Text);
                double b = 0.0;
                A = (Math.PI / 180) * A;
                B = (Math.PI / 180) * B;
                A = Math.Sin(A);
                B = Math.Sin(B);
                b = (a * B) / A;
                Math.Round(b, 2);
                txtLengthb.Text = Convert.ToString(b);
            }
        }

        private void btnCosineAngle_Click(object sender, EventArgs e)
        {
            if (txtLengtha.Text == string.Empty || txtLengthb.Text == string.Empty || txtLengthc.Text == string.Empty)
            {
                MessageBox.Show("One of the fields required (Length A, Length B and/or Length C) are left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                double a = Convert.ToDouble(txtLengtha.Text);
                double a2 = Convert.ToDouble(txtLengtha.Text);
                double b = Convert.ToDouble(txtLengthb.Text);
                double b2 = Convert.ToDouble(txtLengthb.Text);
                double c = Convert.ToDouble(txtLengthc.Text);
                double C = 0.0;
                a = a * a;
                b = b * b;
                c = c * c;
                double A = a + b - c;
                double B = 2 * b2 * a2;
                C = (A) / (B);
                C = Math.Acos(C);
                C = (180 / Math.PI) * C;
                Math.Round(C, 2);
                txtAngleC.Text = Convert.ToString(C);
            }
        }

        private void btnCosineLength_Click(object sender, EventArgs e)
        {
            if (txtLengtha.Text == string.Empty || txtLengthb.Text == string.Empty || txtAngleC.Text == string.Empty)
            {
                MessageBox.Show("One of the fields required (Length A, Length B and/or Angle C ) are left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                double a = Convert.ToDouble(txtLengtha.Text);
                double a2 = Convert.ToDouble(txtLengtha.Text);
                double b = Convert.ToDouble(txtLengthb.Text);
                double b2 = Convert.ToDouble(txtLengthb.Text);
                double c = 0.0;
                double C = Convert.ToDouble(txtAngleC.Text);
                C = (Math.PI / 180) * C;
                C = Math.Cos(C);
                a = a * a2;
                b = b * b2;
                double A = a + b;
                double B = 2 * a2 * b2 * C;
                c = A - B;
                Math.Sqrt(c);
                Math.Round(c, 2);
                txtLengthc.Text = Convert.ToString(c);
            }
        }

        private void btnSineRule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the text boxes to find values.\nFinding the angle by putting in values in Angle A and the lengths a & b. \nFind a length by placing values in Angles A & B and the length a.");
            return;
        }

        private void btnCosineRule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the text boxes to find values.\nFind the angle by placing values in the lengths of a, b and c.\nFind the length by putting values in lengths a and b and the angle C.");
            return;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAngleA.Text = "";
            txtAngleB.Text = "";
            txtAngleC.Text = "";
            txtLengtha.Text = "";
            txtLengthb.Text = "";
            txtLengthc.Text = "";
        }
    }
}
