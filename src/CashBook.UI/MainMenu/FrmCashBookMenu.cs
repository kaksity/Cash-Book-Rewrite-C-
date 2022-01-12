using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.UI.Account;
using CashBook.UI.TransactionDescription;
using CashBook.UI.Transaction;
using CashBook.UI.Reports;
using CashBook.UI.MaintainBalance;

namespace CashBook.UI.MainMenu
{
    public partial class FrmCashBookMenu : Form
    {
        public FrmCashBookMenu()
        {
            InitializeComponent();
        }

        private void FrmCashBookMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            var frmAccounts = Program.container.GetInstance<FrmAccount>();
            frmAccounts.ShowDialog();
        }

        private void btnTransactionDescriptionItem_Click(object sender, EventArgs e)
        {
            var frmTransactionDescriptionItem = Program.container.GetInstance<FrmTransactionDescription>();
            frmTransactionDescriptionItem.ShowDialog();
        }

        private void btnIncomeRegister_Click(object sender, EventArgs e)
        {
            var frmRevenueRegister = Program.container.GetInstance<FrmRevenueRegisterTransaction>();
            frmRevenueRegister.ShowDialog();
        }

        private void btnExpenseRegister_Click(object sender, EventArgs e)
        {
            var frmExpenseRegisterTransaction = Program.container.GetInstance<FrmExpenseTransaction>();
            frmExpenseRegisterTransaction.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var frmReports = Program.container.GetInstance<FrmReportMenu>();
            frmReports.ShowDialog();
        }

        private void btnCloseFinancialMonth_Click(object sender, EventArgs e)
        {
            var frmMaintainBalance = Program.container.GetInstance<FrmMaintainBalance>();
            frmMaintainBalance.ShowDialog();
        }
    }
}
