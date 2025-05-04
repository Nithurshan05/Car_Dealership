namespace ABC_Car_Traders
{
    partial class CarMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarMenu));
            this.Pay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.paymentGridView = new System.Windows.Forms.DataGridView();
            this.PayLater = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.Pay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pay.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.ForeColor = System.Drawing.Color.Yellow;
            this.Pay.Image = ((System.Drawing.Image)(resources.GetObject("Pay.Image")));
            this.Pay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pay.Location = new System.Drawing.Point(867, 423);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(172, 73);
            this.Pay.TabIndex = 9;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(587, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // paymentGridView
            // 
            this.paymentGridView.AllowUserToAddRows = false;
            this.paymentGridView.AllowUserToDeleteRows = false;
            this.paymentGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.paymentGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paymentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentGridView.GridColor = System.Drawing.Color.Red;
            this.paymentGridView.Location = new System.Drawing.Point(0, 0);
            this.paymentGridView.Name = "paymentGridView";
            this.paymentGridView.ReadOnly = true;
            this.paymentGridView.RowHeadersWidth = 51;
            this.paymentGridView.RowTemplate.Height = 24;
            this.paymentGridView.Size = new System.Drawing.Size(1086, 351);
            this.paymentGridView.TabIndex = 8;
            // 
            // PayLater
            // 
            this.PayLater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.PayLater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PayLater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayLater.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayLater.ForeColor = System.Drawing.Color.Yellow;
            this.PayLater.Image = ((System.Drawing.Image)(resources.GetObject("PayLater.Image")));
            this.PayLater.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PayLater.Location = new System.Drawing.Point(70, 423);
            this.PayLater.Name = "PayLater";
            this.PayLater.Size = new System.Drawing.Size(207, 73);
            this.PayLater.TabIndex = 11;
            this.PayLater.Text = "Pay Later";
            this.PayLater.UseVisualStyleBackColor = false;
            this.PayLater.Click += new System.EventHandler(this.PayLater_Click);
            // 
            // CarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(229)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 529);
            this.Controls.Add(this.PayLater);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.paymentGridView);
            this.Controls.Add(this.button1);
            this.Name = "CarMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarMenu";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button Pay;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.DataGridView paymentGridView;
        internal System.Windows.Forms.Button PayLater;
    }
}