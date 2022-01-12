namespace CashBook.UI.Utilities
{
    partial class FrmAcquirePhoto
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
            this.grpFlip = new System.Windows.Forms.GroupBox();
            this.btnHorizontal = new System.Windows.Forms.Button();
            this.btnVertical = new System.Windows.Forms.Button();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.Slider = new System.Windows.Forms.TrackBar();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.chkFile = new System.Windows.Forms.CheckBox();
            this.chkDialog = new System.Windows.Forms.CheckBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAcquire = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnClearPreview = new System.Windows.Forms.Button();
            this.grpFlip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFlip
            // 
            this.grpFlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFlip.Controls.Add(this.btnHorizontal);
            this.grpFlip.Controls.Add(this.btnVertical);
            this.grpFlip.Location = new System.Drawing.Point(639, 141);
            this.grpFlip.Name = "grpFlip";
            this.grpFlip.Size = new System.Drawing.Size(140, 68);
            this.grpFlip.TabIndex = 21;
            this.grpFlip.TabStop = false;
            this.grpFlip.Text = "Flip Image";
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHorizontal.BackColor = System.Drawing.Color.White;
            this.btnHorizontal.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnHorizontal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorizontal.Location = new System.Drawing.Point(14, 22);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(43, 32);
            this.btnHorizontal.TabIndex = 13;
            this.btnHorizontal.Text = "H";
            this.btnHorizontal.UseVisualStyleBackColor = false;
            this.btnHorizontal.Click += new System.EventHandler(this.btnHorizontal_Click);
            // 
            // btnVertical
            // 
            this.btnVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVertical.BackColor = System.Drawing.Color.White;
            this.btnVertical.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnVertical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVertical.Location = new System.Drawing.Point(87, 22);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(43, 32);
            this.btnVertical.TabIndex = 12;
            this.btnVertical.Text = "V";
            this.btnVertical.UseVisualStyleBackColor = false;
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // picPreview
            // 
            this.picPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(639, 215);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(140, 140);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 20;
            this.picPreview.TabStop = false;
            // 
            // Slider
            // 
            this.Slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Slider.LargeChange = 1;
            this.Slider.Location = new System.Drawing.Point(4, 448);
            this.Slider.Maximum = 100;
            this.Slider.Minimum = 1;
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(611, 45);
            this.Slider.TabIndex = 19;
            this.Slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Slider.Value = 100;
            this.Slider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.BackColor = System.Drawing.Color.White;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(640, 446);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(139, 32);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.BackColor = System.Drawing.Color.White;
            this.OK.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(640, 408);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(140, 32);
            this.OK.TabIndex = 17;
            this.OK.Text = "&OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // chkFile
            // 
            this.chkFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFile.AutoSize = true;
            this.chkFile.Checked = true;
            this.chkFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFile.Location = new System.Drawing.Point(642, 2);
            this.chkFile.Name = "chkFile";
            this.chkFile.Size = new System.Drawing.Size(95, 17);
            this.chkFile.TabIndex = 15;
            this.chkFile.Text = "Load From File";
            this.chkFile.UseVisualStyleBackColor = true;
            this.chkFile.CheckedChanged += new System.EventHandler(this.chkFile_CheckedChanged);
            // 
            // chkDialog
            // 
            this.chkDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDialog.AutoSize = true;
            this.chkDialog.Location = new System.Drawing.Point(642, 25);
            this.chkDialog.Name = "chkDialog";
            this.chkDialog.Size = new System.Drawing.Size(138, 17);
            this.chkDialog.TabIndex = 16;
            this.chkDialog.Text = "Show Scanner Window";
            this.chkDialog.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(639, 92);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(140, 32);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "&Select Source";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // btnAcquire
            // 
            this.btnAcquire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcquire.BackColor = System.Drawing.Color.White;
            this.btnAcquire.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAcquire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcquire.Location = new System.Drawing.Point(639, 54);
            this.btnAcquire.Name = "btnAcquire";
            this.btnAcquire.Size = new System.Drawing.Size(140, 32);
            this.btnAcquire.TabIndex = 14;
            this.btnAcquire.Text = "&Acquire";
            this.btnAcquire.UseVisualStyleBackColor = false;
            this.btnAcquire.Click += new System.EventHandler(this.btnAcquire_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPhoto.BackColor = System.Drawing.Color.White;
            this.picPhoto.Location = new System.Drawing.Point(4, 1);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(630, 439);
            this.picPhoto.TabIndex = 12;
            this.picPhoto.TabStop = false;
            this.picPhoto.Click += new System.EventHandler(this.picPhoto_Click);
            this.picPhoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPhoto_MouseMove);
            // 
            // btnClearPreview
            // 
            this.btnClearPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearPreview.BackColor = System.Drawing.Color.White;
            this.btnClearPreview.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnClearPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPreview.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPreview.Location = new System.Drawing.Point(640, 361);
            this.btnClearPreview.Name = "btnClearPreview";
            this.btnClearPreview.Size = new System.Drawing.Size(140, 23);
            this.btnClearPreview.TabIndex = 22;
            this.btnClearPreview.Text = "Clear &Preview";
            this.btnClearPreview.UseVisualStyleBackColor = false;
            this.btnClearPreview.Click += new System.EventHandler(this.btnClearPreview_Click);
            // 
            // FrmAcquirePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 495);
            this.Controls.Add(this.grpFlip);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.Slider);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.chkFile);
            this.Controls.Add(this.chkDialog);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnAcquire);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.btnClearPreview);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAcquirePhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Acquire Photo";
            this.Load += new System.EventHandler(this.FrmAcquirePhoto_Load);
            this.grpFlip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpFlip;
        internal System.Windows.Forms.Button btnHorizontal;
        internal System.Windows.Forms.Button btnVertical;
        internal System.Windows.Forms.PictureBox picPreview;
        internal System.Windows.Forms.TrackBar Slider;
        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button OK;
        internal System.Windows.Forms.CheckBox chkFile;
        internal System.Windows.Forms.CheckBox chkDialog;
        internal System.Windows.Forms.Button btnSelect;
        internal System.Windows.Forms.Button btnAcquire;
        internal System.Windows.Forms.PictureBox picPhoto;
        internal System.Windows.Forms.Button btnClearPreview;
    }
}