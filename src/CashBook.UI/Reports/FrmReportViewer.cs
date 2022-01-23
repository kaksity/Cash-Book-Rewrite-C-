using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.UI.Utilities;
using fyiReporting.RdlViewer;

namespace CashBook.UI.Reports
{
    public partial class FrmReportViewer : Form
    {
        public FrmReportViewer()
        {
            InitializeComponent();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF|*.pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                rdlViewer.SaveAs(saveDialog.FileName, "pdf");
                MessageBox.Show("PDF Report was generated successfully", Software.GetApplicationName());
            }
        }

        private DataTable ZoomTable()
        {
            var table = new DataTable();
            
            // 20% 40% 80% 100% Fit-Page Fit-Width

            table.Columns.Add("name", typeof(string));
            table.Columns.Add("value", typeof(float));

            table.Rows.Add("20% Zoom", 0.20);
            table.Rows.Add("40% Zoom", 0.40);
            table.Rows.Add("60% Zoom", 0.60 );
            table.Rows.Add("80% Zoom", 0.80);
            table.Rows.Add("100% Zoom", 1.0);

            table.Rows.Add("Fit-Page", 2.0);
            table.Rows.Add("Fit-Width", 3.0);
            return table;
        }

        private void LoadZoomInfo()
        {
            cboZoom.DataSource = ZoomTable();
            cboZoom.DisplayMember = "name";
            cboZoom.ValueMember = "value";
        }

        private void FrmReportViewer_Load(object sender, EventArgs e)
        {
            LoadZoomInfo();
        }

        private void cboZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                float zoomValue = (float)cboZoom.SelectedValue;

                if (zoomValue <= 1.0)
                {
                    rdlViewer.Zoom = zoomValue;
                }
                else
                {
                    if (zoomValue == 2)
                    {
                        rdlViewer.ZoomMode = ZoomEnum.FitPage;
                    }else if (zoomValue == 3)
                    {
                        rdlViewer.ZoomMode = ZoomEnum.FitWidth;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
