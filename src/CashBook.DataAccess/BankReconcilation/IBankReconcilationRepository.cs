using CashBook.Models.BankReconcilation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.DataAccess.BankReconcilation
{
    public interface IBankReconcilationRepository
    {
        /// <summary>
        /// DAL to Create a New Bank Reconcilation record
        /// </summary>
        void CreateBankReconcilation(BankReconcilationModel model);
        
        ///<summary>
        /// DAL to Get BankReconcilation Record based on AccountId and Duration
        /// </summary>
        BankReconcilationModel GetBankReconcilationByAccountIdAndDuration(string accountId, string duration);
        
        ///<summary>
        /// DAL to Get List of Bank Reconcilation Record based on AccountId
        /// </summary>
        List<BankReconcilationModel> GetBankReconcilationByAccountId(string accountId);

        ///<summary>
        /// DAL to Delete a Bank Reconcilation record
        /// </summary>
        void DeleteBankReconcilationRecord(string bankReconcilationId);
    }
}
