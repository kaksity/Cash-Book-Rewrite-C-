namespace CashBook.UI.Reports
{
    partial class FrmReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportViewer));
            this.rdlViewer = new fyiReporting.RdlViewer.RdlViewer();
            this.btnPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdlViewer
            // 
            this.rdlViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rdlViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdlViewer.Folder = null;
            this.rdlViewer.HighlightAll = false;
            this.rdlViewer.HighlightAllColor = System.Drawing.Color.Fuchsia;
            this.rdlViewer.HighlightCaseSensitive = false;
            this.rdlViewer.HighlightItemColor = System.Drawing.Color.Aqua;
            this.rdlViewer.HighlightPageItem = null;
            this.rdlViewer.HighlightText = null;
            this.rdlViewer.Location = new System.Drawing.Point(12, 2);
            this.rdlViewer.Name = "rdlViewer";
            this.rdlViewer.PageCurrent = 1;
            this.rdlViewer.Parameters = null;
            this.rdlViewer.ReportName = null;
            this.rdlViewer.ScrollMode = fyiReporting.RdlViewer.ScrollModeEnum.Continuous;
            this.rdlViewer.ShowFindPanel = false;
            this.rdlViewer.ShowParameterPanel = false;
            this.rdlViewer.Size = new System.Drawing.Size(722, 522);
            this.rdlViewer.SourceFile = null;
            this.rdlViewer.SourceRdl = null;
            this.rdlViewer.TabIndex = 1;
            this.rdlViewer.UseTrueMargins = true;
            this.rdlViewer.Zoom = 0.8367286F;
            this.rdlViewer.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.Control;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Location = new System.Drawing.Point(12, 530);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(170, 39);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // FrmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(746, 581);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.rdlViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportViewer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Accounts - Report Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        public fyiReporting.RdlViewer.RdlViewer rdlViewer;
        private System.Windows.Forms.Button btnPDF;
    }
}