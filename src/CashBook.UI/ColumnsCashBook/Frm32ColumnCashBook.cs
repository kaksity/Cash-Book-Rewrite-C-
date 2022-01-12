using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.Services.Account;
using CashBook.Services.Transaction;
using CashBook.Services.TransactionDescription;

namespace CashBook.UI.ColumnsCashBook
{
    public partial class Frm32ColumnCashBook : Form
    {
        private readonly ITransactionDescriptionService _transactionDescriptionService;
        private readonly IAccountService _accountService;
        private readonly ITransactionService _transactionService;

        public Frm32ColumnCashBook(ITransactionDescriptionService transactionDescriptionService,IAccountService accountService,ITransactionService transactionService)
        {
            _accountService = accountService;
            _transactionDescriptionService = transactionDescriptionService;
            _transactionService = transactionService;
            InitializeComponent();
        }

        private void Frm32ColumnCashBook_Load(object sender, EventArgs e)
        {
            Init32ColumnGrid();
            LoadAccountComboBox();
            LoadYearComboBox();
        }

        private void LoadAccountComboBox()
        {
            var accounts = _accountService.GetAllAccounts();
            cboAccounts.DisplayMember = "AccountName";
            cboAccounts.ValueMember = "AccountId";
            cboAccounts.DataSource = accounts;
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

        private void Init32ColumnGrid()
        {
            

        }

        private void LoadData()
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnGetRecords_Click(object sender, EventArgs e)
        {
            
            
            grid.Columns.Clear();
            grid.DataSource = null;

            var results = _transactionService.Get32ColumnCashBook((string)cboAccounts.SelectedValue, (int)cboYears.SelectedValue);

            grid.DataSource = results;

            var expenseTransactionItems = _transactionDescriptionService.GetAllTransactionDescriptionsByTransactionType("EXPENSE");

            grid.Columns["colsDateOfTransaction"].HeaderText = "DATE OF TRANSACTION";
            grid.Columns["colsTotalTransaction"].HeaderText = "TOTAL TRANSACTION";

            for (int i = 2; i < grid.Columns.Count; i++)
            {
                string headerText = grid.Columns[i].HeaderText;
                var transactionDescriptionItem = expenseTransactionItems.Find(item => item.TransactionDescriptionId == headerText);
                grid.Columns[i].HeaderText = transactionDescriptionItem.DescriptionName;
            }

            grid.AllowDrop = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = true;
            
        }
    }
}
