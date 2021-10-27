using CashBook.DataAccess.Account;
using CashBook.Dtos.Account;
using CashBook.Dtos.MaintainBalance;
using CashBook.Models.Account;
using CashBook.Services.MaintainBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashBook.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMaintainBalanceService _maintainBalanceService;
        public AccountService(IAccountRepository accountRepository, IMaintainBalanceService maintainBalanceService)
        {
            _accountRepository = accountRepository;
            _maintainBalanceService = maintainBalanceService;
        }

        public void AddToAccountBalance(ReadAccountDto dto, decimal ammount)
        {
            dto.CurrentBalance = dto.CurrentBalance + ammount;
            this.UpdateAccount(dto);
        }

        public void CreateAccount(CreateAccountDto dto)
        {
            string accountId = Guid.NewGuid().ToString();

            var model = new AccountModel
            {
                AccountId = accountId,
                AccountName = dto.AccountName,
                AccountNumber = dto.AccountNumber,
                BankName = dto.BankName,
                OpeningDate = dto.OpeningDate,
                Description = dto.Description,
                OpeningBalance = dto.OpeningBalance,
                CurrentBalance = dto.CurrentBalance,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            
            _accountRepository.CreateAccount(model);

            var maintainBalanceDto = new CreateMaintainBalanceDto
            {
                AccountId= accountId,
                OpeningBalance=dto.OpeningBalance,
                ClosingBalance=0,
                Duration=$"{dto.OpeningDate.Month}.{dto.OpeningDate.Year}",
                Status=0
            };
            _maintainBalanceService.CreateMaintainBalance(maintainBalanceDto);
        }

        public void DeleteAccount(string accountId)
        {
            _accountRepository.DeleteAccount(accountId);
        }

        public ReadAccountDto GetAccountByAccountId(string accountId)
        {
            var results = _accountRepository.GetAccountByAccountId(accountId);
            var account = new ReadAccountDto
            {
                AccountId = results.AccountId,
                AccountName = results.AccountName,
                AccountNumber = results.AccountNumber,
                BankName = results.BankName,
                OpeningDate = results.OpeningDate,
                Description = results.Description,
                OpeningBalance = results.OpeningBalance,
                CurrentBalance = results.CurrentBalance,
            };
            return account;
        }

        public ReadAccountDto GetAccountByAccountNumber(string accountNumber)
        {
            var results = _accountRepository.GetAccountByAccountNumber(accountNumber);

            if (results == null) return null;

            var account = new ReadAccountDto
            {
                AccountId = results.AccountId,
                AccountName = results.AccountName,
                AccountNumber = results.AccountNumber,
                BankName = results.BankName,
                OpeningDate = results.OpeningDate,
                Description = results.Description,
                OpeningBalance = results.OpeningBalance,
                CurrentBalance = results.CurrentBalance,
            };
            return account;
        }

        public List<ReadAccountDto> GetAllAccounts()
        {
            var results = _accountRepository.GetAllAccounts();
            var accounts = new List<ReadAccountDto>();
            foreach (var item in results)
            {
                accounts.Add(new ReadAccountDto {
                AccountId = item.AccountId,
                AccountName = item.AccountName,
                AccountNumber = item.AccountNumber,
                BankName = item.BankName,
                OpeningDate = item.OpeningDate,
                Description = item.Description,
                OpeningBalance = item.OpeningBalance,
                CurrentBalance = item.CurrentBalance,
                });
            }
            return accounts;
        }

        public void UpdateAccount(ReadAccountDto dto)
        {
            var model = new AccountModel
            {
                AccountId = dto.AccountId,
                AccountName = dto.AccountName,
                AccountNumber = dto.AccountNumber,
                BankName = dto.BankName,
                OpeningDate = dto.OpeningDate,
                Description = dto.Description,
                OpeningBalance = dto.OpeningBalance,
                CurrentBalance = dto.CurrentBalance,
                IsDeleted = false,
                UpdatedAt = DateTime.Now
            };

            _accountRepository.UpdateAccount(model);
        }
    }
}
