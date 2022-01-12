using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Services.Reports
{
    public interface ITransactionReportService
    {
        DataTable GetAllTransactionsByAccountIdAndDuration(string accountId, int month, int year);
        DataTable GetAllTransactionByTransactionDescriptionOnly(string accountId, int month, int year, string transactionDescriptionId);
        DataTable GetAllTransactionByTransactionTypeOnly(string accountId, int month, int year, string transactionType);
        DataTable GetAllTransactionByTransactionDescriptionAndTransactionType(string accountId, int month, int year, string transactionDescriptionId, string transactionType);
        string GenerateReportParameters(string userId, string accountId, int month, int year);
    }
}
