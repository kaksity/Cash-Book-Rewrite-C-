using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.Transaction;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using Dapper;

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
    }
}
