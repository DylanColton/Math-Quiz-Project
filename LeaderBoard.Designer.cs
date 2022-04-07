namespace MainMenu
{
    partial class frmLeader
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
            this.btnLeadNext = new System.Windows.Forms.Button();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.lstHighBoi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLeadNext
            // 
            this.btnLeadNext.Location = new System.Drawing.Point(472, 349);
            this.btnLeadNext.Name = "btnLeadNext";
            this.btnLeadNext.Size = new System.Drawing.Size(100, 50);
            this.btnLeadNext.TabIndex = 0;
            this.btnLeadNext.Text = "Back to Start";
            this.btnLeadNext.UseVisualStyleBackColor = true;
            this.btnLeadNext.Click += new System.EventHandler(this.btnLeadNext_Click);
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.Location = new System.Drawing.Point(44, 9);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(121, 25);
            this.lblFinalScore.TabIndex = 1;
            this.lblFinalScore.Text = "Final Score";
            // 
            // lstHighBoi
            // 
            this.lstHighBoi.FormattingEnabled = true;
            this.lstHighBoi.Location = new System.Drawing.Point(49, 73);
            this.lstHighBoi.Name = "lstHighBoi";
            this.lstHighBoi.Size = new System.Drawing.Size(394, 264);
            this.lstHighBoi.TabIndex = 2;
            // 
            // frmLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.lstHighBoi);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.btnLeadNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLeader";
            this.Text = "Maths Quiz - COMPLETE!";
            this.Load += new System.EventHandler(this.frmLeader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeadNext;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.ListBox lstHighBoi;
    }
}