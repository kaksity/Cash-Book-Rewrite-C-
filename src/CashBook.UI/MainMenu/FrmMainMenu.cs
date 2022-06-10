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
using CashBook.UI.BankReconcilation;
using CashBook.UI.ColumnsCashBook;
using CashBook.UI.DebtorLedger;
using CashBook.UI.Settings;
using CashBook.UI.StockLedger;
using CashBook.UI.Transaction;
using CashBook.UI.TransactionDescription;

namespace CashBook.UI.MainMenu
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            var today = DateTime.Now;
            if (today.Day == 1 || today.Day == 14)
            {
                var frmBackupRestore = Program.container.GetInstance<FrmBackupRestore>();
                frmBackupRestore.ShowDialog();
            }
        }

        private void btnBankReconcilation_Click(object sender, EventArgs e)
        {
            var frmBankReconcilation = Program.container.GetInstance<FrmBankReconcilation>();
            frmBankReconcilation.ShowDialog();
        }

        private void btnIncomeRegister_Click(object sender, EventArgs e)
        {
            var frmIncomeRegister = Program.container.GetInstance<FrmRevenueRegisterTransaction>();
            frmIncomeRegister.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var frmSettings = Program.container.GetInstance<FrmSettings>();
            frmSettings.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm32ColumnCashbook = Program.container.GetInstance<Frm32ColumnCashBook>();
            frm32ColumnCashbook.ShowDialog();
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmCashBook = Program.container.GetInstance<FrmCashBookMenu>();
            frmCashBook.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var frmStockLedgerMenu = Program.container.GetInstance<FrmStockLedgerMenu>();
            frmStockLedgerMenu.ShowDialog();
        }

        private void btnDebtorLedger_Click(object sender, EventArgs e)
        {
            var frmDebtorLedgerMenu = Program.container.GetInstance<FrmDebtorLedgerMenu>();
            frmDebtorLedgerMenu.ShowDialog();
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            var frmBackupRestore = Program.container.GetInstance<FrmBackupRestore>();
            frmBackupRestore.ShowDialog();
        }
    }
}
