namespace ABC_Car_Traders
{
    partial class Car_Details_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_Details_View));
            this.ViewImage = new System.Windows.Forms.PictureBox();
            this.BrandLbl = new System.Windows.Forms.Label();
            this.ModelLbl = new System.Windows.Forms.Label();
            this.ColorLbl = new System.Windows.Forms.Label();
            this.YearLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewImage
            // 
            this.ViewImage.BackColor = System.Drawing.Color.Transparent;
            this.ViewImage.Location = new System.Drawing.Point(28, 44);
            this.ViewImage.Name = "ViewImage";
            this.ViewImage.Size = new System.Drawing.Size(726, 487);
            this.ViewImage.TabIndex = 0;
            this.ViewImage.TabStop = false;
            // 
            // BrandLbl
            // 
            this.BrandLbl.AutoSize = true;
            this.BrandLbl.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BrandLbl.Location = new System.Drawing.Point(825, 93);
            this.BrandLbl.Name = "BrandLbl";
            this.BrandLbl.Size = new System.Drawing.Size(77, 29);
            this.BrandLbl.TabIndex = 1;
            this.BrandLbl.Text = "Brand";
            this.BrandLbl.Click += new System.EventHandler(this.BrandLbl_Click);
            // 
            // ModelLbl
            // 
            this.ModelLbl.AutoSize = true;
            this.ModelLbl.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModelLbl.Location = new System.Drawing.Point(825, 140);
            this.ModelLbl.Name = "ModelLbl";
            this.ModelLbl.Size = new System.Drawing.Size(80, 29);
            this.ModelLbl.TabIndex = 1;
            this.ModelLbl.Text = "Model";
            // 
            // ColorLbl
            // 
            this.ColorLbl.AutoSize = true;
            this.ColorLbl.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ColorLbl.Location = new System.Drawing.Point(825, 192);
            this.ColorLbl.Name = "ColorLbl";
            this.ColorLbl.Size = new System.Drawing.Size(72, 29);
            this.ColorLbl.TabIndex = 1;
            this.ColorLbl.Text = "Color";
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YearLbl.Location = new System.Drawing.Point(825, 247);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(64, 29);
            this.YearLbl.TabIndex = 1;
            this.YearLbl.Text = "Year";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PriceLbl.Location = new System.Drawing.Point(825, 303);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(68, 29);
            this.PriceLbl.TabIndex = 1;
            this.PriceLbl.Text = "Price";
            // 
            // Car_Details_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 608);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.ColorLbl);
            this.Controls.Add(this.ModelLbl);
            this.Controls.Add(this.BrandLbl);
            this.Controls.Add(this.ViewImage);
            this.Name = "Car_Details_View";
            this.Text = "Car_Details_View";
            ((System.ComponentModel.ISupportInitialize)(this.ViewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ViewImage;
        private System.Windows.Forms.Label BrandLbl;
        private System.Windows.Forms.Label ModelLbl;
        private System.Windows.Forms.Label ColorLbl;
        private System.Windows.Forms.Label YearLbl;
        private System.Windows.Forms.Label PriceLbl;
    }
}