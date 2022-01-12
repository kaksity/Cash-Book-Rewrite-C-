using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.DataAccess.Reports.TransactionDescriptions
{
    public interface ITransactionDescriptionReportRepository
    {
        DataTable GetAllExpenseItems();
        DataTable GetAllIncomeItems();
        DataTable GetAllItems();
    }
}
