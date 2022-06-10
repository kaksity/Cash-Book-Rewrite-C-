using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.Dtos.DebtorLedger;
using CashBook.Services.Debtor;
using CashBook.Services.DebtorLedger;
using CashBook.Services.Utility;
using CashBook.UI.Utilities;
using CashBook.Services.Account;

namespace CashBook.UI.DebtorLedger
{
    public partial class FrmDebtorLedger : Form
    {
        private readonly IDebtorService _debtorService;
        private readonly IUtilityService _utilityService;
        private readonly IDebtorLedgerService _debtorLedgerService;
        private readonly IAccountService _accountService;
        private string debtorId = "";
        private List<ReadDebtorLedgerDto> listOfDebtorLedger = null;
        private ReadDebtorLedgerDto debtorLedger = null;

        public FrmDebtorLedger(IDebtorService debtorService, IUtilityService utilityService,IDebtorLedgerService debtorLedgerService,IAccountService accountService)
        {
            _debtorService = debtorService;
            _accountService = accountService;
            _utilityService = utilityService;
            _debtorLedgerService = debtorLedgerService;
            InitializeComponent();
        }

        private void LoadAdvanceRetireComboBox()
        {
            var advanceOrRetire = _utilityService.GetAdavnceOrRetire();
            cboAdvanceRetire.DisplayMember = "name";
            cboAdvanceRetire.ValueMember = "value";
            cboAdvanceRetire.DataSource = advanceOrRetire;
        }
        private void Enable()
        {

            cboAdvanceRetire.Enabled = true;
            cboAccounts.Enabled = true;
            dtpDateOfAdvanceRetire.Enabled = true;
            txtAmmount.Enabled = true;
            txtDescription.Enabled = true;
            txtJVPVNumber.Enabled = true;

            grid.Enabled = false;

            btnSearchDebtor.Enabled = true;
            btnNew.Enabled = false;

            btnSave.Enabled = true;
            btnUndo.Enabled = true;

            btnRemove.Enabled = false;
        }
        private void Disable()
        {
            cboAccounts.Enabled = false;
            cboAdvanceRetire.Enabled = false;
            dtpDateOfAdvanceRetire.Enabled = false;
            txtAmmount.Enabled = false;
            txtDescription.Enabled = false;
            txtJVPVNumber.Enabled = false;

            grid.Enabled = true;

            btnNew.Enabled = true;

            btnSearchDebtor.Enabled = false;

            btnSave.Enabled = false;
            btnUndo.Enabled = false;

            btnRemove.Enabled = true;
        }
        private void Reset()
        {
            Clear();
            debtorLedger = null;
            lblSelectedRecord.Text = "";
            Disable();
        }

        private void Clear()
        {
            lblDebtor.Text = "";
            debtorId = "";
            Program.debtorId = "";
            dtpDateOfAdvanceRetire.Value = DateTime.Now;
            txtAmmount.Clear();
            txtDescription.Clear();
            txtJVPVNumber.Clear();
            txtDescription.Clear();
        }
        private void FrmDebtorLedger_Load(object sender, EventArgs e)
        {
            LoadAccountCombox();
            LoadAdvanceRetireComboBox();
            Reset();
            InitDebtorLedgerDataGrid();
            listOfDebtorLedger = _debtorLedgerService.GetAllDebtorLedger();
            LoadGridData(listOfDebtorLedger);
        }

