using CashBook.Models.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.DataAccess.Transaction
{
    public interface ITransactionRepository
    {
        ///<summary>
        /// DAL to Add a Transaction
        /// </summary>
        void CreateTransaction(TransactionModel model);
        ///<summary>
        /// DAL to Get expense transaction
        /// </summary>
        List<TransactionModel> GetAllExpenseTransaction();
        ///<summary>
        /// DAL to Get a filtered expense transaction
        /// </summary>
        List<TransactionModel> GetFilteredExpenseTransaction(string accountId, int month,int year);
        ///<summary>
        /// DAL to Get Revenue Register transaction
        /// </summary>
        List<TransactionModel> GetAllRevenueRegisterTransaction();
        ///<summary>
        /// DAL to Get a filtered Revenue Register transaction
        /// </summary>
        List<TransactionModel> GetFilteredRevenueRegisterTransaction(string accountId, int month, int year);
        ///<summary>
        /// DAL to Delete a transaction
        /// </summary>
        void DeleteTransaction(string transactionId);
        List<TransactionModel> GetAllExpenseTransactionDistinctByYear(string accountId, int year);
        List<TransactionModel> GetAllExpenseTransactionByDate(string accountId,DateTime dateOfTransaction);
        List<TransactionModel> GetAllTransactionByAccountIdMonthAndYear(string accountId, int month, int year);
        TransactionModel GetTransactionByTransactionId(string transactionId);
    }
}
