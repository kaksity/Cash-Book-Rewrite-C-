using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CashBook.Dtos.Account;
namespace CashBook.Services.Account
{
    public interface IAccountService
    {
        ///<summary>
        ///Service to create an Account
        ///</summary>
        void CreateAccount(CreateAccountDto dto);
        ///<summary>
        ///Service to Get All Accounts
        ///</summary>
        List<ReadAccountDto> GetAllAccounts();
        ///<summary>
        ///Service to Get an Account By Id
        ///</summary>
        ReadAccountDto GetAccountByAccountNumber(string accountNumber);

        ///<summary>
        ///Service to Get an Account
        ///</summary>
        ReadAccountDto GetAccountByAccountId(string accountId);
        ///<summary>
        ///Service to Update an Account
        ///</summary>
        void UpdateAccount(ReadAccountDto dto);
        ///<summary>
        ///Service to Delete an Account
        ///</summary>
        void DeleteAccount(string accountId);

        ///<summary>
        /// Service to Update Account Balance By Adding to the Account
        /// </summary>
        void AddToAccountBalance(ReadAccountDto dto, decimal ammount);
        ///<summary>
        /// Service to Update Account Balance By Deducting from the Account
        /// </summary>
        void DeductFromAccountBalance(ReadAccountDto dto, decimal ammount);
    }
}
