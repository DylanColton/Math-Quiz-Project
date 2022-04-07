namespace MainMenu
{
    partial class frmQ4B
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
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnQ4Help = new System.Windows.Forms.Button();
            this.CobxAns4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CobxAns3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CobxAns2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CobxAns1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck4A = new System.Windows.Forms.Button();
            this.btn4ANext = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(12, 12);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(100, 100);
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 212);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score: ";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 270);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(61, 13);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Question: 4";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name: ";
            // 
            // btnQ4Help
            // 
            this.btnQ4Help.Location = new System.Drawing.Point(12, 119);
            this.btnQ4Help.Name = "btnQ4Help";
            this.btnQ4Help.Size = new System.Drawing.Size(75, 23);
            this.btnQ4Help.TabIndex = 47;
            this.btnQ4Help.Text = "Help?";
            this.btnQ4Help.UseVisualStyleBackColor = true;
            this.btnQ4Help.Click += new System.EventHandler(this.btnQ4Help_Click);
            // 
            // CobxAns4
            // 
            this.CobxAns4.FormattingEnabled = true;
            this.CobxAns4.Items.AddRange(new object[] {
            "(x+5)^2+(125)",
            "(x-5)^2+9(125)",
            "(x-5)^2+(-125)",
            "(x+5)+(-125)"});
            this.CobxAns4.Location = new System.Drawing.Point(366, 286);
            this.CobxAns4.Name = "CobxAns4";
            this.CobxAns4.Size = new System.Drawing.Size(121, 21);
            this.CobxAns4.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "x^2-10x-100";
            // 
            // CobxAns3
            // 
            this.CobxAns3.FormattingEnabled = true;
            this.CobxAns3.Items.AddRange(new object[] {
            "(x+6)^2+(-12)",
            "(x-6)^2+(-12x)",
            "(x-6)^2+(12)",
            "(x+6)^2+(12)"});
            this.CobxAns3.Location = new System.Drawing.Point(366, 223);
            this.CobxAns3.Name = "CobxAns3";
            this.CobxAns3.Size = new System.Drawing.Size(121, 21);
            this.CobxAns3.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "x^2+12x+48";
            // 
            // CobxAns2
            // 
            this.CobxAns2.FormattingEnabled = true;
            this.CobxAns2.Items.AddRange(new object[] {
            "(x-3)^2+(-25)",
            "(x+3)^2+(25x)",
            "(x-3)^2+(25)",
            "(x+3)^2+(-25)"});
            this.CobxAns2.Location = new System.Drawing.Point(366, 157);
            this.CobxAns2.Name = "CobxAns2";
            this.CobxAns2.Size = new System.Drawing.Size(121, 21);
            this.CobxAns2.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "x^2-6x+16";
            // 
            // CobxAns1
            // 
            this.CobxAns1.FormattingEnabled = true;
            this.CobxAns1.Items.AddRange(new object[] {
            "(x-4)^2+(25)",
            "(x+4)^2+(-25)",
            "(x-4)^2+(-25x)",
            "(x+4)+(25)"});
            this.CobxAns1.Location = new System.Drawing.Point(366, 102);
            this.CobxAns1.Name = "CobxAns1";
            this.CobxAns1.Size = new System.Drawing.Size(121, 21);
            this.CobxAns1.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "x^2+8x-9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Completion of the Square";
            // 
            // btnCheck4A
            // 
            this.btnCheck4A.Location = new System.Drawing.Point(472, 349);
            this.btnCheck4A.Name = "btnCheck4A";
            this.btnCheck4A.Size = new System.Drawing.Size(100, 50);
            this.btnCheck4A.TabIndex = 37;
            this.btnCheck4A.Text = "Check Answers";
            this.btnCheck4A.UseVisualStyleBackColor = true;
            this.btnCheck4A.Click += new System.EventHandler(this.btnCheck4B_Click);
            // 
            // btn4ANext
            // 
            this.btn4ANext.Location = new System.Drawing.Point(472, 350);
            this.btn4ANext.Name = "btn4ANext";
            this.btn4ANext.Size = new System.Drawing.Size(100, 50);
            this.btn4ANext.TabIndex = 36;
            this.btn4ANext.Text = "Next";
            this.btn4ANext.UseVisualStyleBackColor = true;
            this.btn4ANext.Click += new System.EventHandler(this.btn4BNext_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(12, 377);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(75, 23);
            this.btnCalculator.TabIndex = 48;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // frmQ4B
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
            this.Controls.Add(this.btn4ANext);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQ4B";
            this.Text = "Maths Quiz";
            this.Load += new System.EventHandler(this.frmQ4B_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnQ4Help;
        private System.Windows.Forms.ComboBox CobxAns4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CobxAns3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CobxAns2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CobxAns1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck4A;
        private System.Windows.Forms.Button btn4ANext;
        private System.Windows.Forms.Button btnCalculator;
    }
}