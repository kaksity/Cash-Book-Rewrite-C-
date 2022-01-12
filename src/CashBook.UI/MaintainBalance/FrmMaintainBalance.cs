using CashBook.Dtos.MaintainBalance;
using CashBook.Models.MaintainBalance;
using CashBook.Services.Account;
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
using CashBook.UI.Utilities;

namespace CashBook.UI.MaintainBalance
{
    public partial class FrmMaintainBalance : Form
    {
        private readonly IAccountService _accountService;
        private readonly IMaintainBalanceService _maintainBalanceService;
        private List<ReadMaintainBalanceDto> maintainBalanceList = null;
        private ReadMaintainBalanceDto maintainBalance = null;
        public FrmMaintainBalance(IAccountService accountService, IMaintainBalanceService maintainBalance)
        {
            _maintainBalanceService = maintainBalance;
            _accountService = accountService;
            InitializeComponent();
        }

        private void FrmMaintainBalance_Load(object sender, EventArgs e)
        {
            InitGrid();
            LoadAccountComboBox();
            maintainBalanceList = GetMaintainBalanceByAccountId((string)cboAccount.SelectedValue);
            LoadGridData(maintainBalanceList);
        }

        

        private void LoadAccountComboBox()
        {
            var account = _accountService.GetAllAccounts();
            cboAccount.DisplayMember = "AccountName";
            cboAccount.ValueMember = "AccountId";
            cboAccount.DataSource = account;
        }
        private List<ReadMaintainBalanceDto> GetMaintainBalanceByAccountId(string accountId)
        {
            var data = _maintainBalanceService.GetAllMaintainBalanceByAccountId(accountId);
            return data;
        }
        private void InitGrid()
        {
            grid.Columns.Clear();
            grid.Rows.Clear();

            grid.Columns.Add("colsSNum", "S/No");
            grid.Columns.Add("colsDuration", "Duration");
            grid.Columns.Add("colsOpeningBalance", "Opening Balance");
            grid.Columns.Add("colsClosingBalance", "Closing Balance");
            grid.Columns.Add("colsHasBeenEdited","Has Been Edited");

            grid.Columns["colsSNum"].Width = 50;
            grid.Columns["colsDuration"].Width = 200;
            grid.Columns["colsOpeningBalance"].Width = 150;
            grid.Columns["colsClosingBalance"].Width = 150;
            grid.Columns["colsHasBeenEdited"].Width = 150;

            grid.Columns["colsSNum"].ReadOnly = true;
            grid.Columns["colsDuration"].ReadOnly = true;
            grid.Columns["colsOpeningBalance"].ReadOnly = true;
            grid.Columns["colsClosingBalance"].ReadOnly = true;
            grid.Columns["colsHasBeenEdited"].ReadOnly = true;

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
        }

        private string GetMonthInWord(int month)
        {
            //List<string> months = new List<string>;
            string[] months = new string[12];


            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            return months[month - 1];
        }

        private void LoadGridData(List<ReadMaintainBalanceDto> data)
        {
            grid.Rows.Clear();

            if (data == null || data.Count == 0) return;

            grid.Rows.Add(data.Count);

            for (int i = 0; i < data.Count; i++)
            {
                string duration = data[i].Duration;
                int month = 0;
                int year = 0;

                if (duration.Length == 6) {
                    month = Convert.ToInt16(duration.Substring(0, 1));
                    year = Convert.ToInt16(duration.Substring(2, 4));
                }
                else if (duration.Length == 7)
                {
                    month = Convert.ToInt16(duration.Substring(0, 2));
                    year = Convert.ToInt16(duration.Substring(3, 4));
                }
                grid.Rows[i].Cells["colsSNum"].Value = i + 1;

                grid.Rows[i].Cells["colsDuration"].Value = $"{GetMonthInWord(month)} {year}";
                grid.Rows[i].Cells["colsOpeningBalance"].Value = $"N{Utility.FormatDecimal(data[i].OpeningBalance)}";
                grid.Rows[i].Cells["colsClosingBalance"].Value = (data[i].ClosingBalance == 0) ? "Yet to be Closed" : $"N{Utility.FormatDecimal(data[i].ClosingBalance)}";
                grid.Rows[i].Cells["colsHasBeenEdited"].Value = (data[i].IsEdited == false) ? "No" : "Yes";
            }
        }
        private void Clear()
        {
            lblCurrentMonth.Text = "";
            lblClosingBalance.Text = "";
            lblOpeningBalance.Text = "";
            lblClosingBalance.Text = "";
            lblStatus.Text = "";
            lblHasBeenEdited.Text = "";
            maintainBalance = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            maintainBalanceList = GetMaintainBalanceByAccountId((string)cboAccount.SelectedValue);
            Clear();
            LoadGridData(maintainBalanceList);
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            maintainBalance = maintainBalanceList[e.RowIndex];
            ToForm(maintainBalanceList[e.RowIndex]);
        }

