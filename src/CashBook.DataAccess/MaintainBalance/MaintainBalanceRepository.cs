using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.MaintainBalance;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using Dapper;

namespace CashBook.DataAccess.MaintainBalance
{
    public class MaintainBalanceRepository : IMaintainBalanceRepository
    {
        IDbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }

        public void CreateMaintainBalance(MaintainBalanceModel model)
        {
            using (IDbConnection connection = dbConnection)
            {
                string query = @"
                                INSERT INTO 
                                    MaintainBalances (MaintainBalanceId, AccountId, OpeningBalance,ClosingBalance, Duration, Status, IsDeleted, CreatedAt, UpdatedAt)
                                VALUES 
                                    (@MaintainBalanceId, @AccountId, @OpeningBalance,@ClosingBalance, @Duration, @Status, @IsDeleted, @CreatedAt, @UpdatedAt)
                                ";
                connection.Open();

                connection.Execute(query,model);
            }
        }

        //public List<MaintainBalanceModel> GetAllMaintainBalance()
        //{
        //    using (IDbConnection connection = dbConnection)
        //    {
        //        string query = @"
        //                        SELECT
        //                            MaintainBalanceId, AccountId, OpeningBalance,ClosingBalance, Duration, Status, IsDeleted, CreatedAt, UpdatedAt 
        //                        FROM 
        //                            MaintainBalances 
        //                        WHERE
        //                            IsDeleted=false
        //                        ";
        //        connection.Open();
        //        return connection.Query<MaintainBalanceModel>(query).ToList();
        //    }
        //}

        public List<MaintainBalanceModel> GetAllMaintainBalanceByAccount(string accountId)
        {
            using (IDbConnection connection = dbConnection)
            {
                string query = @"
                                SELECT
                                    MaintainBalanceId, AccountId, OpeningBalance,ClosingBalance, Duration, Status, IsDeleted, CreatedAt, UpdatedAt 
                                FROM 
                                    MaintainBalances 
                                WHERE
                                    AccountId=@AccountId AND IsDeleted=false
                                ";
                connection.Open();
                return connection.Query<MaintainBalanceModel>(query, new { AccountId = accountId }).ToList();
            }
        }

        public MaintainBalanceModel GetMaintainBalanceByAccountIdAndDuration(string accountId, string duration)
        {
            using (IDbConnection connection = dbConnection)
            {
                string query = @"
                                SELECT
                                    MaintainBalanceId, AccountId, OpeningBalance,ClosingBalance, Duration, Status, IsDeleted, CreatedAt, UpdatedAt 
                                FROM 
                                    MaintainBalances 
                                WHERE
                                    AccountId = @AccountId AND Duration = @Duration AND IsDeleted=false
                                ";
                connection.Open();
                return connection.Query<MaintainBalanceModel>(query, new {
                    AccountId = accountId,
                    Duration = duration
                }).SingleOrDefault();
            }
        }

        public MaintainBalanceModel GetMaintainBalanceByBankReconcilationId(string maintainBalanceId)
        {
            using (IDbConnection connection = dbConnection)
            {
                string query = @"
                                SELECT
                                    MaintainBalanceId, AccountId, OpeningBalance,ClosingBalance, Duration, Status, IsDeleted, CreatedAt, UpdatedAt 
                                FROM 
                                    MaintainBalances 
                                WHERE
                                    MaintainBalanceId = @MaintainBalanceId AND IsDeleted=false
                                ";
                connection.Open();
                return connection.Query<MaintainBalanceModel>(query, new
                {
                    MaintainBalanceId = maintainBalanceId
                }).SingleOrDefault();
            }
        }
        public void UpdateMaintainBalance(MaintainBalanceModel model)
        {
            using (IDbConnection connection = dbConnection)
            {
                string query = @"
                            UPDATE
                                MaintainBalances
                            SET
                                ClosingBalance=@ClosingBalance, Duration=@Duration, Status = @Status, UpdatedAt=@UpdatedAt
                            WHERE
                                MaintainBalanceId=@MaintainBalanceId AND IsDeleted=false
                            ";
                connection.Open();
                connection.Execute(query,model);
            }
        }
    }
}
