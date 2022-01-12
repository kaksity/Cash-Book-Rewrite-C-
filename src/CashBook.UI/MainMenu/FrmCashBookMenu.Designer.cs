namespace CashBook.UI.MainMenu
{
    partial class FrmCashBookMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCashBookMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIncomeRegister = new System.Windows.Forms.Button();
            this.btnTransactionDescriptionItem = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnExpenseRegister = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCloseFinancialMonth = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CASHBOOK MENU";
            // 
            // btnIncomeRegister
            // 
            this.btnIncomeRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIncomeRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnIncomeRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncomeRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncomeRegister.ForeColor = System.Drawing.Color.White;
            this.btnIncomeRegister.Location = new System.Drawing.Point(12, 226);
            this.btnIncomeRegister.Name = "btnIncomeRegister";
            this.btnIncomeRegister.Size = new System.Drawing.Size(236, 65);
            this.btnIncomeRegister.TabIndex = 11;
            this.btnIncomeRegister.Text = "Income Register";
            this.btnIncomeRegister.UseVisualStyleBackColor = false;
            this.btnIncomeRegister.Click += new System.EventHandler(this.btnIncomeRegister_Click);
            // 
            // btnTransactionDescriptionItem
            // 
            this.btnTransactionDescriptionItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTransactionDescriptionItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnTransactionDescriptionItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionDescriptionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionDescriptionItem.ForeColor = System.Drawing.Color.White;
            this.btnTransactionDescriptionItem.Location = new System.Drawing.Point(12, 145);
            this.btnTransactionDescriptionItem.Name = "btnTransactionDescriptionItem";
            this.btnTransactionDescriptionItem.Size = new System.Drawing.Size(236, 65);
            this.btnTransactionDescriptionItem.TabIndex = 10;
            this.btnTransactionDescriptionItem.Text = "Transaction Description Items";
            this.btnTransactionDescriptionItem.UseVisualStyleBackColor = false;
            this.btnTransactionDescriptionItem.Click += new System.EventHandler(this.btnTransactionDescriptionItem_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounts.ForeColor = System.Drawing.Color.White;
            this.btnAccounts.Location = new System.Drawing.Point(12, 69);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(236, 65);
            this.btnAccounts.TabIndex = 9;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.UseVisualStyleBackColor = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnExpenseRegister
            // 
            this.btnExpenseRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExpenseRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnExpenseRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseRegister.ForeColor = System.Drawing.Color.White;
            this.btnExpenseRegister.Location = new System.Drawing.Point(12, 306);
            this.btnExpenseRegister.Name = "btnExpenseRegister";
            this.btnExpenseRegister.Size = new System.Drawing.Size(236, 65);
            this.btnExpenseRegister.TabIndex = 12;
            this.btnExpenseRegister.Text = "Expense Register";
            this.btnExpenseRegister.UseVisualStyleBackColor = false;
            this.btnExpenseRegister.Click += new System.EventHandler(this.btnExpenseRegister_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(12, 459);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(236, 65);
            this.btnReports.TabIndex = 13;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCloseFinancialMonth
            // 
            this.btnCloseFinancialMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseFinancialMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.btnCloseFinancialMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFinancialMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFinancialMonth.ForeColor = System.Drawing.Color.White;
            this.btnCloseFinancialMonth.Location = new System.Drawing.Point(12, 382);
            this.btnCloseFinancialMonth.Name = "btnCloseFinancialMonth";
            this.btnCloseFinancialMonth.Size = new System.Drawing.Size(236, 65);
            this.btnCloseFinancialMonth.TabIndex = 14;
            this.btnCloseFinancialMonth.Text = "Close Financial Month";
            this.btnCloseFinancialMonth.UseVisualStyleBackColor = false;
            this.btnCloseFinancialMonth.Click += new System.EventHandler(this.btnCloseFinancialMonth_Click);
            // 
            // FrmCashBookMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(856, 536);
            this.Controls.Add(this.btnCloseFinancialMonth);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnExpenseRegister);
            this.Controls.Add(this.btnIncomeRegister);
            this.Controls.Add(this.btnTransactionDescriptionItem);
            this.Controls.Add(this.btnAccounts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCashBookMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Cash Book Menu";
            this.Load += new System.EventHandler(this.FrmCashBookMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncomeRegister;
        private System.Windows.Forms.Button btnTransactionDescriptionItem;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnExpenseRegister;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCloseFinancialMonth;
    }
}