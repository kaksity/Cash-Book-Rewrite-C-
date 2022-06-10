using CashBook.Dtos.Debtor;
using CashBook.Services.Debtor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBook.UI.DebtorLedger
{
    public partial class FrmSearchDebtor : Form
    {
        private readonly IDebtorService _debtorService;


        private List<ReadDebtorDto> listOfDebtors,listOfSearchedDebtors;
        private ReadDebtorDto debtor;

        private bool isOkayClicked = false;

        public FrmSearchDebtor(IDebtorService debtorService)
        {
            _debtorService = debtorService;
            InitializeComponent();
        }
        private void LoadDebtorGridData(List<ReadDebtorDto> data)
        {
            grid.Rows.Clear();
            lblNumberOfRecords.Text = $"Number of Records: {data.Count}";
            if (data.Count == 0)
                return;

            grid.Rows.Add(data.Count);

            for (int i = 0; i < data.Count; i++)
            {
                grid.Rows[i].Cells["colsSNum"].Value = i + 1;
                grid.Rows[i].Cells["colsFullName"].Value = data[i].FullName;
                grid.Rows[i].Cells["colsDebtorLedgerNum"].Value = data[i].DebtorLedgerNumber;
            }
        }
        private void FrmSearchDebtor_Load(object sender, EventArgs e)
        {
            Clear();
            listOfDebtors = null;
            debtor = null;
            listOfSearchedDebtors = null;
            InitDebtorGridData();
            listOfDebtors = _debtorService.GetAllDebtors();
            LoadDebtorGridData(listOfDebtors);
        }
        private void InitDebtorGridData()
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            grid.Columns.Add("colsSNum", "S/No");
            grid.Columns.Add("colsFullName", "Full Name");
            grid.Columns.Add("colsDebtorLedgerNum", "Debtor Ledger Number");

            grid.Columns["colsSNum"].ReadOnly = true;
            grid.Columns["colsFullName"].ReadOnly = true;
            grid.Columns["colsDebtorLedgerNum"].ReadOnly = true;

            grid.Columns["colsFullName"].Width = 250;
            grid.Columns["colsDebtorLedgerNum"].Width = 150;

            grid.AllowDrop = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
        }
        private void Clear()
        {
            isOkayClicked = false;
            lblSelectedRecord.Text = "";
            lblNumberOfRecords.Text = "";
            txtSearchParameter.Text = "";
        }

        private void chkDebtorFullName_CheckedChanged(object sender, EventArgs e)
        {
            listOfDebtors = _debtorService.GetAllDebtors();
            LoadDebtorGridData(listOfDebtors);
            Clear();
        }

        private void chkDebtorLedgerNumber_CheckedChanged(object sender, EventArgs e)
        {
            listOfDebtors = _debtorService.GetAllDebtors();
            LoadDebtorGridData(listOfDebtors);
            Clear();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            debtor = listOfDebtors.Find(t => t.DebtorLedgerNumber == (string)grid.Rows[e.RowIndex].Cells["colsDebtorLedgerNum"].Value);
            lblSelectedRecord.Text = $"( {debtor.FullName} - {debtor.DebtorLedgerNumber} )";
            Program.debtorId = debtor.DebtorId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isOkayClicked = false;
            this.Close();
        }

        private void FrmSearchDebtor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isOkayClicked == false)
            {
                Program.debtorId = "";
            }
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            isOkayClicked = true;
            this.Close();
        }


        private void txtSearchParameter_KeyUp(object sender, KeyEventArgs e)
        {
            if (chkDebtorFullName.Checked == true && chkDebtorLedgerNumber.Checked == false)
            {
                listOfSearchedDebtors = listOfDebtors.Where(t => t.FullName.StartsWith(txtSearchParameter.Text.ToUpper())).ToList();
            }
            else
            {
                listOfSearchedDebtors = listOfDebtors.Where(t => t.DebtorLedgerNumber.StartsWith(txtSearchParameter.Text.ToUpper())).ToList();
            }
            LoadDebtorGridData(listOfSearchedDebtors);
        }

    }
}