        private void ToForm(ReadMaintainBalanceDto data)
        {

            var splitedDuration = data.Duration.Split('.');
            int month = Convert.ToInt16(splitedDuration[0]);
            int year = Convert.ToInt16(splitedDuration[1]);
            
            lblCurrentMonth.Text = $"{GetMonthInWord(month)} {year}";

            lblOpeningBalance.Text = $"N{Utility.FormatDecimal(data.OpeningBalance)}";
            lblClosingBalance.Text = (data.ClosingBalance == 0) ? "Yet to be Closed" : $"N{Utility.FormatDecimal(data.ClosingBalance)}";
            lblStatus.Text = (data.Status == 0) ? "Month is not Closed" : "Month is Closed";
            lblHasBeenEdited.Text = (data.IsEdited == false) ? "No" : "Yes";
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnCloseTransaction_Click(object sender, EventArgs e)
        {
            if (maintainBalance == null)
            {
                MessageBox.Show("You must select a record", Software.GetApplicationName());
                return;
            }
            if (maintainBalance.Status != 0)
            {
                MessageBox.Show("Financial Month record has already been closed", Software.GetApplicationName());
                return;
            }
            var closeTransaction = new UpdateMaintainBalanceDto
            {
                MaintainBalanceId = maintainBalance.MaintainBalanceId,
                AccountId = maintainBalance.AccountId,
                ClosingBalance = maintainBalance.OpeningBalance,
                Duration = maintainBalance.Duration,
                Status = 1
            };
            _maintainBalanceService.CloseMaintainBalance(closeTransaction);
            MessageBox.Show("Financial Month was closed successfully", Software.GetApplicationName());
            maintainBalanceList = GetMaintainBalanceByAccountId((string)cboAccount.SelectedValue);
            LoadGridData(maintainBalanceList);
            Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (maintainBalance == null)
            {
                MessageBox.Show("You must select a record", Software.GetApplicationName());
                return;
            }
            if(MessageBox.Show("Are you sure you want to delete this record?",Software.GetApplicationName(),MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                Clear();
                return;
            }
            _maintainBalanceService.DeleteMaintainBalance(maintainBalance.MaintainBalanceId);
            MessageBox.Show("Financial Month record was deleted successfully", Software.GetApplicationName());
            maintainBalanceList = GetMaintainBalanceByAccountId((string)cboAccount.SelectedValue);
            LoadGridData(maintainBalanceList);
            Clear();
        }

        private void btnRecalculateMaintainBalance_Click(object sender, EventArgs e)
        {
            // Get all the maintain balances

            var editedMaintainBalances = _maintainBalanceService.GetEditedMaintainBalanceByAccountId((string)cboAccount.SelectedValue);

            for (int i = 0; i < editedMaintainBalances.Count; i++)
            {
                var result = _maintainBalanceService.RecalculateMaintainBalance(editedMaintainBalances[i]);

                if (i != editedMaintainBalances.Count - 1)
                    editedMaintainBalances[i + 1].OpeningBalance = editedMaintainBalances[i].ClosingBalance;
            }

            MessageBox.Show("Recalculation was complete",Software.GetApplicationName());
            maintainBalanceList = GetMaintainBalanceByAccountId((string)cboAccount.SelectedValue);
            LoadGridData(maintainBalanceList);
        }
    }
}
