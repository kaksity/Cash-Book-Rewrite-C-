using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CashBook.UI.Utilities;
using CashBook.Dtos.Account;
using CashBook.Services.Account;

namespace CashBook.UI.Account
{
    public partial class FrmAccount : Form
    {
        private readonly IAccountService _accountService;
        public FrmAccount(IAccountService accountService)
        {
            _accountService = accountService;
            InitializeComponent();
        }

        private bool isNewRecord = false;
        private bool isEditRecord = false;

        private void EditEnable()
        {
            txtAccountNumber.Enabled = false;
            txtBankName.Enabled = true;
            txtDescription.Enabled = true;
            txtAccountName.Enabled = true;
            txtOpeningBalance.Enabled = false;
            dtpOpeningDate.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnFind.Enabled = false;
            btnSave.Enabled = true;
            btnUndo.Enabled = true;
            btnDelete.Enabled = false;
        }
        private void Disable()
        {
            dtpOpeningDate.Enabled = false;
            txtAccountNumber.Enabled = false;
            txtBankName.Enabled = false;
            txtDescription.Enabled = false;
            txtAccountName.Enabled = false;
            txtOpeningBalance.Enabled = false;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnFind.Enabled = true;
            btnSave.Enabled = false;
            btnUndo.Enabled = false;
            btnDelete.Enabled = true;
        }
        private void Clear()
        {
            txtAccountNumber.Text = "";
            txtBankName.Text = "";
            txtDescription.Text = "";
            txtAccountName.Text = "";
            txtOpeningBalance.Text = "";
            lblCurrentBalance.Text = "";
        }
        private void Enable()
        {
            txtAccountNumber.Enabled = true;
            txtBankName.Enabled = true;
            txtDescription.Enabled = true;
            txtAccountName.Enabled = true;
            txtOpeningBalance.Enabled = true;
            dtpOpeningDate.Enabled = true;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnFind.Enabled = false;
            btnSave.Enabled = true;
            btnUndo.Enabled = true;
            btnDelete.Enabled = false;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            Enable();
            isNewRecord = true;
            isEditRecord = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditEnable();
            isNewRecord = false;
            isEditRecord = true;
        }

        private void Reset()
        {
            Clear();
            isNewRecord = false;
            isEditRecord = false;
            Disable();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*
            * First Verify that the necessary inputs are given
            */
            if (string.IsNullOrWhiteSpace(txtAccountName.Text) == true)
            {
                txtAccountName.Focus();
                MessageBox.Show("Account Name is required","Cash Book");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text) == true)
            {
                txtAccountNumber.Focus();
                MessageBox.Show("Account Number is required", "Cash Book");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtOpeningBalance.Text) == true)
            {
                txtOpeningBalance.Focus();
                MessageBox.Show("Opening Balance is required", "Cash Book");
                return;
            }
            /*
            * Check whether the Input has a valid data type
            */
            if (Utility.IsNumeric(txtAccountNumber.Text) == false)
            {
                txtAccountNumber.Focus();
                MessageBox.Show("Account Number must be numeric", "Cash Book");
                return;
            }
            if (txtAccountNumber.Text.Trim().Length != 10)
            {
                txtAccountNumber.Focus();
                MessageBox.Show("Account Number must 10 digits", "Cash Book");
                return;
            }
            if (Utility.IsNumeric(txtOpeningBalance.Text) == false)
            {
                txtOpeningBalance.Focus();
                MessageBox.Show("Opening Balance must be numeric", "Cash Book");
                return;
            }

            // Check if we are going to add a new record or edit an existing record
            if (isNewRecord == true && isEditRecord == false)
            {
                var account = new CreateAccountDto
                {
                    AccountName = txtAccountName.Text.ToUpper(),
                    AccountNumber = txtAccountNumber.Text,
                    BankName = txtBankName.Text.ToUpper(),
                    OpeningDate = dtpOpeningDate.Value,
                    Description = txtDescription.Text.ToUpper(),
                    OpeningBalance = Utility.ParseNumber(txtOpeningBalance.Text),
                    CurrentBalance = Utility.ParseNumber(txtOpeningBalance.Text),
                };
                _accountService.CreateAccount(account);
                MessageBox.Show("Account was record was created successfully", "Cash Book");
                Reset();
                return;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
