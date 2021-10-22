using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.Transaction;
using CashBook.DataAccess.Transaction;
using CashBook.Models.Transaction;

namespace CashBook.Services.Transaction
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        public void CreateTransaction(CreateTransactionDto dto)
        {
            var transaction = new TransactionModel
            {
                 TransactionId = Guid.NewGuid().ToString(),
                 AccountId = dto.AccountId,
                 AmmountWithdrawn = dto.AmmountWithdrawn,
                 AmmountDeposited = dto.AmmountDeposited,
                 NameOfBeneficiary = dto.NameOfBeneficiary,
                 DateOfTransaction = dto.DateOfTransaction,
                 PVOrRVNumber = dto.PVOrRVNumber,
                 SubHeadColumn = dto.SubHeadColumn,
                 TransactionDescriptionId = dto.TransactionDescriptionId,
                 RefNumber = dto.RefNumber,
                 IsDeleted = false,
                 CreatedAt = DateTime.Now,
                 UpdatedAt = DateTime.Now
            };
            _transactionRepository.CreateTransaction(transaction);
        }
    }
}
