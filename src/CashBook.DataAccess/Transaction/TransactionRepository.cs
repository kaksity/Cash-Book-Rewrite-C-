using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.Transaction;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using Dapper;
using CashBook.Models.Account;
using CashBook.Models.TransactionDescription;

namespace CashBook.DataAccess.Transaction
{
    public class TransactionRepository : ITransactionRepository
    {
        IDbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }
        public void CreateTransaction(TransactionModel model)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                INSERT INTO 
                                    Transactions (TransactionId, AccountId, AmmountWithdrawn,AmmountDeposited, NameOfBeneficiary, DateOfTransaction, PVOrRVNumber,SubHeadColumn, TransactionDescriptionId, RefNumber, IsDeleted, CreatedAt,UpdatedAt)
                                VALUES
                                    (@TransactionId, @AccountId, @AmmountWithdrawn, @AmmountDeposited, @NameOfBeneficiary, @DateOfTransaction, @PVOrRVNumber, @SubHeadColumn, @TransactionDescriptionId, @RefNumber, @IsDeleted, @CreatedAt, @UpdatedAt) 
                                ";
                connection.Execute(query,model);
            }
        }

        public void DeleteTransaction(string transactionId)
        {
            using (var connection = dbConnection)
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = "UPDATE SupportingDocuments SET IsDeleted=true WHERE TransactionId = @TransactionId";
                        connection.Execute(sql: query, param: new { TransactionId = transactionId }, transaction: transaction);

                        query = "UPDATE Transactions SET IsDeleted=true WHERE TransactionId = @TransactionId";
                        connection.Execute(sql:query,param: new { TransactionId = transactionId}, transaction:transaction);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        public List<TransactionModel> GetAllExpenseTransaction()
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string sqlQuery = @"
                                    SELECT 
                                        trans.*,acct.*,transdesc.*
                                    FROM
                                        Transactions trans
                                    INNER JOIN 
                                        Accounts acct
                                    ON
                                        trans.AccountId = acct.AccountId
                                    INNER JOIN 
                                        TransactionDescriptions transdesc                                    
                                    ON
                                        trans.TransactionDescriptionId = transdesc.TransactionDescriptionId
                                    WHERE
                                        trans.IsDeleted=false AND trans.AmmountDeposited=0
                                    ORDER BY trans.DateOfTransaction DESC
                ";
                return connection.Query<TransactionModel,AccountModel,TransactionDescriptionModel,TransactionModel>(
                    sql: sqlQuery,
                    map: (transaction,account,transactionDescriptions) =>
                    {
                        transaction.Account = account;
                        transaction.TransactionDescription = transactionDescriptions;
                        return transaction;
                    },
                    splitOn: "AccountId,TransactionDescriptionId").ToList();
            }
        }

        public List<TransactionModel> GetAllExpenseTransactionByDate(string accountId, DateTime dateOfTransaction)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string sqlQuery = @"
                                    SELECT 
                                        trans.*,acct.*,transdesc.*
                                    FROM
                                        Transactions trans
                                    INNER JOIN 
                                        Accounts acct
                                    ON
                                        trans.AccountId = acct.AccountId
                                    INNER JOIN 
                                        TransactionDescriptions transdesc                                    
                                    ON
                                        trans.TransactionDescriptionId = transdesc.TransactionDescriptionId
                                    WHERE
                                        trans.AccountId = @AccountId AND trans.IsDeleted=false AND trans.AmmountDeposited=0 AND trans.DateOfTransaction=@DateOfTransaction
                                    ORDER BY trans.DateOfTransaction DESC
                ";
                return connection.Query<TransactionModel, AccountModel, TransactionDescriptionModel, TransactionModel>(
                    sql: sqlQuery,
                    map: (transaction, account, transactionDescriptions) =>
                    {
                        transaction.Account = account;
                        transaction.TransactionDescription = transactionDescriptions;
                        return transaction;
                    },
                    splitOn: "AccountId,TransactionDescriptionId",
                    param: new { AccountId = accountId, DateOfTransaction = dateOfTransaction}).ToList();
            }
        }

        public List<TransactionModel> GetAllExpenseTransactionDistinctByYear(string accountId, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();

                string query = @"SELECT DISTINCT(DateOfTransaction) FROM Transactions WHERE AmmountDeposited=0 AND IsDeleted=false AND EXTRACT(YEAR FROM DateOfTransaction)=@Year AND AccountId = @AccountId";
                return connection.Query<TransactionModel>(sql:query,param: new { AccountId = accountId, Year = year}).ToList();
            }
        }

        public List<TransactionModel> GetAllRevenueRegisterTransaction()
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string sqlQuery = @"
                                    SELECT 
                                        trans.*,acct.*,transdesc.*
                                    FROM
                                        Transactions trans
                                    INNER JOIN 
                                        Accounts acct
                                    ON
                                        trans.AccountId = acct.AccountId
                                    INNER JOIN 
                                        TransactionDescriptions transdesc                                    
                                    ON
                                        trans.TransactionDescriptionId = transdesc.TransactionDescriptionId
                                    WHERE
                                        trans.IsDeleted=false AND trans.AmmountWithdrawn=0
                                    ORDER BY trans.DateOfTransaction DESC
                ";
                return connection.Query<TransactionModel, AccountModel, TransactionDescriptionModel, TransactionModel>(
                    sql: sqlQuery,
                    map: (transaction, account, transactionDescriptions) =>
                    {
                        transaction.Account = account;
                        transaction.TransactionDescription = transactionDescriptions;
                        return transaction;
                    },
                    splitOn: "AccountId,TransactionDescriptionId").ToList();
            }
        }

        public List<TransactionModel> GetAllTransactionByAccountIdMonthAndYear(string accountId, int month, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string sqlQuery = @"
                                    SELECT 
                                        trans.*,acct.*,transdesc.*
                                    FROM
                                        Transactions trans
                                    INNER JOIN 
                                        Accounts acct
                                    ON
                                        trans.AccountId = acct.AccountId
                                    INNER JOIN 
                                        TransactionDescriptions transdesc                                    
                                    ON
                                        trans.TransactionDescriptionId = transdesc.TransactionDescriptionId
                                    WHERE
                                        trans.AccountId = @AccountId AND trans.IsDeleted=false AND extract(YEAR FROM trans.DateOfTransaction) = @Year AND extract(MONTH FROM trans.DateOfTransaction) = @Month
                                    ORDER BY trans.DateOfTransaction DESC
                ";
                return connection.Query<TransactionModel, AccountModel, TransactionDescriptionModel, TransactionModel>(
                    sql: sqlQuery,
                    param: new { AccountId = accountId, Year = year, Month = month },
                    map: (transaction, account, transactionDescriptions) =>
                    {
                        transaction.Account = account;
                        transaction.TransactionDescription = transactionDescriptions;
                        return transaction;
                    },
                    splitOn: "AccountId,TransactionDescriptionId").ToList();
            }
        }

        public List<TransactionModel> GetFilteredExpenseTransaction(string accountId, int month, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string sqlQuery = @"
                                    SELECT 
                                        trans.*,acct.*,transdesc.*
                                    FROM
                                        Transactions trans
                                    INNER JOIN 
                                        Accounts acct
                                    ON
                                        trans.AccountId = acct.AccountId
                                    INNER JOIN 
                                        TransactionDescriptions transdesc                                    
                                    ON
                                        trans.TransactionDescriptionId = transdesc.TransactionDescriptionId
                                    WHERE
                                        trans.AccountId = @AccountId AND trans.IsDeleted=false AND trans.AmmountDeposited=0 AND extract(YEAR FROM trans.DateOfTransaction) = @Year AND extract(MONTH FROM trans.DateOfTransaction) = @Month
                                    ORDER BY trans.DateOfTransaction DESC
                ";
                return connection.Query<TransactionModel, AccountModel, TransactionDescriptionModel, TransactionModel>(
                    sql: sqlQuery,
                    param: new {AccountId = accountId, Year = year, Month = month},
                    map: (transaction, account, transactionDescriptions) =>
                    {
                        transaction.Account = account;
                        transaction.TransactionDescription = transactionDescriptions;
                        return transaction;
                    },
                    splitOn: "AccountId,TransactionDescriptionId").ToList();
            }
        }

        public List<TransactionModel> GetFilteredRevenueRegisterTransaction(string accountId, int month, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string sqlQuery = @"
                                    SELECT 
                                        trans.*,acct.*,transdesc.*
                                    FROM
                                        Transactions trans
                                    INNER JOIN 
                                        Accounts acct
                                    ON
                                        trans.AccountId = acct.AccountId
                                    INNER JOIN 
                                        TransactionDescriptions transdesc                                    
                                    ON
                                        trans.TransactionDescriptionId = transdesc.TransactionDescriptionId
                                    WHERE
                                        trans.AccountId = @AccountId AND trans.IsDeleted=false AND trans.AmmountWithdrawn=0 AND extract(YEAR FROM trans.DateOfTransaction) = @Year AND extract(MONTH FROM trans.DateOfTransaction) = @Month
                                    ORDER BY trans.DateOfTransaction DESC
                ";
                return connection.Query<TransactionModel, AccountModel, TransactionDescriptionModel, TransactionModel>(
                    sql: sqlQuery,
                    param: new { AccountId = accountId, Year = year, Month = month },
                    map: (transaction, account, transactionDescriptions) =>
                    {
                        transaction.Account = account;
                        transaction.TransactionDescription = transactionDescriptions;
                        return transaction;
                    },
                    splitOn: "AccountId,TransactionDescriptionId").ToList();
            }
        }

        public TransactionModel GetTransactionByTransactionId(string transactionId)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string sqlQuery = @"
                                    SELECT 
                                        trans.*,acct.*,transdesc.*
                                    FROM
                                        Transactions trans
                                    INNER JOIN 
                                        Accounts acct
                                    ON
                                        trans.AccountId = acct.AccountId
                                    INNER JOIN 
                                        TransactionDescriptions transdesc                                    
                                    ON
                                        trans.TransactionDescriptionId = transdesc.TransactionDescriptionId
                                    WHERE
                                        trans.IsDeleted=false AND trans.TransactionId=@TransactionId
                                    ORDER BY trans.DateOfTransaction DESC
                ";
                return connection.Query<TransactionModel, AccountModel, TransactionDescriptionModel, TransactionModel>(
                    sql: sqlQuery,
                    map: (transaction, account, transactionDescriptions) =>
                    {
                        transaction.Account = account;
                        transaction.TransactionDescription = transactionDescriptions;
                        return transaction;
                    },
                    param: new { TransactionId = transactionId },
                    splitOn: "AccountId,TransactionDescriptionId").SingleOrDefault();
            }
        }
    }
}
