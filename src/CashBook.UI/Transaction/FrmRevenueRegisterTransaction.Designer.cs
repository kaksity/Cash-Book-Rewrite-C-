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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new crsButton.cButton();
            this.btnAddDescription = new crsButton.cButton();
            this.btnNew = new crsButton.cButton();
            this.btnSave = new crsButton.cButton();
            this.btnUndo = new crsButton.cButton();
            this.btnAddAccount = new crsButton.cButton();
            this.cboDescriptions = new System.Windows.Forms.ComboBox();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.txtRVNumber = new System.Windows.Forms.TextBox();
            this.txtSubhead = new System.Windows.Forms.TextBox();
            this.txtReceipts = new System.Windows.Forms.TextBox();
            this.txtNameOfPayee = new System.Windows.Forms.TextBox();
            this.dtpDateOfTransaction = new System.Windows.Forms.DateTimePicker();
            this.cboAccounts = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLoadAllData = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboFilterYears = new System.Windows.Forms.ComboBox();
            this.cboFilterMonths = new System.Windows.Forms.ComboBox();
            this.cboFilterAccounts = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new crsButton.cButton();
            this.btnCancel = new crsButton.cButton();
            this.lblSelectedRecord = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnAddDescription);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUndo);
            this.groupBox1.Controls.Add(this.btnAddAccount);
            this.groupBox1.Controls.Add(this.cboDescriptions);
            this.groupBox1.Controls.Add(this.txtDebit);
            this.groupBox1.Controls.Add(this.txtRVNumber);
            this.groupBox1.Controls.Add(this.txtSubhead);
            this.groupBox1.Controls.Add(this.txtReceipts);
            this.groupBox1.Controls.Add(this.txtNameOfPayee);
            this.groupBox1.Controls.Add(this.dtpDateOfTransaction);
            this.groupBox1.Controls.Add(this.cboAccounts);
            this.groupBox1.Controls.Add(this.Label8);
            this.groupBox1.Controls.Add(this.Label7);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 356);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Revenue Register Transaction";
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
            this.btnClose.Location = new System.Drawing.Point(214, 305);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 45);
            this.btnClose.TabIndex = 59;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnAddDescription.Location = new System.Drawing.Point(346, 156);
            this.btnAddDescription.Name = "btnAddDescription";
            this.btnAddDescription.Size = new System.Drawing.Size(25, 28);
            this.btnAddDescription.TabIndex = 58;
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
            this.btnNew.Location = new System.Drawing.Point(123, 256);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 45);
            this.btnNew.TabIndex = 57;
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
            this.btnSave.Location = new System.Drawing.Point(119, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 45);
            this.btnSave.TabIndex = 56;
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
            this.btnUndo.Location = new System.Drawing.Point(214, 256);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(85, 45);
            this.btnUndo.TabIndex = 55;
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
            this.btnAddAccount.Location = new System.Drawing.Point(346, 24);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(25, 28);
            this.btnAddAccount.TabIndex = 54;
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // cboDescriptions
            // 
            this.cboDescriptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDescriptions.FormattingEnabled = true;
            this.cboDescriptions.Location = new System.Drawing.Point(119, 161);
            this.cboDescriptions.Margin = new System.Windows.Forms.Padding(2);
            this.cboDescriptions.Name = "cboDescriptions";
            this.cboDescriptions.Size = new System.Drawing.Size(221, 21);
            this.cboDescriptions.TabIndex = 53;
            // 
            // txtDebit
            // 
            this.txtDebit.Location = new System.Drawing.Point(119, 187);
            this.txtDebit.Margin = new System.Windows.Forms.Padding(2);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(221, 20);
            this.txtDebit.TabIndex = 51;
            // 
            // txtRVNumber
            // 
            this.txtRVNumber.Location = new System.Drawing.Point(119, 84);
            this.txtRVNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtRVNumber.Name = "txtRVNumber";
            this.txtRVNumber.Size = new System.Drawing.Size(221, 20);
            this.txtRVNumber.TabIndex = 48;
            // 
            // txtSubhead
            // 
            this.txtSubhead.Location = new System.Drawing.Point(119, 135);
            this.txtSubhead.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubhead.Name = "txtSubhead";
            this.txtSubhead.Size = new System.Drawing.Size(221, 20);
            this.txtSubhead.TabIndex = 50;
            // 
            // txtReceipts
            // 
            this.txtReceipts.Location = new System.Drawing.Point(119, 109);
            this.txtReceipts.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceipts.Name = "txtReceipts";
            this.txtReceipts.Size = new System.Drawing.Size(221, 20);
            this.txtReceipts.TabIndex = 49;
            // 
            // txtNameOfPayee
            // 
            this.txtNameOfPayee.Location = new System.Drawing.Point(119, 213);
            this.txtNameOfPayee.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameOfPayee.Name = "txtNameOfPayee";
            this.txtNameOfPayee.Size = new System.Drawing.Size(221, 20);
            this.txtNameOfPayee.TabIndex = 52;
            // 
            // dtpDateOfTransaction
            // 
            this.dtpDateOfTransaction.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOfTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfTransaction.Location = new System.Drawing.Point(119, 58);
            this.dtpDateOfTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateOfTransaction.Name = "dtpDateOfTransaction";
            this.dtpDateOfTransaction.Size = new System.Drawing.Size(221, 20);
            this.dtpDateOfTransaction.TabIndex = 47;
            // 
            // cboAccounts
            // 
            this.cboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccounts.FormattingEnabled = true;
            this.cboAccounts.Location = new System.Drawing.Point(119, 30);
            this.cboAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Size = new System.Drawing.Size(221, 21);
            this.cboAccounts.TabIndex = 45;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(13, 213);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(80, 13);
            this.Label8.TabIndex = 44;
            this.Label8.Text = "Name of Payee";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(13, 187);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(32, 13);
            this.Label7.TabIndex = 43;
            this.Label7.Text = "Debit";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(13, 161);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(60, 13);
            this.Label6.TabIndex = 42;
            this.Label6.Text = "Description";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(13, 135);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(50, 13);
            this.Label5.TabIndex = 41;
            this.Label5.Text = "Subhead";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(13, 110);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(49, 13);
            this.Label4.TabIndex = 40;
            this.Label4.Text = "Receipts";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(13, 84);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(62, 13);
            this.Label3.TabIndex = 39;
            this.Label3.Text = "RV Number";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 60);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(101, 13);
            this.Label2.TabIndex = 46;
            this.Label2.Text = "Date of Transaction";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 30);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "Account";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.pnlContainer.Controls.Add(this.label9);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1183, 55);
            this.pnlContainer.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(329, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(525, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "REVENUE REGISTER TRANSACTION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.grid);
            this.groupBox2.Location = new System.Drawing.Point(395, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 515);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Revenue Register Transaction";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLoadAllData);
            this.groupBox4.Controls.Add(this.btnFilter);
            this.groupBox4.Controls.Add(this.cboFilterYears);
            this.groupBox4.Controls.Add(this.cboFilterMonths);
            this.groupBox4.Controls.Add(this.cboFilterAccounts);
            this.groupBox4.Location = new System.Drawing.Point(5, 452);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(766, 58);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // btnLoadAllData
            // 
            this.btnLoadAllData.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadAllData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadAllData.Location = new System.Drawing.Point(670, 17);
            this.btnLoadAllData.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadAllData.Name = "btnLoadAllData";
            this.btnLoadAllData.Size = new System.Drawing.Size(91, 32);
            this.btnLoadAllData.TabIndex = 2;
            this.btnLoadAllData.Text = "&Load All Data";
            this.btnLoadAllData.UseVisualStyleBackColor = false;
            this.btnLoadAllData.Click += new System.EventHandler(this.btnLoadAllData_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(566, 17);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 32);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cboFilterYears
            // 
            this.cboFilterYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterYears.FormattingEnabled = true;
            this.cboFilterYears.Location = new System.Drawing.Point(452, 24);
            this.cboFilterYears.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterYears.Name = "cboFilterYears";
            this.cboFilterYears.Size = new System.Drawing.Size(110, 21);
            this.cboFilterYears.TabIndex = 0;
            // 
            // cboFilterMonths
            // 
            this.cboFilterMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterMonths.FormattingEnabled = true;
            this.cboFilterMonths.Location = new System.Drawing.Point(311, 24);
            this.cboFilterMonths.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterMonths.Name = "cboFilterMonths";
            this.cboFilterMonths.Size = new System.Drawing.Size(137, 21);
            this.cboFilterMonths.TabIndex = 0;
            // 
            // cboFilterAccounts
            // 
            this.cboFilterAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterAccounts.FormattingEnabled = true;
            this.cboFilterAccounts.Location = new System.Drawing.Point(4, 24);
            this.cboFilterAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterAccounts.Name = "cboFilterAccounts";
            this.cboFilterAccounts.Size = new System.Drawing.Size(303, 21);
            this.cboFilterAccounts.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.lblSelectedRecord);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(5, 360);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(766, 88);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operations";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.ButtonType = crsButton.cButton.btnType.remove;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(650, 20);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 48);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(559, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 48);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSelectedRecord
            // 
            this.lblSelectedRecord.BackColor = System.Drawing.Color.White;
            this.lblSelectedRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectedRecord.Location = new System.Drawing.Point(115, 16);
            this.lblSelectedRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedRecord.Name = "lblSelectedRecord";
            this.lblSelectedRecord.Size = new System.Drawing.Size(439, 67);
            this.lblSelectedRecord.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Selected Record";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(5, 18);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(766, 338);
            this.grid.TabIndex = 5;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // FrmRevenueRegisterTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1183, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRevenueRegisterTransaction";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Revenue Register";
            this.Load += new System.EventHandler(this.FrmRevenueRegisterTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal crsButton.cButton btnAddDescription;
        internal crsButton.cButton btnNew;
        internal crsButton.cButton btnUndo;
        internal crsButton.cButton btnAddAccount;
        internal System.Windows.Forms.ComboBox cboDescriptions;
        internal System.Windows.Forms.TextBox txtDebit;
        internal System.Windows.Forms.TextBox txtRVNumber;
        internal System.Windows.Forms.TextBox txtSubhead;
        internal System.Windows.Forms.TextBox txtReceipts;
        internal System.Windows.Forms.TextBox txtNameOfPayee;
        internal System.Windows.Forms.DateTimePicker dtpDateOfTransaction;
        internal System.Windows.Forms.ComboBox cboAccounts;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal crsButton.cButton btnClose;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button btnLoadAllData;
        internal System.Windows.Forms.Button btnFilter;
        internal System.Windows.Forms.ComboBox cboFilterYears;
        internal System.Windows.Forms.ComboBox cboFilterMonths;
        internal System.Windows.Forms.ComboBox cboFilterAccounts;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal crsButton.cButton btnRemove;
        internal crsButton.cButton btnCancel;
        internal System.Windows.Forms.Label lblSelectedRecord;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.DataGridView grid;
        internal crsButton.cButton btnSave;
    }
}