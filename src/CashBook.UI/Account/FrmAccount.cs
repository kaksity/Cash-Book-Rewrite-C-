using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CashBook.UI.Account
{
    public partial class FrmAccount : Form
    {
        public FrmAccount()
        {
            InitializeComponent();
        }

        private bool newRecord = false;
        private bool editRecord = false;

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
            newRecord = true;
            editRecord = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditEnable();
            newRecord = false;
            editRecord = true;
        }

        private void Reset()
        {
            Clear();
            newRecord = false;
            editRecord = false;
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
    }
}
