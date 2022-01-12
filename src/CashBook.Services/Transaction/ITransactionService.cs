using CashBook.Dtos.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CashBook.Services.Transaction
{
    public interface ITransactionService
    {
        ///<summary>
        /// Service to Add a Transaction
        /// </summary>
        void CreateTransaction(CreateTransactionDto dto);
        ///<summary>
        /// Service to Get expense transaction
        /// </summary>
        List<ReadTransactionDto> GetAllExpenseTransaction();
        ///<summary>
        /// Service to Get revenue register transaction
        /// </summary>
        List<ReadTransactionDto> GetAllRevenueRegiserTransaction();
        ///<summary>
        /// Service to Delete a transaction
        /// </summary>
        void DeleteTransaction(string transactionId);

        ///<summary>
        /// Service to Get a filtered expense transaction
        /// </summary>
        List<ReadTransactionDto> GetFilteredExpenseTransaction(string accountId, int month, int year);
        ///<summary>
        /// Service to Get a filtered revenue register transaction
        /// </summary>
        List<ReadTransactionDto> GetFilteredRevenueRegisterTransaction(string accountId, int month, int year);

        List<ReadTransactionDto> GetAllTransactionByAccountIdMonthAndYear(string accountId, int month, int year);

        DataTable Get32ColumnCashBook(string accountId, int year);

        ReadTransactionDto GetTransactionByTransactionId(string transactionId);
    }
}
