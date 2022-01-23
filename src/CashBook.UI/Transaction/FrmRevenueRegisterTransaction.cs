using CashBook.Dtos.Transaction;
using CashBook.Services.Account;
using CashBook.Services.Transaction;
using CashBook.Services.TransactionDescription;
using CashBook.UI.Account;
using CashBook.UI.TransactionDescription;
using CashBook.UI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.Services.Utility;
using CashBook.Services.MaintainBalance;

namespace CashBook.UI.Transaction
{
    public partial class FrmRevenueRegisterTransaction : Form
    {
        private readonly IAccountService _accountService;
        private readonly ITransactionDescriptionService _transactionDescriptionService;
        private readonly ITransactionService _transactionService;
        private readonly IUtilityService _utilityService;
        private readonly IMaintainBalanceService _maintainBalanceService;

        string transactionId = "";

        List<ReadTransactionDto> transactions = null;

        bool isNewRecord = false;

        public FrmRevenueRegisterTransaction(
            ITransactionDescriptionService transactionDescriptionService,
            IAccountService accountService,
            ITransactionService transactionService,
            IUtilityService utilityService,
            IMaintainBalanceService maintainBalanceService
        )
        {
            _transactionDescriptionService = transactionDescriptionService;
            _accountService = accountService;
            _transactionService = transactionService;
            _utilityService = utilityService;
            _maintainBalanceService = maintainBalanceService;

            InitializeComponent();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var accountForm = Program.container.GetInstance<FrmAccount>();
            accountForm.ShowDialog();
            LoadAccountComboBox();
        }

        private void btnAddDescription_Click(object sender, EventArgs e)
        {
            var transactionDescriptionForm = Program.container.GetInstance<FrmTransactionDescription>();
            transactionDescriptionForm.ShowDialog();
            LoadTransactionDescriptionComboBox();
        }

        private void InitRevenueRegisterTransactionGrid()
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            grid.Columns.Add("colsSNum", "S/No");
            grid.Columns.Add("colsAccountName", "Account Name");
            grid.Columns.Add("colsAccountNumber", "Account Number");
            grid.Columns.Add("colsDateOfTransaction", "Date of Transaction");
            grid.Columns.Add("colsSubHead", "Sub Head");
            grid.Columns.Add("colsRVNumber", "RV Number");
            grid.Columns.Add("colsReceipt", "Receipts");
            grid.Columns.Add("colsDescription", "Description");
            grid.Columns.Add("colsBeneficiaryName", "Beneficiary Name");
            grid.Columns.Add("colsAmmountDeposited", "Ammount Deposited");


            grid.Columns["colsDateOfTransaction"].Width = 150;
            grid.Columns["colsBeneficiaryName"].Width = 250;
            grid.Columns["colsDescription"].Width = 300;
            grid.Columns["colsAccountName"].Width = 150;
            grid.Columns["colsAccountNumber"].Width = 150;
            grid.Columns["colsAmmountDeposited"].Width = 130;
            

            grid.Columns["colsSubHead"].ReadOnly = true;
            grid.Columns["colsRVNumber"].ReadOnly = true;
            grid.Columns["colsDateOfTransaction"].ReadOnly = true;
            grid.Columns["colsBeneficiaryName"].ReadOnly = true;
            grid.Columns["colsDescription"].ReadOnly = true;
            grid.Columns["colsAccountName"].ReadOnly = true;
            grid.Columns["colsAccountNumber"].ReadOnly = true;
            grid.Columns["colsAmmountDeposited"].ReadOnly = true;
            grid.Columns["colsReceipt"].ReadOnly = true;

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
        }

        private void FrmRevenueRegisterTransaction_Load(object sender, EventArgs e)
        {
            LoadAccountComboBox();
            LoadTransactionDescriptionComboBox();
            LoadMonthCombobox();
            LoadYearComboBox();
            InitRevenueRegisterTransactionGrid();
            LoadRevenueRegisterTransactions();
            Reset();
        }



        private void LoadAccountComboBox()
        {
            var account = _accountService.GetAllAccounts();
            cboAccounts.DisplayMember = "AccountName";
            cboAccounts.ValueMember = "AccountId";
            cboAccounts.DataSource = account;
            cboFilterAccounts.DisplayMember = "AccountName";
            cboFilterAccounts.ValueMember = "AccountId";
            cboFilterAccounts.DataSource = account;
        }
        private void LoadTransactionDescriptionComboBox()
        {
            var transactionDescription = _transactionDescriptionService.GetAllTransactionDescriptionsByTransactionType("INCOME");

            cboDescriptions.DisplayMember = "DescriptionName";
            cboDescriptions.ValueMember = "TransactionDescriptionId";
            cboDescriptions.DataSource = transactionDescription;
        }

