using CashBook.Services.Account;
using CashBook.Services.TransactionDescription;
using CashBook.UI.Account;
using CashBook.UI.TransactionDescription;
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
        public FrmRevenueRegisterTransaction(
            ITransactionDescriptionService transactionDescriptionService,
            IAccountService accountService    
        )
        {
            _transactionDescriptionService = transactionDescriptionService;
            _accountService = accountService;
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
    }
}
