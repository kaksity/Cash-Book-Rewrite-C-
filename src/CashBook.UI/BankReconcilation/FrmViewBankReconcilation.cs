using CashBook.Dtos.BankReconcilation;
using CashBook.Services.Account;
using CashBook.Services.BankReconcilation;
using CashBook.Services.MaintainBalance;
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
    public partial class FrmViewBankReconcilation : Form
    {
        private readonly IAccountService _accountService;
        private readonly IBankReconcilationService _bankReconcilationService;
        private readonly IMaintainBalanceService _maintainBalanceService;

        List<ReadBankReconcilationDto> listOfBankReconcilation = null;
        string bankReconcilationId = "";


        public FrmViewBankReconcilation(
            IAccountService accountService,
            IBankReconcilationService bankReconcilationService, 
            IMaintainBalanceService maintainBalanceService
        )
        {
            _maintainBalanceService = maintainBalanceService;
            _bankReconcilationService = bankReconcilationService; 
            _accountService = accountService;
            InitializeComponent();
        }

        private void FrmViewBankReconcilation_Load(object sender, EventArgs e)
        {
            InitGrid();
            LoadAccountComboBox();
            listOfBankReconcilation = _bankReconcilationService.GetBankReconcilationByAccountId((string)cboAccount.SelectedValue);
            LoadGridData(listOfBankReconcilation);
            
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

        private void LoadAccountComboBox()
        {
            var account = _accountService.GetAllAccounts();
            cboAccount.DisplayMember = "AccountName";
            cboAccount.ValueMember = "AccountId";
            cboAccount.DataSource = account;
        }
        private void InitGrid()
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

        private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
            listOfBankReconcilation = _bankReconcilationService.GetBankReconcilationByAccountId((string)cboAccount.SelectedValue);
            LoadGridData(listOfBankReconcilation);
        }
        private void Reset()
        {
            bankReconcilationId = "";
            lblDuration.Text = "";
        }
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            bankReconcilationId = listOfBankReconcilation[e.RowIndex].BankReconcilationId;
            lblDuration.Text = $"Selected Account { cboAccount.SelectedText } for the Month of { listOfBankReconcilation[e.RowIndex].Duration}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ensure that the user selects a record
            if (string.IsNullOrWhiteSpace(bankReconcilationId) == true)
            {
                MessageBox.Show("You Must Select a record", "Cash Book");
                return;
            }

            // Check if the month of transaction has been closed

            var bankReconcilationDto = listOfBankReconcilation.Where( t => t.BankReconcilationId == bankReconcilationId).SingleOrDefault();

            var maintanBalanceDto = _maintainBalanceService.GetMaintainBalanceByAccountIdAndDuration(bankReconcilationDto.AccountId,bankReconcilationDto.Duration);
            if (maintanBalanceDto.Status == 1)
            {
                MessageBox.Show("Cannot perform operation. Financial Month has Been Closed", "Cash Book");
                return;
            }

            // Ask the user whether the bank reconcilation should be deleted or not
            var dialog = MessageBox.Show("Do you wish to delete this bank reconcilation record?", "Cash Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dialog)
            {
                case DialogResult.Yes:

                    _maintainBalanceService.ResetClosingBalance(maintanBalanceDto);
                    _bankReconcilationService.DeleteBankReconcilationRecord(bankReconcilationId);
                    
                    // Get Bank Reconcilation record and display them again
                    listOfBankReconcilation = _bankReconcilationService.GetBankReconcilationByAccountId((string)cboAccount.SelectedValue);
                    LoadGridData(listOfBankReconcilation);

                    MessageBox.Show("Bank reconcilation record was deleted successfully", "Cash Book");
                    Reset();
                    break;
                default:
                    break;
            }
        }
    }
}
