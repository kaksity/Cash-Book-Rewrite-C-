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
            LoadBinCardItemsComboBox();
            LoadIssueReceiptComboBox();
            LoadMonthAndYears();
        }
        private void LoadMonthAndYears()
        {
            var tblMonths = _utilityService.GetMonths();
            var tblYears = _utilityService.GetYears();

            cboFilterMonths.DataSource = tblMonths;
            cboFilterMonths.DisplayMember = "name";
            cboFilterMonths.ValueMember = "value";

            cboFilterYears.DataSource = tblYears;
            cboFilterYears.DisplayMember = "name";
            cboFilterYears.ValueMember = "value";
                }
        private void LoadBinCardItemsComboBox()
        {
            var binCardItems = _binCardItemService.GetAllBinCardItem();

            cboFilterBinCardItems.DisplayMember = "BinCardItemName";
            cboFilterBinCardItems.ValueMember = "BinCardItemId";
            cboFilterBinCardItems.DataSource = binCardItems;

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
            string binCardItemId = (string)cboFilterBinCardItems.SelectedValue;

            int month = (int)cboFilterMonths.SelectedValue;
            int year = (int)cboFilterYears.SelectedValue;

            string issueOrReceipt = (string)cboIssueReceipt.SelectedValue;

            string basePath = Application.StartupPath + @"\\binCards.rdl";
            var path = Path.GetFullPath(basePath.Replace(@"\\", @"\"));

            DataTable tblBinCardReports = null;

            if(chkIssuesReceipt.Checked == true)
            {
                tblBinCardReports = _binCardReportService.GetAllBinCardsReports(binCardItemId,month,year);
            }
            else if (chkIssuesReceipt.Checked == false && issueOrReceipt == "ISSUE")
            {
                tblBinCardReports = _binCardReportService.GetAllIssuedBinCardsReports(binCardItemId, month, year);
            }
            else
            {
                tblBinCardReports = _binCardReportService.GetAllReceivedBinCardsReports(binCardItemId, month, year);
            }
            var frmViewer = new FrmReportViewer();
            frmViewer.rdlViewer.SourceFile = path;
            frmViewer.rdlViewer.Report.DataSets["Data"].SetData(tblBinCardReports);
            frmViewer.rdlViewer.Parameters = _binCardReportService.GenerateReportParameters(binCardItemId, month, year, Program.userId);
            frmViewer.rdlViewer.Rebuild();
            frmViewer.ShowDialog();
        }
    }
}
