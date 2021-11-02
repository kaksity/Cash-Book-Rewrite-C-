using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.BankReconcilation;
using CashBook.DataAccess.BankReconcilation;
using CashBook.Models.BankReconcilation;

namespace CashBook.Services.BankReconcilation
{
    public class BankReconcilationService : IBankReconcilationService
    {
        private readonly IBankReconcilationRepository _bankReconcilationRepository;
        public BankReconcilationService(IBankReconcilationRepository bankReconcilationRepository)
        {
            _bankReconcilationRepository = bankReconcilationRepository;
        }
        public void CreateBankReconcilation(CreateBankReconcilationDto dto)
        {
            var bankReconcilation = new BankReconcilationModel
            {
                BankReconcilationId  = Guid.NewGuid().ToString(),
                AccountId  =  dto.AccountId,
                Duration  =  dto.Duration,
                CreditTransfer  =  dto.CreditTransfer,
                InterestReceived  =  dto.InterestReceived,
                StaleChqsReversed  =  dto.StaleChqsReversed,
                BankCharges  = dto.BankCharges,
                DebitTransfer  = dto.DebitTransfer,
                OutstandingStaleChqs  = dto.OutstandingStaleChqs,
                UnpresentedChqs  = dto.UnpresentedChqs,
                BankNotCashBook  = dto.BankNotCashBook,
                UncreditedLodgements  = dto.UncreditedLodgements,
                CashBookNotBank  = dto.CashBookNotBank,
                DiffBtwBankAndCashBook  = dto.DiffBtwBankAndCashBook,
                IsDeleted  = false,
                CreatedAt  = DateTime.Now,
                UpdatedAt  = DateTime.Now
            };
            _bankReconcilationRepository.CreateBankReconcilation(bankReconcilation);
        }

        public void DeleteBankReconcilationRecord(string bankReconcilationId)
        {
            
            _bankReconcilationRepository.DeleteBankReconcilationRecord(bankReconcilationId);
        }

        public List<ReadBankReconcilationDto> GetBankReconcilationByAccountId(string accountId)
        {
            var result = _bankReconcilationRepository.GetBankReconcilationByAccountId(accountId);
            var data = new List<ReadBankReconcilationDto>();
            foreach (var item in result)
            {
                data.Add(new ReadBankReconcilationDto
                {
                    BankReconcilationId = item.BankReconcilationId,
                    AccountId = item.AccountId,
                    Duration = item.Duration,
                    CreditTransfer = item.CreditTransfer,
                    InterestReceived = item.InterestReceived,
                    StaleChqsReversed = item.StaleChqsReversed,
                    BankCharges = item.BankCharges,
                    DebitTransfer = item.DebitTransfer,
                    OutstandingStaleChqs = item.OutstandingStaleChqs,
                    UnpresentedChqs = item.UnpresentedChqs,
                    BankNotCashBook = item.BankNotCashBook,
                    UncreditedLodgements = item.UncreditedLodgements,
                    CashBookNotBank = item.CashBookNotBank,
                    DiffBtwBankAndCashBook = item.DiffBtwBankAndCashBook
                });
            }
            return data;
        }

        public ReadBankReconcilationDto GetBankReconcilationByAccountIdAndDuration(string accountId, string duration)
        {
            var result = _bankReconcilationRepository.GetBankReconcilationByAccountIdAndDuration(accountId, duration);
            if (result == null) return null;
            var data = new ReadBankReconcilationDto
            {
                 BankReconcilationId  = result.BankReconcilationId,
                 AccountId  = result.AccountId,
                 Duration  = result.Duration,
                 CreditTransfer  = result.CreditTransfer,
                 InterestReceived  = result.InterestReceived,
                 StaleChqsReversed  = result.StaleChqsReversed,
                 BankCharges  = result.BankCharges,
                 DebitTransfer  = result.DebitTransfer,
                 OutstandingStaleChqs  = result.OutstandingStaleChqs,
                 UnpresentedChqs  = result.UnpresentedChqs,
                 BankNotCashBook  = result.BankNotCashBook,
                 UncreditedLodgements  = result.UncreditedLodgements,
                 CashBookNotBank  = result.CashBookNotBank,
                 DiffBtwBankAndCashBook  = result.DiffBtwBankAndCashBook
            };
            return data;
        }
    }
}
