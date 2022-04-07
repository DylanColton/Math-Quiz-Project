namespace MainMenu
{
    partial class frmQ4A
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn4ANext = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCheck4A = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CobxAns1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CobxAns2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CobxAns3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CobxAns4 = new System.Windows.Forms.ComboBox();
            this.btnQ4Help = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn4ANext
            // 
            this.btn4ANext.Location = new System.Drawing.Point(472, 349);
            this.btn4ANext.Name = "btn4ANext";
            this.btn4ANext.Size = new System.Drawing.Size(100, 50);
            this.btn4ANext.TabIndex = 0;
            this.btn4ANext.Text = "Next";
            this.btn4ANext.UseVisualStyleBackColor = true;
            this.btn4ANext.Click += new System.EventHandler(this.btn4ANext_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(12, 12);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(100, 100);
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 197);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Question: 4";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 141);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name: ";
            // 
            // btnCheck4A
            // 
            this.btnCheck4A.Location = new System.Drawing.Point(472, 349);
            this.btnCheck4A.Name = "btnCheck4A";
            this.btnCheck4A.Size = new System.Drawing.Size(100, 50);
            this.btnCheck4A.TabIndex = 10;
            this.btnCheck4A.Text = "Check Answers";
            this.btnCheck4A.UseVisualStyleBackColor = true;
            this.btnCheck4A.Click += new System.EventHandler(this.btnCheck4A_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Completion of the Square";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "x^2+3x-2";
            // 
            // CobxAns1
            // 
            this.CobxAns1.FormattingEnabled = true;
            this.CobxAns1.Items.AddRange(new object[] {
            "(x+3/2)^2 - (17/4)",
            "(x+2/3)^2 + (17/4)",
            "(x+3/2)^2 - (17/2)",
            "(x-3/2)^2 + (17/3)"});
            this.CobxAns1.Location = new System.Drawing.Point(366, 101);
            this.CobxAns1.Name = "CobxAns1";
            this.CobxAns1.Size = new System.Drawing.Size(121, 21);
            this.CobxAns1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "x^2-8x-12";
            // 
            // CobxAns2
            // 
            this.CobxAns2.FormattingEnabled = true;
            this.CobxAns2.Items.AddRange(new object[] {
            "(x+4)^2 - (28)",
            "(x-4)^2 + (28)",
            "(x-4)^2 - (28)",
            "(x+4)^2 + (28)"});
            this.CobxAns2.Location = new System.Drawing.Point(366, 156);
            this.CobxAns2.Name = "CobxAns2";
            this.CobxAns2.Size = new System.Drawing.Size(121, 21);
            this.CobxAns2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "x^2-5x+10";
            // 
            // CobxAns3
            // 
            this.CobxAns3.FormattingEnabled = true;
            this.CobxAns3.Items.AddRange(new object[] {
            "(x+25/2)^2 + (25/4)",
            "(x-5/2)^2 - (65/4)",
            "(x-25/4)^2 - (40/4)",
            "(x-5/2)^2 + (65/4)"});
            this.CobxAns3.Location = new System.Drawing.Point(366, 222);
            this.CobxAns3.Name = "CobxAns3";
            this.CobxAns3.Size = new System.Drawing.Size(121, 21);
            this.CobxAns3.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "x^2-12x-28";
            // 
            // CobxAns4
            // 
            this.CobxAns4.FormattingEnabled = true;
            this.CobxAns4.Items.AddRange(new object[] {
            "(x+6)^2 - (36)",
            "(x-6)^2 - (64)",
            "(x-6)^2 + (64)",
            "(x-6)^2 + (36)"});
            this.CobxAns4.Location = new System.Drawing.Point(366, 285);
            this.CobxAns4.Name = "CobxAns4";
            this.CobxAns4.Size = new System.Drawing.Size(121, 21);
            this.CobxAns4.TabIndex = 19;
            // 
            // btnQ4Help
            // 
            this.btnQ4Help.Location = new System.Drawing.Point(12, 118);
            this.btnQ4Help.Name = "btnQ4Help";
            this.btnQ4Help.Size = new System.Drawing.Size(75, 23);
            this.btnQ4Help.TabIndex = 35;
            this.btnQ4Help.Text = "Help?";
            this.btnQ4Help.UseVisualStyleBackColor = true;
            this.btnQ4Help.Click += new System.EventHandler(this.btnQ4Help_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(12, 376);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(75, 23);
            this.btnCalculator.TabIndex = 36;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // frmQ4A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnQ4Help);
            this.Controls.Add(this.CobxAns4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CobxAns3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CobxAns2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CobxAns1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck4A);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.btn4ANext);
            this.Name = "frmQ4A";
            this.Text = "Maths Quiz";
            this.Load += new System.EventHandler(this.frmQ4A_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn4ANext;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCheck4A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CobxAns1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CobxAns2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CobxAns3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CobxAns4;
        private System.Windows.Forms.Button btnQ4Help;
        private System.Windows.Forms.Button btnCalculator;
    }
}