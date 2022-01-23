using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.UI.Reports;

namespace CashBook.UI.StockLedger
{
    public partial class FrmStockLedgerMenu : Form
    {
        public FrmStockLedgerMenu()
        {
            InitializeComponent();
        }

        private void btnBinCardItem_Click(object sender, EventArgs e)
        {
            var frmBinCardItems = Program.container.GetInstance<FrmBinCardItems>();
            frmBinCardItems.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var frmBinCardReportMenu = Program.container.GetInstance<FrmGenerateBinCardReport>();
            frmBinCardReportMenu.ShowDialog();
        }

        private void btnIssueAndReceiveItem_Click(object sender, EventArgs e)
        {
            var frmBinCard = Program.container.GetInstance<FrmBinCard>();
            frmBinCard.ShowDialog();
        }
    }
}
