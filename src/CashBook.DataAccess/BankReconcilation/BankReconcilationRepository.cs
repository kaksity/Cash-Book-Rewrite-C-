using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.BankReconcilation;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using Dapper;

namespace CashBook.DataAccess.BankReconcilation
{
    public class BankReconcilationRepository : IBankReconcilationRepository
    {
        IDbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }
        public void CreateBankReconcilation(BankReconcilationModel model)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                INSERT INTO 
                                    BankReconcilations(BankReconcilationId, AccountId, Duration,CreditTransfer, InterestReceived, StaleChqsReversed, BankCharges,DebitTransfer,OutstandingStaleChqs,UnpresentedChqs, BankNotCashBook,UncreditedLodgements, CashBookNotBank, DiffBtwBankAndCashBook, IsDeleted,CreatedAt, UpdatedAt)
                                VALUES 
                                    (@BankReconcilationId, @AccountId, @Duration, @CreditTransfer, @InterestReceived, @StaleChqsReversed, @BankCharges, @DebitTransfer, @OutstandingStaleChqs, @UnpresentedChqs, @BankNotCashBook, @UncreditedLodgements, @CashBookNotBank, @DiffBtwBankAndCashBook, @IsDeleted, @CreatedAt, @UpdatedAt)
                                ";
                connection.Execute(query,model);
            }
        }

        public void DeleteBankReconcilationRecord(string bankReconcilationId)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                DELETE FROM 
                                    BankReconcilations 
                                WHERE 
                                    BankReconcilationId = @BankReconcilationId AND IsDeleted = false
                                ";
                connection.Execute(query, new { BankReconcilationId = bankReconcilationId });
            }
        }

        public BankReconcilationModel GetBankReconcilationByAccountIdAndDuration(string accountId, string duration)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                SELECT 
                                    BankReconcilationId, AccountId, Duration,CreditTransfer, InterestReceived, StaleChqsReversed, BankCharges,DebitTransfer,OutstandingStaleChqs,UnpresentedChqs, BankNotCashBook,UncreditedLodgements, CashBookNotBank, DiffBtwBankAndCashBook, IsDeleted,CreatedAt, UpdatedAt 
                                FROM
                                    BankReconcilations
                                WHERE
                                    AccountId = @AccountId AND Duration = @Duration AND IsDeleted = false";
                return connection.Query<BankReconcilationModel>(query, new {
                    AccountId = accountId,
                    Duration = duration
                }).SingleOrDefault();
            }
        }
    }
}
