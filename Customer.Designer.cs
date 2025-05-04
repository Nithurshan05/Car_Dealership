namespace ABC_Car_Traders
{
    partial class customerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerForm));
            this.townTxt = new System.Windows.Forms.TextBox();
            this.nicTxt = new System.Windows.Forms.TextBox();
            this.addressTex = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pageTitle = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.districtTxt = new System.Windows.Forms.TextBox();
            this.searchColumnComboBox = new System.Windows.Forms.ComboBox();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.profileImg = new System.Windows.Forms.PictureBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.aBC_TradersDataSet = new ABC_Car_Traders.ABC_TradersDataSet();
            this.cusregistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cus_registrationTableAdapter = new ABC_Car_Traders.ABC_TradersDataSetTableAdapters.cus_registrationTableAdapter();
            this.searchValueBox = new System.Windows.Forms.TextBox();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.teachBx = new System.Windows.Forms.TextBox();
            this.frdBx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_TradersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusregistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // townTxt
            // 
            this.townTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.townTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.townTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.townTxt.Location = new System.Drawing.Point(238, 153);
            this.townTxt.Name = "townTxt";
            this.townTxt.Size = new System.Drawing.Size(394, 30);
            this.townTxt.TabIndex = 22;
            this.townTxt.TextChanged += new System.EventHandler(this.yearTex_TextChanged);
            // 
            // nicTxt
            // 
            this.nicTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.nicTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.nicTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nicTxt.Location = new System.Drawing.Point(238, 117);
            this.nicTxt.Name = "nicTxt";
            this.nicTxt.Size = new System.Drawing.Size(394, 30);
            this.nicTxt.TabIndex = 21;
            this.nicTxt.TextChanged += new System.EventHandler(this.colorTex_TextChanged);
            // 
            // addressTex
            // 
            this.addressTex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.addressTex.Font = new System.Drawing.Font("Arial", 12F);
            this.addressTex.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addressTex.Location = new System.Drawing.Point(238, 60);
            this.addressTex.Multiline = true;
            this.addressTex.Name = "addressTex";
            this.addressTex.Size = new System.Drawing.Size(394, 51);
            this.addressTex.TabIndex = 20;
            // 
            // userNameTxt
            // 
            this.userNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.userNameTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.userNameTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.userNameTxt.Location = new System.Drawing.Point(238, 24);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(394, 30);
            this.userNameTxt.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(149, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "District :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(124, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Town/City :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(177, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "NIC :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(137, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Address :";
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.BackColor = System.Drawing.Color.Transparent;
            this.pageTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.ForeColor = System.Drawing.Color.Black;
            this.pageTitle.Location = new System.Drawing.Point(112, 26);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(120, 23);
            this.pageTitle.TabIndex = 14;
            this.pageTitle.Text = "User Name :";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Location = new System.Drawing.Point(1094, 331);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(107, 36);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(831, 331);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(107, 36);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(162, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(152, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mobile :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(122, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(148, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Search :";
            // 
            // districtTxt
            // 
            this.districtTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.districtTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.districtTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.districtTxt.Location = new System.Drawing.Point(238, 189);
            this.districtTxt.Name = "districtTxt";
            this.districtTxt.Size = new System.Drawing.Size(394, 30);
            this.districtTxt.TabIndex = 22;
            this.districtTxt.TextChanged += new System.EventHandler(this.yearTex_TextChanged);
            // 
            // searchColumnComboBox
            // 
            this.searchColumnComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.searchColumnComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchColumnComboBox.ForeColor = System.Drawing.Color.White;
            this.searchColumnComboBox.FormattingEnabled = true;
            this.searchColumnComboBox.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.searchColumnComboBox.Location = new System.Drawing.Point(373, 347);
            this.searchColumnComboBox.Name = "searchColumnComboBox";
            this.searchColumnComboBox.Size = new System.Drawing.Size(114, 31);
            this.searchColumnComboBox.TabIndex = 23;
            // 
            // mobileTxt
            // 
            this.mobileTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.mobileTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.mobileTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.mobileTxt.Location = new System.Drawing.Point(238, 266);
            this.mobileTxt.Name = "mobileTxt";
            this.mobileTxt.Size = new System.Drawing.Size(394, 30);
            this.mobileTxt.TabIndex = 22;
            this.mobileTxt.TextChanged += new System.EventHandler(this.yearTex_TextChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.passwordTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.passwordTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.passwordTxt.Location = new System.Drawing.Point(238, 305);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(394, 30);
            this.passwordTxt.TabIndex = 22;
            this.passwordTxt.TextChanged += new System.EventHandler(this.yearTex_TextChanged);
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.emailTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.emailTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.emailTxt.Location = new System.Drawing.Point(238, 227);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(394, 30);
            this.emailTxt.TabIndex = 22;
            this.emailTxt.TextChanged += new System.EventHandler(this.yearTex_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Chartreuse;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(703, 331);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 36);
            this.saveBtn.TabIndex = 50;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(961, 331);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(107, 36);
            this.deleteBtn.TabIndex = 52;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.browseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn.ForeColor = System.Drawing.Color.Yellow;
            this.browseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseBtn.Location = new System.Drawing.Point(988, 286);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(130, 30);
            this.browseBtn.TabIndex = 82;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = false;
            // 
            // pathTxt
            // 
            this.pathTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.pathTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.pathTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pathTxt.Location = new System.Drawing.Point(776, 286);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(198, 30);
            this.pathTxt.TabIndex = 81;
            this.pathTxt.TextChanged += new System.EventHandler(this.pathTxt_TextChanged);
            // 
            // profileImg
            // 
            this.profileImg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.profileImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profileImg.BackgroundImage")));
            this.profileImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profileImg.Location = new System.Drawing.Point(777, 27);
            this.profileImg.Name = "profileImg";
            this.profileImg.Size = new System.Drawing.Size(341, 248);
            this.profileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImg.TabIndex = 80;
            this.profileImg.TabStop = false;
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.idBox.Font = new System.Drawing.Font("Arial", 12F);
            this.idBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.idBox.Location = new System.Drawing.Point(493, 345);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(139, 30);
            this.idBox.TabIndex = 83;
            // 
            // aBC_TradersDataSet
            // 
            this.aBC_TradersDataSet.DataSetName = "ABC_TradersDataSet";
            this.aBC_TradersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cusregistrationBindingSource
            // 
            this.cusregistrationBindingSource.DataMember = "cus_registration";
            this.cusregistrationBindingSource.DataSource = this.aBC_TradersDataSet;
            // 
            // cus_registrationTableAdapter
            // 
            this.cus_registrationTableAdapter.ClearBeforeFill = true;
            // 
            // searchValueBox
            // 
            this.searchValueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.searchValueBox.Font = new System.Drawing.Font("Arial", 12F);
            this.searchValueBox.ForeColor = System.Drawing.Color.White;
            this.searchValueBox.Location = new System.Drawing.Point(238, 348);
            this.searchValueBox.Name = "searchValueBox";
            this.searchValueBox.Size = new System.Drawing.Size(129, 30);
            this.searchValueBox.TabIndex = 83;
            this.searchValueBox.TextChanged += new System.EventHandler(this.searchValueBox_TextChanged);
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            this.customerGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.customerGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customerGridView.Location = new System.Drawing.Point(0, 399);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.RowHeadersWidth = 51;
            this.customerGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.customerGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.customerGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.customerGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.customerGridView.RowTemplate.Height = 24;
            this.customerGridView.Size = new System.Drawing.Size(1275, 228);
            this.customerGridView.TabIndex = 84;
            // 
            // teachBx
            // 
            this.teachBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.teachBx.Font = new System.Drawing.Font("Arial", 12F);
            this.teachBx.ForeColor = System.Drawing.SystemColors.Desktop;
            this.teachBx.Location = new System.Drawing.Point(1138, 27);
            this.teachBx.Name = "teachBx";
            this.teachBx.Size = new System.Drawing.Size(113, 30);
            this.teachBx.TabIndex = 81;
            this.teachBx.Visible = false;
            this.teachBx.TextChanged += new System.EventHandler(this.pathTxt_TextChanged);
            // 
            // frdBx
            // 
            this.frdBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
            this.frdBx.Font = new System.Drawing.Font("Arial", 12F);
            this.frdBx.ForeColor = System.Drawing.SystemColors.Desktop;
            this.frdBx.Location = new System.Drawing.Point(1138, 65);
            this.frdBx.Name = "frdBx";
            this.frdBx.Size = new System.Drawing.Size(113, 30);
            this.frdBx.TabIndex = 81;
            this.frdBx.Visible = false;
            this.frdBx.TextChanged += new System.EventHandler(this.pathTxt_TextChanged);
            // 
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(229)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1275, 627);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.searchValueBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.frdBx);
            this.Controls.Add(this.teachBx);
            this.Controls.Add(this.pathTxt);
            this.Controls.Add(this.profileImg);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.searchColumnComboBox);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.mobileTxt);
            this.Controls.Add(this.districtTxt);
            this.Controls.Add(this.townTxt);
            this.Controls.Add(this.nicTxt);
            this.Controls.Add(this.addressTex);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.updateBtn);
            this.Name = "customerForm";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.customerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_TradersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusregistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox townTxt;
        internal System.Windows.Forms.TextBox nicTxt;
        internal System.Windows.Forms.TextBox addressTex;
        internal System.Windows.Forms.TextBox userNameTxt;
        internal System.Windows.Forms.Button clearBtn;
        internal System.Windows.Forms.Button updateBtn;
        internal System.Windows.Forms.TextBox districtTxt;
        internal System.Windows.Forms.ComboBox searchColumnComboBox;
        internal System.Windows.Forms.TextBox mobileTxt;
        internal System.Windows.Forms.TextBox passwordTxt;
        internal System.Windows.Forms.TextBox emailTxt;
        internal System.Windows.Forms.Button saveBtn;
        internal System.Windows.Forms.Button deleteBtn;
        internal System.Windows.Forms.Button browseBtn;
        internal System.Windows.Forms.TextBox pathTxt;
        internal System.Windows.Forms.PictureBox profileImg;
        internal System.Windows.Forms.TextBox idBox;
        private ABC_TradersDataSet aBC_TradersDataSet;
        private System.Windows.Forms.BindingSource cusregistrationBindingSource;
        private ABC_TradersDataSetTableAdapters.cus_registrationTableAdapter cus_registrationTableAdapter;
        internal System.Windows.Forms.TextBox searchValueBox;
        internal System.Windows.Forms.DataGridView customerGridView;
        internal System.Windows.Forms.TextBox teachBx;
        internal System.Windows.Forms.TextBox frdBx;
    }
}