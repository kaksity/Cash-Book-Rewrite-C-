using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.Dtos.BinCard;
using CashBook.Services.BinCard;
using CashBook.Services.BinCardItem;
using CashBook.Services.Utility;
using CashBook.UI.Utilities;

namespace CashBook.UI.StockLedger
{
    public partial class FrmBinCard : Form
    {
        private readonly IBinCardItemService _binCardItemService;
        private readonly IUtilityService _utilityService;
        private readonly IBinCardService _binCardService;

        private bool isNewRecord = false;
        private bool isEditedRecord = false;

        private string binCardId = "";
        private List<ReadBinCardDto> binCardsList = null;


        public FrmBinCard(IBinCardItemService binCardItemService,IUtilityService utilityService, IBinCardService binCardService)
        {
            _binCardItemService = binCardItemService;
            _utilityService = utilityService;
            _binCardService = binCardService;
            InitializeComponent();
        }

        

        private void FrmBinCard_Load(object sender, EventArgs e)
        {
            LoadBinCardItemsComboBox();
            LoadIssueReceiptComboBox();
            LoadMonthAndYears();
            Reset();
            InitBinCardDataGridView();

            binCardsList = _binCardService.GetAllBinCards();
            LoadGridData(binCardsList);
        }

        private void LoadMonthAndYears()
        {
            var tblMonths = _utilityService.GetMonths();
            var tblYears = _utilityService.GetYears();

            cboFilterMonths.DataSource = tblMonths;
            cboFilterMonths.DisplayMember = "name";
            cboFilterMonths.ValueMember = "value";

            cboFilterYears.DataSource = tblYears;
            cboFilterYears.DisplayMember = "name";
            cboFilterYears.ValueMember = "value";
        }
        
        private void InitBinCardDataGridView()
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            grid.Columns.Add("colsSNum","S/No");
            grid.Columns.Add("colsBinCardItem","Bin Card Item");
            grid.Columns.Add("colsSivSrvOthers", "Siv, Srv & Others");
            grid.Columns.Add("colsDateOfIssueOrReceipt"," Date of Issue / Receipt");
            grid.Columns.Add("colsReceivedQuanity","Received Quantity");
            grid.Columns.Add("colsIssuedQuantity","Issued Quantity");
            grid.Columns.Add("colsUnitPrice","Unit Price");
            grid.Columns.Add("colsDescription","Description");

            grid.Columns["colsSNum"].ReadOnly = true;
            grid.Columns["colsBinCardItem"].ReadOnly = true;
            grid.Columns["colsDateOfIssueOrReceipt"].ReadOnly = true;
            grid.Columns["colsSivSrvOthers"].ReadOnly = true;
            grid.Columns["colsReceivedQuanity"].ReadOnly = true;
            grid.Columns["colsIssuedQuantity"].ReadOnly = true;
            grid.Columns["colsUnitPrice"].ReadOnly = true;
            grid.Columns["colsDescription"].ReadOnly = true;

            grid.Columns["colsSivSrvOthers"].Width = 150;
            grid.Columns["colsDateOfIssueOrReceipt"].Width = 200;
            grid.Columns["colsReceivedQuanity"].Width = 200;
            grid.Columns["colsIssuedQuantity"].Width = 200;
            grid.Columns["colsDescription"].Width = 250;

            grid.AllowDrop = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
           
        }

        private void Enable()
        {
            cboBinCardItems.Enabled = true;
            cboIssueReceipt.Enabled = true;
            txtDescription.Enabled = true;
            txtQuantity.Enabled = true;
            txtUnitPrice.Enabled = true;

            grid.Enabled = false;

            btnNew.Enabled = false;

            btnUndo.Enabled = true;
            btnSave.Enabled = true;



        }
        private void Disable()
        {

            cboBinCardItems.Enabled = false;
            cboIssueReceipt.Enabled = false;
            txtDescription.Enabled = false;
            txtQuantity.Enabled = false;
            txtUnitPrice.Enabled = false;

            grid.Enabled = true;

            btnNew.Enabled = true;

            btnUndo.Enabled = false;
            btnSave.Enabled = false;


        }
        private void Clear()
        {
            txtDescription.Text = "";
            txtQuantity.Text = "";
            txtUnitPrice.Text = "";
            txtSivSrvOtherInvoices.Text = "";

            lblSelectedRecord.Text = "";

            cboIssueReceipt.SelectedValue = 0;
            binCardId = "";
        }
        private void Reset()
        {
            Disable();
            Clear();
            isNewRecord = false;
            isEditedRecord = false;
        }

        private void LoadGridData(List<ReadBinCardDto> data)
        {

            grid.Rows.Clear();

            if (data.Count == 0) return;

            grid.Rows.Add(data.Count);

            for (int i = 0; i < data.Count; i++)
            {
                grid.Rows[i].Cells["colsSNum"].Value = i + 1;
                grid.Rows[i].Cells["colsBinCardItem"].Value = data[i].BinCardItemName;
                grid.Rows[i].Cells["colsSivSrvOthers"].Value = data[i].SivSrvOthers;
                grid.Rows[i].Cells["colsDateOfIssueOrReceipt"].Value = Utility.FormatDate(data[i].DateOfIssueOrReceipt);
                grid.Rows[i].Cells["colsReceivedQuanity"].Value = Utility.FormatDecimal(data[i].RecievedQuantity);
                grid.Rows[i].Cells["colsIssuedQuantity"].Value = Utility.FormatDecimal(data[i].IssuedQuantity);
                grid.Rows[i].Cells["colsUnitPrice"].Value = $"N{Utility.FormatDecimal(data[i].UnitPrice)}";
                grid.Rows[i].Cells["colsDescription"].Value = data[i].Description;
            }
        }
            
