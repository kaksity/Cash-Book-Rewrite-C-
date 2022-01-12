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
using CashBook.Services.Reports.Accounts;

namespace CashBook.UI.Reports
{
    public partial class FrmReportMenu : Form
    {
        private readonly IAccountReportService _accountReportService;

        public FrmReportMenu(IAccountReportService accountReportService)
        {
            _accountReportService = accountReportService;
            InitializeComponent();
        }

        private void btnTransactionReport_Click(object sender, EventArgs e)
        {
            var frmGenerateTransactionReport = Program.container.GetInstance<FrmGenerateTransactionReport>();
            frmGenerateTransactionReport.ShowDialog();
        }

        private void BankReconcilationReport_Click(object sender, EventArgs e)
        {
            var frmGenerateBankReconcilationReport = Program.container.GetInstance<FrmGenerateBankReconcilationReport>();
            frmGenerateBankReconcilationReport.ShowDialog();
        }

        private void btnTransactionDescriptionItemReport_Click(object sender, EventArgs e)
        {
            var frmGenerateTransactionDescriptionItem = Program.container.GetInstance<FrmGenerateTransactionDescriptionReport>();
            frmGenerateTransactionDescriptionItem.ShowDialog();
        }

        private void btnAccountsReport_Click(object sender, EventArgs e)
        {
            string basePath = Application.StartupPath + @"\\accounts.rdl";
            var path = Path.GetFullPath(basePath.Replace(@"\\", @"\"));

            //Get the Parameters value and the display the report
            var tblAccounts = _accountReportService.GetAllAccounts();
            var frmViewer = new FrmReportViewer();
            frmViewer.rdlViewer.SourceFile = path;
            frmViewer.rdlViewer.Report.DataSets["Data"].SetData(tblAccounts);
            frmViewer.rdlViewer.Parameters = _accountReportService.GenerateReportParameters(Program.userId);
            frmViewer.rdlViewer.Rebuild();
            frmViewer.ShowDialog();
        }
    }
}
