using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos;
using CashBook.Dtos.TransactionDescription;

namespace CashBook.Services.TransactionDescription
{
    public interface ITransactionDescriptionService
    {
        ///<summary>
        ///Service to create a Transaction Description 
        /// </summary>
        void CreateTransactionDescription(CreateTransactionDescriptionDto dto);
        /// <summary>
        /// Service to Get All Transaction Descriptions
        /// </summary>
        /// <returns></returns>
        List<ReadTransactionDescriptionDto> GetAllTransactionDescriptions();
        ///<summary>
        /// Service to Get All Transaction Descriptions By the Transaction Type
        /// </summary>
        List<ReadTransactionDescriptionDto> GetAllTransactionDescriptionsByTransactionType(string transactionType);
        ///<summary>
        /// Service to Delete a transaction description
        /// </summary>
        void DeleteTransactionDescription(string transactionDescriptionId);
    }
}
