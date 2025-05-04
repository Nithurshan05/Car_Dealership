namespace ABC_Car_Traders.Customer
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.adminLogin = new System.Windows.Forms.Button();
            this.CustomerLogin = new System.Windows.Forms.Button();
            this.pageTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminLogin
            // 
            this.adminLogin.BackColor = System.Drawing.Color.Transparent;
            this.adminLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminLogin.BackgroundImage")));
            this.adminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminLogin.FlatAppearance.BorderSize = 0;
            this.adminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLogin.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.adminLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminLogin.Location = new System.Drawing.Point(321, 235);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(276, 259);
            this.adminLogin.TabIndex = 3;
            this.adminLogin.UseVisualStyleBackColor = false;
            this.adminLogin.Click += new System.EventHandler(this.adminLogin_Click);
            this.adminLogin.Enter += new System.EventHandler(this.logoutBtn_Enter);
            // 
            // CustomerLogin
            // 
            this.CustomerLogin.BackColor = System.Drawing.Color.Transparent;
            this.CustomerLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CustomerLogin.BackgroundImage")));
            this.CustomerLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomerLogin.FlatAppearance.BorderSize = 0;
            this.CustomerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerLogin.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CustomerLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerLogin.Location = new System.Drawing.Point(743, 215);
            this.CustomerLogin.Name = "CustomerLogin";
            this.CustomerLogin.Size = new System.Drawing.Size(276, 259);
            this.CustomerLogin.TabIndex = 3;
            this.CustomerLogin.UseVisualStyleBackColor = false;
            this.CustomerLogin.Click += new System.EventHandler(this.CustomerLogin_Click);
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.BackColor = System.Drawing.Color.Transparent;
            this.pageTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.ForeColor = System.Drawing.Color.Black;
            this.pageTitle.Location = new System.Drawing.Point(356, 2);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(206, 60);
            this.pageTitle.TabIndex = 4;
            this.pageTitle.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(753, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pageTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 62);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1078, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "EXIT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1194, 632);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 719);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerLogin);
            this.Controls.Add(this.adminLogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button adminLogin;
        internal System.Windows.Forms.Button CustomerLogin;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}