        private void LoadAccountCombox()
        {
            var accounts = _accountService.GetAllAccounts();
            cboAccounts.DataSource = accounts;
            cboAccounts.DisplayMember = "AccountName";
            cboAccounts.ValueMember = "AccountId";
        }
        private void InitDebtorLedgerDataGrid()
        {

            grid.Rows.Clear();
            grid.Columns.Clear();

            grid.Columns.Add("colsSNum","S/No");
            grid.Columns.Add("colsDebtorFullName","Debtor Full Name");
            grid.Columns.Add("colsDebtorLedgerNumber", "Debtor Ledger Number");
            grid.Columns.Add("colsAccount", "Accounts");
            grid.Columns.Add("colsDateOfRetireAdvance","Date Of Advance / Retire");
            grid.Columns.Add("colsAmmountAdvanced","Ammount Advanced");
            grid.Columns.Add("colsPVNumber", "PV Number");
            grid.Columns.Add("colsAmmountRetired","Ammount Retired");
            grid.Columns.Add("colsJVNumber", "JV Number");
            grid.Columns.Add("colsDescription", "Description");

            grid.Columns["colsSNum"].ReadOnly = true;
            grid.Columns["colsDebtorFullName"].ReadOnly = true;
            grid.Columns["colsDebtorLedgerNumber"].ReadOnly = true;
            grid.Columns["colsAccount"].ReadOnly = true;
            grid.Columns["colsDateOfRetireAdvance"].ReadOnly = true;
            grid.Columns["colsAmmountAdvanced"].ReadOnly = true;
            grid.Columns["colsJVNumber"].ReadOnly = true;
            grid.Columns["colsAmmountRetired"].ReadOnly = true;
            grid.Columns["colsPVNumber"].ReadOnly = true;
            grid.Columns["colsDescription"].ReadOnly = true;

            grid.Columns["colsSNum"].Width = 70;
            grid.Columns["colsDebtorFullName"].Width = 200;
            grid.Columns["colsDebtorLedgerNumber"].Width = 200;
            grid.Columns["colsAccount"].Width = 200;
            grid.Columns["colsDateOfRetireAdvance"].Width = 150;
            grid.Columns["colsAmmountAdvanced"].Width = 150;
            grid.Columns["colsJVNumber"].Width = 150;
            grid.Columns["colsAmmountRetired"].Width = 150;
            grid.Columns["colsPVNumber"].Width = 150;
            grid.Columns["colsDescription"].Width = 200;

            grid.AllowDrop = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeRows = false;

        }

        private void LoadGridData(List<ReadDebtorLedgerDto> data)
        {
            grid.Rows.Clear();

            if (data.Count == 0)
                return;

            grid.Rows.Add(data.Count);

            for (int i = 0; i < data.Count; i++)
            {
             
                grid.Rows[i].Cells["colsSNum"].Value = i + 1;
                grid.Rows[i].Cells["colsDebtorFullName"].Value = data[i].DebtorFullName;
                grid.Rows[i].Cells["colsDebtorLedgerNumber"].Value = data[i].DebtorLedgerNumber;
                grid.Rows[i].Cells["colsAccount"].Value = data[i].AccountName;
                grid.Rows[i].Cells["colsDateOfRetireAdvance"].Value = Utility.FormatDate(data[i].DateOfAdvanceRetire);
                grid.Rows[i].Cells["colsAmmountAdvanced"].Value = $"N{Utility.FormatDecimal(data[i].AmmountAdvanced)}";
                grid.Rows[i].Cells["colsJVNumber"].Value = data[i].JvNumber;
                grid.Rows[i].Cells["colsAmmountRetired"].Value = $"N{Utility.FormatDecimal(data[i].AmmountRetired)}";
                grid.Rows[i].Cells["colsPVNumber"].Value = data[i].PvNumber;
                grid.Rows[i].Cells["colsDescription"].Value = data[i].Description;
            }
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            Enable();
        }

