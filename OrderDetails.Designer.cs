namespace ABC_Car_Traders
{
    partial class OrderDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formLoadArea = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CarOrder = new System.Windows.Forms.Button();
            this.OrderDetailsGridView = new System.Windows.Forms.DataGridView();
            this.abC_TradersDataSet1 = new ABC_Car_Traders.ABC_TradersDataSet();
            this.formLoadArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abC_TradersDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // formLoadArea
            // 
            this.formLoadArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(229)))));
            this.formLoadArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formLoadArea.Controls.Add(this.button1);
            this.formLoadArea.Controls.Add(this.CarOrder);
            this.formLoadArea.Controls.Add(this.OrderDetailsGridView);
            this.formLoadArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formLoadArea.Location = new System.Drawing.Point(0, 0);
            this.formLoadArea.Name = "formLoadArea";
            this.formLoadArea.Size = new System.Drawing.Size(1086, 529);
            this.formLoadArea.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(729, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 54);
            this.button1.TabIndex = 11;
            this.button1.Text = "Car Parts Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CarPartOrder_Click);
            // 
            // CarOrder
            // 
            this.CarOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.CarOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CarOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarOrder.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarOrder.ForeColor = System.Drawing.Color.Yellow;
            this.CarOrder.Image = ((System.Drawing.Image)(resources.GetObject("CarOrder.Image")));
            this.CarOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CarOrder.Location = new System.Drawing.Point(138, 48);
            this.CarOrder.Name = "CarOrder";
            this.CarOrder.Size = new System.Drawing.Size(236, 54);
            this.CarOrder.TabIndex = 10;
            this.CarOrder.Text = "Car Order";
            this.CarOrder.UseVisualStyleBackColor = false;
            this.CarOrder.Click += new System.EventHandler(this.CarOrder_Click);
            // 
            // OrderDetailsGridView
            // 
            this.OrderDetailsGridView.AllowUserToAddRows = false;
            this.OrderDetailsGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.OrderDetailsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDetailsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.OrderDetailsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderDetailsGridView.GridColor = System.Drawing.Color.Red;
            this.OrderDetailsGridView.Location = new System.Drawing.Point(0, 178);
            this.OrderDetailsGridView.Name = "OrderDetailsGridView";
            this.OrderDetailsGridView.ReadOnly = true;
            this.OrderDetailsGridView.RowHeadersWidth = 51;
            this.OrderDetailsGridView.RowTemplate.Height = 24;
            this.OrderDetailsGridView.Size = new System.Drawing.Size(1086, 351);
            this.OrderDetailsGridView.TabIndex = 9;
            // 
            // abC_TradersDataSet1
            // 
            this.abC_TradersDataSet1.DataSetName = "ABC_TradersDataSet";
            this.abC_TradersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 529);
            this.Controls.Add(this.formLoadArea);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetails";
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            this.formLoadArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abC_TradersDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.DataGridView OrderDetailsGridView;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button CarOrder;
        internal System.Windows.Forms.Panel formLoadArea;
        internal ABC_TradersDataSet abC_TradersDataSet1;
    }
}