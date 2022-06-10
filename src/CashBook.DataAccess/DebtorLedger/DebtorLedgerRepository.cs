using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.Debtor;
using CashBook.Models.DebtorLedger;
using Dapper;
using FirebirdSql.Data.FirebirdClient;
using CashBook.Models.Account;

namespace CashBook.DataAccess.DebtorLedger
{
    public class DebtorLedgerRepository : IDebtorLedgerRepository
    {
        IDbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }

        public void CreateDebtorLedger(DebtorLedgerModel model)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"INSERT INTO 
                                    DebtorLedgers (DebtorLedgerId, DebtorId, AccountId, DateOfAdvanceRetire, JvNumber, PvNumber, AmmountAdvanced, AmmountRetired, DESCRIPTION, IsDeleted, CreatedAt, UpdatedAt)
                                 VALUES 
                                    (@DebtorLedgerId, @DebtorId, @AccountId, @DateOfAdvanceRetire, @JvNumber, @PvNumber, @AmmountAdvanced, @AmmountRetired, @Description, @IsDeleted, @CreatedAt, @UpdatedAt);
";
                connection.Execute(query, model);
            }
        }

        public void DeleteDebtorLedger(string debtorLedgerId)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                UPDATE
                                    DebtorLedgers
                                SET 
                                    IsDeleted = true, UpdatedAt = @UpdatedAt
                                WHERE 
                                    IsDeleted=false AND DebtorLedgerId = @DebtorLedgerId
                ";
                connection.Execute(query, new { DebtorLedgerId = debtorLedgerId, UpdatedAt = DateTime.Now });
            }
        }

        public List<DebtorLedgerModel> GetAllDebtorLedger()
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                SELECT 
                                    dl.*,d.*,ac.*
                                FROM
                                    DebtorLedgers dl
                                INNER JOIN
                                    Debtors d
                                ON
                                    dl.DebtorId = d.DebtorId
                                INNER JOIN
                                    Accounts ac
                                ON
                                    dl.AccountId = ac.AccountId
                                WHERE 
                                    dl.IsDeleted=false
                                ORDER BY
                                    dl.DateOfAdvanceRetire
                                ASC
                ";
                return connection.Query<DebtorLedgerModel,DebtorModel,AccountModel,DebtorLedgerModel>(sql:query,map: (debtorLedger,debtor,account) => {
                    debtorLedger.Debtor = debtor;
                    debtorLedger.Account = account;
                    return debtorLedger;
                },splitOn: "DebtorId,AccountId").ToList();
            }
        }

        public List<DebtorLedgerModel> GetAllDebtorLedgerByDebtorId(string debtorId)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                SELECT 
                                    dl.*,d.*,ac.*
                                FROM
                                    DebtorLedgers dl
                                INNER JOIN
                                    Debtors d
                                ON
                                    dl.DebtorId = d.DebtorId
                                INNER JOIN
                                    Accounts ac
                                ON
                                    dl.AccountId = ac.AccountId
                                WHERE 
                                    dl.IsDeleted=false AND dl.DebtorId = @DebtorId
                                ORDER BY
                                    dl.DateOfAdvanceRetire
                                DESC
                ";
                return connection.Query<DebtorLedgerModel, DebtorModel, AccountModel, DebtorLedgerModel>(sql: query, map: (debtorLedger, debtor,account) => {
                    debtorLedger.Debtor = debtor;
                    debtorLedger.Account = account;
                    return debtorLedger;
                },
                splitOn: "DebtorId,AccountId",
                param: new { DebtorId = debtorId }).ToList();
            }
        }
    }
}
