using CashBook.Dtos.TransactionDescription;
using CashBook.Services.TransactionDescription;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBook.UI.TransactionDescription
{
    public partial class FrmTransactionDescription : Form
    {
        private readonly ITransactionDescriptionService _transactionDescriptionService;
        public FrmTransactionDescription(ITransactionDescriptionService transactionDescription)
        {
            _transactionDescriptionService = transactionDescription;
            InitializeComponent();
        }

        bool isNewRecord = false;
        string transactionDescriptionId = "";
        bool isEditRecord = false;
        private List<ReadTransactionDescriptionDto> transactionDescriptionList;

        private void FrmTransactionDescription_Load(object sender, EventArgs e)
        {
            InitDataGrid();
            LoadTransactionType();
            Reset();
            
            LoadTransactionDescriptionData();
        }

        private void Enable()
        {
            grid.Enabled = false;
            txtDescription.Enabled = true;
            txtNameOfDescription.Enabled = true;
            cboTypeOfTransaction.Enabled = true;

            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnUndo.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void Disable()
        {
            grid.Enabled = true;
            txtDescription.Enabled = false;
            txtNameOfDescription.Enabled = false;
            cboTypeOfTransaction.Enabled = false;

            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnUndo.Enabled = false;
            btnDelete.Enabled = true;
        }
        private void Clear()
        {
            cboTypeOfTransaction.SelectedIndex = 0;
            txtDescription.Text = "";
            txtNameOfDescription.Text = "";
            transactionDescriptionId = "";
        }
        private void Reset()
        {
            isNewRecord = false;
            isEditRecord = false;
            Clear();
            Disable();
        }
        private void LoadTransactionType()
        {
            var tblTransactionType = new DataTable();

            tblTransactionType.Columns.Add("name", typeof(string));
            tblTransactionType.Columns.Add("value", typeof(string));


            tblTransactionType.Rows.Add("Income", "INCOME");
            tblTransactionType.Rows.Add("Expense", "EXPENSE");

            cboTypeOfTransaction.DisplayMember = "name";
            cboTypeOfTransaction.ValueMember = "value";
            cboTypeOfTransaction.DataSource = tblTransactionType;
        }

           
        private void InitDataGrid()
        {

            grid.Columns.Clear();
            grid.Rows.Clear();
            grid.Columns.Add("colsSNum", "S/No");
            grid.Columns.Add("colsName", "Name");
            grid.Columns.Add("colsTypeOfTransaction", "Type Of Transaction");
            grid.Columns.Add("colsDescription", "Description");

            grid.Columns["colsSNum"].Width = 100;
            grid.Columns["colsName"].Width = 200;
            grid.Columns["colsTypeOfTransaction"].Width = 150;
            grid.Columns["colsDescription"].Width = 200;

            grid.Columns["colsSNum"].ReadOnly = true;
            grid.Columns["colsName"].ReadOnly = true;
            grid.Columns["colsTypeOfTransaction"].ReadOnly = true;
            grid.Columns["colsDescription"].ReadOnly = true;

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isNewRecord = true;
            isEditRecord = false;
            Clear();
            Enable();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isNewRecord = false;
            isEditRecord = true;
            Enable();
        }
        private List<ReadTransactionDescriptionDto> GetAllTransactionDescriptions()
        {
            transactionDescriptionList = _transactionDescriptionService.GetAllTransactionDescriptions();
            return transactionDescriptionList;
        }
        private void LoadTransactionDescriptionData()
        {
            GetAllTransactionDescriptions();
            grid.Rows.Clear();

            if (transactionDescriptionList.Count == 0) return;

            grid.Rows.Add(transactionDescriptionList.Count);

            for (int i = 0; i < transactionDescriptionList.Count; i++)
            {
                grid.Rows[i].Cells["colsSNum"].Value = i + 1;
                grid.Rows[i].Cells["colsName"].Value = transactionDescriptionList[i].DescriptionName;
                grid.Rows[i].Cells["colsTypeOfTransaction"].Value = transactionDescriptionList[i].TransactionType;
                grid.Rows[i].Cells["colsDescription"].Value = transactionDescriptionList[i].Description;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Check if the required data is given
            if (string.IsNullOrWhiteSpace(txtNameOfDescription.Text) == true)
            {
                MessageBox.Show("Transaction Description Name is required","Cash Book");
                txtNameOfDescription.Focus();
                return;
            }

            if (isNewRecord == true && isEditRecord == false)
            {
                var transactionDescription = new CreateTransactionDescriptionDto
                {
                    DescriptionName = txtNameOfDescription.Text.Trim().ToUpper(),
                    TransactionType = (string)cboTypeOfTransaction.SelectedValue,
                    Description = txtDescription.Text.Trim().ToUpper()
                };

                _transactionDescriptionService.CreateTransactionDescription(transactionDescription);
                LoadTransactionDescriptionData();
                Reset();
                MessageBox.Show("Transaction Description record was created successfully","Cash Book");
                return;
            }

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ToForm(transactionDescriptionList[e.RowIndex]);
        }
        private void ToForm(ReadTransactionDescriptionDto dto)
        {
            transactionDescriptionId = dto.TransactionDescriptionId;
            txtNameOfDescription.Text = dto.DescriptionName;
            cboTypeOfTransaction.SelectedValue = dto.TransactionType;
            txtDescription.Text = dto.Description;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(transactionDescriptionId) == true )
            {
                MessageBox.Show("You must select a record", "Cash Book");
                return;
            }
            _transactionDescriptionService.DeleteTransactionDescription(transactionDescriptionId);
            LoadTransactionDescriptionData();
            Reset();
            MessageBox.Show("Transaction Description record was created successfully", "Cash Book");
        }
    }
}
