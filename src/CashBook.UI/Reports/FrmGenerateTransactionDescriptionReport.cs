using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.Services.Reports.TransactionDescriptions;

namespace CashBook.UI.Reports
{
    public partial class FrmGenerateTransactionDescriptionReport : Form
    {
        private readonly ITransactionDescriptionReportService _transactionDescriptionReportService;

        public FrmGenerateTransactionDescriptionReport(ITransactionDescriptionReportService transactionDescriptionReportService)
        {
            _transactionDescriptionReportService = transactionDescriptionReportService;
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

            DataTable tblReport = null;

            //Check the approriate transaction type and then display the report
            if (rbIncomeTransactionTypeOnly.Checked == true)
            {
                tblReport = _transactionDescriptionReportService.GetAllIncomeItems();    
            }
            else if (rbExpenseTransactionTypeOnly.Checked == true)
            {
                tblReport = _transactionDescriptionReportService.GetAllExpenseItems();
            }
            else
            {
                tblReport = _transactionDescriptionReportService.GetAllItems();
            }

            string basePath = Application.StartupPath + @"\\TransactionDescriptionItems.rdl";
            var path = Path.GetFullPath(basePath.Replace(@"\\", @"\"));

            //Get the Parameters value and the display the report
            var frmViewer = new FrmReportViewer();
            frmViewer.rdlViewer.SourceFile = path;
            frmViewer.rdlViewer.Report.DataSets["Data"].SetData(tblReport);
            frmViewer.rdlViewer.Parameters = _transactionDescriptionReportService.GenerateReportParameters(Program.userId);
            frmViewer.rdlViewer.Rebuild();
            frmViewer.ShowDialog();

        }
    }
}
