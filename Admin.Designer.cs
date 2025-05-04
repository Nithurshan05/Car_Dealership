namespace ABC_Car_Traders
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.appSideBarContainer = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.paymentsBtn = new System.Windows.Forms.Button();
            this.orderDetailsBtn = new System.Windows.Forms.Button();
            this.carPartsBtn = new System.Windows.Forms.Button();
            this.carBtn = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.pageTitle = new System.Windows.Forms.Label();
            this.formLoadArea = new System.Windows.Forms.Panel();
            this.appSideBarContainer.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // appSideBarContainer
            // 
            this.appSideBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.appSideBarContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.appSideBarContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.appSideBarContainer.Controls.Add(this.ExitBtn);
            this.appSideBarContainer.Controls.Add(this.settingsBtn);
            this.appSideBarContainer.Controls.Add(this.reportsBtn);
            this.appSideBarContainer.Controls.Add(this.paymentsBtn);
            this.appSideBarContainer.Controls.Add(this.orderDetailsBtn);
            this.appSideBarContainer.Controls.Add(this.carPartsBtn);
            this.appSideBarContainer.Controls.Add(this.carBtn);
            this.appSideBarContainer.Controls.Add(this.customer);
            this.appSideBarContainer.Controls.Add(this.dashboardBtn);
            this.appSideBarContainer.Controls.Add(this.logo);
            this.appSideBarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.appSideBarContainer.Location = new System.Drawing.Point(0, 0);
            this.appSideBarContainer.Name = "appSideBarContainer";
            this.appSideBarContainer.Size = new System.Drawing.Size(227, 753);
            this.appSideBarContainer.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(229)))));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Red;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.Location = new System.Drawing.Point(3, 695);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(216, 51);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Location = new System.Drawing.Point(0, 455);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(223, 51);
            this.settingsBtn.TabIndex = 19;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.navBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.reportsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.reportsBtn.Image = ((System.Drawing.Image)(resources.GetObject("reportsBtn.Image")));
            this.reportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsBtn.Location = new System.Drawing.Point(0, 404);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(223, 51);
            this.reportsBtn.TabIndex = 18;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = false;
            this.reportsBtn.Click += new System.EventHandler(this.navBtn_Click);
            // 
            // paymentsBtn
            // 
            this.paymentsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.paymentsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paymentsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentsBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.paymentsBtn.Image = ((System.Drawing.Image)(resources.GetObject("paymentsBtn.Image")));
            this.paymentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentsBtn.Location = new System.Drawing.Point(0, 353);
            this.paymentsBtn.Name = "paymentsBtn";
            this.paymentsBtn.Size = new System.Drawing.Size(223, 51);
            this.paymentsBtn.TabIndex = 17;
            this.paymentsBtn.Text = "Payments";
            this.paymentsBtn.UseVisualStyleBackColor = false;
            this.paymentsBtn.Click += new System.EventHandler(this.navBtn_Click);
            // 
            // orderDetailsBtn
            // 
            this.orderDetailsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.orderDetailsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderDetailsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderDetailsBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.orderDetailsBtn.Image = ((System.Drawing.Image)(resources.GetObject("orderDetailsBtn.Image")));
            this.orderDetailsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderDetailsBtn.Location = new System.Drawing.Point(0, 302);
            this.orderDetailsBtn.Name = "orderDetailsBtn";
            this.orderDetailsBtn.Size = new System.Drawing.Size(223, 51);
            this.orderDetailsBtn.TabIndex = 16;
            this.orderDetailsBtn.Text = "Order Details";
            this.orderDetailsBtn.UseVisualStyleBackColor = false;
            this.orderDetailsBtn.Click += new System.EventHandler(this.navBtn_Click);
            // 
            // carPartsBtn
            // 
            this.carPartsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.carPartsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carPartsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.carPartsBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carPartsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.carPartsBtn.Image = ((System.Drawing.Image)(resources.GetObject("carPartsBtn.Image")));
            this.carPartsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carPartsBtn.Location = new System.Drawing.Point(0, 251);
            this.carPartsBtn.Name = "carPartsBtn";
            this.carPartsBtn.Size = new System.Drawing.Size(223, 51);
            this.carPartsBtn.TabIndex = 15;
            this.carPartsBtn.Text = "Car Parts";
            this.carPartsBtn.UseVisualStyleBackColor = false;
            this.carPartsBtn.Click += new System.EventHandler(this.navBtn_Click);
            // 
            // carBtn
            // 
            this.carBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.carBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.carBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.carBtn.Image = ((System.Drawing.Image)(resources.GetObject("carBtn.Image")));
            this.carBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carBtn.Location = new System.Drawing.Point(0, 200);
            this.carBtn.Name = "carBtn";
            this.carBtn.Size = new System.Drawing.Size(223, 51);
            this.carBtn.TabIndex = 14;
            this.carBtn.Text = "Car";
            this.carBtn.UseVisualStyleBackColor = false;
            this.carBtn.Click += new System.EventHandler(this.navBtn_Click);
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.customer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.customer.Image = ((System.Drawing.Image)(resources.GetObject("customer.Image")));
            this.customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customer.Location = new System.Drawing.Point(0, 149);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(223, 51);
            this.customer.TabIndex = 2;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = false;
            this.customer.Click += new System.EventHandler(this.navBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.dashboardBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 98);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(223, 51);
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.navBtn_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(223, 98);
            this.logo.TabIndex = 0;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.titleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titleBar.Controls.Add(this.logoutBtn);
            this.titleBar.Controls.Add(this.pageTitle);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(227, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1311, 100);
            this.titleBar.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(1084, 25);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(169, 51);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Admin";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.BackColor = System.Drawing.Color.Transparent;
            this.pageTitle.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pageTitle.Location = new System.Drawing.Point(41, 35);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(145, 30);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "Dashboard";
            // 
            // formLoadArea
            // 
            this.formLoadArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(229)))));
            this.formLoadArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formLoadArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formLoadArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formLoadArea.Location = new System.Drawing.Point(227, 100);
            this.formLoadArea.Name = "formLoadArea";
            this.formLoadArea.Size = new System.Drawing.Size(1311, 653);
            this.formLoadArea.TabIndex = 2;
            this.formLoadArea.Paint += new System.Windows.Forms.PaintEventHandler(this.formLoadArea_Paint);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 753);
            this.Controls.Add(this.formLoadArea);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.appSideBarContainer);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.appSideBarContainer.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel appSideBarContainer;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel formLoadArea;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button paymentsBtn;
        private System.Windows.Forms.Button orderDetailsBtn;
        private System.Windows.Forms.Button carPartsBtn;
        private System.Windows.Forms.Button carBtn;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button ExitBtn;
    }
}