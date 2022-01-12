namespace CashBook.UI.MaintainBalance
{
    partial class FrmMaintainBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaintainBalance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecalculateMaintainBalance = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHasBeenEdited = new System.Windows.Forms.Label();
            this.btnRemove = new crsButton.cButton();
            this.btnClose = new crsButton.cButton();
            this.btnCancel = new crsButton.cButton();
            this.cboAccount = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblClosingBalance = new System.Windows.Forms.Label();
            this.lblOpeningBalance = new System.Windows.Forms.Label();
            this.lblCurrentMonth = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnCloseTransaction = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 55);
            this.panel1.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(262, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Close Financial Month";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecalculateMaintainBalance);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblHasBeenEdited);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.cboAccount);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblClosingBalance);
            this.groupBox1.Controls.Add(this.lblOpeningBalance);
            this.groupBox1.Controls.Add(this.lblCurrentMonth);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.btnCloseTransaction);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 362);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Close a financial month";
            // 
            // btnRecalculateMaintainBalance
            // 
            this.btnRecalculateMaintainBalance.BackColor = System.Drawing.SystemColors.Control;
            this.btnRecalculateMaintainBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecalculateMaintainBalance.Location = new System.Drawing.Point(236, 197);
            this.btnRecalculateMaintainBalance.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecalculateMaintainBalance.Name = "btnRecalculateMaintainBalance";
            this.btnRecalculateMaintainBalance.Size = new System.Drawing.Size(135, 46);
            this.btnRecalculateMaintainBalance.TabIndex = 82;
            this.btnRecalculateMaintainBalance.Text = "Recalculate Maintain &Balance";
            this.btnRecalculateMaintainBalance.UseVisualStyleBackColor = false;
            this.btnRecalculateMaintainBalance.Click += new System.EventHandler(this.btnRecalculateMaintainBalance_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Has Been Edited";
            // 
            // lblHasBeenEdited
            // 
            this.lblHasBeenEdited.BackColor = System.Drawing.Color.White;
            this.lblHasBeenEdited.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHasBeenEdited.Location = new System.Drawing.Point(115, 124);
            this.lblHasBeenEdited.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasBeenEdited.Name = "lblHasBeenEdited";
            this.lblHasBeenEdited.Size = new System.Drawing.Size(257, 22);
            this.lblHasBeenEdited.TabIndex = 81;
            this.lblHasBeenEdited.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnRemove.Location = new System.Drawing.Point(125, 301);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 45);
            this.btnRemove.TabIndex = 79;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnClose.Location = new System.Drawing.Point(266, 301);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 45);
            this.btnClose.TabIndex = 78;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(21, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 45);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboAccount
            // 
            this.cboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccount.FormattingEnabled = true;
            this.cboAccount.Location = new System.Drawing.Point(115, 19);
            this.cboAccount.Name = "cboAccount";
            this.cboAccount.Size = new System.Drawing.Size(256, 21);
            this.cboAccount.TabIndex = 76;
            this.cboAccount.SelectedIndexChanged += new System.EventHandler(this.cboAccount_SelectedIndexChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(4, 150);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(37, 13);
            this.Label5.TabIndex = 67;
            this.Label5.Text = "Status";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(4, 99);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(83, 13);
            this.Label4.TabIndex = 68;
            this.Label4.Text = "Closing Balance";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(4, 73);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 13);
            this.Label3.TabIndex = 69;
            this.Label3.Text = "Opening Balance";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(115, 150);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(257, 22);
            this.lblStatus.TabIndex = 70;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClosingBalance
            // 
            this.lblClosingBalance.BackColor = System.Drawing.Color.White;
            this.lblClosingBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClosingBalance.Location = new System.Drawing.Point(115, 99);
            this.lblClosingBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClosingBalance.Name = "lblClosingBalance";
            this.lblClosingBalance.Size = new System.Drawing.Size(257, 22);
            this.lblClosingBalance.TabIndex = 71;
            this.lblClosingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOpeningBalance
            // 
            this.lblOpeningBalance.BackColor = System.Drawing.Color.White;
            this.lblOpeningBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOpeningBalance.Location = new System.Drawing.Point(115, 73);
            this.lblOpeningBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpeningBalance.Name = "lblOpeningBalance";
            this.lblOpeningBalance.Size = new System.Drawing.Size(257, 22);
            this.lblOpeningBalance.TabIndex = 72;
            this.lblOpeningBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentMonth
            // 
            this.lblCurrentMonth.BackColor = System.Drawing.Color.White;
            this.lblCurrentMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentMonth.Location = new System.Drawing.Point(115, 48);
            this.lblCurrentMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentMonth.Name = "lblCurrentMonth";
            this.lblCurrentMonth.Size = new System.Drawing.Size(257, 22);
            this.lblCurrentMonth.TabIndex = 73;
            this.lblCurrentMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(4, 18);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 74;
            this.Label2.Text = "Account";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(4, 48);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 13);
            this.Label1.TabIndex = 75;
            this.Label1.Text = "Month";
            // 
            // btnCloseTransaction
            // 
            this.btnCloseTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTransaction.Location = new System.Drawing.Point(115, 197);
            this.btnCloseTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseTransaction.Name = "btnCloseTransaction";
            this.btnCloseTransaction.Size = new System.Drawing.Size(117, 46);
            this.btnCloseTransaction.TabIndex = 66;
            this.btnCloseTransaction.Text = "Close &Transaction";
            this.btnCloseTransaction.UseVisualStyleBackColor = false;
            this.btnCloseTransaction.Click += new System.EventHandler(this.btnCloseTransaction_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid);
            this.groupBox2.Location = new System.Drawing.Point(405, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 362);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Closed Financial Month";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(5, 18);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(409, 339);
            this.grid.TabIndex = 4;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // FrmMaintainBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(836, 445);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaintainBalance";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Close Monthly Transaction";
            this.Load += new System.EventHandler(this.FrmMaintainBalance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal crsButton.cButton btnRemove;
        internal crsButton.cButton btnClose;
        internal crsButton.cButton btnCancel;
        private System.Windows.Forms.ComboBox cboAccount;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.Label lblClosingBalance;
        internal System.Windows.Forms.Label lblOpeningBalance;
        internal System.Windows.Forms.Label lblCurrentMonth;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnCloseTransaction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView grid;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label lblHasBeenEdited;
        internal System.Windows.Forms.Button btnRecalculateMaintainBalance;
    }
}