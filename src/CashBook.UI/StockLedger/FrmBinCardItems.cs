using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.Dtos.BinCardItem;
using CashBook.Services.BinCardItem;
using CashBook.UI.Utilities;

namespace CashBook.UI.StockLedger
{
    public partial class FrmBinCardItems : Form
    {
        private readonly IBinCardItemService _binCardItemService;

        private bool isNewRecord = false;
        private bool isEditRecord = false;

        private List<ReadBinCardItemDto> binCardItemList = null;
        private ReadBinCardItemDto binCardItem = null;

        public FrmBinCardItems(IBinCardItemService binCardItemService)
        {
            _binCardItemService = binCardItemService;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataGridView(List<ReadBinCardItemDto> data)
        {
            grid.Rows.Clear();

            if (data.Count == 0) return;

            grid.Rows.Add(data.Count);

            for (int i = 0; i < data.Count; i++)
            {
                grid.Rows[i].Cells["colsSNum"].Value = i + 1;
                grid.Rows[i].Cells["colsBinCardItemName"].Value = data[i].BinCardItemName;
                grid.Rows[i].Cells["colsBinCardItemDescription"].Value = data[i].BinCardItemDescription;
            }
        }

        private void InitBinCardItemDataGrid()
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            grid.Columns.Add("colsSNum","S/No");
            grid.Columns.Add("colsBinCardItemName","Bin Card Item Name");
            grid.Columns.Add("colsBinCardItemDescription", "Bin Card Item Description");

            grid.Columns["colsSNum"].ReadOnly = true;
            grid.Columns["colsBinCardItemName"].ReadOnly = true;
            grid.Columns["colsBinCardItemDescription"].ReadOnly = true;

            grid.Columns["colsBinCardItemName"].Width = 250;
            grid.Columns["colsBinCardItemDescription"].Width = 250;

            grid.AllowDrop = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
        }
        private void Enable()
        {
            txtDescription.Enabled = true;
            txtNameOfBinCardItem.Enabled = true;

            grid.Enabled = false;

            btnNew.Enabled = false;
            btnEdit.Enabled = false;

            btnSave.Enabled = true;
            btnUndo.Enabled = true;

            btnDelete.Enabled = false;
        }
        private void Disable()
        {
            txtNameOfBinCardItem.Enabled = false;
            txtDescription.Enabled = false;

            grid.Enabled = true;

            btnNew.Enabled = true;
            btnEdit.Enabled = true;

            btnSave.Enabled = false;
            btnUndo.Enabled = false;

            btnDelete.Enabled = true;

        }
        private void Clear()
        {
            txtDescription.Clear();
            txtNameOfBinCardItem.Clear();
        }
        private void FrmBinCardItems_Load(object sender, EventArgs e)
        {
            InitBinCardItemDataGrid();
            binCardItemList = _binCardItemService.GetAllBinCardItem();
            LoadDataGridView(binCardItemList);
            Reset();
        }
        private void Reset()
        {
            Clear();
            Disable();
            isNewRecord = false;
            isEditRecord = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isNewRecord = true;
            isEditRecord = false;
            Clear();
            Enable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (binCardItem == null) return;
            isNewRecord = false;
            isEditRecord = true;
            Enable();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameOfBinCardItem.Text) == true)
            {
                MessageBox.Show("Bin Card Item Name is required", Software.GetApplicationName());
                return;
            }
            if (isNewRecord == true && isEditRecord == false)
            {
                var newRecord = new CreateBinCardItemDto
                {
                    BinCardItemName = txtNameOfBinCardItem.Text,
                    BinCardItemDescription = txtDescription.Text
                };
                _binCardItemService.CreateBinCardItem(newRecord);

                MessageBox.Show("Bin Card Item record was created successfully",Software.GetApplicationName());
            }
            else if (isNewRecord == false && isEditRecord == true)
            {
                if (binCardItem == null)
                {
                    MessageBox.Show("You must select a record",Software.GetApplicationName());
                    return;
                }

                var updateDto = new UpdateBinCardItemDto
                {
                    BinCardItemId = binCardItem.BinCardItemId,
                    BinCardItemName = binCardItem.BinCardItemName,
                    BinCardItemDescription = binCardItem.BinCardItemDescription
                };
                _binCardItemService.UpdateBinCardItem(updateDto);
                MessageBox.Show("Bin Card Item record was updated successfully",Software.GetApplicationName());
            }
            binCardItemList = _binCardItemService.GetAllBinCardItem();
            LoadDataGridView(binCardItemList);
            Reset();
        }

        private void ToForm(ReadBinCardItemDto item)
        {
            txtNameOfBinCardItem.Text = item.BinCardItemName;
            txtDescription.Text = item.BinCardItemDescription;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            binCardItem = binCardItemList[e.RowIndex];

            ToForm(binCardItem);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (binCardItem == null)
            {
                MessageBox.Show("You must select a record", Software.GetApplicationName());
                return;
            }

            _binCardItemService.DeleteBinCardItem(binCardItem.BinCardItemId);
            binCardItemList = _binCardItemService.GetAllBinCardItem();
            MessageBox.Show("Bin Card Item record was deleted successfully", Software.GetApplicationName());
            LoadDataGridView(binCardItemList);
            Reset();
        }
    }
}
