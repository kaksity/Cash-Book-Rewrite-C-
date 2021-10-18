using CashBook.Dtos.Account;
using CashBook.Services.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBook.UI.Account
{
    public partial class FrmSearchAccount : Form
    {
        private readonly IAccountService _accountService;

        bool isSelectedRecord = false;

        public FrmSearchAccount(IAccountService accountService)
        {
            _accountService = accountService;
            InitializeComponent();
        }

        private List<ReadAccountDto> accountList;

        private void InitGrid()
        {
            grid.Columns.Clear();
            grid.Rows.Clear();


            grid.Columns.Add("colsSNum", "S/No");
            grid.Columns.Add("colsAccountName", "Account Name");
            grid.Columns.Add("colsAccountNumber", "Account Number");
            grid.Columns.Add("colsOpeningBalance", "Opening Balance");
            grid.Columns.Add("colsCurrentBalance", "Current Balance");
            grid.Columns.Add("colsDateOfOpening", "Date Of Opening");

            grid.Columns["colsSNum"].ReadOnly = true;
            grid.Columns["colsAccountName"].ReadOnly = true;
            grid.Columns["colsAccountNumber"].ReadOnly = true;
            grid.Columns["colsOpeningBalance"].ReadOnly = true;
            grid.Columns["colsCurrentBalance"].ReadOnly = true;
            grid.Columns["colsDateOfOpening"].ReadOnly = true;

            grid.Columns["colsSNum"].Width = 70;
            grid.Columns["colsAccountName"].Width = 200;
            grid.Columns["colsAccountNumber"].Width = 200;
            grid.Columns["colsOpeningBalance"].Width = 200;
            grid.Columns["colsCurrentBalance"].Width = 200;
            grid.Columns["colsDateOfOpening"].Width = 200;

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
        
    }

        private List<ReadAccountDto>GetAllAccounts()
        {
            return _accountService.GetAllAccounts();
        }

        private void LoadGridData(List<ReadAccountDto> data)
        {

            grid.Rows.Clear();

            if (data.Count == 0) return;

            grid.Rows.Add(data.Count);
            lblNumberOfFoundRecord.Text = $"Number of Records: {data.Count}";
            for (int i = 0; i < data.Count; i++)
            {
                grid.Rows[i].Cells["colsSNum"].Value = i + 1;
                grid.Rows[i].Cells["colsAccountName"].Value = data[i].AccountName;
                grid.Rows[i].Cells["colsAccountNumber"].Value = data[i].AccountNumber;
                grid.Rows[i].Cells["colsOpeningBalance"].Value = data[i].OpeningBalance;
                grid.Rows[i].Cells["colsCurrentBalance"].Value = data[i].CurrentBalance;
                grid.Rows[i].Cells["colsDateOfOpening"].Value = data[i].OpeningDate;
            }
        }

        private void FrmSearchAccount_Load(object sender, EventArgs e)
        {
            InitGrid();
            accountList = GetAllAccounts();
            LoadGridData(accountList);
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var account = accountList[e.RowIndex];
            Program.accountId = account.AccountId;
            lblSearchResult.Text = $"({account.AccountName}-{account.AccountNumber})";
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            isSelectedRecord = true;
            this.Close();
        }

        private void FrmSearchAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSelectedRecord == false)
            {
                Program.accountId = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
