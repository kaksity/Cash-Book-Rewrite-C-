using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.Services.DataRecovery;
using CashBook.Services.Utility;
using CashBook.UI.Utilities;

namespace CashBook.UI.Settings
{
    public partial class FrmBackupRestore : Form
    {
        private string filePath = "";
        private readonly IDataRecoveryService _dataRecoveryService;
        public FrmBackupRestore(IDataRecoveryService dataRecoveryService)
        {
            _dataRecoveryService = dataRecoveryService;
            InitializeComponent();
        }

        private void FrmBackupRestore_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            chkBackup.Checked = true;
            chkRestore.Checked = false;
            lblPath.Text = "";
            filePath = "";
            lblStatus.Text = "";
        }
        private void btnShowDialogBox_Click(object sender, EventArgs e)
        {
            if (chkBackup.Checked == true && chkRestore.Checked == false)
            {
                var saveDialog = new SaveFileDialog();

                saveDialog.Title = "Swift Accounts - Back Up";
                saveDialog.Filter = "Swift Accounts File|*.fbk";

                if (saveDialog.ShowDialog() == DialogResult.Cancel)
                {
                    Reset();
                    return;
                }

                filePath = saveDialog.FileName;
            }
            else
            {
                var openDialog = new OpenFileDialog();
                openDialog.Title = "Swift Accounts - Restore";
                openDialog.Filter = "Swift Accounts File|*.fbk";
                if (openDialog.ShowDialog() == DialogResult.Cancel)
                {
                    Reset();
                    return;
                }
                filePath = openDialog.FileName;

            }
            lblPath.Text = filePath;
        }

        private void btnStartProcessing_Click(object sender, EventArgs e)
        {

            if (filePath == "")
            {
                MessageBox.Show("Backup / Restore File Path is required",Software.GetApplicationName());
                Reset();
                return;
            }

            if (chkBackup.Checked == true && chkRestore.Checked == false)
            {
                try
                {
                    lblStatus.Text = "Performing Backup";
                    _dataRecoveryService.PerformBackup(filePath);
                    lblStatus.Text = "Backup Successfully";
                    MessageBox.Show("Backup was performed successfully", Software.GetApplicationName());
                    Reset();
                }
                catch (Exception)
                {
                    lblStatus.Text = "Error occured while performing backup";
                    MessageBox.Show("Unable to perform Backup",Software.GetApplicationName());
                    Reset();
                }        
            }
            else
            {
                if (MessageBox.Show("Restoring backup will overwrite previous data. Do you still wish to continue?",Software.GetApplicationName(),MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No )
                {
                    Reset();
                    return;
                }
                try
                {
                    lblStatus.Text = "Performing Restore";
                    _dataRecoveryService.PerformRestore(filePath);
                    lblStatus.Text = "Restored Successfully";
                    MessageBox.Show("Restore was performed successfully. Application is going to Close to update changes", Software.GetApplicationName());
                    Application.Exit();
                }
                catch (Exception)
                {
                    lblStatus.Text = "Error occured while performing restore";
                    MessageBox.Show("Unable to perform Restore", Software.GetApplicationName());
                    Reset();
                }
            }
        }
    }
}
