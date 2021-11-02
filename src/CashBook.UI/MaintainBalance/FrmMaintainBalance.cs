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

namespace CashBook.UI.MaintainBalance
{
    public partial class FrmMaintainBalance : Form
    {
        private readonly IAccountService _accountService;
        private readonly IMaintainBalanceService _maintainBalanceService;
        List<ReadMaintainBalanceDto> maintainBalanceList = null;
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

            grid.Columns["colsSNum"].Width = 50;
            grid.Columns["colsDuration"].Width = 200;
            grid.Columns["colsOpeningBalance"].Width = 150;
            grid.Columns["colsClosingBalance"].Width = 150;

            grid.Columns["colsSNum"].ReadOnly = true;
            grid.Columns["colsDuration"].ReadOnly = true;
            grid.Columns["colsOpeningBalance"].ReadOnly = true;
            grid.Columns["colsClosingBalance"].ReadOnly = true;


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
                grid.Rows[i].Cells["colsOpeningBalance"].Value = $"N{data[i].OpeningBalance}";
                grid.Rows[i].Cells["colsClosingBalance"].Value = (data[i].ClosingBalance == 0) ? "Yet to be Closed" : $"N{data[i].ClosingBalance}";
            }
        }
        private void Clear()
        {
            lblCurrentMonth.Text = "";
            lblClosingBalance.Text = "";
            lblOpeningBalance.Text = "";
            lblClosingBalance.Text = "";
            lblStatus.Text = "";
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
            ToForm(maintainBalanceList[e.RowIndex]);
        }

        private void ToForm(ReadMaintainBalanceDto data)
        {

            string duration = data.Duration;
            int month = 0;
            int year = 0;

            if (duration.Length == 6)
            {
                month = Convert.ToInt16(duration.Substring(0, 1));
                year = Convert.ToInt16(duration.Substring(2, 4));
            }
            else if (duration.Length == 7)
            {
                month = Convert.ToInt16(duration.Substring(0, 2));
                year = Convert.ToInt16(duration.Substring(3, 4));
            }
            lblCurrentMonth.Text = $"{GetMonthInWord(month)} {year}";

            lblOpeningBalance.Text = $"N{data.OpeningBalance}";
            lblClosingBalance.Text = (data.ClosingBalance == 0) ? "Yet to be Closed" : $"N{data.ClosingBalance}";
            lblStatus.Text = (data.Status == 0) ? "Month is not Closed" : "Month is Closed";
        
        }
    }
}
