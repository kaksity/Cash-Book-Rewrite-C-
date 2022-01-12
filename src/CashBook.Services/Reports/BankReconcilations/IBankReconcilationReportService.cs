using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.Transaction;

namespace CashBook.Services.Reports.BankReconcilations
{
    public interface IBankReconcilationReportService
    {
        string GenerateBankReconcilationReport(string bankReconcilationId,string accountId, string userId);
        Tuple<decimal, decimal> CalculateTotalIncomeAndExpenseTransaction(List<ReadTransactionDto> data);
    }
}
