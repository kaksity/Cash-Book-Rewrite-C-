using CashBook.Dtos.BankReconcilation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Services.BankReconcilation
{
    public interface IBankReconcilationService
    {
        /// <summary>
        /// Service Layer to Create a New Bank Reconcilation record
        /// </summary>
        void CreateBankReconcilation(CreateBankReconcilationDto dto);

        ///<summary>
        /// Service Layer to Delete a Bank Reconcilation record
        /// </summary>
        void DeleteBankReconcilationRecord(string bankReconcilationId);
        ///<summary>
        /// Service Layer to Get BankReconcilation Record based on AccountId and Duration
        /// </summary>
        ReadBankReconcilationDto GetBankReconcilationByAccountIdAndDuration(string accountId, string duration);

        ///<summary>
        /// Service Layer to Get List of Bank Reconcilation Record based on AccountId
        /// </summary>
        List<ReadBankReconcilationDto> GetBankReconcilationByAccountId(string accountId);
    }
}
