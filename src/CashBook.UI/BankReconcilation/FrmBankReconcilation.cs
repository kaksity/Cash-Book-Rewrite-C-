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
            LoadAccountComboBox();
            LoadMonthComboBox();
            LoadYearComboBox();
            Reset();
        }
        private void Reset()
        {
            isNewRecord = false;
            Clear();
            Disable();
        }
        private void LoadAccountComboBox()
        {
            var account = _accountService.GetAllAccounts();
            cboAccount.DisplayMember = "AccountName";
            cboAccount.ValueMember = "AccountId";
            cboAccount.DataSource = account;
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

            cboAccount.Enabled = false;
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

            cboAccount.Enabled = true;
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

            cboAccount.Text = "";
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
            if (string.IsNullOrWhiteSpace((string)cboAccount.SelectedValue) == true )
            {
                MessageBox.Show("Account is Required", "Cash Book");
                cboAccount.Focus();
                return;
            }

            if ((int)cboMonths.SelectedValue == 0)
            {
                MessageBox.Show("Months is required", "Cash Book");
                cboMonths.Focus();
                return;
            }

            if ((int)cboYears.SelectedValue < 2020)
            {
                MessageBox.Show("Years is required", "Cash Book");
                cboYears.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCreditTransfer.Text) == true)
            {
                MessageBox.Show("Credit Transfer is required", "Cash Book");
                txtCreditTransfer.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInterestReceived.Text) == true)
            {
                MessageBox.Show("Interest Received is required", "Cash Book");
                txtInterestReceived.Focus();
                return;
            }
            if (txtStaleChqsReversed.Text == "")
            {
                MessageBox.Show("Stale Cheque Reversed is required", "Cash Book");
                txtStaleChqsReversed.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBankCharges.Text) == true)
            {
                MessageBox.Show("Bank Charges is required", "Cash Book");
                txtBankCharges.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDebitTransfer.Text) == true)
            {
                MessageBox.Show("Debit Transfer is required", "Cash Book");
                txtDebitTransfer.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtOutstandingStaleChqs.Text) == true)
            {
                MessageBox.Show("Outstanding Stale Cheques is required", "Cash Book");
                txtOutstandingStaleChqs.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUnpresentedChqs.Text) == true)
            {
                MessageBox.Show("Unpresented Cheques is required","Cash Book");
                txtUnpresentedChqs.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtItemsInBankNotCashBook.Text) == true)
            {
                MessageBox.Show("Items in Bank not in Cash Book is required", "Cash Book");
                txtItemsInBankNotCashBook.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUncreditedLodgement.Text) == true)
            {
                MessageBox.Show("Uncredited Lodgements is required", "Cash Book");
                txtUncreditedLodgement.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtItemsInCashBookNotBank.Text) == true)
            {
                MessageBox.Show("Items in Cash Book not in Bank is required", "Cash Book");
                txtItemsInCashBookNotBank.Focus();
                return;
            }

            // Check if the data are in the right format
            if (Utility.IsNumeric(txtCreditTransfer.Text) == false)
            {
                MessageBox.Show("Credit Transfer must be numeric", "Cash Book");
                txtCreditTransfer.Focus();
                return;
            }

            if (Utility.IsNumeric(txtInterestReceived.Text) == false)
            {
                MessageBox.Show("Interest Received must be numeric", "Cash Book");
                txtInterestReceived.Focus();
                return;
            }

            if (Utility.IsNumeric(txtStaleChqsReversed.Text) == false)
            {
                MessageBox.Show("Stale Cheques Reversed must be numeric", "Cash Book");
                txtStaleChqsReversed.Focus();
                return;
            }

            if (Utility.IsNumeric(txtBankCharges.Text) == false)
            {
                MessageBox.Show("Bank Charges must be numeric", "Cash Book");
                txtBankCharges.Focus();
                return;
            }

            if (Utility.IsNumeric(txtDebitTransfer.Text) == false)
            {
                MessageBox.Show("Debit Transfer must be numeric", "Cash Book");
                txtDebitTransfer.Focus();
                return;
            }

            if (Utility.IsNumeric(txtOutstandingStaleChqs.Text) == false)
            {
                MessageBox.Show("Outstanding Stale Cheques must be numeric", "Cash Book");
                txtOutstandingStaleChqs.Focus();
                return;
            }

            if (Utility.IsNumeric(txtUnpresentedChqs.Text) == false)
            {
                MessageBox.Show("Unpresented Cheques must be numeric", "Cash Book");
                txtUnpresentedChqs.Focus();
                return;
            }
            if (Utility.IsNumeric(txtItemsInBankNotCashBook.Text) == false)
            {
                MessageBox.Show("Items in Bank and not in Cash Book must be numeric", "Cash Book");
                txtItemsInBankNotCashBook.Focus();
                return;

            }
            if (Utility.IsNumeric(txtUncreditedLodgement.Text) == false)
            {
                MessageBox.Show("Uncredited Lodgement must be numeric", "Cash Book");
                txtUncreditedLodgement.Focus();
                return;
            }
            if (Utility.IsNumeric(txtItemsInCashBookNotBank.Text) == false)
            {
                MessageBox.Show("Items in Cash Book and not in Bank must be numeric", "Cash Book");
                txtItemsInCashBookNotBank.Focus();
                return;
            }
            if (isNewRecord == true)
            {
                // Check if the Financial Month Has Been Closed
                string duration = $"{cboMonths.SelectedValue}.{cboYears.SelectedValue}";

                var maintainBalanceForDuration = _maintainBalanceService.GetMaintainBalanceByAccountIdAndDuration((string)cboAccount.SelectedValue,duration);

                if (maintainBalanceForDuration == null)
                {
                    MessageBox.Show("You must close previous month before generating bank reconcilation for present month", "Cash Book");
                    return;
                }
                var bankReconcilationResult = _bankReconcilationService.GetBankReconcilationByAccountIdAndDuration((string)cboAccount.SelectedValue,duration);

                if (bankReconcilationResult != null)
                {
                    MessageBox.Show("Bank Reconcilation for this month has already been generated", "Cash Book");
                    Reset();
                    return;
                }

                var bankReconcilationCreateDto = new CreateBankReconcilationDto
                {
                     AccountId  = (string)cboAccount.SelectedValue,
                     Duration  =  $"{cboMonths.SelectedValue}.{cboYears.SelectedValue}",
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
                MessageBox.Show("New Bank Reconcilation record was created successfully", "Cash Book");
                Reset();
                return;
            }
        }
    }
}
