namespace CashBook.UI.StockLedger
{
    partial class FrmBinCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBinCard));
            this.btnCancel = new crsButton.cButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new crsButton.cButton();
            this.lblSelectedRecord = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new crsButton.cButton();
            this.btnAddBinCardItem = new crsButton.cButton();
            this.btnSave = new crsButton.cButton();
            this.btnUndo = new crsButton.cButton();
            this.btnNew = new crsButton.cButton();
            this.cboIssueReceipt = new System.Windows.Forms.ComboBox();
            this.dtpDateOfIssueReceipt = new System.Windows.Forms.DateTimePicker();
            this.cboFilterYears = new System.Windows.Forms.ComboBox();
            this.btnLoadAllData = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSivSrvOtherInvoices = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnSearchBinCardItem = new System.Windows.Forms.Button();
            this.lblBinCardItem = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFilterBinCardItem = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ButtonType = crsButton.cButton.btnType.close2;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(230, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 45);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddBinCardItem
            // 
            this.btnAddBinCardItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBinCardItem.ButtonType = crsButton.cButton.btnType.add_combo;
            this.btnAddBinCardItem.FlatAppearance.BorderSize = 0;
            this.btnAddBinCardItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddBinCardItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddBinCardItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBinCardItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBinCardItem.Image")));
            this.btnAddBinCardItem.Location = new System.Drawing.Point(344, 22);
            this.btnAddBinCardItem.Name = "btnAddBinCardItem";
            this.btnAddBinCardItem.Size = new System.Drawing.Size(26, 24);
            this.btnAddBinCardItem.TabIndex = 56;
            this.btnAddBinCardItem.UseVisualStyleBackColor = false;
            this.btnAddBinCardItem.Click += new System.EventHandler(this.btnAddBinCardItem_Click);
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
            this.btnSave.Location = new System.Drawing.Point(139, 321);
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
            this.btnUndo.Location = new System.Drawing.Point(257, 270);
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
            this.btnNew.Location = new System.Drawing.Point(139, 270);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 45);
            this.btnNew.TabIndex = 7;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cboIssueReceipt
            // 
            this.cboIssueReceipt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIssueReceipt.FormattingEnabled = true;
            this.cboIssueReceipt.Location = new System.Drawing.Point(149, 76);
            this.cboIssueReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.cboIssueReceipt.Name = "cboIssueReceipt";
            this.cboIssueReceipt.Size = new System.Drawing.Size(190, 21);
            this.cboIssueReceipt.TabIndex = 2;
            // 
            // dtpDateOfIssueReceipt
            // 
            this.dtpDateOfIssueReceipt.CustomFormat = "dd/M/yyyy";
            this.dtpDateOfIssueReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfIssueReceipt.Location = new System.Drawing.Point(149, 51);
            this.dtpDateOfIssueReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateOfIssueReceipt.Name = "dtpDateOfIssueReceipt";
            this.dtpDateOfIssueReceipt.Size = new System.Drawing.Size(190, 20);
            this.dtpDateOfIssueReceipt.TabIndex = 1;
            // 
            // cboFilterYears
            // 
            this.cboFilterYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterYears.FormattingEnabled = true;
            this.cboFilterYears.Location = new System.Drawing.Point(426, 22);
            this.cboFilterYears.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterYears.Name = "cboFilterYears";
            this.cboFilterYears.Size = new System.Drawing.Size(137, 21);
            this.cboFilterYears.TabIndex = 15;
            // 
            // btnLoadAllData
            // 
            this.btnLoadAllData.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadAllData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadAllData.Location = new System.Drawing.Point(671, 15);
            this.btnLoadAllData.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadAllData.Name = "btnLoadAllData";
            this.btnLoadAllData.Size = new System.Drawing.Size(91, 32);
            this.btnLoadAllData.TabIndex = 17;
            this.btnLoadAllData.Text = "&Load All Data";
            this.btnLoadAllData.UseVisualStyleBackColor = false;
            this.btnLoadAllData.Click += new System.EventHandler(this.btnLoadAllData_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(149, 176);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(190, 85);
            this.txtDescription.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(149, 150);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(190, 20);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(149, 125);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(190, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(567, 15);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 32);
            this.btnFilter.TabIndex = 16;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.Label6.Location = new System.Drawing.Point(11, 178);
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
            this.groupBox2.Location = new System.Drawing.Point(395, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 515);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Bin Cards";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblFilterBinCardItem);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.btnLoadAllData);
            this.groupBox4.Controls.Add(this.btnFilter);
            this.groupBox4.Controls.Add(this.cboFilterYears);
            this.groupBox4.Location = new System.Drawing.Point(5, 452);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(766, 58);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(11, 153);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(53, 13);
            this.Label5.TabIndex = 40;
            this.Label5.Text = "Unit Price";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(11, 127);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(46, 13);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "Quantity";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(11, 83);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(74, 13);
            this.Label3.TabIndex = 38;
            this.Label3.Text = "Issue/Receipt";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 55);
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
            this.Label1.Size = new System.Drawing.Size(70, 13);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "Bin Card Item";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBinCardItem);
            this.groupBox1.Controls.Add(this.btnSearchBinCardItem);
            this.groupBox1.Controls.Add(this.txtSivSrvOtherInvoices);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnAddBinCardItem);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUndo);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.cboIssueReceipt);
            this.groupBox1.Controls.Add(this.dtpDateOfIssueReceipt);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Bin Card";
            // 
            // txtSivSrvOtherInvoices
            // 
            this.txtSivSrvOtherInvoices.Location = new System.Drawing.Point(149, 101);
            this.txtSivSrvOtherInvoices.Margin = new System.Windows.Forms.Padding(2);
            this.txtSivSrvOtherInvoices.Name = "txtSivSrvOtherInvoices";
            this.txtSivSrvOtherInvoices.Size = new System.Drawing.Size(190, 20);
            this.txtSivSrvOtherInvoices.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Siv Srv and  Other Invoices";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(396, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(419, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "ISSUE / RECEIVE BIN CARDS";
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
            // btnSearchBinCardItem
            // 
            this.btnSearchBinCardItem.Location = new System.Drawing.Point(315, 26);
            this.btnSearchBinCardItem.Name = "btnSearchBinCardItem";
            this.btnSearchBinCardItem.Size = new System.Drawing.Size(27, 20);
            this.btnSearchBinCardItem.TabIndex = 60;
            this.btnSearchBinCardItem.Text = "...";
            this.btnSearchBinCardItem.UseVisualStyleBackColor = true;
            this.btnSearchBinCardItem.Click += new System.EventHandler(this.btnSearchBinCardItem_Click);
            // 
            // lblBinCardItem
            // 
            this.lblBinCardItem.BackColor = System.Drawing.Color.White;
            this.lblBinCardItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBinCardItem.Location = new System.Drawing.Point(149, 26);
            this.lblBinCardItem.Name = "lblBinCardItem";
            this.lblBinCardItem.Size = new System.Drawing.Size(163, 23);
            this.lblBinCardItem.TabIndex = 61;
            this.lblBinCardItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(394, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 20);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFilterBinCardItem
            // 
            this.lblFilterBinCardItem.BackColor = System.Drawing.Color.White;
            this.lblFilterBinCardItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilterBinCardItem.Location = new System.Drawing.Point(10, 20);
            this.lblFilterBinCardItem.Name = "lblFilterBinCardItem";
            this.lblFilterBinCardItem.Size = new System.Drawing.Size(378, 23);
            this.lblFilterBinCardItem.TabIndex = 64;
            this.lblFilterBinCardItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmBinCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1183, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBinCard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Bin Card";
            this.Load += new System.EventHandler(this.FrmBinCard_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal crsButton.cButton btnCancel;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal crsButton.cButton btnRemove;
        internal System.Windows.Forms.Label lblSelectedRecord;
        internal System.Windows.Forms.Label label10;
        internal crsButton.cButton btnClose;
        internal crsButton.cButton btnAddBinCardItem;
        internal crsButton.cButton btnSave;
        internal crsButton.cButton btnUndo;
        internal crsButton.cButton btnNew;
        internal System.Windows.Forms.ComboBox cboIssueReceipt;
        internal System.Windows.Forms.DateTimePicker dtpDateOfIssueReceipt;
        internal System.Windows.Forms.ComboBox cboFilterYears;
        internal System.Windows.Forms.Button btnLoadAllData;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.TextBox txtUnitPrice;
        internal System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.Button btnFilter;
        internal System.Windows.Forms.DataGridView grid;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlContainer;
        internal System.Windows.Forms.TextBox txtSivSrvOtherInvoices;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBinCardItem;
        private System.Windows.Forms.Button btnSearchBinCardItem;
        private System.Windows.Forms.Label lblFilterBinCardItem;
        private System.Windows.Forms.Button btnSearch;
    }
}