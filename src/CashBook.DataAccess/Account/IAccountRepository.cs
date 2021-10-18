using System;
using CashBook.Models.Account;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashBook.DataAccess.Account
{
    public interface IAccountRepository
    {
        ///<Summary>
        ///DAL to create an Account
        ///</Summary>
        void CreateAccount(AccountModel model);
        ///<Summary>
        ///DAL to Get All Accounts
        ///</Summary>
        List<AccountModel> GetAllAccounts();
        ///<Summary>
        ///DAL to Get an Account By Account Id
        ///</Summary>
        AccountModel GetAccountByAccountId(string accountId);
        ///<Summary>
        ///DAL to Get an Account By Account Number
        ///</Summary>
        AccountModel GetAccountByAccountNumber(string accountNumber);
        ///<Summary>
        ///DAL to Update an Account
        ///</Summary>
        void UpdateAccount(AccountModel updateModel);
        ///<Summary>
        ///DAL to Delete an Account
        ///</Summary>
        void DeleteAccount(string accountId);

    }
}
