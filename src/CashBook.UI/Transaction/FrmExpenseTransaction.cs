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

namespace CashBook.UI.Transaction
{
    public partial class FrmExpenseTransaction : Form
    {
        private readonly IAccountService _accountService;
        private readonly ITransactionDescriptionService _transactionDescriptionService;
        private readonly ITransactionService _transactionService;
        bool isNewRecord = false;

        public FrmExpenseTransaction(
            ITransactionDescriptionService transactionDescriptionService,
            IAccountService accountService,
            ITransactionService transactionService
        )
        {
            _transactionDescriptionService = transactionDescriptionService;
            _accountService = accountService;
            _transactionService = transactionService;
            InitializeComponent();
        }
        private void Enable()
        {
            cboAccount.Enabled = true;
            dtpDateOfTransaction.Enabled = true;
            cboDescription.Enabled = true;
            txtRefNumber.Enabled = true;
            txtPayment.Enabled = true;
            txtPVNumber.Enabled = true;
            txtSubhead.Enabled = true;
            txtNameOfBeneficiary.Enabled = true;
            btnNew.Enabled = false;
            btnUndo.Enabled = true;
            btnSave.Enabled = true;
        }
        private void Disable()
        {
            cboAccount.Enabled = false;
            dtpDateOfTransaction.Enabled = false;
            cboDescription.Enabled = false;
            txtPayment.Enabled = false;
            txtPVNumber.Enabled = false;
            txtRefNumber.Enabled = false;
            txtNameOfBeneficiary.Enabled = false;
            txtSubhead.Enabled = false;
            btnNew.Enabled = true;
            btnUndo.Enabled = false;
            btnSave.Enabled = false;
        }
        private void FrmExpenseTransaction_Load(object sender, EventArgs e)
        {
            LoadAccountComboBox();
            LoadTransactionDescriptionComboBox();
            Reset();
        }
        private void Reset()
        {
            isNewRecord = false;
            Clear();
            Disable();
        }
        private void Clear()
        {

            txtPayment.Text = "";
            txtRefNumber.Text = "";
            txtPVNumber.Text = "";
            txtSubhead.Text = "";
            txtNameOfBeneficiary.Text = "";
        }
        private void LoadAccountComboBox()
        {
            var account = _accountService.GetAllAccounts();
            cboAccount.DisplayMember = "AccountName";
            cboAccount.ValueMember = "AccountId";
            cboAccount.DataSource = account;
        }
        private void LoadTransactionDescriptionComboBox()
        {
            var transactionDescription = _transactionDescriptionService.GetAllTransactionDescriptionsByTransactionType("EXPENSE");

            cboDescription.DisplayMember = "DescriptionName";
            cboDescription.ValueMember = "TransactionDescriptionId";
            cboDescription.DataSource = transactionDescription;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboDescription.Text) == true)
            {
                MessageBox.Show("Description is required", "Cash Book");
                cboDescription.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPVNumber.Text) == true)
            {
                MessageBox.Show("PV Number is required", "Cash Book");
                txtPVNumber.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRefNumber.Text) == true)
            {
                MessageBox.Show("Ref. No is required", "Cash Book");
                txtRefNumber.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSubhead.Text) == true)
            {
                MessageBox.Show("Subhead Column is required", "Cash Book");
                txtSubhead.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPayment.Text) == true)
            {
                MessageBox.Show("Credit Payment is required", "Cash Book");
                txtPayment.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtNameOfBeneficiary.Text) == true)
            {
                MessageBox.Show("Name of Beneficiary is required", "Cash Book");
                txtNameOfBeneficiary.Focus();
                return;
            }

            if (isNewRecord == true)
            {

                //Check if the financial month has not been closeed

                //Create the Transaction
                var transaction = new CreateTransactionDto
                {
                    AccountId = (string)cboAccount.SelectedValue,
                    AmmountWithdrawn = Utility.ParseNumber(txtPayment.Text),
                    AmmountDeposited = 0,
                    NameOfBeneficiary = txtNameOfBeneficiary.Text.ToUpper(),
                    DateOfTransaction = dtpDateOfTransaction.Value,
                    PVOrRVNumber = txtPVNumber.Text.ToUpper(),
                    SubHeadColumn = txtSubhead.Text.ToUpper(),
                    TransactionDescriptionId = (string)cboDescription.SelectedValue,
                    RefNumber = txtRefNumber.Text.ToUpper(),
                };


                _transactionService.CreateTransaction(transaction);

                //Update the Account Balance
                var account = _accountService.GetAccountByAccountId((string)cboAccount.SelectedValue);

                _accountService.DeductFromAccountBalance(account, Utility.ParseNumber(txtPayment.Text));

                MessageBox.Show("Transaction record was created successfully", "Cash Book");
                Reset();
                return;
            }
        }
    }
}
