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
using CashBook.Services.Debtor;
using CashBook.Services.Reports.DebtorLedgers;
using CashBook.Services.Utility;
using CashBook.UI.Utilities;
using CashBook.UI.DebtorLedger;
using CashBook.Services.Account;

namespace CashBook.UI.Reports
{
    public partial class FrmGenerateDebtorLedgerReport : Form
    {
        private readonly IUtilityService _utilityService;
        private readonly IDebtorService _debtorService;
        private readonly IDebtorLedgerReportService _debtorLedgerReportService;
        private readonly IAccountService _accountService;
        public FrmGenerateDebtorLedgerReport(IUtilityService utilityService,IDebtorService debtorService, IDebtorLedgerReportService debtorLedgerReportService, IAccountService accountService)
        {
            _utilityService = utilityService;
            _accountService = accountService;
            _debtorService = debtorService;
            _debtorLedgerReportService = debtorLedgerReportService;
            InitializeComponent();
        }

        private void FrmGenerateDebtorLedgerReport_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            LoadRetireAndAdvanced();
            LoadMonthAndYears();
        }
        private void LoadAccounts()
        {
            var accounts = _accountService.GetAllAccounts();
            cboAccounts.DataSource = accounts;
            cboAccounts.DisplayMember = "AccountName";
            cboAccounts.ValueMember = "AccountId";
        }
        private void LoadRetireAndAdvanced()
        {
            var tblAdvancedRetired = _utilityService.GetAdavnceOrRetire();
            cboAdvancedRetired.DisplayMember = "name";
            cboAdvancedRetired.ValueMember = "value";
            cboAdvancedRetired.DataSource = tblAdvancedRetired;
        }
        private void LoadMonthAndYears()
        {
            var tblYears = _utilityService.GetYears();

            cboFilterYears.DataSource = tblYears;
            cboFilterYears.DisplayMember = "name";
            cboFilterYears.ValueMember = "value";
        }

        private void chkAdvancedAndRetired_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdvancedAndRetired.Checked == true)
                cboAdvancedRetired.Enabled = false;
            else
                cboAdvancedRetired.Enabled = true;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            
            string debtorId = Program.debtorId;

            int year = (int)cboFilterYears.SelectedValue;

            string accountId = (string)cboAccounts.SelectedValue;
            string advancedRetired = (string)cboAdvancedRetired.SelectedValue;

            string basePath = Application.StartupPath + @"\\debtorLeders.rdl";
            var path = Path.GetFullPath(basePath.Replace(@"\\", @"\"));

            DataTable tblDebtorLedgerReport = null;

            if (string.IsNullOrWhiteSpace(debtorId) == true)
            {
                MessageBox.Show("You must select a debtor",Software.GetApplicationName());
                return;
            }

            if (chkAllAccounts.Checked == false && chkAdvancedAndRetired.Checked == false)
            {
                tblDebtorLedgerReport = _debtorLedgerReportService.GetSingleAccountAndAdvanceOrRetire(debtorId, accountId, advancedRetired, year);
            }
            else if (chkAllAccounts.Checked == false && chkAdvancedAndRetired.Checked == true)
            {
                tblDebtorLedgerReport = _debtorLedgerReportService.GetSingleAccountAndAllAdvanceRetireDebtorLedgerReports(debtorId, accountId, year);
            }
            else if (chkAllAccounts.Checked == true && chkAdvancedAndRetired.Checked == false)
            {
                if (advancedRetired == "ADVANCE")
                {
                    tblDebtorLedgerReport = _debtorLedgerReportService.GetAllAdvancedDebtorLedgerReports(debtorId, year);
                }
                else
                {
                    tblDebtorLedgerReport = _debtorLedgerReportService.GetAllRetiredDebtorLedgerReports(debtorId, year);
                }
            }
            else if (chkAllAccounts.Checked == true && chkAdvancedAndRetired.Checked == true)
            {
                tblDebtorLedgerReport = _debtorLedgerReportService.GetAllDebtorLedgerReports(debtorId, year);
            }

            var frmViewer = new FrmReportViewer();
            frmViewer.rdlViewer.SourceFile = path;
            frmViewer.rdlViewer.Report.DataSets["Data"].SetData(tblDebtorLedgerReport);
            frmViewer.rdlViewer.Parameters = _debtorLedgerReportService.GenerateReportParameters(Program.userId,debtorId,year);
            frmViewer.rdlViewer.Rebuild();
            frmViewer.ShowDialog();
        }

        private void btnSearchDebtor_Click(object sender, EventArgs e)
        {
            var frmSearchDebtor = Program.container.GetInstance<FrmSearchDebtor>();
            frmSearchDebtor.ShowDialog();

            if (string.IsNullOrWhiteSpace(Program.debtorId) == true)
                return;

            var debtor = _debtorService.GetDebtorByDebtorId(Program.debtorId);

            if (debtor == null)
            {
                MessageBox.Show("Invalid Debtor", Software.GetApplicationName());
                return;
            }

            lblDebtor.Text = $"{debtor.FullName} - {debtor.DebtorLedgerNumber}";
        }

        private void chkAllAccounts_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllAccounts.Checked == false)
                cboAccounts.Enabled = true;
            else
                cboAccounts.Enabled = false;
        }
    }
}
