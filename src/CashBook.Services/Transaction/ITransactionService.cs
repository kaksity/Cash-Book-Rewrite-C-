using CashBook.Dtos.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Services.Transaction
{
    public interface ITransactionService
    {
        ///<summary>
        /// Service to Add a Transaction
        /// </summary>
        void CreateTransaction(CreateTransactionDto dto);
    }
}
