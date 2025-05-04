namespace ABC_Car_Traders
{
    partial class Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.emptyPassword = new System.Windows.Forms.Label();
            this.emptyUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eyeOpenBtn = new System.Windows.Forms.Button();
            this.eyeCloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(733, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName :";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.BackColor = System.Drawing.SystemColors.Window;
            this.UserNameTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.UserNameTxt.Location = new System.Drawing.Point(737, 280);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(352, 30);
            this.UserNameTxt.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.loginBtn.Location = new System.Drawing.Point(829, 435);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(164, 37);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(732, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.passwordTxt.Location = new System.Drawing.Point(737, 373);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(352, 30);
            this.passwordTxt.TabIndex = 1;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.BackBtn.Location = new System.Drawing.Point(28, 549);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(128, 37);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "<< Back to ";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // emptyPassword
            // 
            this.emptyPassword.AutoSize = true;
            this.emptyPassword.BackColor = System.Drawing.Color.Transparent;
            this.emptyPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.emptyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emptyPassword.Font = new System.Drawing.Font("Arial Nova Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyPassword.ForeColor = System.Drawing.Color.Red;
            this.emptyPassword.Location = new System.Drawing.Point(785, 404);
            this.emptyPassword.Name = "emptyPassword";
            this.emptyPassword.Size = new System.Drawing.Size(272, 21);
            this.emptyPassword.TabIndex = 17;
            this.emptyPassword.Text = "           Please Enter The Password...!";
            this.emptyPassword.Visible = false;
            // 
            // emptyUsername
            // 
            this.emptyUsername.AutoSize = true;
            this.emptyUsername.BackColor = System.Drawing.Color.Transparent;
            this.emptyUsername.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.emptyUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emptyUsername.Font = new System.Drawing.Font("Arial Nova Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyUsername.ForeColor = System.Drawing.Color.Red;
            this.emptyUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emptyUsername.Location = new System.Drawing.Point(796, 313);
            this.emptyUsername.Name = "emptyUsername";
            this.emptyUsername.Size = new System.Drawing.Size(265, 21);
            this.emptyUsername.TabIndex = 16;
            this.emptyUsername.Text = "        Please Enter The UserName...!";
            this.emptyUsername.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Display Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(656, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login to the Admin Page";
            // 
            // eyeOpenBtn
            // 
            this.eyeOpenBtn.BackColor = System.Drawing.Color.Transparent;
            this.eyeOpenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeOpenBtn.BackgroundImage")));
            this.eyeOpenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyeOpenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeOpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyeOpenBtn.ForeColor = System.Drawing.Color.Transparent;
            this.eyeOpenBtn.Location = new System.Drawing.Point(1052, 375);
            this.eyeOpenBtn.Name = "eyeOpenBtn";
            this.eyeOpenBtn.Size = new System.Drawing.Size(36, 26);
            this.eyeOpenBtn.TabIndex = 19;
            this.eyeOpenBtn.UseVisualStyleBackColor = false;
            // 
            // eyeCloseBtn
            // 
            this.eyeCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.eyeCloseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeCloseBtn.BackgroundImage")));
            this.eyeCloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyeCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyeCloseBtn.ForeColor = System.Drawing.Color.Transparent;
            this.eyeCloseBtn.Location = new System.Drawing.Point(1052, 375);
            this.eyeCloseBtn.Name = "eyeCloseBtn";
            this.eyeCloseBtn.Size = new System.Drawing.Size(36, 26);
            this.eyeCloseBtn.TabIndex = 19;
            this.eyeCloseBtn.UseVisualStyleBackColor = false;
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 608);
            this.Controls.Add(this.eyeCloseBtn);
            this.Controls.Add(this.eyeOpenBtn);
            this.Controls.Add(this.emptyPassword);
            this.Controls.Add(this.emptyUsername);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Admin_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackBtn;
        internal System.Windows.Forms.Button loginBtn;
        internal System.Windows.Forms.TextBox UserNameTxt;
        internal System.Windows.Forms.TextBox passwordTxt;
        internal System.Windows.Forms.Label emptyPassword;
        internal System.Windows.Forms.Label emptyUsername;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button eyeOpenBtn;
        internal System.Windows.Forms.Button eyeCloseBtn;
    }
}

