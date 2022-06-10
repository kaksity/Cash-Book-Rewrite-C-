using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashBook.Services.Account;
using CashBook.Services.Transaction;
using CashBook.Services.TransactionDescription;
using CashBook.UI.Utilities;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;


namespace CashBook.UI.ColumnsCashBook
{
    public partial class Frm32ColumnCashBook : Form
    {
        private readonly ITransactionDescriptionService _transactionDescriptionService;
        private readonly IAccountService _accountService;
        private readonly ITransactionService _transactionService;

        public Frm32ColumnCashBook(ITransactionDescriptionService transactionDescriptionService,IAccountService accountService,ITransactionService transactionService)
        {
            _accountService = accountService;
            _transactionDescriptionService = transactionDescriptionService;
            _transactionService = transactionService;
            InitializeComponent();
        }

        private void Frm32ColumnCashBook_Load(object sender, EventArgs e)
        {
            Init32ColumnGrid();
            LoadAccountComboBox();
            LoadYearComboBox();
        }

        private void LoadAccountComboBox()
        {
            var accounts = _accountService.GetAllAccounts();
            cboAccounts.DisplayMember = "AccountName";
            cboAccounts.ValueMember = "AccountId";
            cboAccounts.DataSource = accounts;
        }

        private void LoadYearComboBox()
        {
            DataTable tblYears = new DataTable();
            int currentYear = 2020;

            tblYears.Columns.Add("name", typeof(string));
            tblYears.Columns.Add("value", typeof(int));

            while (currentYear <= DateTime.Now.Year)
            {
                tblYears.Rows.Add(currentYear, currentYear);
                currentYear += 1;
            }

            cboYears.DisplayMember = "name";
            cboYears.ValueMember = "value";
            cboYears.DataSource = tblYears;
        }

        private void Init32ColumnGrid()
        {
            //grid.Rows.Clear();
            //grid.Columns.Add("colsDateOfTransaction", "colsDateOfTransaction");
            //grid.Columns.Add("colsTotalTransaction", "colsTotalTransaction");

            //var expenseTransactionItems = _transactionDescriptionService.GetAllTransactionDescriptionsByTransactionType("EXPENSE");

            //foreach (var item in expenseTransactionItems)
            //{
            //    grid.Columns.Add(item.TransactionDescriptionId, item.TransactionDescriptionId);
            //}

            //grid.AllowDrop = false;
            //grid.AllowUserToAddRows = false;
            //grid.AllowUserToDeleteRows = false;
            //grid.AllowUserToOrderColumns = false;
            //grid.AllowUserToResizeColumns = true;
        }

        private void LoadData()
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grid.DataSource == null)
            {
                MessageBox.Show("You must select a record first",Software.GetApplicationName());
                return;
            }
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel |*.xlsx";

            if (saveDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string fileName = saveDialog.FileName;

            using (var spreadSheetDocument = SpreadsheetDocument.Create(fileName, SpreadsheetDocumentType.Workbook))
            {
                var workBookPart = spreadSheetDocument.AddWorkbookPart();
                workBookPart.Workbook = new Workbook();

                var workSheetPart = workBookPart.AddNewPart<WorksheetPart>();
                workSheetPart.Worksheet = new Worksheet(new SheetData());

                var sheets = spreadSheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());

                var sheet = new Sheet
                {
                    Id = spreadSheetDocument.WorkbookPart.GetIdOfPart(workSheetPart),
                    SheetId = 1,
                    Name = "Sheet1"
                };

                sheets.Append(sheet);

                var sheetData = workSheetPart.Worksheet.GetFirstChild<SheetData>();

                LoadSheetData(sheetData);

                workSheetPart.Worksheet.Save();
                spreadSheetDocument.WorkbookPart.Workbook.Save();
                spreadSheetDocument.Close();
            }
            

            MessageBox.Show($"Excel File Saved at {fileName}", Software.GetApplicationName());
        }

        private Cell CreateCell(string text, uint styleIndex)
        {
            return new Cell
            {
                StyleIndex = styleIndex,
                DataType = ResolveCellDataTypeOnValue(text),
                CellValue = new CellValue(text)
            };
        }
        private void LoadSheetData(SheetData sheetData)
        {
            pgProgress.Value = 0;

            var headerRow = new Row();

            for (int i = 0; i < grid.Columns.Count; i++)
            {
                headerRow.Append(CreateCell(grid.Columns[i].HeaderText, 2U));
            }

            sheetData.AppendChild(headerRow);

            for (int i = 0; i < grid.Rows.Count; i++)
            {

                var bodyRow = new Row();
                for (int j = 0; j < grid.Columns.Count; j++)
                {
                    if (grid.Rows[i].Cells[j].Value != null)
                    {
                        bodyRow.Append(CreateCell(grid.Rows[i].Cells[j].Value.ToString(), 2U));
                    }
                }
                sheetData.AppendChild(bodyRow);
                pgProgress.Value = (i / grid.Rows.Count) * 100;
            }
        }
        private EnumValue<CellValues> ResolveCellDataTypeOnValue(string text)
        {
            DateTime date;

            if (DateTime.TryParse(text,out date) == true)
            {
                return CellValues.Date;
            }
            else
            {
                return CellValues.String;
            }
        }
        private void btnGetRecords_Click(object sender, EventArgs e)
        {

            grid.Columns.Clear();
            grid.Rows.Clear();

            var results = _transactionService.Get32ColumnCashBook((string)cboAccounts.SelectedValue, (int)cboYears.SelectedValue);

            grid.DataSource = results;

            var expenseTransactionItems = _transactionDescriptionService.GetAllTransactionDescriptionsByTransactionType("EXPENSE");

            //Loop through the grid rows
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Cells["colsTotalTransaction"].Value = $"N{Utility.FormatDecimal(Convert.ToDecimal(grid.Rows[i].Cells["colsTotalTransaction"].Value))}";
                // For Each row Loop through the columns
                foreach (var item in expenseTransactionItems)
                {
                    if (Convert.IsDBNull(grid.Rows[i].Cells[item.TransactionDescriptionId].Value) == false)
                    {
                        grid.Rows[i].Cells[item.TransactionDescriptionId].Value = $"N{Utility.FormatDecimal(Convert.ToDecimal(grid.Rows[i].Cells[item.TransactionDescriptionId].Value))}";
                    }
                    
                }
            }

            grid.Columns["colsDateOfTransaction"].HeaderText = "DATE OF TRANSACTION";
            grid.Columns["colsTotalTransaction"].HeaderText = "TOTAL TRANSACTION";

            for (int i = 2; i < grid.Columns.Count; i++)
            {
                string headerText = grid.Columns[i].HeaderText;
                var transactionDescriptionItem = expenseTransactionItems.Find(item => item.TransactionDescriptionId == headerText);
                grid.Columns[i].HeaderText = transactionDescriptionItem.DescriptionName;
            }

        }
    }
}
