namespace ABC_Car_Traders
{
    partial class ReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ReportGridView = new System.Windows.Forms.DataGridView();
            this.ReportSidePanel = new System.Windows.Forms.Panel();
            this.s = new System.Windows.Forms.ComboBox();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).BeginInit();
            this.ReportSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportGridView
            // 
            this.ReportGridView.AllowUserToAddRows = false;
            this.ReportGridView.AllowUserToDeleteRows = false;
            this.ReportGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.ReportGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ReportGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReportGridView.Location = new System.Drawing.Point(0, 0);
            this.ReportGridView.Name = "ReportGridView";
            this.ReportGridView.ReadOnly = true;
            this.ReportGridView.RowHeadersWidth = 51;
            this.ReportGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.ReportGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.ReportGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.ReportGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ReportGridView.RowTemplate.Height = 24;
            this.ReportGridView.Size = new System.Drawing.Size(944, 627);
            this.ReportGridView.TabIndex = 86;
            // 
            // ReportSidePanel
            // 
            this.ReportSidePanel.Controls.Add(this.s);
            this.ReportSidePanel.Controls.Add(this.ToDate);
            this.ReportSidePanel.Controls.Add(this.FromDate);
            this.ReportSidePanel.Location = new System.Drawing.Point(950, 0);
            this.ReportSidePanel.Name = "ReportSidePanel";
            this.ReportSidePanel.Size = new System.Drawing.Size(323, 627);
            this.ReportSidePanel.TabIndex = 87;
            // 
            // s
            // 
            this.s.FormattingEnabled = true;
            this.s.Location = new System.Drawing.Point(38, 188);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(200, 24);
            this.s.TabIndex = 1;
            // 
            // ToDate
            // 
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDate.Location = new System.Drawing.Point(38, 135);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(200, 22);
            this.ToDate.TabIndex = 0;
            this.ToDate.ValueChanged += new System.EventHandler(this.ToDate_ValueChanged);
            // 
            // FromDate
            // 
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDate.Location = new System.Drawing.Point(38, 93);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(200, 22);
            this.FromDate.TabIndex = 0;
            this.FromDate.ValueChanged += new System.EventHandler(this.FromDate_ValueChanged);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1275, 627);
            this.Controls.Add(this.ReportSidePanel);
            this.Controls.Add(this.ReportGridView);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).EndInit();
            this.ReportSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView ReportGridView;
        private System.Windows.Forms.Panel ReportSidePanel;
        internal System.Windows.Forms.ComboBox s;
        internal System.Windows.Forms.DateTimePicker ToDate;
        internal System.Windows.Forms.DateTimePicker FromDate;
    }
}