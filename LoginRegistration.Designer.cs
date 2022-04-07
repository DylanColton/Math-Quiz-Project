namespace MainMenu
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLNext = new System.Windows.Forms.Button();
            this.btnResetLogin = new System.Windows.Forms.Button();
            this.Avatar4 = new System.Windows.Forms.PictureBox();
            this.Avatar3 = new System.Windows.Forms.PictureBox();
            this.Avatar2 = new System.Windows.Forms.PictureBox();
            this.Avatar1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.rbnRegister = new System.Windows.Forms.RadioButton();
            this.rbnLogin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLNext
            // 
            this.btnLNext.Location = new System.Drawing.Point(572, 599);
            this.btnLNext.Name = "btnLNext";
            this.btnLNext.Size = new System.Drawing.Size(100, 50);
            this.btnLNext.TabIndex = 0;
            this.btnLNext.Text = "Next";
            this.btnLNext.UseVisualStyleBackColor = true;
            this.btnLNext.Click += new System.EventHandler(this.btnLNext_Click);
            // 
            // btnResetLogin
            // 
            this.btnResetLogin.Location = new System.Drawing.Point(251, 598);
            this.btnResetLogin.Name = "btnResetLogin";
            this.btnResetLogin.Size = new System.Drawing.Size(108, 51);
            this.btnResetLogin.TabIndex = 7;
            this.btnResetLogin.Text = "Reset Choice of Avatar";
            this.btnResetLogin.UseVisualStyleBackColor = true;
            this.btnResetLogin.Click += new System.EventHandler(this.btnResetLogin_Click);
            // 
            // Avatar4
            // 
            this.Avatar4.Image = ((System.Drawing.Image)(resources.GetObject("Avatar4.Image")));
            this.Avatar4.Location = new System.Drawing.Point(480, 377);
            this.Avatar4.Name = "Avatar4";
            this.Avatar4.Size = new System.Drawing.Size(150, 150);
            this.Avatar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar4.TabIndex = 11;
            this.Avatar4.TabStop = false;
            this.Avatar4.Click += new System.EventHandler(this.Avatar4_Click);
            // 
            // Avatar3
            // 
            this.Avatar3.Image = ((System.Drawing.Image)(resources.GetObject("Avatar3.Image")));
            this.Avatar3.Location = new System.Drawing.Point(324, 377);
            this.Avatar3.Name = "Avatar3";
            this.Avatar3.Size = new System.Drawing.Size(150, 150);
            this.Avatar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar3.TabIndex = 10;
            this.Avatar3.TabStop = false;
            this.Avatar3.Click += new System.EventHandler(this.Avatar3_Click);
            // 
            // Avatar2
            // 
            this.Avatar2.Image = ((System.Drawing.Image)(resources.GetObject("Avatar2.Image")));
            this.Avatar2.Location = new System.Drawing.Point(168, 377);
            this.Avatar2.Name = "Avatar2";
            this.Avatar2.Size = new System.Drawing.Size(150, 150);
            this.Avatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar2.TabIndex = 9;
            this.Avatar2.TabStop = false;
            this.Avatar2.Click += new System.EventHandler(this.Avatar2_Click);
            // 
            // Avatar1
            // 
            this.Avatar1.Image = ((System.Drawing.Image)(resources.GetObject("Avatar1.Image")));
            this.Avatar1.Location = new System.Drawing.Point(12, 377);
            this.Avatar1.Name = "Avatar1";
            this.Avatar1.Size = new System.Drawing.Size(150, 150);
            this.Avatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar1.TabIndex = 8;
            this.Avatar1.TabStop = false;
            this.Avatar1.Click += new System.EventHandler(this.Avatar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Login / Register";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(164, 136);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(466, 20);
            this.txtUsername.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(164, 192);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(466, 20);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(244, 236);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(386, 20);
            this.txtConfirmPassword.TabIndex = 18;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 293);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 50);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 293);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 50);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rbnRegister
            // 
            this.rbnRegister.AutoSize = true;
            this.rbnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnRegister.Location = new System.Drawing.Point(244, 91);
            this.rbnRegister.Name = "rbnRegister";
            this.rbnRegister.Size = new System.Drawing.Size(87, 24);
            this.rbnRegister.TabIndex = 21;
            this.rbnRegister.TabStop = true;
            this.rbnRegister.Text = "Register";
            this.rbnRegister.UseVisualStyleBackColor = true;
            this.rbnRegister.CheckedChanged += new System.EventHandler(this.rbnRegister_CheckedChanged);
            // 
            // rbnLogin
            // 
            this.rbnLogin.AutoSize = true;
            this.rbnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnLogin.Location = new System.Drawing.Point(373, 91);
            this.rbnLogin.Name = "rbnLogin";
            this.rbnLogin.Size = new System.Drawing.Size(66, 24);
            this.rbnLogin.TabIndex = 22;
            this.rbnLogin.TabStop = true;
            this.rbnLogin.Text = "Login";
            this.rbnLogin.UseVisualStyleBackColor = true;
            this.rbnLogin.CheckedChanged += new System.EventHandler(this.rbnLogin_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.rbnLogin);
            this.Controls.Add(this.rbnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Avatar4);
            this.Controls.Add(this.Avatar3);
            this.Controls.Add(this.Avatar2);
            this.Controls.Add(this.Avatar1);
            this.Controls.Add(this.btnResetLogin);
            this.Controls.Add(this.btnLNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.Text = "Math Quiz Login/Registration";
            ((System.ComponentModel.ISupportInitialize)(this.Avatar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLNext;
        private System.Windows.Forms.Button btnResetLogin;
        private System.Windows.Forms.PictureBox Avatar1;
        private System.Windows.Forms.PictureBox Avatar2;
        private System.Windows.Forms.PictureBox Avatar3;
        private System.Windows.Forms.PictureBox Avatar4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton rbnRegister;
        private System.Windows.Forms.RadioButton rbnLogin;
    }
}