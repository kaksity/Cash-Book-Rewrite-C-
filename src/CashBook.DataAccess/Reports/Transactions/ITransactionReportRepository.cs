using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.DataAccess.Reports
{
    public interface ITransactionReportRepository
    {
        DataTable GetAllTransactions(string accountId, int month, int year);
        DataTable GetAllTransactionByTransactionDescriptionOnly(string accountId, int month, int year, string transactionDescriptionId);
        DataTable GetAllTransactionByTransactionTypeOnly(string accountId, int month, int year, string transactionType);
        DataTable GetAllTransactionByTransactionDescriptionAndTransactionType(string accountId, int month, int year, string transactionDescriptionId, string transactionType);
    }
}
