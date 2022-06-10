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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClose = new crsButton.cButton();
            this.btnSave = new crsButton.cButton();
            this.btnNew = new crsButton.cButton();
            this.btnUndo = new crsButton.cButton();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.cboMonths = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtItemsInCashBookNotBank = new System.Windows.Forms.TextBox();
            this.txtUncreditedLodgement = new System.Windows.Forms.TextBox();
            this.txtItemsInBankNotCashBook = new System.Windows.Forms.TextBox();
            this.txtUnpresentedChqs = new System.Windows.Forms.TextBox();
            this.cboAccounts = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboViewBankReconcilationAccounts = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new crsButton.cButton();
            this.lblSelectedRecord = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 55);
            this.panel1.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(403, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(339, 31);
            this.label12.TabIndex = 0;
            this.label12.Text = "BANK RECONCILATION";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnNew);
            this.groupBox4.Controls.Add(this.btnUndo);
            this.groupBox4.Controls.Add(this.GroupBox2);
            this.groupBox4.Controls.Add(this.Label1);
            this.groupBox4.Controls.Add(this.GroupBox3);
            this.groupBox4.Controls.Add(this.cboAccounts);
            this.groupBox4.Controls.Add(this.GroupBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(601, 369);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Create Bank Reconcilation";
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
            this.btnClose.Location = new System.Drawing.Point(292, 309);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 45);
            this.btnClose.TabIndex = 17;
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
            this.btnSave.Location = new System.Drawing.Point(201, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 45);
            this.btnSave.TabIndex = 18;
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
            this.btnNew.Location = new System.Drawing.Point(10, 309);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 45);
            this.btnNew.TabIndex = 19;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnUndo.Location = new System.Drawing.Point(101, 309);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(85, 45);
            this.btnUndo.TabIndex = 20;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.cboYears);
            this.GroupBox2.Controls.Add(this.cboMonths);
            this.GroupBox2.Location = new System.Drawing.Point(5, 57);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox2.Size = new System.Drawing.Size(584, 60);
            this.GroupBox2.TabIndex = 12;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Duration";
            // 
            // cboYears
            // 
            this.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(295, 20);
            this.cboYears.Margin = new System.Windows.Forms.Padding(2);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(278, 21);
            this.cboYears.TabIndex = 2;
            // 
            // cboMonths
            // 
            this.cboMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonths.FormattingEnabled = true;
            this.cboMonths.Location = new System.Drawing.Point(9, 20);
            this.cboMonths.Margin = new System.Windows.Forms.Padding(2);
            this.cboMonths.Name = "cboMonths";
            this.cboMonths.Size = new System.Drawing.Size(282, 21);
            this.cboMonths.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 35);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Account";
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
            this.GroupBox3.Location = new System.Drawing.Point(300, 122);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox3.Size = new System.Drawing.Size(289, 125);
            this.GroupBox3.TabIndex = 13;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Bank Details";
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
            this.txtItemsInCashBookNotBank.Location = new System.Drawing.Point(156, 94);
            this.txtItemsInCashBookNotBank.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemsInCashBookNotBank.Name = "txtItemsInCashBookNotBank";
            this.txtItemsInCashBookNotBank.Size = new System.Drawing.Size(122, 20);
            this.txtItemsInCashBookNotBank.TabIndex = 12;
            // 
            // txtUncreditedLodgement
            // 
            this.txtUncreditedLodgement.Location = new System.Drawing.Point(156, 69);
            this.txtUncreditedLodgement.Margin = new System.Windows.Forms.Padding(2);
            this.txtUncreditedLodgement.Name = "txtUncreditedLodgement";
            this.txtUncreditedLodgement.Size = new System.Drawing.Size(122, 20);
            this.txtUncreditedLodgement.TabIndex = 11;
            // 
            // txtItemsInBankNotCashBook
            // 
            this.txtItemsInBankNotCashBook.Location = new System.Drawing.Point(156, 43);
            this.txtItemsInBankNotCashBook.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemsInBankNotCashBook.Name = "txtItemsInBankNotCashBook";
            this.txtItemsInBankNotCashBook.Size = new System.Drawing.Size(122, 20);
            this.txtItemsInBankNotCashBook.TabIndex = 10;
            // 
            // txtUnpresentedChqs
            // 
            this.txtUnpresentedChqs.Location = new System.Drawing.Point(156, 18);
            this.txtUnpresentedChqs.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnpresentedChqs.Name = "txtUnpresentedChqs";
            this.txtUnpresentedChqs.Size = new System.Drawing.Size(122, 20);
            this.txtUnpresentedChqs.TabIndex = 9;
            // 
            // cboAccounts
            // 
            this.cboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccounts.FormattingEnabled = true;
            this.cboAccounts.Location = new System.Drawing.Point(71, 32);
            this.cboAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Size = new System.Drawing.Size(518, 21);
            this.cboAccounts.TabIndex = 14;
            this.cboAccounts.SelectedIndexChanged += new System.EventHandler(this.cboAccounts_SelectedIndexChanged);
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
            this.GroupBox1.Location = new System.Drawing.Point(5, 122);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(291, 182);
            this.GroupBox1.TabIndex = 15;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Cash Book Details";
            // 
            // txtOutstandingStaleChqs
            // 
            this.txtOutstandingStaleChqs.Location = new System.Drawing.Point(177, 147);
            this.txtOutstandingStaleChqs.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutstandingStaleChqs.Name = "txtOutstandingStaleChqs";
            this.txtOutstandingStaleChqs.Size = new System.Drawing.Size(102, 20);
            this.txtOutstandingStaleChqs.TabIndex = 8;
            // 
            // txtDebitTransfer
            // 
            this.txtDebitTransfer.Location = new System.Drawing.Point(177, 121);
            this.txtDebitTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.txtDebitTransfer.Name = "txtDebitTransfer";
            this.txtDebitTransfer.Size = new System.Drawing.Size(102, 20);
            this.txtDebitTransfer.TabIndex = 7;
            // 
            // txtBankCharges
            // 
            this.txtBankCharges.Location = new System.Drawing.Point(177, 96);
            this.txtBankCharges.Margin = new System.Windows.Forms.Padding(2);
            this.txtBankCharges.Name = "txtBankCharges";
            this.txtBankCharges.Size = new System.Drawing.Size(102, 20);
            this.txtBankCharges.TabIndex = 6;
            // 
            // txtStaleChqsReversed
            // 
            this.txtStaleChqsReversed.Location = new System.Drawing.Point(177, 70);
            this.txtStaleChqsReversed.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaleChqsReversed.Name = "txtStaleChqsReversed";
            this.txtStaleChqsReversed.Size = new System.Drawing.Size(102, 20);
            this.txtStaleChqsReversed.TabIndex = 5;
            // 
            // txtInterestReceived
            // 
            this.txtInterestReceived.Location = new System.Drawing.Point(177, 45);
            this.txtInterestReceived.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterestReceived.Name = "txtInterestReceived";
            this.txtInterestReceived.Size = new System.Drawing.Size(102, 20);
            this.txtInterestReceived.TabIndex = 4;
            // 
            // txtCreditTransfer
            // 
            this.txtCreditTransfer.Location = new System.Drawing.Point(177, 19);
            this.txtCreditTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditTransfer.Name = "txtCreditTransfer";
            this.txtCreditTransfer.Size = new System.Drawing.Size(102, 20);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboViewBankReconcilationAccounts);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.btnReset);
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Controls.Add(this.lblSelectedRecord);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.grid);
            this.groupBox5.Location = new System.Drawing.Point(619, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(480, 406);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "View Bank Reconcilation";
            // 
            // cboViewBankReconcilationAccounts
            // 
            this.cboViewBankReconcilationAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViewBankReconcilationAccounts.FormattingEnabled = true;
            this.cboViewBankReconcilationAccounts.Location = new System.Drawing.Point(113, 276);
            this.cboViewBankReconcilationAccounts.Name = "cboViewBankReconcilationAccounts";
            this.cboViewBankReconcilationAccounts.Size = new System.Drawing.Size(361, 21);
            this.cboViewBankReconcilationAccounts.TabIndex = 26;
            this.cboViewBankReconcilationAccounts.SelectedIndexChanged += new System.EventHandler(this.cboViewBankReconcilationAccounts_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 279);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Account";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(269, 365);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 36);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ButtonType = crsButton.cButton.btnType.remove;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(113, 365);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 36);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSelectedRecord
            // 
            this.lblSelectedRecord.BackColor = System.Drawing.Color.White;
            this.lblSelectedRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectedRecord.Location = new System.Drawing.Point(113, 300);
            this.lblSelectedRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedRecord.Name = "lblSelectedRecord";
            this.lblSelectedRecord.Size = new System.Drawing.Size(362, 63);
            this.lblSelectedRecord.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 309);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Selected Record";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(5, 18);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(470, 245);
            this.grid.TabIndex = 19;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // FrmBankReconcilation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1111, 493);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBankReconcilation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Bank Reconcilation";
            this.Load += new System.EventHandler(this.FrmBankReconcilation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        internal crsButton.cButton btnClose;
        internal crsButton.cButton btnSave;
        internal crsButton.cButton btnNew;
        internal crsButton.cButton btnUndo;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ComboBox cboYears;
        internal System.Windows.Forms.ComboBox cboMonths;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtItemsInCashBookNotBank;
        internal System.Windows.Forms.TextBox txtUncreditedLodgement;
        internal System.Windows.Forms.TextBox txtItemsInBankNotCashBook;
        internal System.Windows.Forms.TextBox txtUnpresentedChqs;
        internal System.Windows.Forms.ComboBox cboAccounts;
        internal System.Windows.Forms.GroupBox GroupBox1;
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
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cboViewBankReconcilationAccounts;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Button btnReset;
        internal crsButton.cButton btnDelete;
        internal System.Windows.Forms.Label lblSelectedRecord;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.DataGridView grid;
    }
}