namespace CashBook.UI.StockLedger
{
    partial class FrmStockLedgerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockLedgerMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssueAndReceiveItem = new System.Windows.Forms.Button();
            this.btnBinCardItem = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 55);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOCK LEDGER MENU";
            // 
            // btnIssueAndReceiveItem
            // 
            this.btnIssueAndReceiveItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIssueAndReceiveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnIssueAndReceiveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueAndReceiveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueAndReceiveItem.ForeColor = System.Drawing.Color.White;
            this.btnIssueAndReceiveItem.Location = new System.Drawing.Point(12, 153);
            this.btnIssueAndReceiveItem.Name = "btnIssueAndReceiveItem";
            this.btnIssueAndReceiveItem.Size = new System.Drawing.Size(236, 65);
            this.btnIssueAndReceiveItem.TabIndex = 12;
            this.btnIssueAndReceiveItem.Text = "&Issue Item / Recieve Item";
            this.btnIssueAndReceiveItem.UseVisualStyleBackColor = false;
            this.btnIssueAndReceiveItem.Click += new System.EventHandler(this.btnIssueAndReceiveItem_Click);
            // 
            // btnBinCardItem
            // 
            this.btnBinCardItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBinCardItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnBinCardItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBinCardItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinCardItem.ForeColor = System.Drawing.Color.White;
            this.btnBinCardItem.Location = new System.Drawing.Point(12, 77);
            this.btnBinCardItem.Name = "btnBinCardItem";
            this.btnBinCardItem.Size = new System.Drawing.Size(236, 65);
            this.btnBinCardItem.TabIndex = 11;
            this.btnBinCardItem.Text = "&Bin Card Item";
            this.btnBinCardItem.UseVisualStyleBackColor = false;
            this.btnBinCardItem.Click += new System.EventHandler(this.btnBinCardItem_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(12, 224);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(236, 65);
            this.btnReports.TabIndex = 14;
            this.btnReports.Text = "Re&ports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // FrmStockLedgerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(856, 536);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnIssueAndReceiveItem);
            this.Controls.Add(this.btnBinCardItem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStockLedgerMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Stock Ledger Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIssueAndReceiveItem;
        private System.Windows.Forms.Button btnBinCardItem;
        private System.Windows.Forms.Button btnReports;
    }
}