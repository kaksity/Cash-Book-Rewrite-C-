using CashBook.Dtos.BankReconcilation;
using CashBook.Services.Account;
using CashBook.Services.BankReconcilation;
using CashBook.Services.MaintainBalance;
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

namespace CashBook.UI.BankReconcilation
{
    public partial class FrmBankReconcilation : Form
    {
        private readonly IAccountService _accountService;
        private readonly IBankReconcilationService _bankReconcilationService;
        private readonly IMaintainBalanceService _maintainBalanceService;

        List<ReadBankReconcilationDto> listOfBankReconcilation = null;
        string bankReconcilationId = "";

        bool isNewRecord = false;

        public FrmBankReconcilation(
            IAccountService accountService, 
            IBankReconcilationService bankReconcilationService,
            IMaintainBalanceService maintainBalanceService
        )
        {
            _bankReconcilationService = bankReconcilationService;
            _maintainBalanceService = maintainBalanceService;
            _accountService = accountService;
            InitializeComponent();
        }

        private void FrmBankReconcilation_Load(object sender, EventArgs e)
        {
            InitBankReconcilationGrid();

            LoadAccountComboBox();
            LoadMonthComboBox();
            LoadYearComboBox();
            
            listOfBankReconcilation = _bankReconcilationService.GetBankReconcilationByAccountId((string)cboViewBankReconcilationAccounts.SelectedValue);
            LoadGridData(listOfBankReconcilation);
            Reset();
        }
        private void Reset()
        {
            isNewRecord = false;
            Clear();
            lblSelectedRecord.Text = "";
            bankReconcilationId = "";
            Disable();
        }
        private void LoadAccountComboBox()
        {
            var accounts = _accountService.GetAllAccounts();
            cboAccounts.DisplayMember = "AccountName";
            cboAccounts.ValueMember = "AccountId";
            cboAccounts.DataSource = accounts;
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
                grid.Rows[i].Cells["colsDuration"].Value = data[i].Duration;
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
            tblMonths.Columns.Add("value",typeof(int));

            tblMonths.Rows.Add("", 0);
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
        private void Disable()
        {

            cboAccounts.Enabled = false;
            cboMonths.Enabled = false;
            cboYears.Enabled = false;
            txtBankCharges.Enabled = false;
            txtCreditTransfer.Enabled = false;
            txtDebitTransfer.Enabled = false;
            txtInterestReceived.Enabled = false;
            txtItemsInBankNotCashBook.Enabled = false;
            txtItemsInCashBookNotBank.Enabled = false;
            txtOutstandingStaleChqs.Enabled = false;
            txtStaleChqsReversed.Enabled = false;
            txtUncreditedLodgement.Enabled = false;
            txtUnpresentedChqs.Enabled = false;

            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnClose.Enabled = true;
            btnUndo.Enabled = false;

        }

        private void Enable()
        {

            cboAccounts.Enabled = true;
            cboMonths.Enabled = true;
            cboYears.Enabled = true;
            txtBankCharges.Enabled = true;
            txtCreditTransfer.Enabled = true;
            txtDebitTransfer.Enabled = true;
            txtInterestReceived.Enabled = true;
            txtItemsInBankNotCashBook.Enabled = true;
            txtItemsInCashBookNotBank.Enabled = true;
            txtOutstandingStaleChqs.Enabled = true;
            txtStaleChqsReversed.Enabled = true;
            txtUncreditedLodgement.Enabled = true;
            txtUnpresentedChqs.Enabled = true;

            btnUndo.Enabled = true;
            btnSave.Enabled = true;
            btnNew.Enabled = false;
            btnClose.Enabled = true;
        }

        private void Clear()
        {

            cboAccounts.Text = "";
            cboMonths.Text = "";
            cboYears.Text = "";
            txtBankCharges.Text = "";
            txtCreditTransfer.Text = "";
            txtDebitTransfer.Text = "";
            txtInterestReceived.Text = "";
            txtItemsInBankNotCashBook.Text = "";
            txtItemsInCashBookNotBank.Text = "";
            txtOutstandingStaleChqs.Text = "";
            txtStaleChqsReversed.Text = "";
            txtUncreditedLodgement.Text = "";
            txtUnpresentedChqs.Text = "";

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            Enable();
            isNewRecord = true;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Verify If All the Necesary InPuts are given
            if (string.IsNullOrWhiteSpace((string)cboAccounts.SelectedValue) == true )
            {
                MessageBox.Show("Account is Required", Software.GetApplicationName());
                cboAccounts.Focus();
                return;
            }

            if ((int)cboMonths.SelectedValue == 0)
            {
                MessageBox.Show("Months is required", Software.GetApplicationName());
                cboMonths.Focus();
                return;
            }

            if ((int)cboYears.SelectedValue < 2020)
            {
                MessageBox.Show("Years is required", Software.GetApplicationName());
                cboYears.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCreditTransfer.Text) == true)
            {
                MessageBox.Show("Credit Transfer is required", Software.GetApplicationName());
                txtCreditTransfer.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInterestReceived.Text) == true)
            {
                MessageBox.Show("Interest Received is required", Software.GetApplicationName());
                txtInterestReceived.Focus();
                return;
            }
            if (txtStaleChqsReversed.Text == "")
            {
                MessageBox.Show("Stale Cheque Reversed is required", Software.GetApplicationName());
                txtStaleChqsReversed.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBankCharges.Text) == true)
            {
                MessageBox.Show("Bank Charges is required", Software.GetApplicationName());
                txtBankCharges.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDebitTransfer.Text) == true)
            {
                MessageBox.Show("Debit Transfer is required", Software.GetApplicationName());
                txtDebitTransfer.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtOutstandingStaleChqs.Text) == true)
            {
                MessageBox.Show("Outstanding Stale Cheques is required", Software.GetApplicationName());
                txtOutstandingStaleChqs.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUnpresentedChqs.Text) == true)
            {
                MessageBox.Show("Unpresented Cheques is required",Software.GetApplicationName());
                txtUnpresentedChqs.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtItemsInBankNotCashBook.Text) == true)
            {
                MessageBox.Show("Items in Bank not in Cash Book is required", Software.GetApplicationName());
                txtItemsInBankNotCashBook.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUncreditedLodgement.Text) == true)
            {
                MessageBox.Show("Uncredited Lodgements is required", Software.GetApplicationName());
                txtUncreditedLodgement.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtItemsInCashBookNotBank.Text) == true)
            {
                MessageBox.Show("Items in Cash Book not in Bank is required", Software.GetApplicationName());
                txtItemsInCashBookNotBank.Focus();
                return;
            }

            // Check if the data are in the right format
            if (Utility.IsNumeric(txtCreditTransfer.Text) == false)
            {
                MessageBox.Show("Credit Transfer must be numeric", Software.GetApplicationName());
                txtCreditTransfer.Focus();
                return;
            }

            if (Utility.IsNumeric(txtInterestReceived.Text) == false)
            {
                MessageBox.Show("Interest Received must be numeric", Software.GetApplicationName());
                txtInterestReceived.Focus();
                return;
            }

            if (Utility.IsNumeric(txtStaleChqsReversed.Text) == false)
            {
                MessageBox.Show("Stale Cheques Reversed must be numeric", Software.GetApplicationName());
                txtStaleChqsReversed.Focus();
                return;
            }

            if (Utility.IsNumeric(txtBankCharges.Text) == false)
            {
                MessageBox.Show("Bank Charges must be numeric", Software.GetApplicationName());
                txtBankCharges.Focus();
                return;
            }

            if (Utility.IsNumeric(txtDebitTransfer.Text) == false)
            {
                MessageBox.Show("Debit Transfer must be numeric", Software.GetApplicationName());
                txtDebitTransfer.Focus();
                return;
            }

            if (Utility.IsNumeric(txtOutstandingStaleChqs.Text) == false)
            {
                MessageBox.Show("Outstanding Stale Cheques must be numeric", Software.GetApplicationName());
                txtOutstandingStaleChqs.Focus();
                return;
            }

            if (Utility.IsNumeric(txtUnpresentedChqs.Text) == false)
            {
                MessageBox.Show("Unpresented Cheques must be numeric", Software.GetApplicationName());
                txtUnpresentedChqs.Focus();
                return;
            }
            if (Utility.IsNumeric(txtItemsInBankNotCashBook.Text) == false)
            {
                MessageBox.Show("Items in Bank and not in Cash Book must be numeric", Software.GetApplicationName());
                txtItemsInBankNotCashBook.Focus();
                return;

            }
            if (Utility.IsNumeric(txtUncreditedLodgement.Text) == false)
            {
                MessageBox.Show("Uncredited Lodgement must be numeric", Software.GetApplicationName());
                txtUncreditedLodgement.Focus();
                return;
            }
            if (Utility.IsNumeric(txtItemsInCashBookNotBank.Text) == false)
            {
                MessageBox.Show("Items in Cash Book and not in Bank must be numeric", Software.GetApplicationName());
                txtItemsInCashBookNotBank.Focus();
                return;
            }
            if (isNewRecord == true)
            {

                string duration = $"{cboMonths.SelectedValue}.{cboYears.SelectedValue}";
                var bankReconcilationResult = _bankReconcilationService.GetBankReconcilationByAccountIdAndDuration((string)cboAccounts.SelectedValue,duration);

                if (bankReconcilationResult != null)
                {
                    MessageBox.Show("Bank Reconcilation for this month has already been generated", Software.GetApplicationName());
                    Reset();
                    return;
                }

                string accountId = (string)cboAccounts.SelectedValue;
                var bankReconcilationCreateDto = new CreateBankReconcilationDto
                {
                     AccountId  = accountId,
                     Duration  = duration,
                     CreditTransfer  = Utility.ParseNumber(txtCreditTransfer.Text),
                     InterestReceived  = Utility.ParseNumber(txtInterestReceived.Text),
                     StaleChqsReversed  = Utility.ParseNumber(txtStaleChqsReversed.Text),
                     BankCharges  = Utility.ParseNumber(txtBankCharges.Text),
                     DebitTransfer  = Utility.ParseNumber(txtDebitTransfer.Text),
                     OutstandingStaleChqs  = Utility.ParseNumber(txtOutstandingStaleChqs.Text),
                     UnpresentedChqs  = Utility.ParseNumber(txtUnpresentedChqs.Text),
                     BankNotCashBook  = Utility.ParseNumber(txtItemsInBankNotCashBook.Text),
                     UncreditedLodgements  = Utility.ParseNumber(txtUncreditedLodgement.Text),
                     CashBookNotBank  = Utility.ParseNumber(txtItemsInCashBookNotBank.Text),
                     DiffBtwBankAndCashBook  = 0
                };
                
                _bankReconcilationService.CreateBankReconcilation(bankReconcilationCreateDto);

                // Check if the financial month has been created and closed
                // If true then set it as been edited
                var maintainBalance = _maintainBalanceService.GetMaintainBalanceByAccountIdAndDuration(accountId,duration);

                if (maintainBalance != null && maintainBalance.Status == 1)
                {
                    _maintainBalanceService.SetMaintainBalanceAsEdited(maintainBalance.MaintainBalanceId);
                }
                MessageBox.Show("New Bank Reconcilation record was created successfully", Software.GetApplicationName());
                // Get Bank Reconcilation record and display them again
                listOfBankReconcilation = _bankReconcilationService.GetBankReconcilationByAccountId((string)cboViewBankReconcilationAccounts.SelectedValue);
                LoadGridData(listOfBankReconcilation);
                Reset();
                return;
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ensure that the user selects a record
            if (string.IsNullOrWhiteSpace(bankReconcilationId) == true)
            {
                MessageBox.Show("You Must Select a record", Software.GetApplicationName());
                return;
            }

            if (MessageBox.Show("Do you wish to delete this bank reconcilation record?", Software.GetApplicationName(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Reset();
                return;
            }

            var bankReconcilation = listOfBankReconcilation.Find(t => t.BankReconcilationId == bankReconcilationId);
            
            //Check if the financial month has not been closeed
            var maintainBalance = _maintainBalanceService.GetMaintainBalanceByAccountIdAndDuration(bankReconcilation.AccountId, bankReconcilation.Duration);

            if (maintainBalance != null && maintainBalance.Status == 1)
            {
                // Set the record as the account has been edited;
                _maintainBalanceService.SetMaintainBalanceAsEdited(maintainBalance.MaintainBalanceId);
            }

            _bankReconcilationService.DeleteBankReconcilationRecord(bankReconcilationId);

            // Get Bank Reconcilation record and display them again
            listOfBankReconcilation = _bankReconcilationService.GetBankReconcilationByAccountId((string)cboViewBankReconcilationAccounts.SelectedValue);
            LoadGridData(listOfBankReconcilation);

            MessageBox.Show("Bank reconcilation record was deleted successfully", Software.GetApplicationName());
            Reset();
        }
    }
}
