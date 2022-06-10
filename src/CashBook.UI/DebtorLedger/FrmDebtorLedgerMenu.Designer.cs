namespace CashBook.UI.DebtorLedger
{
    partial class FrmDebtorLedgerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDebtorLedgerMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAdvanceOrRetire = new System.Windows.Forms.Button();
            this.btnDebtor = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 15;
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
            this.label1.Size = new System.Drawing.Size(352, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEBTOR LEDGER MENU";
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(12, 208);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(236, 65);
            this.btnReports.TabIndex = 18;
            this.btnReports.Text = "Re&ports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAdvanceOrRetire
            // 
            this.btnAdvanceOrRetire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdvanceOrRetire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnAdvanceOrRetire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvanceOrRetire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvanceOrRetire.ForeColor = System.Drawing.Color.White;
            this.btnAdvanceOrRetire.Location = new System.Drawing.Point(12, 137);
            this.btnAdvanceOrRetire.Name = "btnAdvanceOrRetire";
            this.btnAdvanceOrRetire.Size = new System.Drawing.Size(236, 65);
            this.btnAdvanceOrRetire.TabIndex = 17;
            this.btnAdvanceOrRetire.Text = "Advance / Retire Ammount";
            this.btnAdvanceOrRetire.UseVisualStyleBackColor = false;
            this.btnAdvanceOrRetire.Click += new System.EventHandler(this.btnAdvanceOrRetire_Click);
            // 
            // btnDebtor
            // 
            this.btnDebtor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDebtor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnDebtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebtor.ForeColor = System.Drawing.Color.White;
            this.btnDebtor.Location = new System.Drawing.Point(12, 61);
            this.btnDebtor.Name = "btnDebtor";
            this.btnDebtor.Size = new System.Drawing.Size(236, 65);
            this.btnDebtor.TabIndex = 16;
            this.btnDebtor.Text = "Debtor";
            this.btnDebtor.UseVisualStyleBackColor = false;
            this.btnDebtor.Click += new System.EventHandler(this.btnDebtor_Click);
            // 
            // FrmDebtorLedgerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(856, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnAdvanceOrRetire);
            this.Controls.Add(this.btnDebtor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDebtorLedgerMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Debtor Ledger Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAdvanceOrRetire;
        private System.Windows.Forms.Button btnDebtor;
    }
}