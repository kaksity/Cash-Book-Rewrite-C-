using CashBook.DataAccess.Account;
using CashBook.Dtos.Account;
using CashBook.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashBook.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public void CreateAccount(CreateAccountDto dto)
        {
            var model = new AccountModel
            {
                AccountId = Guid.NewGuid().ToString(),
                AccountName = dto.AccountName,
                AccountNumber = dto.AccountNumber,
                BankName = dto.BankName,
                OpeningDate = dto.OpeningDate,
                Description = dto.Description,
                OpeningBalance = dto.OpeningBalance,
                CurrentBalance = dto.CurrentBalance,
                IsDeleted = 0,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _accountRepository.CreateAccount(model);
        }
    }
}
