namespace CashBook.UI.Reports
{
    partial class FrmGenerateBinCardReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerateBinCardReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateReport = new crsButton.cButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.cboFilterYears = new System.Windows.Forms.ComboBox();
            this.cboIssueReceipt = new System.Windows.Forms.ComboBox();
            this.chkIssuesReceipt = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblBinCardItem = new System.Windows.Forms.Label();
            this.btnSearchBinCardItem = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "BIN CARD REPORT MENU";
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
            this.btnGenerateReport.Location = new System.Drawing.Point(119, 216);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(301, 60);
            this.btnGenerateReport.TabIndex = 35;
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(25, 193);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 34;
            this.Label2.Text = "Duration";
            // 
            // cboFilterYears
            // 
            this.cboFilterYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterYears.FormattingEnabled = true;
            this.cboFilterYears.Location = new System.Drawing.Point(117, 190);
            this.cboFilterYears.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterYears.Name = "cboFilterYears";
            this.cboFilterYears.Size = new System.Drawing.Size(303, 21);
            this.cboFilterYears.TabIndex = 32;
            this.cboFilterYears.SelectedIndexChanged += new System.EventHandler(this.cboFilterYears_SelectedIndexChanged);
            // 
            // cboIssueReceipt
            // 
            this.cboIssueReceipt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIssueReceipt.FormattingEnabled = true;
            this.cboIssueReceipt.Location = new System.Drawing.Point(119, 144);
            this.cboIssueReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.cboIssueReceipt.Name = "cboIssueReceipt";
            this.cboIssueReceipt.Size = new System.Drawing.Size(301, 21);
            this.cboIssueReceipt.TabIndex = 31;
            // 
            // chkIssuesReceipt
            // 
            this.chkIssuesReceipt.AutoSize = true;
            this.chkIssuesReceipt.Location = new System.Drawing.Point(119, 169);
            this.chkIssuesReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.chkIssuesReceipt.Name = "chkIssuesReceipt";
            this.chkIssuesReceipt.Size = new System.Drawing.Size(143, 17);
            this.chkIssuesReceipt.TabIndex = 30;
            this.chkIssuesReceipt.Text = "Both Receipt and Issued";
            this.chkIssuesReceipt.UseVisualStyleBackColor = true;
            this.chkIssuesReceipt.CheckedChanged += new System.EventHandler(this.chkIssuesReceipt_CheckedChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(25, 147);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(86, 13);
            this.Label5.TabIndex = 29;
            this.Label5.Text = "Issue Or Receipt";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(25, 120);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 13);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Bin Card Item";
            // 
            // lblBinCardItem
            // 
            this.lblBinCardItem.BackColor = System.Drawing.Color.White;
            this.lblBinCardItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBinCardItem.Location = new System.Drawing.Point(119, 115);
            this.lblBinCardItem.Name = "lblBinCardItem";
            this.lblBinCardItem.Size = new System.Drawing.Size(301, 23);
            this.lblBinCardItem.TabIndex = 63;
            this.lblBinCardItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchBinCardItem
            // 
            this.btnSearchBinCardItem.Location = new System.Drawing.Point(426, 116);
            this.btnSearchBinCardItem.Name = "btnSearchBinCardItem";
            this.btnSearchBinCardItem.Size = new System.Drawing.Size(27, 20);
            this.btnSearchBinCardItem.TabIndex = 62;
            this.btnSearchBinCardItem.Text = "...";
            this.btnSearchBinCardItem.UseVisualStyleBackColor = true;
            this.btnSearchBinCardItem.Click += new System.EventHandler(this.btnSearchBinCardItem_Click);
            // 
            // FrmGenerateBinCardReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(465, 371);
            this.Controls.Add(this.lblBinCardItem);
            this.Controls.Add(this.btnSearchBinCardItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cboFilterYears);
            this.Controls.Add(this.cboIssueReceipt);
            this.Controls.Add(this.chkIssuesReceipt);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGenerateBinCardReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Generate Bin Card Report";
            this.Load += new System.EventHandler(this.FrmGenerateBinCardReport_Load);
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
        internal System.Windows.Forms.ComboBox cboIssueReceipt;
        internal System.Windows.Forms.CheckBox chkIssuesReceipt;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label lblBinCardItem;
        private System.Windows.Forms.Button btnSearchBinCardItem;
    }
}