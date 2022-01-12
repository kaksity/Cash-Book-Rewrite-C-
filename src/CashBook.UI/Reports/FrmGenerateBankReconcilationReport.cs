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
using CashBook.Dtos.BankReconcilation;
using CashBook.Services.Account;
using CashBook.Services.BankReconcilation;
using CashBook.Services.MaintainBalance;
using CashBook.Services.Reports.BankReconcilations;
using CashBook.UI.Utilities;

namespace CashBook.UI.Reports
{
    public partial class FrmGenerateBankReconcilationReport : Form
    {

        private readonly IAccountService _accountService;
        private readonly IBankReconcilationService _bankReconcilationService;
        private readonly IMaintainBalanceService _maintainBalanceService;
        private readonly IBankReconcilationReportService _bankReconcilationReportService;

        List<ReadBankReconcilationDto> listOfBankReconcilation = null;
        string bankReconcilationId = "";

        public FrmGenerateBankReconcilationReport(
            IAccountService accountService,
            IBankReconcilationService bankReconcilationService,
            IMaintainBalanceService maintainBalanceService,
            IBankReconcilationReportService bankReconcilationReportService
            )
        {
            _bankReconcilationService = bankReconcilationService;
            _maintainBalanceService = maintainBalanceService;
            _accountService = accountService;
            _bankReconcilationReportService = bankReconcilationReportService;
            InitializeComponent();
        }

        private void FrmGenerateBankReconcilationReport_Load(object sender, EventArgs e)
        {
            InitBankReconcilationGrid();
            LoadAccountComboBox();
            listOfBankReconcilation = _bankReconcilationService.GetBankReconcilationByAccountId((string)cboViewBankReconcilationAccounts.SelectedValue);
            LoadGridData(listOfBankReconcilation);
            Reset();
        }
        private void Reset()
        {
            lblSelectedRecord.Text = "";
            bankReconcilationId = "";
        }
        private void LoadAccountComboBox()
        {
            var accounts = _accountService.GetAllAccounts();
            cboViewBankReconcilationAccounts.DisplayMember = "AccountName";
            cboViewBankReconcilationAccounts.ValueMember = "AccountId";
            cboViewBankReconcilationAccounts.DataSource = accounts;
        }
        private void LoadGridData(List<ReadBankReconcilationDto> data)
        {
            grid.Rows.Clear();

            if (data.Count == 0) return;

            grid.Rows.Add(data.Count);

            for (int i = 0; i < data.Count; i++)
            {
                grid.Rows[i].Cells["colsSNum"].Value = i + 1;
                grid.Rows[i].Cells["colsDuration"].Value = data[i].Duration.Replace('.','/');
                grid.Rows[i].Cells["colsStatus"].Value = "GENERATED";
            }
        }
        private void InitBankReconcilationGrid()
        {
            grid.Columns.Clear();
            grid.Rows.Clear();
            grid.Columns.Add("colsSNum", "S/No");
            grid.Columns.Add("colsDuration", "Duration");
            grid.Columns.Add("colsStatus", "Status");

            grid.Columns["colsSNum"].Width = 70;
            grid.Columns["colsDuration"].Width = 250;
            grid.Columns["colsStatus"].Width = 250;

            grid.Columns["colsSNum"].ReadOnly = true;
            grid.Columns["colsDuration"].ReadOnly = true;
            grid.Columns["colsStatus"].ReadOnly = true;

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void cboViewBankReconcilationAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
            listOfBankReconcilation = _bankReconcilationService.GetBankReconcilationByAccountId((string)cboViewBankReconcilationAccounts.SelectedValue);
            LoadGridData(listOfBankReconcilation);
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            bankReconcilationId = listOfBankReconcilation[e.RowIndex].BankReconcilationId;
            lblSelectedRecord.Text = $"Selected Account { cboViewBankReconcilationAccounts.SelectedText } for the Month of { listOfBankReconcilation[e.RowIndex].Duration}";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string accountId = (string)cboViewBankReconcilationAccounts.SelectedValue;

            string basePath = Application.StartupPath + @"\\bankReconcilations.rdl";
            var path = Path.GetFullPath(basePath.Replace(@"\\", @"\"));

            if (bankReconcilationId == "")
            {
                MessageBox.Show("You must select a record", Software.GetApplicationName());
                return;
            }

            //Get the Parameters value and the display the report
            var frmViewer = new FrmReportViewer();
            frmViewer.rdlViewer.SourceFile = path;
            frmViewer.rdlViewer.Parameters = _bankReconcilationReportService.GenerateBankReconcilationReport(bankReconcilationId,accountId,Program.userId);
            frmViewer.rdlViewer.Rebuild();
            frmViewer.ShowDialog();
        }
    }
}
