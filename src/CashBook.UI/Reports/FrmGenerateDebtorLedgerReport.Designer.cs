namespace CashBook.UI.Reports
{
    partial class FrmGenerateDebtorLedgerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerateDebtorLedgerReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateReport = new crsButton.cButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.cboFilterYears = new System.Windows.Forms.ComboBox();
            this.cboAdvancedRetired = new System.Windows.Forms.ComboBox();
            this.chkAdvancedAndRetired = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnSearchDebtor = new System.Windows.Forms.Button();
            this.lblDebtor = new System.Windows.Forms.Label();
            this.cboAccounts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAllAccounts = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 55);
            this.panel1.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "DEBTOR REPORT MENU";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateReport.ButtonType = crsButton.cButton.btnType.report;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateReport.Image")));
            this.btnGenerateReport.Location = new System.Drawing.Point(148, 232);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(237, 60);
            this.btnGenerateReport.TabIndex = 45;
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 209);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "Duration";
            // 
            // cboFilterYears
            // 
            this.cboFilterYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterYears.FormattingEnabled = true;
            this.cboFilterYears.Location = new System.Drawing.Point(108, 206);
            this.cboFilterYears.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterYears.Name = "cboFilterYears";
            this.cboFilterYears.Size = new System.Drawing.Size(315, 21);
            this.cboFilterYears.TabIndex = 42;
            // 
            // cboAdvancedRetired
            // 
            this.cboAdvancedRetired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdvancedRetired.FormattingEnabled = true;
            this.cboAdvancedRetired.Location = new System.Drawing.Point(108, 160);
            this.cboAdvancedRetired.Margin = new System.Windows.Forms.Padding(2);
            this.cboAdvancedRetired.Name = "cboAdvancedRetired";
            this.cboAdvancedRetired.Size = new System.Drawing.Size(315, 21);
            this.cboAdvancedRetired.TabIndex = 41;
            // 
            // chkAdvancedAndRetired
            // 
            this.chkAdvancedAndRetired.AutoSize = true;
            this.chkAdvancedAndRetired.Location = new System.Drawing.Point(108, 185);
            this.chkAdvancedAndRetired.Margin = new System.Windows.Forms.Padding(2);
            this.chkAdvancedAndRetired.Name = "chkAdvancedAndRetired";
            this.chkAdvancedAndRetired.Size = new System.Drawing.Size(158, 17);
            this.chkAdvancedAndRetired.TabIndex = 40;
            this.chkAdvancedAndRetired.Text = "Both Advanced and Retired";
            this.chkAdvancedAndRetired.UseVisualStyleBackColor = true;
            this.chkAdvancedAndRetired.CheckedChanged += new System.EventHandler(this.chkAdvancedAndRetired_CheckedChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(9, 163);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(93, 13);
            this.Label5.TabIndex = 39;
            this.Label5.Text = "Advance or Retire";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(9, 96);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "Debtor";
            // 
            // btnSearchDebtor
            // 
            this.btnSearchDebtor.Location = new System.Drawing.Point(426, 86);
            this.btnSearchDebtor.Name = "btnSearchDebtor";
            this.btnSearchDebtor.Size = new System.Drawing.Size(27, 23);
            this.btnSearchDebtor.TabIndex = 63;
            this.btnSearchDebtor.Text = "...";
            this.btnSearchDebtor.UseVisualStyleBackColor = true;
            this.btnSearchDebtor.Click += new System.EventHandler(this.btnSearchDebtor_Click);
            // 
            // lblDebtor
            // 
            this.lblDebtor.BackColor = System.Drawing.Color.White;
            this.lblDebtor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDebtor.Location = new System.Drawing.Point(110, 86);
            this.lblDebtor.Name = "lblDebtor";
            this.lblDebtor.Size = new System.Drawing.Size(313, 23);
            this.lblDebtor.TabIndex = 62;
            this.lblDebtor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboAccounts
            // 
            this.cboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccounts.FormattingEnabled = true;
            this.cboAccounts.Location = new System.Drawing.Point(110, 114);
            this.cboAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Size = new System.Drawing.Size(313, 21);
            this.cboAccounts.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Accounts";
            // 
            // chkAllAccounts
            // 
            this.chkAllAccounts.AutoSize = true;
            this.chkAllAccounts.Location = new System.Drawing.Point(110, 139);
            this.chkAllAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.chkAllAccounts.Name = "chkAllAccounts";
            this.chkAllAccounts.Size = new System.Drawing.Size(85, 17);
            this.chkAllAccounts.TabIndex = 66;
            this.chkAllAccounts.Text = "All Accounts";
            this.chkAllAccounts.UseVisualStyleBackColor = true;
            this.chkAllAccounts.CheckedChanged += new System.EventHandler(this.chkAllAccounts_CheckedChanged);
            // 
            // FrmGenerateDebtorLedgerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(465, 371);
            this.Controls.Add(this.chkAllAccounts);
            this.Controls.Add(this.cboAccounts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchDebtor);
            this.Controls.Add(this.lblDebtor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cboFilterYears);
            this.Controls.Add(this.cboAdvancedRetired);
            this.Controls.Add(this.chkAdvancedAndRetired);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGenerateDebtorLedgerReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Generate Debtor Ledger Report";
            this.Load += new System.EventHandler(this.FrmGenerateDebtorLedgerReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        internal crsButton.cButton btnGenerateReport;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cboFilterYears;
        internal System.Windows.Forms.ComboBox cboAdvancedRetired;
        internal System.Windows.Forms.CheckBox chkAdvancedAndRetired;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnSearchDebtor;
        private System.Windows.Forms.Label lblDebtor;
        internal System.Windows.Forms.ComboBox cboAccounts;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.CheckBox chkAllAccounts;
    }
}