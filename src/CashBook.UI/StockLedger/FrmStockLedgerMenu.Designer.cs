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
            this.btnIssueItem = new System.Windows.Forms.Button();
            this.btnBinCardItem = new System.Windows.Forms.Button();
            this.btnReceiveItem = new System.Windows.Forms.Button();
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
            // btnIssueItem
            // 
            this.btnIssueItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIssueItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnIssueItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueItem.ForeColor = System.Drawing.Color.White;
            this.btnIssueItem.Location = new System.Drawing.Point(12, 153);
            this.btnIssueItem.Name = "btnIssueItem";
            this.btnIssueItem.Size = new System.Drawing.Size(236, 65);
            this.btnIssueItem.TabIndex = 12;
            this.btnIssueItem.Text = "&Issue Item";
            this.btnIssueItem.UseVisualStyleBackColor = false;
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
            // btnReceiveItem
            // 
            this.btnReceiveItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReceiveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnReceiveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveItem.ForeColor = System.Drawing.Color.White;
            this.btnReceiveItem.Location = new System.Drawing.Point(12, 233);
            this.btnReceiveItem.Name = "btnReceiveItem";
            this.btnReceiveItem.Size = new System.Drawing.Size(236, 65);
            this.btnReceiveItem.TabIndex = 13;
            this.btnReceiveItem.Text = "Re&ceive Item";
            this.btnReceiveItem.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(12, 315);
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
            this.Controls.Add(this.btnReceiveItem);
            this.Controls.Add(this.btnIssueItem);
            this.Controls.Add(this.btnBinCardItem);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button btnIssueItem;
        private System.Windows.Forms.Button btnBinCardItem;
        private System.Windows.Forms.Button btnReceiveItem;
        private System.Windows.Forms.Button btnReports;
    }
}