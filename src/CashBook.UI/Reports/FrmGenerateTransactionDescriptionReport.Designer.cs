namespace CashBook.UI.Reports
{
    partial class FrmGenerateTransactionDescriptionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerateTransactionDescriptionReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateReport = new crsButton.cButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBothIncomeAndExpenseTransactionType = new System.Windows.Forms.RadioButton();
            this.rbExpenseTransactionTypeOnly = new System.Windows.Forms.RadioButton();
            this.rbIncomeTransactionTypeOnly = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 55);
            this.panel1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(653, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "TRANSACTION DESCRIPTION ITEMS REPORT";
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
            this.btnGenerateReport.Location = new System.Drawing.Point(197, 367);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(237, 60);
            this.btnGenerateReport.TabIndex = 26;
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBothIncomeAndExpenseTransactionType);
            this.groupBox1.Controls.Add(this.rbExpenseTransactionTypeOnly);
            this.groupBox1.Controls.Add(this.rbIncomeTransactionTypeOnly);
            this.groupBox1.Location = new System.Drawing.Point(141, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 278);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // rbBothIncomeAndExpenseTransactionType
            // 
            this.rbBothIncomeAndExpenseTransactionType.AutoSize = true;
            this.rbBothIncomeAndExpenseTransactionType.Location = new System.Drawing.Point(28, 135);
            this.rbBothIncomeAndExpenseTransactionType.Name = "rbBothIncomeAndExpenseTransactionType";
            this.rbBothIncomeAndExpenseTransactionType.Size = new System.Drawing.Size(237, 17);
            this.rbBothIncomeAndExpenseTransactionType.TabIndex = 2;
            this.rbBothIncomeAndExpenseTransactionType.TabStop = true;
            this.rbBothIncomeAndExpenseTransactionType.Text = "Both Income And Expense Transaction Type";
            this.rbBothIncomeAndExpenseTransactionType.UseVisualStyleBackColor = true;
            // 
            // rbExpenseTransactionTypeOnly
            // 
            this.rbExpenseTransactionTypeOnly.AutoSize = true;
            this.rbExpenseTransactionTypeOnly.Location = new System.Drawing.Point(28, 88);
            this.rbExpenseTransactionTypeOnly.Name = "rbExpenseTransactionTypeOnly";
            this.rbExpenseTransactionTypeOnly.Size = new System.Drawing.Size(176, 17);
            this.rbExpenseTransactionTypeOnly.TabIndex = 1;
            this.rbExpenseTransactionTypeOnly.TabStop = true;
            this.rbExpenseTransactionTypeOnly.Text = "Expense Transaction Type Only";
            this.rbExpenseTransactionTypeOnly.UseVisualStyleBackColor = true;
            // 
            // rbIncomeTransactionTypeOnly
            // 
            this.rbIncomeTransactionTypeOnly.AutoSize = true;
            this.rbIncomeTransactionTypeOnly.Location = new System.Drawing.Point(28, 40);
            this.rbIncomeTransactionTypeOnly.Name = "rbIncomeTransactionTypeOnly";
            this.rbIncomeTransactionTypeOnly.Size = new System.Drawing.Size(170, 17);
            this.rbIncomeTransactionTypeOnly.TabIndex = 0;
            this.rbIncomeTransactionTypeOnly.TabStop = true;
            this.rbIncomeTransactionTypeOnly.Text = "Income Transaction Type Only";
            this.rbIncomeTransactionTypeOnly.UseVisualStyleBackColor = true;
            // 
            // FrmGenerateTransactionDescriptionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(681, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGenerateTransactionDescriptionReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Generate Transaction Description Item Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        internal crsButton.cButton btnGenerateReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBothIncomeAndExpenseTransactionType;
        private System.Windows.Forms.RadioButton rbExpenseTransactionTypeOnly;
        private System.Windows.Forms.RadioButton rbIncomeTransactionTypeOnly;
    }
}