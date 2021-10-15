using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CashBook.Models.Account;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using Dapper;

namespace CashBook.DataAccess.Account
{
    public class AccountRepository : IAccountRepository
    {
        public IDbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }

        public void CreateAccount(AccountModel model)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @" INSERT INTO 
                                    Accounts(AccountId,AccountName,AccountNumber,BankName,OpeningDate,Description,OpeningBalance,CurrentBalance,IsDeleted,CreatedAt,UpdatedAt)
                                  VALUES
                                    (@AccountId,@AccountName,@AccountNumber,@BankName,@OpeningDate,@Description,@OpeningBalance,@CurrentBalance,@IsDeleted,@CreatedAt,@UpdatedAt)
                                ";
                connection.Execute(query, model);
            }
        }

        public void DeleteAccount(string accountId)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"UPDATE
                                    Accounts
                                 SET 
                                    IsDeleted=1
                                 WHERE
                                    Account = @AccountId AND IsDeleted=0
                                 ";
                connection.Execute(query, new { AccountId = accountId });
            }
        }

        public AccountModel GetAccount(string accountId)
        {
            //using (IDbConnection connection = dbConnection)
            //{
            //    string query = "SELECT AccountId,AccountName,AccountNumber,BankName,OpeningDate,Description,OpeningBalance,CurrentBalance,IsDeleted,CreatedAt,UpdatedAt FROM Accounts WHERE IsDeleted=0";
            //    connection.Open();
            //    return connection.Query<AccountModel>(query).ToList();
            //}
            return null;
        }

        public List<AccountModel> GetAllAccounts()
        {
            using (IDbConnection connection = dbConnection)
            {
                string query = "SELECT AccountId,AccountName,AccountNumber,BankName,OpeningDate,Description,OpeningBalance,CurrentBalance,IsDeleted,CreatedAt,UpdatedAt FROM Accounts WHERE IsDeleted=0";
                connection.Open();
                return connection.Query<AccountModel>(query).ToList();
            }
        }

        public void UpdateAccount(AccountModel updateModel)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"UPDATE
                                    Accounts
                                 SET 
                                    AccountName = @AccountName,AccountNumber = @AccountNumber, BankName = @BankName,OpeningDate = @OpeningDate,Description = @Description,OpeningBalance = @OpeningBalance, CurrentBalance = @CurrentBalance, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt
                                 WHERE
                                    Account = @AccountId AND IsDeleted=0
                                 ";
                connection.Execute(query);
            }
        }
    }
}
