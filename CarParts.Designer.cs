namespace ABC_Car_Traders
{
    partial class CarPartsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarPartsForm));
            this.car_PartsGridView = new System.Windows.Forms.DataGridView();
            this.browseBtn = new System.Windows.Forms.Button();
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.addImg = new System.Windows.Forms.PictureBox();
            this.colorTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.brandComBx = new System.Windows.Forms.ComboBox();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.qtyTxt = new System.Windows.Forms.TextBox();
            this.disTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.addNewBrand = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.partsNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.car_PartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addImg)).BeginInit();
            this.SuspendLayout();
            // 
            // car_PartsGridView
            // 
            this.car_PartsGridView.AllowUserToAddRows = false;
            this.car_PartsGridView.AllowUserToDeleteRows = false;
            this.car_PartsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.car_PartsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.car_PartsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.car_PartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.car_PartsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.car_PartsGridView.Location = new System.Drawing.Point(0, 383);
            this.car_PartsGridView.Name = "car_PartsGridView";
            this.car_PartsGridView.ReadOnly = true;
            this.car_PartsGridView.RowHeadersWidth = 51;
            this.car_PartsGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.car_PartsGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_PartsGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.car_PartsGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.car_PartsGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.car_PartsGridView.RowTemplate.Height = 24;
            this.car_PartsGridView.Size = new System.Drawing.Size(1275, 244);
            this.car_PartsGridView.TabIndex = 120;
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.browseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn.ForeColor = System.Drawing.Color.Yellow;
            this.browseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseBtn.Location = new System.Drawing.Point(864, 230);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(130, 32);
            this.browseBtn.TabIndex = 119;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = false;
            // 
            // pathTxt
            // 
            this.pathTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.pathTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.pathTxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.pathTxt.Location = new System.Drawing.Point(692, 232);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(159, 30);
            this.pathTxt.TabIndex = 118;
            // 
            // addImg
            // 
            this.addImg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addImg.BackgroundImage")));
            this.addImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addImg.Location = new System.Drawing.Point(692, 19);
            this.addImg.Name = "addImg";
            this.addImg.Size = new System.Drawing.Size(302, 205);
            this.addImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addImg.TabIndex = 117;
            this.addImg.TabStop = false;
            // 
            // colorTxt
            // 
            this.colorTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.colorTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.colorTxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.colorTxt.Location = new System.Drawing.Point(180, 324);
            this.colorTxt.Name = "colorTxt";
            this.colorTxt.Size = new System.Drawing.Size(302, 30);
            this.colorTxt.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.label10.Location = new System.Drawing.Point(102, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 23);
            this.label10.TabIndex = 106;
            this.label10.Text = "Color :";
            // 
            // brandComBx
            // 
            this.brandComBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.brandComBx.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandComBx.ForeColor = System.Drawing.SystemColors.Window;
            this.brandComBx.FormattingEnabled = true;
            this.brandComBx.Items.AddRange(new object[] {
            "BMW",
            "Benz",
            "Audi"});
            this.brandComBx.Location = new System.Drawing.Point(180, 114);
            this.brandComBx.Name = "brandComBx";
            this.brandComBx.Size = new System.Drawing.Size(254, 27);
            this.brandComBx.TabIndex = 104;
            // 
            // modelTxt
            // 
            this.modelTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.modelTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.modelTxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.modelTxt.Location = new System.Drawing.Point(180, 155);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(336, 30);
            this.modelTxt.TabIndex = 103;
            // 
            // priceTxt
            // 
            this.priceTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.priceTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.priceTxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.priceTxt.Location = new System.Drawing.Point(180, 196);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(336, 30);
            this.priceTxt.TabIndex = 99;
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.idBox.Font = new System.Drawing.Font("Arial", 12F);
            this.idBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.idBox.Location = new System.Drawing.Point(180, 26);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(105, 30);
            this.idBox.TabIndex = 102;
            // 
            // qtyTxt
            // 
            this.qtyTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.qtyTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.qtyTxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.qtyTxt.Location = new System.Drawing.Point(180, 280);
            this.qtyTxt.Name = "qtyTxt";
            this.qtyTxt.Size = new System.Drawing.Size(336, 30);
            this.qtyTxt.TabIndex = 101;
            // 
            // disTxt
            // 
            this.disTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.disTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.disTxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.disTxt.Location = new System.Drawing.Point(180, 238);
            this.disTxt.Name = "disTxt";
            this.disTxt.Size = new System.Drawing.Size(336, 30);
            this.disTxt.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.label5.Location = new System.Drawing.Point(105, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 97;
            this.label5.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.label3.Location = new System.Drawing.Point(118, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 96;
            this.label3.Text = "Qty :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(104, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 95;
            this.label2.Text = "Dis% :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(98, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 98;
            this.label1.Text = "Model :";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.BackColor = System.Drawing.Color.Transparent;
            this.Brand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.Brand.Location = new System.Drawing.Point(98, 117);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(74, 23);
            this.Brand.TabIndex = 94;
            this.Brand.Text = "Brand :";
            // 
            // addNewBrand
            // 
            this.addNewBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.addNewBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewBrand.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBrand.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addNewBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewBrand.Location = new System.Drawing.Point(456, 114);
            this.addNewBrand.Name = "addNewBrand";
            this.addNewBrand.Size = new System.Drawing.Size(60, 29);
            this.addNewBrand.TabIndex = 93;
            this.addNewBrand.Text = ">>>";
            this.addNewBrand.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Location = new System.Drawing.Point(1058, 238);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(107, 36);
            this.clearBtn.TabIndex = 91;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(1058, 181);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(107, 36);
            this.deleteBtn.TabIndex = 92;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(1058, 123);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(107, 36);
            this.updateBtn.TabIndex = 90;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Chartreuse;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(1058, 63);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 36);
            this.saveBtn.TabIndex = 86;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.label4.Location = new System.Drawing.Point(48, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 98;
            this.label4.Text = "Parts Name :";
            // 
            // partsNameTxt
            // 
            this.partsNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.partsNameTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.partsNameTxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.partsNameTxt.Location = new System.Drawing.Point(180, 69);
            this.partsNameTxt.Name = "partsNameTxt";
            this.partsNameTxt.Size = new System.Drawing.Size(336, 30);
            this.partsNameTxt.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.label6.Location = new System.Drawing.Point(560, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 98;
            this.label6.Text = "Description :";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.descriptionTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.descriptionTxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.descriptionTxt.Location = new System.Drawing.Point(692, 276);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(336, 78);
            this.descriptionTxt.TabIndex = 103;
            // 
            // CarPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(229)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1275, 627);
            this.Controls.Add(this.car_PartsGridView);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pathTxt);
            this.Controls.Add(this.addImg);
            this.Controls.Add(this.colorTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.brandComBx);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.partsNameTxt);
            this.Controls.Add(this.modelTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.qtyTxt);
            this.Controls.Add(this.disTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.addNewBrand);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "CarPartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarParts";
            ((System.ComponentModel.ISupportInitialize)(this.car_PartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView car_PartsGridView;
        internal System.Windows.Forms.Button browseBtn;
        internal System.Windows.Forms.TextBox pathTxt;
        internal System.Windows.Forms.PictureBox addImg;
        internal System.Windows.Forms.TextBox colorTxt;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ComboBox brandComBx;
        internal System.Windows.Forms.TextBox modelTxt;
        internal System.Windows.Forms.TextBox priceTxt;
        internal System.Windows.Forms.TextBox idBox;
        internal System.Windows.Forms.TextBox qtyTxt;
        internal System.Windows.Forms.TextBox disTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Brand;
        internal System.Windows.Forms.Button addNewBrand;
        internal System.Windows.Forms.Button clearBtn;
        internal System.Windows.Forms.Button deleteBtn;
        internal System.Windows.Forms.Button updateBtn;
        internal System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox partsNameTxt;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox descriptionTxt;
    }
}