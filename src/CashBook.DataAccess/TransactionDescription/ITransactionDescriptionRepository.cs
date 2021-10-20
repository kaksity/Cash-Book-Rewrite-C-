using CashBook.Models.TransactionDescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.DataAccess.TransactionDescription
{
    public interface ITransactionDescriptionRepository
    {
        ///<summary>
        ///DAL to create a Transaction Description 
        /// </summary>
        void CreateTransactionDescription(TransactionDescriptionModel model);
        /// <summary>
        /// DAL to Get All Transaction Descriptions
        /// </summary>
        /// <returns></returns>
        List<TransactionDescriptionModel> GetAllTransactionDescriptions();
        ///<summary>
        /// DAL to Get All Transaction Descriptions By the Transaction Type
        /// </summary>
        List<TransactionDescriptionModel> GetAllTransactionDescriptionsByTransactionType(string transactionType);
        ///<summary>
        /// DAL to Delete a transaction description
        /// </summary>
        void DeleteTransactionDescription(string transactionDescriptionId);
    }
}
