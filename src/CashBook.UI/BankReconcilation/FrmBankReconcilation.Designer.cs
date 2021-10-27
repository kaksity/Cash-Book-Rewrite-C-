namespace CashBook.UI.BankReconcilation
{
    partial class FrmBankReconcilation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankReconcilation));
            this.btnClose = new crsButton.cButton();
            this.btnSave = new crsButton.cButton();
            this.btnNew = new crsButton.cButton();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtItemsInCashBookNotBank = new System.Windows.Forms.TextBox();
            this.txtUncreditedLodgement = new System.Windows.Forms.TextBox();
            this.txtItemsInBankNotCashBook = new System.Windows.Forms.TextBox();
            this.txtUnpresentedChqs = new System.Windows.Forms.TextBox();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.cboMonths = new System.Windows.Forms.ComboBox();
            this.btnUndo = new crsButton.cButton();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOutstandingStaleChqs = new System.Windows.Forms.TextBox();
            this.txtDebitTransfer = new System.Windows.Forms.TextBox();
            this.txtBankCharges = new System.Windows.Forms.TextBox();
            this.txtStaleChqsReversed = new System.Windows.Forms.TextBox();
            this.txtInterestReceived = new System.Windows.Forms.TextBox();
            this.txtCreditTransfer = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.cboAccount = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ButtonType = crsButton.cButton.btnType.close2;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(609, 239);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 45);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ButtonType = crsButton.cButton.btnType.save;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(518, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 45);
            this.btnSave.TabIndex = 9;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.ButtonType = crsButton.cButton.btnType.new_;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(327, 239);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 45);
            this.btnNew.TabIndex = 10;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(5, 97);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(147, 13);
            this.Label10.TabIndex = 1;
            this.Label10.Text = "Items In Cash Book Not Bank";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(5, 71);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(120, 13);
            this.Label11.TabIndex = 1;
            this.Label11.Text = "Uncredited Lodgements";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(5, 46);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(147, 13);
            this.Label9.TabIndex = 1;
            this.Label9.Text = "Items In Bank Not Cash Book";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(5, 20);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(83, 13);
            this.Label8.TabIndex = 1;
            this.Label8.Text = "Unpresent Chqs";
            // 
            // txtItemsInCashBookNotBank
            // 
            this.txtItemsInCashBookNotBank.Location = new System.Drawing.Point(191, 93);
            this.txtItemsInCashBookNotBank.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemsInCashBookNotBank.Name = "txtItemsInCashBookNotBank";
            this.txtItemsInCashBookNotBank.Size = new System.Drawing.Size(155, 20);
            this.txtItemsInCashBookNotBank.TabIndex = 12;
            // 
            // txtUncreditedLodgement
            // 
            this.txtUncreditedLodgement.Location = new System.Drawing.Point(191, 68);
            this.txtUncreditedLodgement.Margin = new System.Windows.Forms.Padding(2);
            this.txtUncreditedLodgement.Name = "txtUncreditedLodgement";
            this.txtUncreditedLodgement.Size = new System.Drawing.Size(155, 20);
            this.txtUncreditedLodgement.TabIndex = 11;
            // 
            // txtItemsInBankNotCashBook
            // 
            this.txtItemsInBankNotCashBook.Location = new System.Drawing.Point(191, 42);
            this.txtItemsInBankNotCashBook.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemsInBankNotCashBook.Name = "txtItemsInBankNotCashBook";
            this.txtItemsInBankNotCashBook.Size = new System.Drawing.Size(155, 20);
            this.txtItemsInBankNotCashBook.TabIndex = 10;
            // 
            // txtUnpresentedChqs
            // 
            this.txtUnpresentedChqs.Location = new System.Drawing.Point(191, 17);
            this.txtUnpresentedChqs.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnpresentedChqs.Name = "txtUnpresentedChqs";
            this.txtUnpresentedChqs.Size = new System.Drawing.Size(155, 20);
            this.txtUnpresentedChqs.TabIndex = 9;
            // 
            // cboYears
            // 
            this.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(353, 19);
            this.cboYears.Margin = new System.Windows.Forms.Padding(2);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(325, 21);
            this.cboYears.TabIndex = 2;
            // 
            // cboMonths
            // 
            this.cboMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonths.FormattingEnabled = true;
            this.cboMonths.Location = new System.Drawing.Point(5, 20);
            this.cboMonths.Margin = new System.Windows.Forms.Padding(2);
            this.cboMonths.Name = "cboMonths";
            this.cboMonths.Size = new System.Drawing.Size(328, 21);
            this.cboMonths.TabIndex = 1;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnUndo.ButtonType = crsButton.cButton.btnType.undo;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.Location = new System.Drawing.Point(418, 239);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(85, 45);
            this.btnUndo.TabIndex = 11;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.cboYears);
            this.GroupBox2.Controls.Add(this.cboMonths);
            this.GroupBox2.Location = new System.Drawing.Point(12, 46);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox2.Size = new System.Drawing.Size(682, 60);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Duration";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 22);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Account";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 48);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(91, 13);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Interest Received";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 22);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Credit Transfer";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Controls.Add(this.Label11);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.txtItemsInCashBookNotBank);
            this.GroupBox3.Controls.Add(this.txtUncreditedLodgement);
            this.GroupBox3.Controls.Add(this.txtItemsInBankNotCashBook);
            this.GroupBox3.Controls.Add(this.txtUnpresentedChqs);
            this.GroupBox3.Location = new System.Drawing.Point(327, 111);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox3.Size = new System.Drawing.Size(367, 125);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Bank Details";
            // 
            // txtOutstandingStaleChqs
            // 
            this.txtOutstandingStaleChqs.Location = new System.Drawing.Point(171, 148);
            this.txtOutstandingStaleChqs.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutstandingStaleChqs.Name = "txtOutstandingStaleChqs";
            this.txtOutstandingStaleChqs.Size = new System.Drawing.Size(135, 20);
            this.txtOutstandingStaleChqs.TabIndex = 8;
            // 
            // txtDebitTransfer
            // 
            this.txtDebitTransfer.Location = new System.Drawing.Point(171, 122);
            this.txtDebitTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.txtDebitTransfer.Name = "txtDebitTransfer";
            this.txtDebitTransfer.Size = new System.Drawing.Size(135, 20);
            this.txtDebitTransfer.TabIndex = 7;
            // 
            // txtBankCharges
            // 
            this.txtBankCharges.Location = new System.Drawing.Point(171, 97);
            this.txtBankCharges.Margin = new System.Windows.Forms.Padding(2);
            this.txtBankCharges.Name = "txtBankCharges";
            this.txtBankCharges.Size = new System.Drawing.Size(135, 20);
            this.txtBankCharges.TabIndex = 6;
            // 
            // txtStaleChqsReversed
            // 
            this.txtStaleChqsReversed.Location = new System.Drawing.Point(171, 71);
            this.txtStaleChqsReversed.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaleChqsReversed.Name = "txtStaleChqsReversed";
            this.txtStaleChqsReversed.Size = new System.Drawing.Size(135, 20);
            this.txtStaleChqsReversed.TabIndex = 5;
            // 
            // txtInterestReceived
            // 
            this.txtInterestReceived.Location = new System.Drawing.Point(171, 46);
            this.txtInterestReceived.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterestReceived.Name = "txtInterestReceived";
            this.txtInterestReceived.Size = new System.Drawing.Size(135, 20);
            this.txtInterestReceived.TabIndex = 4;
            // 
            // txtCreditTransfer
            // 
            this.txtCreditTransfer.Location = new System.Drawing.Point(171, 20);
            this.txtCreditTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditTransfer.Name = "txtCreditTransfer";
            this.txtCreditTransfer.Size = new System.Drawing.Size(135, 20);
            this.txtCreditTransfer.TabIndex = 3;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 150);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(167, 13);
            this.Label7.TabIndex = 1;
            this.Label7.Text = "Outstanding Stale Chqs/Revenue";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 125);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(74, 13);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "Debit Transfer";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 99);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(74, 13);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Bank Charges";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 74);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(107, 13);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Stale Chqs Reversed";
            // 
            // cboAccount
            // 
            this.cboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccount.FormattingEnabled = true;
            this.cboAccount.Location = new System.Drawing.Point(74, 19);
            this.cboAccount.Margin = new System.Windows.Forms.Padding(2);
            this.cboAccount.Name = "cboAccount";
            this.cboAccount.Size = new System.Drawing.Size(616, 21);
            this.cboAccount.TabIndex = 5;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtOutstandingStaleChqs);
            this.GroupBox1.Controls.Add(this.txtDebitTransfer);
            this.GroupBox1.Controls.Add(this.txtBankCharges);
            this.GroupBox1.Controls.Add(this.txtStaleChqsReversed);
            this.GroupBox1.Controls.Add(this.txtInterestReceived);
            this.GroupBox1.Controls.Add(this.txtCreditTransfer);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(12, 111);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(310, 182);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Cash Book Details";
            // 
            // FrmBankReconcilation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 312);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.cboAccount);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBankReconcilation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Book - Bank Reconcilation";
            this.Load += new System.EventHandler(this.FrmBankReconcilation_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal crsButton.cButton btnClose;
        internal crsButton.cButton btnSave;
        internal crsButton.cButton btnNew;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtItemsInCashBookNotBank;
        internal System.Windows.Forms.TextBox txtUncreditedLodgement;
        internal System.Windows.Forms.TextBox txtItemsInBankNotCashBook;
        internal System.Windows.Forms.TextBox txtUnpresentedChqs;
        internal System.Windows.Forms.ComboBox cboYears;
        internal System.Windows.Forms.ComboBox cboMonths;
        internal crsButton.cButton btnUndo;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtOutstandingStaleChqs;
        internal System.Windows.Forms.TextBox txtDebitTransfer;
        internal System.Windows.Forms.TextBox txtBankCharges;
        internal System.Windows.Forms.TextBox txtStaleChqsReversed;
        internal System.Windows.Forms.TextBox txtInterestReceived;
        internal System.Windows.Forms.TextBox txtCreditTransfer;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cboAccount;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}