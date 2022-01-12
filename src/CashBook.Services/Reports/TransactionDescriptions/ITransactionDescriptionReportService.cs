using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Services.Reports.TransactionDescriptions
{
    public interface ITransactionDescriptionReportService
    {
        DataTable GetAllExpenseItems();
        DataTable GetAllIncomeItems();
        DataTable GetAllItems();
        string GenerateReportParameters(string userId);
    }
}
