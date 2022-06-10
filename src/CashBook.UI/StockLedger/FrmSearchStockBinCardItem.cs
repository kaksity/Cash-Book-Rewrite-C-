using CashBook.Dtos.BinCardItem;
using CashBook.Services.BinCardItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBook.UI.StockLedger
{
    public partial class FrmSearchStockBinCardItem : Form
    {
        private readonly IBinCardItemService _binCardItemService;

        private List<ReadBinCardItemDto> binCardItemList, searchBinCardItemList;

        private bool isOkayClicked = false;

        public FrmSearchStockBinCardItem(IBinCardItemService binCardItemService)
        {
            _binCardItemService = binCardItemService;
            InitializeComponent();
        }

        private void FrmSearchStockBinCardItem_Load(object sender, EventArgs e)
        {
            binCardItemList = null;
            searchBinCardItemList = null;
            InitBinCardItemDataGrid();
            binCardItemList = _binCardItemService.GetAllBinCardItem();
            LoadDataGridView(binCardItemList);
        }
        private void LoadDataGridView(List<ReadBinCardItemDto> data)
        {
            grid.Rows.Clear();
            lblNumberOfRecords.Text = $"Number of Records: {data.Count}";
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

            grid.Columns.Add("colsSNum", "S/No");
            grid.Columns.Add("colsBinCardItemName", "Bin Card Item Name");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isOkayClicked = false;
            this.Close();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            isOkayClicked = true;
            this.Close();
        }

        private void FrmSearchStockBinCardItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isOkayClicked == false )
            {
                Program.binCardItemId = "";
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var item = binCardItemList.Find(t => t.BinCardItemName == (string)grid.Rows[e.RowIndex].Cells["colsBinCardItemName"].Value);
            lblSelectedRecord.Text = $"( {item.BinCardItemName} )";
            Program.binCardItemId = item.BinCardItemId;
        }

        private void txtSearchParameter_KeyUp(object sender, KeyEventArgs e)
        {
            searchBinCardItemList = binCardItemList.Where(t => t.BinCardItemName.StartsWith(txtSearchParameter.Text.ToUpper())).ToList();
            LoadDataGridView(searchBinCardItemList);
        }
    }
}
