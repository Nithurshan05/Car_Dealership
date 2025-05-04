namespace ABC_Car_Traders
{
    partial class Customer_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Login));
            this.registerBtn = new System.Windows.Forms.Button();
            this.forgetPasswordBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.emptyUserName = new System.Windows.Forms.Label();
            this.emptyPassword = new System.Windows.Forms.Label();
            this.eyeOpenBtn = new System.Windows.Forms.Button();
            this.eyeCloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Transparent;
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline);
            this.registerBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.registerBtn.Location = new System.Drawing.Point(983, 498);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(129, 29);
            this.registerBtn.TabIndex = 11;
            this.registerBtn.Text = "Register?";
            this.registerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // forgetPasswordBtn
            // 
            this.forgetPasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.forgetPasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetPasswordBtn.FlatAppearance.BorderSize = 0;
            this.forgetPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgetPasswordBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline);
            this.forgetPasswordBtn.ForeColor = System.Drawing.Color.Red;
            this.forgetPasswordBtn.Location = new System.Drawing.Point(745, 498);
            this.forgetPasswordBtn.Name = "forgetPasswordBtn";
            this.forgetPasswordBtn.Size = new System.Drawing.Size(215, 29);
            this.forgetPasswordBtn.TabIndex = 12;
            this.forgetPasswordBtn.Text = "Forget Password";
            this.forgetPasswordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.forgetPasswordBtn.UseVisualStyleBackColor = false;
            this.forgetPasswordBtn.Click += new System.EventHandler(this.forgetPasswordBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.loginBtn.Location = new System.Drawing.Point(845, 440);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(164, 37);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click_1);
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.passwordTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.passwordTxt.Location = new System.Drawing.Point(753, 372);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(352, 30);
            this.passwordTxt.TabIndex = 8;
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UserName.Font = new System.Drawing.Font("Arial", 12F);
            this.UserName.ForeColor = System.Drawing.SystemColors.Window;
            this.UserName.Location = new System.Drawing.Point(753, 275);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(352, 30);
            this.UserName.TabIndex = 0;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(748, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(748, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "UserName :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Display Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(621, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 72);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login to the Customer Page";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.back.Location = new System.Drawing.Point(31, 549);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(132, 35);
            this.back.TabIndex = 13;
            this.back.Text = "<< Back to ";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // emptyUserName
            // 
            this.emptyUserName.AutoSize = true;
            this.emptyUserName.BackColor = System.Drawing.Color.Transparent;
            this.emptyUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emptyUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emptyUserName.Font = new System.Drawing.Font("Arial Nova Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyUserName.ForeColor = System.Drawing.Color.Red;
            this.emptyUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emptyUserName.Location = new System.Drawing.Point(806, 308);
            this.emptyUserName.Name = "emptyUserName";
            this.emptyUserName.Size = new System.Drawing.Size(261, 21);
            this.emptyUserName.TabIndex = 15;
            this.emptyUserName.Text = "       Please Enter The UserName...!";
            this.emptyUserName.Visible = false;
            // 
            // emptyPassword
            // 
            this.emptyPassword.AutoSize = true;
            this.emptyPassword.BackColor = System.Drawing.Color.Transparent;
            this.emptyPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emptyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emptyPassword.Font = new System.Drawing.Font("Arial Nova Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyPassword.ForeColor = System.Drawing.Color.Red;
            this.emptyPassword.Location = new System.Drawing.Point(808, 405);
            this.emptyPassword.Name = "emptyPassword";
            this.emptyPassword.Size = new System.Drawing.Size(256, 21);
            this.emptyPassword.TabIndex = 15;
            this.emptyPassword.Text = "       Please Enter The Password...!";
            this.emptyPassword.Visible = false;
            // 
            // eyeOpenBtn
            // 
            this.eyeOpenBtn.BackColor = System.Drawing.Color.Transparent;
            this.eyeOpenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeOpenBtn.BackgroundImage")));
            this.eyeOpenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyeOpenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeOpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyeOpenBtn.ForeColor = System.Drawing.Color.Transparent;
            this.eyeOpenBtn.Location = new System.Drawing.Point(1066, 375);
            this.eyeOpenBtn.Name = "eyeOpenBtn";
            this.eyeOpenBtn.Size = new System.Drawing.Size(36, 24);
            this.eyeOpenBtn.TabIndex = 17;
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
            this.eyeCloseBtn.Location = new System.Drawing.Point(1066, 375);
            this.eyeCloseBtn.Name = "eyeCloseBtn";
            this.eyeCloseBtn.Size = new System.Drawing.Size(36, 24);
            this.eyeCloseBtn.TabIndex = 18;
            this.eyeCloseBtn.UseVisualStyleBackColor = false;
            // 
            // Customer_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 608);
            this.Controls.Add(this.eyeCloseBtn);
            this.Controls.Add(this.eyeOpenBtn);
            this.Controls.Add(this.emptyPassword);
            this.Controls.Add(this.emptyUserName);
            this.Controls.Add(this.back);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.forgetPasswordBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Login";
            this.Load += new System.EventHandler(this.Customer_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button loginBtn;
        internal System.Windows.Forms.Button registerBtn;
        internal System.Windows.Forms.Button forgetPasswordBtn;
        internal System.Windows.Forms.TextBox passwordTxt;
        internal System.Windows.Forms.TextBox UserName;
        internal System.Windows.Forms.Button back;
        internal System.Windows.Forms.Label emptyUserName;
        internal System.Windows.Forms.Label emptyPassword;
        internal System.Windows.Forms.Button eyeOpenBtn;
        internal System.Windows.Forms.Button eyeCloseBtn;
    }
}