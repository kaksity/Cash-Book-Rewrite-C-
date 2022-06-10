namespace CashBook.UI.DebtorLedger
{
    partial class FrmSearchDebtor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchDebtor));
            this.grid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchParameter = new System.Windows.Forms.TextBox();
            this.chkDebtorLedgerNumber = new System.Windows.Forms.RadioButton();
            this.chkDebtorFullName = new System.Windows.Forms.RadioButton();
            this.lblSelectedRecord = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.btnOkay = new crsButton.cButton();
            this.btnCancel = new crsButton.cButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 189);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(443, 282);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchParameter);
            this.groupBox1.Controls.Add(this.chkDebtorLedgerNumber);
            this.groupBox1.Controls.Add(this.chkDebtorFullName);
            this.groupBox1.Controls.Add(this.lblSelectedRecord);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by Debtor Name / Debtor Ledger Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Full Name / Debtor Ledger Number";
            // 
            // txtSearchParameter
            // 
            this.txtSearchParameter.Location = new System.Drawing.Point(185, 73);
            this.txtSearchParameter.Name = "txtSearchParameter";
            this.txtSearchParameter.Size = new System.Drawing.Size(252, 20);
            this.txtSearchParameter.TabIndex = 2;
            this.txtSearchParameter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchParameter_KeyUp);
            // 
            // chkDebtorLedgerNumber
            // 
            this.chkDebtorLedgerNumber.AutoSize = true;
            this.chkDebtorLedgerNumber.Location = new System.Drawing.Point(215, 99);
            this.chkDebtorLedgerNumber.Name = "chkDebtorLedgerNumber";
            this.chkDebtorLedgerNumber.Size = new System.Drawing.Size(140, 17);
            this.chkDebtorLedgerNumber.TabIndex = 1;
            this.chkDebtorLedgerNumber.TabStop = true;
            this.chkDebtorLedgerNumber.Text = "Debtor\'s Ledger Number";
            this.chkDebtorLedgerNumber.UseVisualStyleBackColor = true;
            this.chkDebtorLedgerNumber.CheckedChanged += new System.EventHandler(this.chkDebtorLedgerNumber_CheckedChanged);
            // 
            // chkDebtorFullName
            // 
            this.chkDebtorFullName.AutoSize = true;
            this.chkDebtorFullName.Checked = true;
            this.chkDebtorFullName.Location = new System.Drawing.Point(50, 99);
            this.chkDebtorFullName.Name = "chkDebtorFullName";
            this.chkDebtorFullName.Size = new System.Drawing.Size(95, 17);
            this.chkDebtorFullName.TabIndex = 1;
            this.chkDebtorFullName.TabStop = true;
            this.chkDebtorFullName.Text = "Debtor\'s Name";
            this.chkDebtorFullName.UseVisualStyleBackColor = true;
            this.chkDebtorFullName.CheckedChanged += new System.EventHandler(this.chkDebtorFullName_CheckedChanged);
            // 
            // lblSelectedRecord
            // 
            this.lblSelectedRecord.BackColor = System.Drawing.Color.White;
            this.lblSelectedRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectedRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedRecord.Location = new System.Drawing.Point(6, 16);
            this.lblSelectedRecord.Name = "lblSelectedRecord";
            this.lblSelectedRecord.Size = new System.Drawing.Size(431, 48);
            this.lblSelectedRecord.TabIndex = 0;
            this.lblSelectedRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.BackColor = System.Drawing.Color.White;
            this.lblNumberOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfRecords.Location = new System.Drawing.Point(12, 474);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(145, 48);
            this.lblNumberOfRecords.TabIndex = 2;
            this.lblNumberOfRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOkay
            // 
            this.btnOkay.BackColor = System.Drawing.Color.Transparent;
            this.btnOkay.ButtonType = crsButton.cButton.btnType.ok;
            this.btnOkay.FlatAppearance.BorderSize = 0;
            this.btnOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkay.Image = ((System.Drawing.Image)(resources.GetObject("btnOkay.Image")));
            this.btnOkay.Location = new System.Drawing.Point(248, 477);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(85, 45);
            this.btnOkay.TabIndex = 8;
            this.btnOkay.UseVisualStyleBackColor = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonType = crsButton.cButton.btnType.cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(364, 477);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 45);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 55);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "DEBTORS LIST";
            // 
            // FrmSearchDebtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(467, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearchDebtor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Search Debtor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSearchDebtor_FormClosing);
            this.Load += new System.EventHandler(this.FrmSearchDebtor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchParameter;
        private System.Windows.Forms.RadioButton chkDebtorLedgerNumber;
        private System.Windows.Forms.RadioButton chkDebtorFullName;
        private System.Windows.Forms.Label lblSelectedRecord;
        private System.Windows.Forms.Label lblNumberOfRecords;
        internal crsButton.cButton btnOkay;
        internal crsButton.cButton btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}