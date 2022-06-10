namespace CashBook.UI.DebtorLedger
{
    partial class FrmDebtorLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDebtorLedger));
            this.label9 = new System.Windows.Forms.Label();
            this.txtJVPVNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmmount = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearchFilterDebtor = new System.Windows.Forms.Button();
            this.lblFilterRecord = new System.Windows.Forms.Label();
            this.btnLoadAllData = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new crsButton.cButton();
            this.btnCancel = new crsButton.cButton();
            this.lblSelectedRecord = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchDebtor = new System.Windows.Forms.Button();
            this.lblDebtor = new System.Windows.Forms.Label();
            this.btnClose = new crsButton.cButton();
            this.btnSave = new crsButton.cButton();
            this.btnUndo = new crsButton.cButton();
            this.btnNew = new crsButton.cButton();
            this.cboAdvanceRetire = new System.Windows.Forms.ComboBox();
            this.dtpDateOfAdvanceRetire = new System.Windows.Forms.DateTimePicker();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.cboAccounts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(396, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(370, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "ADVANCE / RETIRE DEBT";
            // 
            // txtJVPVNumber
            // 
            this.txtJVPVNumber.Location = new System.Drawing.Point(149, 138);
            this.txtJVPVNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtJVPVNumber.Name = "txtJVPVNumber";
            this.txtJVPVNumber.Size = new System.Drawing.Size(190, 20);
            this.txtJVPVNumber.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "JV Number / PV Number";
            // 
            // txtAmmount
            // 
            this.txtAmmount.Location = new System.Drawing.Point(149, 162);
            this.txtAmmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmmount.Name = "txtAmmount";
            this.txtAmmount.Size = new System.Drawing.Size(190, 20);
            this.txtAmmount.TabIndex = 4;
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
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(14, 188);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(60, 13);
            this.Label6.TabIndex = 41;
            this.Label6.Text = "Description";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.grid);
            this.groupBox2.Location = new System.Drawing.Point(395, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 515);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Debtor Ledger";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearchFilterDebtor);
            this.groupBox4.Controls.Add(this.lblFilterRecord);
            this.groupBox4.Controls.Add(this.btnLoadAllData);
            this.groupBox4.Controls.Add(this.btnFilter);
            this.groupBox4.Location = new System.Drawing.Point(5, 452);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(766, 58);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // btnSearchFilterDebtor
            // 
            this.btnSearchFilterDebtor.Location = new System.Drawing.Point(357, 22);
            this.btnSearchFilterDebtor.Name = "btnSearchFilterDebtor";
            this.btnSearchFilterDebtor.Size = new System.Drawing.Size(27, 23);
            this.btnSearchFilterDebtor.TabIndex = 63;
            this.btnSearchFilterDebtor.Text = "...";
            this.btnSearchFilterDebtor.UseVisualStyleBackColor = true;
            this.btnSearchFilterDebtor.Click += new System.EventHandler(this.btnSearchFilterDebtor_Click);
            // 
            // lblFilterRecord
            // 
            this.lblFilterRecord.BackColor = System.Drawing.Color.White;
            this.lblFilterRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilterRecord.Location = new System.Drawing.Point(10, 22);
            this.lblFilterRecord.Name = "lblFilterRecord";
            this.lblFilterRecord.Size = new System.Drawing.Size(341, 23);
            this.lblFilterRecord.TabIndex = 62;
            this.lblFilterRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLoadAllData
            // 
            this.btnLoadAllData.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadAllData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadAllData.Location = new System.Drawing.Point(616, 17);
            this.btnLoadAllData.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadAllData.Name = "btnLoadAllData";
            this.btnLoadAllData.Size = new System.Drawing.Size(138, 32);
            this.btnLoadAllData.TabIndex = 17;
            this.btnLoadAllData.Text = "&Load All Data";
            this.btnLoadAllData.UseVisualStyleBackColor = false;
            this.btnLoadAllData.Click += new System.EventHandler(this.btnLoadAllData_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(468, 17);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(144, 32);
            this.btnFilter.TabIndex = 16;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.btnRemove.TabIndex = 13;
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
            this.btnCancel.TabIndex = 12;
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
            this.lblSelectedRecord.Size = new System.Drawing.Size(424, 67);
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
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(149, 185);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(190, 116);
            this.txtDescription.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(11, 164);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(51, 13);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "Ammount";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(11, 120);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 13);
            this.Label3.TabIndex = 38;
            this.Label3.Text = "Advance / Retire";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 92);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 13);
            this.Label2.TabIndex = 45;
            this.Label2.Text = "Date of Issue/Receipt";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 26);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "Debtor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboAccounts);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSearchDebtor);
            this.groupBox1.Controls.Add(this.lblDebtor);
            this.groupBox1.Controls.Add(this.txtJVPVNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUndo);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.cboAdvanceRetire);
            this.groupBox1.Controls.Add(this.dtpDateOfAdvanceRetire);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtAmmount);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 426);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Debtor Ledger";
            // 
            // btnSearchDebtor
            // 
            this.btnSearchDebtor.Location = new System.Drawing.Point(344, 26);
            this.btnSearchDebtor.Name = "btnSearchDebtor";
            this.btnSearchDebtor.Size = new System.Drawing.Size(27, 23);
            this.btnSearchDebtor.TabIndex = 61;
            this.btnSearchDebtor.Text = "...";
            this.btnSearchDebtor.UseVisualStyleBackColor = true;
            this.btnSearchDebtor.Click += new System.EventHandler(this.btnSearchDebtor_Click);
            // 
            // lblDebtor
            // 
            this.lblDebtor.BackColor = System.Drawing.Color.White;
            this.lblDebtor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDebtor.Location = new System.Drawing.Point(149, 26);
            this.lblDebtor.Name = "lblDebtor";
            this.lblDebtor.Size = new System.Drawing.Size(190, 23);
            this.lblDebtor.TabIndex = 60;
            this.lblDebtor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnClose.Location = new System.Drawing.Point(230, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 45);
            this.btnClose.TabIndex = 10;
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
            this.btnSave.Location = new System.Drawing.Point(139, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 45);
            this.btnSave.TabIndex = 9;
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
            this.btnUndo.Location = new System.Drawing.Point(257, 307);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(85, 45);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
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
            this.btnNew.Location = new System.Drawing.Point(139, 307);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 45);
            this.btnNew.TabIndex = 7;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cboAdvanceRetire
            // 
            this.cboAdvanceRetire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdvanceRetire.FormattingEnabled = true;
            this.cboAdvanceRetire.Location = new System.Drawing.Point(149, 113);
            this.cboAdvanceRetire.Margin = new System.Windows.Forms.Padding(2);
            this.cboAdvanceRetire.Name = "cboAdvanceRetire";
            this.cboAdvanceRetire.Size = new System.Drawing.Size(190, 21);
            this.cboAdvanceRetire.TabIndex = 2;
            // 
            // dtpDateOfAdvanceRetire
            // 
            this.dtpDateOfAdvanceRetire.CustomFormat = "dd/M/yyyy";
            this.dtpDateOfAdvanceRetire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfAdvanceRetire.Location = new System.Drawing.Point(149, 88);
            this.dtpDateOfAdvanceRetire.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateOfAdvanceRetire.Name = "dtpDateOfAdvanceRetire";
            this.dtpDateOfAdvanceRetire.Size = new System.Drawing.Size(190, 20);
            this.dtpDateOfAdvanceRetire.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.pnlContainer.Controls.Add(this.label9);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1183, 55);
            this.pnlContainer.TabIndex = 44;
            // 
            // cboAccounts
            // 
            this.cboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccounts.FormattingEnabled = true;
            this.cboAccounts.Location = new System.Drawing.Point(149, 60);
            this.cboAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Size = new System.Drawing.Size(190, 21);
            this.cboAccounts.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Accounts";
            // 
            // FrmDebtorLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1183, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDebtorLedger";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Debtor Ledger";
            this.Load += new System.EventHandler(this.FrmDebtorLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtJVPVNumber;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtAmmount;
        internal System.Windows.Forms.DataGridView grid;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button btnLoadAllData;
        internal System.Windows.Forms.Button btnFilter;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal crsButton.cButton btnRemove;
        internal crsButton.cButton btnCancel;
        internal System.Windows.Forms.Label lblSelectedRecord;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal crsButton.cButton btnClose;
        internal crsButton.cButton btnSave;
        internal crsButton.cButton btnUndo;
        internal crsButton.cButton btnNew;
        internal System.Windows.Forms.ComboBox cboAdvanceRetire;
        internal System.Windows.Forms.DateTimePicker dtpDateOfAdvanceRetire;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnSearchDebtor;
        private System.Windows.Forms.Label lblDebtor;
        private System.Windows.Forms.Button btnSearchFilterDebtor;
        private System.Windows.Forms.Label lblFilterRecord;
        internal System.Windows.Forms.ComboBox cboAccounts;
        internal System.Windows.Forms.Label label5;
    }
}