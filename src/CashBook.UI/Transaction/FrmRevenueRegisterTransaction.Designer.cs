namespace CashBook.UI.Transaction
{
    partial class FrmRevenueRegisterTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRevenueRegisterTransaction));
            this.btnAddDescription = new crsButton.cButton();
            this.btnNew = new crsButton.cButton();
            this.btnSave = new crsButton.cButton();
            this.btnUndo = new crsButton.cButton();
            this.btnAddAccount = new crsButton.cButton();
            this.cboDescription = new System.Windows.Forms.ComboBox();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.txtRVNumber = new System.Windows.Forms.TextBox();
            this.txtSubhead = new System.Windows.Forms.TextBox();
            this.txtReceipts = new System.Windows.Forms.TextBox();
            this.txtNameOfPayee = new System.Windows.Forms.TextBox();
            this.dtpDateOfTransaction = new System.Windows.Forms.DateTimePicker();
            this.cboAccount = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddDescription
            // 
            this.btnAddDescription.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDescription.ButtonType = crsButton.cButton.btnType.add_combo;
            this.btnAddDescription.FlatAppearance.BorderSize = 0;
            this.btnAddDescription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddDescription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDescription.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDescription.Image")));
            this.btnAddDescription.Location = new System.Drawing.Point(426, 148);
            this.btnAddDescription.Name = "btnAddDescription";
            this.btnAddDescription.Size = new System.Drawing.Size(25, 28);
            this.btnAddDescription.TabIndex = 37;
            this.btnAddDescription.UseVisualStyleBackColor = false;
            this.btnAddDescription.Click += new System.EventHandler(this.btnAddDescription_Click);
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
            this.btnNew.Location = new System.Drawing.Point(135, 249);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 45);
            this.btnNew.TabIndex = 36;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnSave.Location = new System.Drawing.Point(336, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 45);
            this.btnSave.TabIndex = 35;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnUndo.Location = new System.Drawing.Point(226, 249);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(85, 45);
            this.btnUndo.TabIndex = 34;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAccount.ButtonType = crsButton.cButton.btnType.add_combo;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.Image")));
            this.btnAddAccount.Location = new System.Drawing.Point(426, 16);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(25, 28);
            this.btnAddAccount.TabIndex = 33;
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // cboDescription
            // 
            this.cboDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDescription.FormattingEnabled = true;
            this.cboDescription.Location = new System.Drawing.Point(134, 151);
            this.cboDescription.Margin = new System.Windows.Forms.Padding(2);
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.Size = new System.Drawing.Size(287, 21);
            this.cboDescription.TabIndex = 32;
            // 
            // txtDebit
            // 
            this.txtDebit.Location = new System.Drawing.Point(134, 177);
            this.txtDebit.Margin = new System.Windows.Forms.Padding(2);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(287, 20);
            this.txtDebit.TabIndex = 30;
            // 
            // txtRVNumber
            // 
            this.txtRVNumber.Location = new System.Drawing.Point(134, 74);
            this.txtRVNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtRVNumber.Name = "txtRVNumber";
            this.txtRVNumber.Size = new System.Drawing.Size(287, 20);
            this.txtRVNumber.TabIndex = 27;
            // 
            // txtSubhead
            // 
            this.txtSubhead.Location = new System.Drawing.Point(134, 125);
            this.txtSubhead.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubhead.Name = "txtSubhead";
            this.txtSubhead.Size = new System.Drawing.Size(287, 20);
            this.txtSubhead.TabIndex = 29;
            // 
            // txtReceipts
            // 
            this.txtReceipts.Location = new System.Drawing.Point(134, 99);
            this.txtReceipts.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceipts.Name = "txtReceipts";
            this.txtReceipts.Size = new System.Drawing.Size(287, 20);
            this.txtReceipts.TabIndex = 28;
            // 
            // txtNameOfPayee
            // 
            this.txtNameOfPayee.Location = new System.Drawing.Point(134, 203);
            this.txtNameOfPayee.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameOfPayee.Name = "txtNameOfPayee";
            this.txtNameOfPayee.Size = new System.Drawing.Size(287, 20);
            this.txtNameOfPayee.TabIndex = 31;
            // 
            // dtpDateOfTransaction
            // 
            this.dtpDateOfTransaction.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOfTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfTransaction.Location = new System.Drawing.Point(134, 48);
            this.dtpDateOfTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateOfTransaction.Name = "dtpDateOfTransaction";
            this.dtpDateOfTransaction.Size = new System.Drawing.Size(287, 20);
            this.dtpDateOfTransaction.TabIndex = 26;
            // 
            // cboAccount
            // 
            this.cboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccount.FormattingEnabled = true;
            this.cboAccount.Location = new System.Drawing.Point(134, 20);
            this.cboAccount.Margin = new System.Windows.Forms.Padding(2);
            this.cboAccount.Name = "cboAccount";
            this.cboAccount.Size = new System.Drawing.Size(287, 21);
            this.cboAccount.TabIndex = 24;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(12, 205);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(80, 13);
            this.Label8.TabIndex = 21;
            this.Label8.Text = "Name of Payee";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(12, 179);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(32, 13);
            this.Label7.TabIndex = 20;
            this.Label7.Text = "Debit";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(12, 153);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(60, 13);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "Description";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(12, 127);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(50, 13);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Subhead";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 102);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(49, 13);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Receipts";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 76);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(62, 13);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "RV Number";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 52);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(101, 13);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "Date of Transaction";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 22);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Account";
            // 
            // FrmRevenueRegisterTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 330);
            this.Controls.Add(this.btnAddDescription);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.cboDescription);
            this.Controls.Add(this.txtDebit);
            this.Controls.Add(this.txtRVNumber);
            this.Controls.Add(this.txtSubhead);
            this.Controls.Add(this.txtReceipts);
            this.Controls.Add(this.txtNameOfPayee);
            this.Controls.Add(this.dtpDateOfTransaction);
            this.Controls.Add(this.cboAccount);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRevenueRegisterTransaction";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Book - Revenue Register";
            this.Load += new System.EventHandler(this.FrmRevenueRegisterTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal crsButton.cButton btnAddDescription;
        internal crsButton.cButton btnNew;
        internal crsButton.cButton btnSave;
        internal crsButton.cButton btnUndo;
        internal crsButton.cButton btnAddAccount;
        internal System.Windows.Forms.ComboBox cboDescription;
        internal System.Windows.Forms.TextBox txtDebit;
        internal System.Windows.Forms.TextBox txtRVNumber;
        internal System.Windows.Forms.TextBox txtSubhead;
        internal System.Windows.Forms.TextBox txtReceipts;
        internal System.Windows.Forms.TextBox txtNameOfPayee;
        internal System.Windows.Forms.DateTimePicker dtpDateOfTransaction;
        internal System.Windows.Forms.ComboBox cboAccount;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}