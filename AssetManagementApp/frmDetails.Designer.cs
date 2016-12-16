namespace AssetManagementApp
{
    partial class frmDetails
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBorrower = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnChangePicture = new System.Windows.Forms.Button();
            this.txtLifeSpan = new System.Windows.Forms.TextBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAssetTag = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentValue = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnBrowseUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(591, 347);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 27);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnBrowseUser);
            this.panel1.Controls.Add(this.txtBorrower);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.btnChangePicture);
            this.panel1.Controls.Add(this.txtLifeSpan);
            this.panel1.Controls.Add(this.dtpPurchaseDate);
            this.panel1.Controls.Add(this.dtpReturnDate);
            this.panel1.Controls.Add(this.pbPicture);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAssetTag);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCurrentValue);
            this.panel1.Controls.Add(this.txtPurchasePrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbxType);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbxStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 331);
            this.panel1.TabIndex = 40;
            // 
            // txtBorrower
            // 
            this.txtBorrower.Location = new System.Drawing.Point(462, 51);
            this.txtBorrower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBorrower.Name = "txtBorrower";
            this.txtBorrower.ReadOnly = true;
            this.txtBorrower.Size = new System.Drawing.Size(159, 23);
            this.txtBorrower.TabIndex = 44;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(567, 264);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 27);
            this.btnCalculate.TabIndex = 43;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnChangePicture
            // 
            this.btnChangePicture.Location = new System.Drawing.Point(242, 128);
            this.btnChangePicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangePicture.Name = "btnChangePicture";
            this.btnChangePicture.Size = new System.Drawing.Size(58, 27);
            this.btnChangePicture.TabIndex = 42;
            this.btnChangePicture.Text = "Change";
            this.btnChangePicture.UseVisualStyleBackColor = true;
            this.btnChangePicture.Click += new System.EventHandler(this.btnChangePicture_Click);
            // 
            // txtLifeSpan
            // 
            this.txtLifeSpan.Location = new System.Drawing.Point(462, 206);
            this.txtLifeSpan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLifeSpan.Name = "txtLifeSpan";
            this.txtLifeSpan.Size = new System.Drawing.Size(193, 23);
            this.txtLifeSpan.TabIndex = 42;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CustomFormat = "MMMM dd, yyyy ";
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(462, 177);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(193, 23);
            this.dtpPurchaseDate.TabIndex = 41;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CustomFormat = "MMMM dd, yyyy ";
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnDate.Location = new System.Drawing.Point(462, 77);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(193, 23);
            this.dtpReturnDate.TabIndex = 40;
            // 
            // pbPicture
            // 
            this.pbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(13, 15);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(300, 150);
            this.pbPicture.TabIndex = 39;
            this.pbPicture.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 208);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 23);
            this.txtName.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 179);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Purchase Date";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 264);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(193, 55);
            this.txtDescription.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 208);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "Life Span (Yrs)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Description";
            // 
            // txtAssetTag
            // 
            this.txtAssetTag.Location = new System.Drawing.Point(120, 179);
            this.txtAssetTag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAssetTag.Name = "txtAssetTag";
            this.txtAssetTag.Size = new System.Drawing.Size(193, 23);
            this.txtAssetTag.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 238);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Current Value";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Asset Tag";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentValue
            // 
            this.txtCurrentValue.Enabled = false;
            this.txtCurrentValue.Location = new System.Drawing.Point(462, 235);
            this.txtCurrentValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCurrentValue.Name = "txtCurrentValue";
            this.txtCurrentValue.Size = new System.Drawing.Size(193, 23);
            this.txtCurrentValue.TabIndex = 33;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(462, 148);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(193, 23);
            this.txtPurchasePrice.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Return Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Purchase Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Borrower";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(120, 236);
            this.cbxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(193, 23);
            this.cbxType.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(462, 23);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(193, 23);
            this.cbxStatus.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(495, 347);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(10, 347);
            this.btnLock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(88, 27);
            this.btnLock.TabIndex = 42;
            this.btnLock.Text = "Unlock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnBrowseUser
            // 
            this.btnBrowseUser.Location = new System.Drawing.Point(629, 51);
            this.btnBrowseUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseUser.Name = "btnBrowseUser";
            this.btnBrowseUser.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseUser.TabIndex = 45;
            this.btnBrowseUser.Text = "...";
            this.btnBrowseUser.UseVisualStyleBackColor = true;
            this.btnBrowseUser.Click += new System.EventHandler(this.btnBrowseUser_Click);
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 386);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Name = "frmDetails";
            this.Text = "Assset Management - View Items";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAssetTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCurrentValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.TextBox txtLifeSpan;
        private System.Windows.Forms.Button btnChangePicture;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtBorrower;
        private System.Windows.Forms.Button btnBrowseUser;
    }
}