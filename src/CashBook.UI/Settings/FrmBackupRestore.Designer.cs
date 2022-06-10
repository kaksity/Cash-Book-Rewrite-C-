namespace CashBook.UI.Settings
{
    partial class FrmBackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackupRestore));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBackup = new System.Windows.Forms.RadioButton();
            this.chkRestore = new System.Windows.Forms.RadioButton();
            this.btnStartProcessing = new crsButton.cButton();
            this.btnCancel = new crsButton.cButton();
            this.btnShowDialogBox = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // lblPath
            // 
            this.lblPath.BackColor = System.Drawing.Color.White;
            this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPath.Location = new System.Drawing.Point(65, 66);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(255, 23);
            this.lblPath.TabIndex = 0;
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 55);
            this.panel1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "BACKUP AND RESTORE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRestore);
            this.groupBox1.Controls.Add(this.chkBackup);
            this.groupBox1.Location = new System.Drawing.Point(65, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 69);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup / Restore";
            // 
            // chkBackup
            // 
            this.chkBackup.AutoSize = true;
            this.chkBackup.Location = new System.Drawing.Point(6, 29);
            this.chkBackup.Name = "chkBackup";
            this.chkBackup.Size = new System.Drawing.Size(62, 17);
            this.chkBackup.TabIndex = 1;
            this.chkBackup.TabStop = true;
            this.chkBackup.Text = "Backup";
            this.chkBackup.UseVisualStyleBackColor = true;
            // 
            // chkRestore
            // 
            this.chkRestore.AutoSize = true;
            this.chkRestore.Location = new System.Drawing.Point(173, 29);
            this.chkRestore.Name = "chkRestore";
            this.chkRestore.Size = new System.Drawing.Size(62, 17);
            this.chkRestore.TabIndex = 2;
            this.chkRestore.TabStop = true;
            this.chkRestore.Text = "Restore";
            this.chkRestore.UseVisualStyleBackColor = true;
            // 
            // btnStartProcessing
            // 
            this.btnStartProcessing.BackColor = System.Drawing.Color.Transparent;
            this.btnStartProcessing.ButtonType = crsButton.cButton.btnType.startprocessing;
            this.btnStartProcessing.FlatAppearance.BorderSize = 0;
            this.btnStartProcessing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStartProcessing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStartProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartProcessing.Image = ((System.Drawing.Image)(resources.GetObject("btnStartProcessing.Image")));
            this.btnStartProcessing.Location = new System.Drawing.Point(65, 211);
            this.btnStartProcessing.Name = "btnStartProcessing";
            this.btnStartProcessing.Size = new System.Drawing.Size(168, 60);
            this.btnStartProcessing.TabIndex = 3;
            this.btnStartProcessing.UseVisualStyleBackColor = false;
            this.btnStartProcessing.Click += new System.EventHandler(this.btnStartProcessing_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(249, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 45);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnShowDialogBox
            // 
            this.btnShowDialogBox.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowDialogBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDialogBox.Location = new System.Drawing.Point(326, 66);
            this.btnShowDialogBox.Name = "btnShowDialogBox";
            this.btnShowDialogBox.Size = new System.Drawing.Size(34, 23);
            this.btnShowDialogBox.TabIndex = 0;
            this.btnShowDialogBox.Text = "...";
            this.btnShowDialogBox.UseVisualStyleBackColor = false;
            this.btnShowDialogBox.Click += new System.EventHandler(this.btnShowDialogBox_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(65, 99);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(255, 23);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Status";
            // 
            // FrmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(374, 295);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnShowDialogBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStartProcessing);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackupRestore";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts  - Backup And Restore";
            this.Load += new System.EventHandler(this.FrmBackupRestore_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chkRestore;
        private System.Windows.Forms.RadioButton chkBackup;
        internal crsButton.cButton btnStartProcessing;
        internal crsButton.cButton btnCancel;
        private System.Windows.Forms.Button btnShowDialogBox;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
    }
}