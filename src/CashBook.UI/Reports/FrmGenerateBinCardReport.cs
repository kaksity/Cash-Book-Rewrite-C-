using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.Services.BinCardItem;
using CashBook.Services.Utility;

namespace CashBook.UI.Reports
{
    public partial class FrmGenerateBinCardReport : Form
    {
        private readonly IBinCardItemService _binCardItemService;
        private readonly IUtilityService _utilityService;

        public FrmGenerateBinCardReport(IBinCardItemService binCardItemService, IUtilityService utilityService)
        {
            _binCardItemService = binCardItemService;
            _utilityService = utilityService;
            InitializeComponent();
        }

        private void FrmGenerateBinCardReport_Load(object sender, EventArgs e)
        {
            LoadBinCardItemsComboBox();
            LoadIssueReceiptComboBox();
            LoadMonthAndYears();
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
        private void LoadBinCardItemsComboBox()
        {
            var binCardItems = _binCardItemService.GetAllBinCardItem();

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

        private void cboFilterYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
