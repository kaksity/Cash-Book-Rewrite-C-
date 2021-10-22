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
    }
}