        private void LoadYearComboBox()
        {
            var tblYears = _utilityService.GetYears();

            cboFilterYears.DisplayMember = "name";
            cboFilterYears.ValueMember = "value";
            cboFilterYears.DataSource = tblYears;
        }
        private void LoadMonthCombobox()
        {
            var tblMonths = _utilityService.GetMonths();
            cboFilterMonths.DisplayMember = "name";
            cboFilterMonths.ValueMember = "value";
            cboFilterMonths.DataSource = tblMonths;
        }

        private void Enable()
        {
            cboAccounts.Enabled = true;
            dtpDateOfTransaction.Enabled = true;
            txtDebit.Enabled = true;
            cboDescriptions.Enabled = true;
            txtReceipts.Enabled = true;
            txtRVNumber.Enabled = true;
            txtSubhead.Enabled = true;
            txtNameOfPayee.Enabled = true;
            grid.Enabled = false;

            btnNew.Enabled = false;
            btnUndo.Enabled = true;
            btnSave.Enabled = true;
        }
        private void Disable()
        {
            cboAccounts.Enabled = false;
            dtpDateOfTransaction.Enabled = false;
            txtDebit.Enabled = false;
            cboDescriptions.Enabled = false;
            txtReceipts.Enabled = false;
            txtRVNumber.Enabled = false;
            txtNameOfPayee.Enabled = false;
            txtSubhead.Enabled = false;

            grid.Enabled = true;

            btnNew.Enabled = true;
            btnUndo.Enabled = false;
            btnSave.Enabled = false;
        }

        private void Clear()
        {

            txtDebit.Text = "";
            txtReceipts.Text = "";
            txtRVNumber.Text = "";
            txtSubhead.Text = "";
            txtNameOfPayee.Text = "";

            
        }
        private void Reset()
        {
            isNewRecord = false;
            Clear();
            Disable();
            lblSelectedRecord.Text = "";
            transactionId = "";
        }
    
