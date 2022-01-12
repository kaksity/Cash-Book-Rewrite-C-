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
using CashBook.Services.Account;
using CashBook.Services.Reports;
using CashBook.Services.TransactionDescription;
using fyiReporting;

namespace CashBook.UI.Reports
{
    public partial class FrmGenerateTransactionReport : Form
    {
        private IAccountService _accountService;
        private ITransactionDescriptionService _transactionDescriptionService;
        private ITransactionReportService _transactionReportService;
        public FrmGenerateTransactionReport(
            IAccountService accountService,
            ITransactionDescriptionService transactionDescriptionService,
            ITransactionReportService transactionReportService
            )
        {
            _accountService = accountService;
            _transactionDescriptionService = transactionDescriptionService;
            _transactionReportService = transactionReportService;
            InitializeComponent();
        }

        private void FrmGenerateTransactionReport_Load(object sender, EventArgs e)
        {
            LoadAccountComboBox();
            LoadTransactionTypeCombox();
            LoadTransactionDescriptionComboBox((string)cboTypeOfTransaction.SelectedValue);
            LoadMonthComboBox();
            LoadYearComboBox();
        }
        private void LoadTransactionTypeCombox()
        {
            var transactionType = new DataTable();

            transactionType.Columns.Add("Name",typeof(string));
            transactionType.Columns.Add("Value", typeof(string));

            transactionType.Rows.Add("Expense","EXPENSE");
            transactionType.Rows.Add("Income","INCOME");

            cboTypeOfTransaction.DisplayMember = "Name";
            cboTypeOfTransaction.ValueMember = "Value";
            cboTypeOfTransaction.DataSource = transactionType;
        }
        private void LoadAccountComboBox()
        {
            var account = _accountService.GetAllAccounts();
            cboAccounts.DisplayMember = "AccountName";
            cboAccounts.ValueMember = "AccountId";
            cboAccounts.DataSource = account;
        }
        private void LoadTransactionDescriptionComboBox(string transactionType)
        {
            var transactionDescription = _transactionDescriptionService.GetAllTransactionDescriptionsByTransactionType(transactionType);

            cboDescriptions.DisplayMember = "DescriptionName";
            cboDescriptions.ValueMember = "TransactionDescriptionId";
            cboDescriptions.DataSource = transactionDescription;
        }

        private void cboTypeOfTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactionDescriptionComboBox((string)cboTypeOfTransaction.SelectedValue);
        }

        private void chkTransactionType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransactionType.Checked == true)
                cboTypeOfTransaction.Enabled = false;
            else
                cboTypeOfTransaction.Enabled = true;
        }

        private void chkDescription_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescription.Checked == true)
                cboDescriptions.Enabled = false;
            else
                cboDescriptions.Enabled = true;
        }
        private void LoadYearComboBox()
        {
            DataTable tblYears = new DataTable();
            int currentYear = 2020;

            tblYears.Columns.Add("name", typeof(string));
            tblYears.Columns.Add("value", typeof(int));

            while (currentYear <= DateTime.Now.Year)
            {
                tblYears.Rows.Add(currentYear, currentYear);
                currentYear += 1;
            }

            cboYears.DisplayMember = "name";
            cboYears.ValueMember = "value";
            cboYears.DataSource = tblYears;
        }
        private void LoadMonthComboBox()
        {
            DataTable tblMonths = new DataTable();

            tblMonths.Columns.Add("name", typeof(string));
            tblMonths.Columns.Add("value", typeof(int));

            tblMonths.Rows.Add("January", 1);
            tblMonths.Rows.Add("February", 2);
            tblMonths.Rows.Add("March", 3);
            tblMonths.Rows.Add("April", 4);
            tblMonths.Rows.Add("May", 5);
            tblMonths.Rows.Add("June", 6);
            tblMonths.Rows.Add("July", 7);
            tblMonths.Rows.Add("August", 8);
            tblMonths.Rows.Add("September", 9);
            tblMonths.Rows.Add("October", 10);
            tblMonths.Rows.Add("November", 11);
            tblMonths.Rows.Add("December", 12);

            cboMonths.DisplayMember = "name";
            cboMonths.ValueMember = "value";
            cboMonths.DataSource = tblMonths;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string accountId = (string)cboAccounts.SelectedValue;

            int month = (int)cboMonths.SelectedValue;
            int years = (int)cboYears.SelectedValue;

            string transactionDescription = (string)cboDescriptions.SelectedValue;
            string transactionType = (string)cboTypeOfTransaction.SelectedValue;

            string basePath = Application.StartupPath + @"\\transactions.rdl";
            var path = Path.GetFullPath(basePath.Replace(@"\\",@"\"));

            DataTable tblTransactionReports = null;
           

            if (chkTransactionType.Checked == false && chkDescription.Checked == false)
            {
                tblTransactionReports = _transactionReportService.GetAllTransactionByTransactionDescriptionAndTransactionType(accountId, month, years, transactionDescription, transactionType);
            }
            else if (chkTransactionType.Checked == false && chkDescription.Checked == true)
            {
                tblTransactionReports = _transactionReportService.GetAllTransactionByTransactionTypeOnly(accountId, month, years, transactionType);
            }
            else if (chkTransactionType.Checked == true && chkDescription.Checked == false)
            {
                tblTransactionReports = _transactionReportService.GetAllTransactionByTransactionDescriptionOnly(accountId, month, years, transactionDescription);
            }
            else if (chkTransactionType.Checked == true && chkDescription.Checked == true)
            {
                tblTransactionReports = _transactionReportService.GetAllTransactionsByAccountIdAndDuration(accountId, month, years);
            }

            var frmViewer = new FrmReportViewer();
            frmViewer.rdlViewer.SourceFile = path;
            frmViewer.rdlViewer.Report.DataSets["Data"].SetData(tblTransactionReports);
            frmViewer.rdlViewer.Parameters = _transactionReportService.GenerateReportParameters(Program.userId, accountId, month, years);
            frmViewer.rdlViewer.Rebuild();
            frmViewer.ShowDialog();

        }
    }
}
