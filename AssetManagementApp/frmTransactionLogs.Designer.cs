namespace AssetManagementApp
{
    partial class frmTransactionLogs
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
            this.dvItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dvItems
            // 
            this.dvItems.AllowUserToAddRows = false;
            this.dvItems.AllowUserToDeleteRows = false;
            this.dvItems.AllowUserToResizeRows = false;
            this.dvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvItems.Location = new System.Drawing.Point(12, 12);
            this.dvItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvItems.MultiSelect = false;
            this.dvItems.Name = "dvItems";
            this.dvItems.RowHeadersVisible = false;
            this.dvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvItems.ShowCellErrors = false;
            this.dvItems.ShowCellToolTips = false;
            this.dvItems.ShowEditingIcon = false;
            this.dvItems.ShowRowErrors = false;
            this.dvItems.Size = new System.Drawing.Size(531, 474);
            this.dvItems.TabIndex = 4;
            // 
            // frmTransactionLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 498);
            this.Controls.Add(this.dvItems);
            this.Name = "frmTransactionLogs";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Asset Management - Transaction Logs";
            this.Load += new System.EventHandler(this.frmTransactionLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvItems;
    }
}