        private void btnSave_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(txtRVNumber.Text) == true) {
                MessageBox.Show("RV Number is required", Software.GetApplicationName());
                txtRVNumber.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtReceipts.Text) == true) {
                MessageBox.Show("Receipts is required", Software.GetApplicationName());
                txtReceipts.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSubhead.Text) == true) {
                MessageBox.Show("Subhead is required", Software.GetApplicationName());
                txtSubhead.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cboDescriptions.Text) == true) {
                MessageBox.Show("Description is required", Software.GetApplicationName());
                cboDescriptions.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDebit.Text) == true) {
                MessageBox.Show("Debit Ammount is required", Software.GetApplicationName());
                txtDebit.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNameOfPayee.Text) == true) {
                MessageBox.Show("Name of Payee is required", Software.GetApplicationName());
                txtNameOfPayee.Focus();
                return;
            }

            if (Utility.IsNumeric(txtDebit.Text) == false) {
                MessageBox.Show("Debit Account must be numeric", Software.GetApplicationName());
                return;
            }

            if (isNewRecord == true)
            {

                //Check if the financial month has not been closeed

                //Create the Transaction
                var transaction = new CreateTransactionDto
                {
                    AccountId = (string)cboAccounts.SelectedValue,
                    AmmountWithdrawn = 0,
                    AmmountDeposited = Utility.ParseNumber(txtDebit.Text),
                    NameOfBeneficiary = txtNameOfPayee.Text.ToUpper(),
                    DateOfTransaction = dtpDateOfTransaction.Value,
                    PVOrRVNumber = txtRVNumber.Text.ToUpper(),
                    SubHeadColumn = txtSubhead.Text.ToUpper(),
                    TransactionDescriptionId =(string)cboDescriptions.SelectedValue,
                    RefNumber = txtReceipts.Text.ToUpper(),
                };

                
                _transactionService.CreateTransaction(transaction);

                //Update the Account Balance
                var account = _accountService.GetAccountByAccountId((string)cboAccounts.SelectedValue);
                
                _accountService.AddToAccountBalance(account, Utility.ParseNumber(txtDebit.Text));

                string duration = $"{dtpDateOfTransaction.Value.Month}.{dtpDateOfTransaction.Value.Year}";
                //Check if the financial month has not been closeed
                var maintainBalance = _maintainBalanceService.GetMaintainBalanceByAccountIdAndDuration((string)cboAccounts.SelectedValue, duration);

                if (maintainBalance != null && maintainBalance.Status == 1)
                {
                    // Set the record as the account has been edited;
                    _maintainBalanceService.SetMaintainBalanceAsEdited(maintainBalance.MaintainBalanceId);
                }

                MessageBox.Show("Transaction record was created successfully",Software.GetApplicationName());
                Reset();
                LoadRevenueRegisterTransactions();
                return;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isNewRecord = true;
            Clear();
            Enable();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadFilteredRevenueRegisterTransactions(string accountId, int month, int year)
        {
            transactions = null;
            transactions = _transactionService.GetFilteredRevenueRegisterTransaction(accountId, month, year);

            grid.Rows.Clear();
            if (transactions?.Count == 0) return;
            grid.Rows.Add(transactions.Count);

            for (int i = 0; i < transactions.Count; i++)
            {
                grid.Rows[i].Cells["colsSNum"].Value = i + 1;
                grid.Rows[i].Cells["colsAccountName"].Value = transactions[i].AccountName;
                grid.Rows[i].Cells["colsAccountNumber"].Value = transactions[i].AccountNumber;
                grid.Rows[i].Cells["colsDateOfTransaction"].Value = Utility.FormatDate(transactions[i].DateOfTransaction);
                grid.Rows[i].Cells["colsSubHead"].Value = transactions[i].SubHeadColumn;
                grid.Rows[i].Cells["colsRVNumber"].Value = transactions[i].PVOrRVNumber;
                grid.Rows[i].Cells["colsReceipt"].Value = transactions[i].RefNumber;
                grid.Rows[i].Cells["colsDescription"].Value = transactions[i].TransactionDescriptionName;
                grid.Rows[i].Cells["colsBeneficiaryName"].Value = transactions[i].NameOfBeneficiary;
                grid.Rows[i].Cells["colsAmmountDeposited"].Value = $"N{Utility.FormatDecimal(transactions[i].AmmountDeposited)}";
            }
        }
        private void LoadRevenueRegisterTransactions()
        {
            transactions = null;
            transactions = _transactionService.GetAllRevenueRegiserTransaction();

            grid.Rows.Clear();
            if (transactions?.Count == 0) return;
            grid.Rows.Add(transactions.Count);

            for (int i = 0; i < transactions.Count; i++)
            {
                grid.Rows[i].Cells["colsSNum"].Value = i + 1;
                grid.Rows[i].Cells["colsAccountName"].Value = transactions[i].AccountName;
                grid.Rows[i].Cells["colsAccountNumber"].Value = transactions[i].AccountNumber;
                grid.Rows[i].Cells["colsDateOfTransaction"].Value = Utility.FormatDate(transactions[i].DateOfTransaction);
                grid.Rows[i].Cells["colsSubHead"].Value = transactions[i].SubHeadColumn;
                grid.Rows[i].Cells["colsReceipt"].Value = transactions[i].RefNumber;
                grid.Rows[i].Cells["colsRVNumber"].Value = transactions[i].PVOrRVNumber;
                grid.Rows[i].Cells["colsDescription"].Value = transactions[i].TransactionDescriptionName;
                grid.Rows[i].Cells["colsBeneficiaryName"].Value = transactions[i].NameOfBeneficiary;
                grid.Rows[i].Cells["colsAmmountDeposited"].Value = $"N{Utility.FormatDecimal(transactions[i].AmmountDeposited)}";
            }
        }

        private void btnLoadAllData_Click(object sender, EventArgs e)
        {
            LoadRevenueRegisterTransactions();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadFilteredRevenueRegisterTransactions((string)cboAccounts.SelectedValue, (int)cboFilterMonths.SelectedValue, (int)cboFilterYears.SelectedValue);
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var transaction = transactions[e.RowIndex];
            transactionId = transaction.TransactionId;
            lblSelectedRecord.Text = $"Account Name: {transaction.AccountName}, Account Number: {transaction.AccountNumber}, Date Of Transaction: {Utility.FormatDate(transaction.DateOfTransaction)}, Name Of Beneficiary: {transaction.NameOfBeneficiary}, Ammount Deposited: N{Utility.FormatDecimal(transaction.AmmountDeposited)}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            transactionId = "";
            lblSelectedRecord.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (transactionId == "")
            {
                MessageBox.Show("You must select a record", Software.GetApplicationName(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Are you sure you want to remove this transaction?", Software.GetApplicationName(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (MessageBox.Show("Removing transaction will remove related attached supporting documents", Software.GetApplicationName(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            var transaction = _transactionService.GetTransactionByTransactionId(transactionId);
            string duration = $"{transaction.DateOfTransaction.Month}.{transaction.DateOfTransaction.Year}";
            //Check if the financial month has not been closeed
            var maintainBalance = _maintainBalanceService.GetMaintainBalanceByAccountIdAndDuration(transaction.AccountId, duration);

            if (maintainBalance != null && maintainBalance.Status == 1)
            {
                // Set the record as the account has been edited;
                _maintainBalanceService.SetMaintainBalanceAsEdited(maintainBalance.MaintainBalanceId);
            }

            _transactionService.DeleteTransaction(transactionId);
            MessageBox.Show("Transaction record was deleted successfully", Software.GetApplicationName(), MessageBoxButtons.OK);
            LoadRevenueRegisterTransactions();
            Reset();
        }
    }
}
