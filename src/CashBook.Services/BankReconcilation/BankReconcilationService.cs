using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.BankReconcilation;
using CashBook.DataAccess.BankReconcilation;
using CashBook.Models.BankReconcilation;
using CashBook.Services.Reports.BankReconcilations;
using CashBook.Services.Transaction;
using CashBook.Dtos.Transaction;

namespace CashBook.Services.BankReconcilation
{
    public class BankReconcilationService : IBankReconcilationService
    {
        private readonly IBankReconcilationRepository _bankReconcilationRepository;
        private readonly ITransactionService _transactionService;

        public BankReconcilationService(IBankReconcilationRepository bankReconcilationRepository, ITransactionService transactionService)
        {
            _bankReconcilationRepository = bankReconcilationRepository;
            _transactionService = transactionService;

        }

        private Tuple<decimal, decimal> CalculateTotalIncomeAndExpenseTransaction(List<ReadTransactionDto> data)
        {
            decimal totalIncomeTransaction = 0;
            decimal totalExpenseTransaction = 0;

            foreach (var item in data)
            {
                if (item.AmmountDeposited == 0)
                {
                    totalExpenseTransaction += item.AmmountWithdrawn;
                }
                else
                {
                    totalIncomeTransaction += item.AmmountDeposited;
                }
            }
            return Tuple.Create(totalIncomeTransaction, totalExpenseTransaction);
        }

        public decimal CalculateBankReconcilationClosingBalance(decimal openingBalance, ReadBankReconcilationDto dto)
        {
            var splitedDuration = dto.Duration.Split('.');

            int month = Convert.ToInt16(splitedDuration[0]);
            int year = Convert.ToInt16(splitedDuration[1]);

            var allTransactions = _transactionService.GetAllTransactionByAccountIdMonthAndYear(dto.AccountId, month, year);
            var totalReceiptsAndPayments = CalculateTotalIncomeAndExpenseTransaction(allTransactions);

            var totalReceipts = totalReceiptsAndPayments.Item1;
            var totalPayments = totalReceiptsAndPayments.Item2;

            decimal subCashBookBalance = totalReceipts + dto.CreditTransfer + dto.InterestReceived + dto.StaleChqsReversed - totalPayments - dto.BankCharges - dto.DebitTransfer;

            decimal cashbookBalance = openingBalance + subCashBookBalance;
            decimal suggestedCashbookBalance = cashbookBalance + dto.OutstandingStaleChqs;

            decimal bankAddTotal = dto.UnpresentedChqs + dto.BankNotCashBook;
            decimal bankLessTotal = dto.UncreditedLodgements + dto.CashBookNotBank;

            decimal bankTotal = bankAddTotal - bankLessTotal;

            decimal closingBalance = suggestedCashbookBalance + bankTotal;

            return closingBalance;
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
