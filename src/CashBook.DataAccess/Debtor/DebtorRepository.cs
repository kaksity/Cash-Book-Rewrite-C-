using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.Debtor;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace CashBook.DataAccess.Debtor
{
    public class DebtorRepository : IDebtorRepository
    {

        IDbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }

        public void CreateDebtor(DebtorModel model)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                INSERT INTO 
                                    DEBTORS (DebtorId, FullName, DebtorLedgerNumber, IsDeleted, CreatedAt, UpdatedAt)
                                VALUES
                                    (@DebtorId, @FullName, @DebtorLedgerNumber, @IsDeleted, @CreatedAt, @UpdatedAt);
                ";
                connection.Execute(query, model);
            }
        }

        public void DeleteDebtor(string debtorId)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                UPDATE 
                                    Debtors
                                SET
                                    IsDeleted=true,UpdatedAt=@UpdatedAt
                                WHERE 
                                    IsDeleted=false AND DebtorId = @DebtorId
                ";
                connection.Execute(query, new { DebtorId = debtorId, UpdatedAt = DateTime.Now });
            }
        }

        public List<DebtorModel> GetAllDebtors()
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                SELECT
                                    DebtorId, FullName, DebtorLedgerNumber, IsDeleted, CreatedAt, UpdatedAt
                                FROM
                                    Debtors
                                WHERE 
                                    IsDeleted=false
                                ORDER BY 
                                    FullName
                                ASC
                ";
                return connection.Query<DebtorModel>(query).ToList();
            }
        }

        public DebtorModel GetDebtorByDebtorId(string debtorId)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                SELECT
                                    DebtorId, FullName, DebtorLedgerNumber, IsDeleted, CreatedAt, UpdatedAt
                                FROM
                                    Debtors
                                WHERE 
                                    IsDeleted=false And DebtorId = @DebtorId
                ";
                return connection.Query<DebtorModel>(query, new { DebtorId = debtorId }).FirstOrDefault();
            }
        }

        public DebtorModel GetDebtorByDebtorLedgerNumber(string debtorLedgerNumber)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                SELECT
                                    DebtorId, FullName, DebtorLedgerNumber, IsDeleted, CreatedAt, UpdatedAt
                                FROM
                                    Debtors
                                WHERE 
                                    IsDeleted=false And DebtorLedgerNumber = @DebtorLedgerNumber
                ";
                return connection.Query<DebtorModel>(query,new { DebtorLedgerNumber = debtorLedgerNumber }).FirstOrDefault();
            }
        }

        public void UpdateDebtor(DebtorModel model)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                UPDATE 
                                    Debtors
                                SET
                                    DebtorId=@DebtorId, FullName=@FullName, DebtorLedgerNumber=@DebtorLedgerNumber, UpdatedAt = @UpdatedAt
                                WHERE 
                                    IsDeleted=false AND DebtorId = @DebtorId
                ";
                connection.Execute(query, model);
            }
        }
    }
}
