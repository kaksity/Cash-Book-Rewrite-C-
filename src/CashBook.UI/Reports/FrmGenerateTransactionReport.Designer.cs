namespace CashBook.UI.Reports
{
    partial class FrmGenerateTransactionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerateTransactionReport));
            this.btnGenerateReport = new crsButton.cButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.cboMonths = new System.Windows.Forms.ComboBox();
            this.cboTypeOfTransaction = new System.Windows.Forms.ComboBox();
            this.chkTransactionType = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.chkDescription = new System.Windows.Forms.CheckBox();
            this.cboAccounts = new System.Windows.Forms.ComboBox();
            this.cboDescriptions = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnGenerateReport.Location = new System.Drawing.Point(160, 242);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(237, 60);
            this.btnGenerateReport.TabIndex = 22;
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(30, 218);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Duration";
            // 
            // cboYears
            // 
            this.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(269, 213);
            this.cboYears.Margin = new System.Windows.Forms.Padding(2);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(128, 21);
            this.cboYears.TabIndex = 19;
            // 
            // cboMonths
            // 
            this.cboMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonths.FormattingEnabled = true;
            this.cboMonths.Location = new System.Drawing.Point(160, 213);
            this.cboMonths.Margin = new System.Windows.Forms.Padding(2);
            this.cboMonths.Name = "cboMonths";
            this.cboMonths.Size = new System.Drawing.Size(105, 21);
            this.cboMonths.TabIndex = 20;
            // 
            // cboTypeOfTransaction
            // 
            this.cboTypeOfTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeOfTransaction.FormattingEnabled = true;
            this.cboTypeOfTransaction.Location = new System.Drawing.Point(162, 131);
            this.cboTypeOfTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.cboTypeOfTransaction.Name = "cboTypeOfTransaction";
            this.cboTypeOfTransaction.Size = new System.Drawing.Size(235, 21);
            this.cboTypeOfTransaction.TabIndex = 18;
            this.cboTypeOfTransaction.SelectedIndexChanged += new System.EventHandler(this.cboTypeOfTransaction_SelectedIndexChanged);
            // 
            // chkTransactionType
            // 
            this.chkTransactionType.AutoSize = true;
            this.chkTransactionType.Location = new System.Drawing.Point(162, 108);
            this.chkTransactionType.Margin = new System.Windows.Forms.Padding(2);
            this.chkTransactionType.Name = "chkTransactionType";
            this.chkTransactionType.Size = new System.Drawing.Size(123, 17);
            this.chkTransactionType.TabIndex = 17;
            this.chkTransactionType.Text = "All Transaction Type";
            this.chkTransactionType.UseVisualStyleBackColor = true;
            this.chkTransactionType.CheckedChanged += new System.EventHandler(this.chkTransactionType_CheckedChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(30, 135);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(104, 13);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "Type Of Transaction";
            // 
            // chkDescription
            // 
            this.chkDescription.AutoSize = true;
            this.chkDescription.Location = new System.Drawing.Point(160, 158);
            this.chkDescription.Margin = new System.Windows.Forms.Padding(2);
            this.chkDescription.Name = "chkDescription";
            this.chkDescription.Size = new System.Drawing.Size(93, 17);
            this.chkDescription.TabIndex = 15;
            this.chkDescription.Text = "All Description";
            this.chkDescription.UseVisualStyleBackColor = true;
            this.chkDescription.CheckedChanged += new System.EventHandler(this.chkDescription_CheckedChanged);
            // 
            // cboAccounts
            // 
            this.cboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccounts.FormattingEnabled = true;
            this.cboAccounts.Location = new System.Drawing.Point(162, 81);
            this.cboAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Size = new System.Drawing.Size(237, 21);
            this.cboAccounts.TabIndex = 13;
            // 
            // cboDescriptions
            // 
            this.cboDescriptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDescriptions.FormattingEnabled = true;
            this.cboDescriptions.Location = new System.Drawing.Point(160, 182);
            this.cboDescriptions.Margin = new System.Windows.Forms.Padding(2);
            this.cboDescriptions.Name = "cboDescriptions";
            this.cboDescriptions.Size = new System.Drawing.Size(237, 21);
            this.cboDescriptions.TabIndex = 14;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(28, 186);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(60, 13);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Description";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(25, 86);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Accounts";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 55);
            this.panel1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "TRANSACTION REPORT MENU";
            // 
            // FrmGenerateTransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(465, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cboYears);
            this.Controls.Add(this.cboMonths);
            this.Controls.Add(this.cboTypeOfTransaction);
            this.Controls.Add(this.chkTransactionType);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.chkDescription);
            this.Controls.Add(this.cboAccounts);
            this.Controls.Add(this.cboDescriptions);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGenerateTransactionReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Generate Transaction Report";
            this.Load += new System.EventHandler(this.FrmGenerateTransactionReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal crsButton.cButton btnGenerateReport;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cboYears;
        internal System.Windows.Forms.ComboBox cboMonths;
        internal System.Windows.Forms.ComboBox cboTypeOfTransaction;
        internal System.Windows.Forms.CheckBox chkTransactionType;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.CheckBox chkDescription;
        internal System.Windows.Forms.ComboBox cboAccounts;
        internal System.Windows.Forms.ComboBox cboDescriptions;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}