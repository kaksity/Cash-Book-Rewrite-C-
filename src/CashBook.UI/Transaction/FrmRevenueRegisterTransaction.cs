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
    public partial class FrmRevenueRegisterTransaction : Form
    {
        private readonly IAccountService _accountService;
        private readonly ITransactionDescriptionService _transactionDescriptionService;
        private readonly ITransactionService _transactionService;
        bool isNewRecord = false;

        public FrmRevenueRegisterTransaction(
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

        private void FrmRevenueRegisterTransaction_Load(object sender, EventArgs e)
        {
            LoadAccountComboBox();
            LoadTransactionDescriptionComboBox();
            Reset();
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
            var transactionDescription = _transactionDescriptionService.GetAllTransactionDescriptionsByTransactionType("INCOME");

            cboDescription.DisplayMember = "DescriptionName";
            cboDescription.ValueMember = "TransactionDescriptionId";
            cboDescription.DataSource = transactionDescription;
        }

        private void Enable()
        {
            cboAccount.Enabled = true;
            dtpDateOfTransaction.Enabled = true;
            txtDebit.Enabled = true;
            cboDescription.Enabled = true;
            txtReceipts.Enabled = true;
            txtRVNumber.Enabled = true;
            txtSubhead.Enabled = true;
            txtNameOfPayee.Enabled = true;
            btnNew.Enabled = false;
            btnUndo.Enabled = true;
            btnSave.Enabled = true;
        }
        private void Disable()
        {
            cboAccount.Enabled = false;
            dtpDateOfTransaction.Enabled = false;
            txtDebit.Enabled = false;
            cboDescription.Enabled = false;
            txtReceipts.Enabled = false;
            txtRVNumber.Enabled = false;
            txtNameOfPayee.Enabled = false;
            txtSubhead.Enabled = false;
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
        }
    
        private void btnSave_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(txtRVNumber.Text) == true) {
                MessageBox.Show("RV Number is required", "Cash Book");
                txtRVNumber.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtReceipts.Text) == true) {
                MessageBox.Show("Receipts is required", "Cash Book");
                txtReceipts.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSubhead.Text) == true) {
                MessageBox.Show("Subhead is required", "Cash Book");
                txtSubhead.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cboDescription.Text) == true) {
                MessageBox.Show("Description is required", "Cash Book");
                cboDescription.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDebit.Text) == true) {
                MessageBox.Show("Debit Ammount is required", "Cash Book");
                txtDebit.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNameOfPayee.Text) == true) {
                MessageBox.Show("Name of Payee is required", "Cash Book");
                txtNameOfPayee.Focus();
                return;
            }

            if (Utility.IsNumeric(txtDebit.Text) == false) {
                MessageBox.Show("Debit Account must be numeric", "Cash Book");
                return;
            }

            if (isNewRecord == true)
            {
                var transaction = new CreateTransactionDto
                {
                    AccountId = (string)cboAccount.SelectedValue,
                    AmmountWithdrawn = 0,
                    AmmountDeposited = Utility.ParseNumber(txtDebit.Text),
                    NameOfBeneficiary = txtNameOfPayee.Text.ToUpper(),
                    DateOfTransaction = dtpDateOfTransaction.Value,
                    PVOrRVNumber = txtRVNumber.Text.ToUpper(),
                    SubHeadColumn = txtSubhead.Text.ToUpper(),
                    TransactionDescriptionId =(string)cboDescription.SelectedValue,
                    RefNumber = "",
                };
                _transactionService.CreateTransaction(transaction);
                MessageBox.Show("Transaction record was created successfully","Cash Book");
                Reset();
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
    }
}
