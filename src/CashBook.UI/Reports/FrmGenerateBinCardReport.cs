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
using CashBook.Services.BinCardItem;
using CashBook.Services.Reports.BinCards;
using CashBook.Services.Utility;
using CashBook.UI.StockLedger;

namespace CashBook.UI.Reports
{
    public partial class FrmGenerateBinCardReport : Form
    {
        private readonly IBinCardItemService _binCardItemService;
        private readonly IUtilityService _utilityService;
        private readonly IBinCardReportService _binCardReportService;
        public FrmGenerateBinCardReport(IBinCardItemService binCardItemService, IUtilityService utilityService, IBinCardReportService binCardReportService)
        {
            _binCardItemService = binCardItemService;
            _utilityService = utilityService;
            _binCardReportService = binCardReportService;
            InitializeComponent();
        }

        private void FrmGenerateBinCardReport_Load(object sender, EventArgs e)
        {
            LoadIssueReceiptComboBox();
            LoadMonthAndYears();
        }
        private void LoadMonthAndYears()
        {
            var tblYears = _utilityService.GetYears();

            cboFilterYears.DataSource = tblYears;
            cboFilterYears.DisplayMember = "name";
            cboFilterYears.ValueMember = "value";
        }
        private void LoadIssueReceiptComboBox()
        {
            var tblIssueOrReceipt = _utilityService.GetIssueOrReceipt();

            cboIssueReceipt.DataSource = tblIssueOrReceipt;
            cboIssueReceipt.ValueMember = "value";
            cboIssueReceipt.DisplayMember = "name";
        }

        private void cboFilterYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void chkIssuesReceipt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIssuesReceipt.Checked == false)
                cboIssueReceipt.Enabled = true;
            else
                cboIssueReceipt.Enabled = false;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string binCardItemId = Program.binCardItemId;

            int year = (int)cboFilterYears.SelectedValue;

            string issueOrReceipt = (string)cboIssueReceipt.SelectedValue;

            string basePath = Application.StartupPath + @"\\binCards.rdl";
            var path = Path.GetFullPath(basePath.Replace(@"\\", @"\"));

            DataTable tblBinCardReports = null;

            if(chkIssuesReceipt.Checked == true)
            {
                tblBinCardReports = _binCardReportService.GetAllBinCardsReports(binCardItemId,year);
            }
            else if (chkIssuesReceipt.Checked == false && issueOrReceipt == "ISSUE")
            {
                tblBinCardReports = _binCardReportService.GetAllIssuedBinCardsReports(binCardItemId, year);
            }
            else
            {
                tblBinCardReports = _binCardReportService.GetAllReceivedBinCardsReports(binCardItemId, year);
            }
            var frmViewer = new FrmReportViewer();
            frmViewer.rdlViewer.SourceFile = path;
            frmViewer.rdlViewer.Report.DataSets["Data"].SetData(tblBinCardReports);
            frmViewer.rdlViewer.Parameters = _binCardReportService.GenerateReportParameters(binCardItemId, year, Program.userId);
            frmViewer.rdlViewer.Rebuild();
            frmViewer.ShowDialog();
        }

        private void btnSearchBinCardItem_Click(object sender, EventArgs e)
        {
            var frmSearchStockBinCard = Program.container.GetInstance<FrmSearchStockBinCardItem>();
            frmSearchStockBinCard.ShowDialog();

            if (string.IsNullOrWhiteSpace(Program.binCardItemId) == true)
                return;

            var binCardItem = _binCardItemService.GetBinCardItemByBinCardItemId(Program.binCardItemId);

            lblBinCardItem.Text = $"{binCardItem.BinCardItemName}";
        }
    }
}
