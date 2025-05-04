namespace ABC_Car_Traders
{
    partial class CarPartsDetailsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarPartsDetailsView));
            this.PriceLbl = new System.Windows.Forms.Label();
            this.DisLbl = new System.Windows.Forms.Label();
            this.ColorLbl = new System.Windows.Forms.Label();
            this.ModelLbl = new System.Windows.Forms.Label();
            this.BrandLbl = new System.Windows.Forms.Label();
            this.ViewImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.PriceLbl.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PriceLbl.Location = new System.Drawing.Point(792, 241);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(68, 29);
            this.PriceLbl.TabIndex = 3;
            this.PriceLbl.Text = "Price";
            // 
            // DisLbl
            // 
            this.DisLbl.AutoSize = true;
            this.DisLbl.BackColor = System.Drawing.Color.Transparent;
            this.DisLbl.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisLbl.Location = new System.Drawing.Point(792, 290);
            this.DisLbl.Name = "DisLbl";
            this.DisLbl.Size = new System.Drawing.Size(136, 29);
            this.DisLbl.TabIndex = 4;
            this.DisLbl.Text = "Description";
            // 
            // ColorLbl
            // 
            this.ColorLbl.AutoSize = true;
            this.ColorLbl.BackColor = System.Drawing.Color.Transparent;
            this.ColorLbl.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ColorLbl.Location = new System.Drawing.Point(792, 187);
            this.ColorLbl.Name = "ColorLbl";
            this.ColorLbl.Size = new System.Drawing.Size(72, 29);
            this.ColorLbl.TabIndex = 5;
            this.ColorLbl.Text = "Color";
            // 
            // ModelLbl
            // 
            this.ModelLbl.AutoSize = true;
            this.ModelLbl.BackColor = System.Drawing.Color.Transparent;
            this.ModelLbl.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModelLbl.Location = new System.Drawing.Point(792, 135);
            this.ModelLbl.Name = "ModelLbl";
            this.ModelLbl.Size = new System.Drawing.Size(80, 29);
            this.ModelLbl.TabIndex = 6;
            this.ModelLbl.Text = "Model";
            // 
            // BrandLbl
            // 
            this.BrandLbl.AutoSize = true;
            this.BrandLbl.BackColor = System.Drawing.Color.Transparent;
            this.BrandLbl.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BrandLbl.Location = new System.Drawing.Point(792, 88);
            this.BrandLbl.Name = "BrandLbl";
            this.BrandLbl.Size = new System.Drawing.Size(77, 29);
            this.BrandLbl.TabIndex = 7;
            this.BrandLbl.Text = "Brand";
            // 
            // ViewImage
            // 
            this.ViewImage.BackColor = System.Drawing.Color.Transparent;
            this.ViewImage.Location = new System.Drawing.Point(25, 29);
            this.ViewImage.Name = "ViewImage";
            this.ViewImage.Size = new System.Drawing.Size(726, 487);
            this.ViewImage.TabIndex = 2;
            this.ViewImage.TabStop = false;
            // 
            // CarPartsDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 608);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.DisLbl);
            this.Controls.Add(this.ColorLbl);
            this.Controls.Add(this.ModelLbl);
            this.Controls.Add(this.BrandLbl);
            this.Controls.Add(this.ViewImage);
            this.Name = "CarPartsDetailsView";
            this.Text = "CarPartsDetailsView";
            ((System.ComponentModel.ISupportInitialize)(this.ViewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label DisLbl;
        private System.Windows.Forms.Label ColorLbl;
        private System.Windows.Forms.Label ModelLbl;
        private System.Windows.Forms.Label BrandLbl;
        private System.Windows.Forms.PictureBox ViewImage;
    }
}