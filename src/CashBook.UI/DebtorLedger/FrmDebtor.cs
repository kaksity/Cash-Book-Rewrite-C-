using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.Dtos.Debtor;
using CashBook.Services.Debtor;
using CashBook.Services.Utility;
using CashBook.UI.Utilities;

namespace CashBook.UI.DebtorLedger
{
    public partial class FrmDebtor : Form
    {
        private readonly IDebtorService _debtorService;
        

        private List<ReadDebtorDto> listOfDebtors = null;
        private ReadDebtorDto debtor = null;

        private bool isNewRecord = false;
        private bool isEditRecord = false;

        public FrmDebtor(IDebtorService debtorService)
        {
            _debtorService = debtorService;
            
            InitializeComponent();
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
            grid.Columns["colsDebtorLedgerNum"].Width = 250;

            grid.AllowDrop = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
        }
        private void LoadDebtorGridData(List<ReadDebtorDto> data)
        {
            grid.Rows.Clear();

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
        private void Enable()
        {
            txtFullName.Enabled = true;
            txtDebtorLedgerNumber.Enabled = true;

            grid.Enabled = false;

            btnNew.Enabled = false;
            btnEdit.Enabled = false;

            btnSave.Enabled = true;
            btnUndo.Enabled = true;

            btnDelete.Enabled = false;
        }
        private void Disable()
        {
            txtFullName.Enabled = false;
            txtDebtorLedgerNumber.Enabled = false;

            grid.Enabled = true;

            btnNew.Enabled = true;
            btnEdit.Enabled = true;

            btnSave.Enabled = false;
            btnUndo.Enabled = false;

            btnDelete.Enabled = true;

        }
        private void Reset()
        {
            Clear();
            Disable();
            debtor = null;
            isNewRecord = false;
            isEditRecord = false;
        }

        private void Clear()
        {
            txtFullName.Clear();
            txtDebtorLedgerNumber.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDebtor_Load(object sender, EventArgs e)
        {
            InitDebtorGridData();
            Reset();
            listOfDebtors = _debtorService.GetAllDebtors();
            LoadDebtorGridData(listOfDebtors);
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
            if (debtor == null)
            {
                MessageBox.Show("You must select a record", Software.GetApplicationName());
                return;
            }
            Enable();
            txtDebtorLedgerNumber.Enabled = false;
            isNewRecord = false;
            isEditRecord = true;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) == true)
            {
                MessageBox.Show("Full Name is required", Software.GetApplicationName());
                txtFullName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDebtorLedgerNumber.Text) == true)
            {
                MessageBox.Show("Debtor Ledger Number is required", Software.GetApplicationName());
                txtDebtorLedgerNumber.Focus();
                return;
            }

            

            if (isNewRecord == true && isEditRecord == false)
            {
                var results = _debtorService.GetDebtorByDebtorLedgerNumber(txtDebtorLedgerNumber.Text);

                if (results != null)
                {
                    MessageBox.Show("Debtor with this Debtor Ledger Number already exist", Software.GetApplicationName());
                    txtDebtorLedgerNumber.Focus();
                    return;
                }

                _debtorService.CreateDebtor(new CreateDebtorDto {
                    FullName = txtFullName.Text,
                    DebtorLedgerNumber = txtDebtorLedgerNumber.Text
                });

                MessageBox.Show("Debtor record was created successfully",Software.GetApplicationName());

            }
            else if (isNewRecord == false && isEditRecord == true)
            {
                _debtorService.UpdateDebtor(new UpdateDebtorDto
                {
                    DebtorId = debtor.DebtorId,
                    FullName = txtFullName.Text,
                    DebtorLedgerNumber = txtDebtorLedgerNumber.Text
                });

                MessageBox.Show("Debtor record was updated successfully", Software.GetApplicationName());
            }

            Reset();
            listOfDebtors = _debtorService.GetAllDebtors();
            LoadDebtorGridData(listOfDebtors);
        }

        private void ToForm(ReadDebtorDto data)
        {
            txtFullName.Text = data.FullName;
            txtDebtorLedgerNumber.Text = data.DebtorLedgerNumber;
        }
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            debtor = listOfDebtors[e.RowIndex];

            ToForm(debtor);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(debtor == null)
            {
                MessageBox.Show("You must select a record", Software.GetApplicationName());
                return;
            }

            if(MessageBox.Show("Are you sure you want to delete this record?",Software.GetApplicationName(),MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
            {
                Reset();
                return;
            }

            _debtorService.DeleteDebtor(debtor.DebtorId);
            Reset();
            MessageBox.Show("Debtor Record was deleted successfully",Software.GetApplicationName());
            listOfDebtors = _debtorService.GetAllDebtors();
            LoadDebtorGridData(listOfDebtors);
        }
    }
}
