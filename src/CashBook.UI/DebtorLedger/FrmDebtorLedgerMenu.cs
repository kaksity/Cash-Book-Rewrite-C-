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

namespace CashBook.UI.DebtorLedger
{
    public partial class FrmDebtorLedgerMenu : Form
    {
        public FrmDebtorLedgerMenu()
        {
            InitializeComponent();
        }

        private void btnDebtor_Click(object sender, EventArgs e)
        {
            var frmDebtor = Program.container.GetInstance<FrmDebtor>();
            frmDebtor.ShowDialog();
        }

        private void btnAdvanceOrRetire_Click(object sender, EventArgs e)
        {
            var frmAdvanceOrRetire = Program.container.GetInstance<FrmDebtorLedger>();
            frmAdvanceOrRetire.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var frmGenerateDebtorLedgerReport = Program.container.GetInstance<FrmGenerateDebtorLedgerReport>();
            frmGenerateDebtorLedgerReport.ShowDialog();
        }
    }
}