        private void LoadBinCardItemsComboBox()
        {
            var binCardItems = _binCardItemService.GetAllBinCardItem();

            cboBinCardItems.DisplayMember = "BinCardItemName";
            cboBinCardItems.ValueMember = "BinCardItemId";
            cboBinCardItems.DataSource = binCardItems;

            cboFilterBinCardItems.DisplayMember = "BinCardItemName";
            cboFilterBinCardItems.ValueMember = "BinCardItemId";
            cboFilterBinCardItems.DataSource = binCardItems;

        }
        private void LoadIssueReceiptComboBox()
        {
            var tblIssueOrReceipt = _utilityService.GetIssueOrReceipt();

            cboIssueReceipt.DataSource = tblIssueOrReceipt;
            cboIssueReceipt.ValueMember = "value";
            cboIssueReceipt.DisplayMember = "name";
        }
        private void btnAddBinCardItem_Click(object sender, EventArgs e)
        {
            var frmBinCardItem = Program.container.GetInstance<FrmBinCardItems>();
            frmBinCardItem.ShowDialog();
            LoadBinCardItemsComboBox();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            Enable();
            isNewRecord = true;
            isEditedRecord = false;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cboBinCardItems.SelectedValue == null)
            {
                MessageBox.Show("Bin Card Iems is required", Software.GetApplicationName());
                cboBinCardItems.Focus();
                return;
            }
            if (cboIssueReceipt.SelectedValue == null)
            {
                MessageBox.Show("Issue/Receipt is required", Software.GetApplicationName());
                cboBinCardItems.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSivSrvOtherInvoices.Text) == true)
            {
                MessageBox.Show("Siv Srv & Other Invoices is required", Software.GetApplicationName());
                txtQuantity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) == true)
            {
                MessageBox.Show("Quantity is required",Software.GetApplicationName());
                txtQuantity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text) == true)
            {
                MessageBox.Show("Unit price is required",Software.GetApplicationName());
                txtUnitPrice.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text) == true)
            {
                MessageBox.Show("Description is required", Software.GetApplicationName());
                txtDescription.Focus();
                return;
            }
            if (Utility.IsNumeric(txtQuantity.Text) == false)
            {
                MessageBox.Show("Quantity must be numeric", Software.GetApplicationName());
                txtQuantity.Focus();
                return;
            }
            if (Utility.IsNumeric(txtUnitPrice.Text) == false)
            {
                MessageBox.Show("Unit price must be numeric", Software.GetApplicationName());
                txtUnitPrice.Focus();
                return;
            }

            if (isNewRecord == true && isEditedRecord == false)
            {
                var newRecord = new CreateBinCardDto {
                    BinCardItemId = (string)cboBinCardItems.SelectedValue,
                    DateOfIssueOrReceipt = dtpDateOfIssueReceipt.Value,
                    SivSrvOthers = txtSivSrvOtherInvoices.Text,
                    Description = txtDescription.Text,
                    UnitPrice = Utility.ParseNumber(txtUnitPrice.Text)
                };

                if ((string) cboIssueReceipt.SelectedValue == "ISSUE")
                {
                    newRecord.IssuedQuantity = Utility.ParseNumber(txtQuantity.Text);
                    newRecord.RecievedQuantity = 0;
                }
                else
                {
                    newRecord.IssuedQuantity = 0;
                    newRecord.RecievedQuantity = Utility.ParseNumber(txtQuantity.Text);
                }

                _binCardService.CreateNewBinCard(newRecord);
                MessageBox.Show("Bin Card record was created successfully",Software.GetApplicationName());
            }
            binCardsList = _binCardService.GetAllBinCards();
            LoadGridData(binCardsList);
            Reset();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var binCard = binCardsList[e.RowIndex];
            binCardId = binCard.BinCardId;

            lblSelectedRecord.Text = $"Selected Bin Card Item: {binCard.BinCardItemName} On: {binCard.DateOfIssueOrReceipt}";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (binCardId == "")
            {
                MessageBox.Show("You must select a record",Software.GetApplicationName());
                return;
            }

            if (MessageBox.Show("Are you sure to delete this record?",Software.GetApplicationName(),MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
            {
                Reset();
                return;
            }
            _binCardService.DeleteBinCard(binCardId);
            MessageBox.Show("Bin Card record was deleted successfully",Software.GetApplicationName());

            binCardsList = _binCardService.GetAllBinCards();
            LoadGridData(binCardsList);
        }


        private void btnLoadAllData_Click(object sender, EventArgs e)
        {
            binCardsList = _binCardService.GetAllBinCards();
            LoadGridData(binCardsList);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            binCardsList = _binCardService.GetBinCardsByBinCardItemsMonthAndYear((string)cboFilterBinCardItems.SelectedValue, (int)cboFilterMonths.SelectedValue, (int)cboFilterYears.SelectedValue);
            LoadGridData(binCardsList);
        }
    }
}
