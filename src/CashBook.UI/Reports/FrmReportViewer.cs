using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MessageBox.Show("PDF Report was generated successfully", Application.ProductName);
            }
        }
    }
}
