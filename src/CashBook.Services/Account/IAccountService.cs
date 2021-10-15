using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CashBook.Dtos.Account;
namespace CashBook.Services.Account
{
    public interface IAccountService
    {
        //<Summary>
        //Service to create an Account
        //</Summary>
        void CreateAccount(CreateAccountDto dto);
        //<Summary>
        //DAL to Get All Accounts
        //</Summary>
        //List<AccountModel> GetAllAccounts();
        //<Summary>
        //DAL to Get an Account
        //</Summary>
        //AccountModel GetAccount(string accountId);
        //<Summary>
        //DAL to Update an Account
        //</Summary>
        //void UpdateAccount(AccountModel updateModel);
        //<Summary>
        //DAL to Delete an Account
        //</Summary>
        //void DeleteAccount(string accountId);
    }
}