        private void btnLoadAllData_Click(object sender, EventArgs e)
        {
            listOfDebtorLedger = _debtorLedgerService.GetAllDebtorLedger();
            LoadGridData(listOfDebtorLedger);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboAccounts.SelectedValue == null)
            {
                MessageBox.Show("Account is required", Software.GetApplicationName());
                cboAccounts.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(Program.debtorId) == true || string.IsNullOrWhiteSpace(lblDebtor.Text) == true)
            {
                MessageBox.Show("Debtor is required", Software.GetApplicationName());
                btnSearchDebtor.Focus();
                return;
            }
            if (cboAdvanceRetire.SelectedValue == null)
            {
                MessageBox.Show("Advance / Retire is required",Software.GetApplicationName());
                cboAdvanceRetire.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtJVPVNumber.Text) == true)
            {
                MessageBox.Show("JV Number / RV Number is required", Software.GetApplicationName());
                txtJVPVNumber.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmmount.Text) == true)
            {
                MessageBox.Show("Ammount is required",Software.GetApplicationName());
                txtAmmount.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text) == true)
            {
                MessageBox.Show("Description is required", Software.GetApplicationName());
                txtDescription.Focus();
                return;
            }

            if (Utility.IsNumeric(txtAmmount.Text) == false)
            {
                MessageBox.Show("Ammount must be numeric",Software.GetApplicationName());
                txtAmmount.Focus();
                return;
            }

            var debtorLedger = new CreateDebtorLedgerDto
            {
                DebtorId = Program.debtorId,
                AccountId = (string)cboAccounts.SelectedValue,
                DateOfAdvanceRetire = dtpDateOfAdvanceRetire.Value,
                Description = txtDescription.Text.Trim()
            };

            if ((string) cboAdvanceRetire.SelectedValue == "ADVANCE")
            {
                debtorLedger.AmmountAdvanced = Utility.ParseNumber(txtAmmount.Text);
                debtorLedger.AmmountRetired = 0;
                debtorLedger.PvNumber = txtJVPVNumber.Text.Trim().ToUpper();
                debtorLedger.JvNumber = "-";
            }
            else
            {
                debtorLedger.AmmountRetired = Utility.ParseNumber(txtAmmount.Text);
                debtorLedger.AmmountAdvanced = 0;
                debtorLedger.JvNumber = txtJVPVNumber.Text.Trim().ToUpper();
                debtorLedger.PvNumber = "-";
            }

            _debtorLedgerService.CreateDebtorLedger(debtorLedger);
            // Write the code to store the data in the database
            MessageBox.Show("Debtor Ledger record was created successfully",Software.GetApplicationName());
            listOfDebtorLedger = _debtorLedgerService.GetAllDebtorLedger();
            LoadGridData(listOfDebtorLedger);
            Reset();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (debtorLedger == null)
            {
                MessageBox.Show("You must select a record", Software.GetApplicationName());
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this record?",Software.GetApplicationName(),MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
            {
                Reset();
                return;
            }

            _debtorLedgerService.DeleteDebtorLedger(debtorLedger.DebtorLedgerId);
            MessageBox.Show("Debtor Ledger record was deleted successfully",Software.GetApplicationName());
            Reset();

            listOfDebtorLedger = _debtorLedgerService.GetAllDebtorLedgerByDebtorId(debtorId);
            LoadGridData(listOfDebtorLedger);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            listOfDebtorLedger = _debtorLedgerService.GetAllDebtorLedgerByDebtorId(debtorId);
            LoadGridData(listOfDebtorLedger);
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            debtorLedger = listOfDebtorLedger[e.RowIndex];

            lblSelectedRecord.Text = $"Selected {debtorLedger.DebtorFullName} with Debtor Ledger Number {debtorLedger.DebtorLedgerNumber} in {debtorLedger.AccountName} on {Utility.FormatDate(debtorLedger.DateOfAdvanceRetire)}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchDebtor_Click(object sender, EventArgs e)
        {
            var frmSearchDebtor = Program.container.GetInstance<FrmSearchDebtor>();
            frmSearchDebtor.ShowDialog();

            if (string.IsNullOrWhiteSpace(Program.debtorId) == true)
                return;

            var debtor = _debtorService.GetDebtorByDebtorId(Program.debtorId);

            if (debtor == null)
            {
                MessageBox.Show("Invalid Debtor",Software.GetApplicationName());
                return;
            }

            lblDebtor.Text = $"{debtor.FullName} - {debtor.DebtorLedgerNumber}";
        }

        private void btnSearchFilterDebtor_Click(object sender, EventArgs e)
        {
            var frmSearchDebtor = Program.container.GetInstance<FrmSearchDebtor>();
            frmSearchDebtor.ShowDialog();

            debtorId = Program.debtorId;
            Program.debtorId = "";


            if (string.IsNullOrWhiteSpace(debtorId) == true)
                return;

            var debtor = _debtorService.GetDebtorByDebtorId(debtorId);

            if (debtor == null)
            {
                MessageBox.Show("Invalid Debtor", Software.GetApplicationName());
                return;
            }

            lblFilterRecord.Text = $"{debtor.FullName} - {debtor.DebtorLedgerNumber}";
        }
    }
}
