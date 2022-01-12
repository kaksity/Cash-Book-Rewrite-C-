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
                                    MaintainBalances (MaintainBalanceId, AccountId, OpeningBalance,ClosingBalance, Duration, Status,IsEdited, IsDeleted, CreatedAt, UpdatedAt)
                                VALUES 
                                    (@MaintainBalanceId, @AccountId, @OpeningBalance,@ClosingBalance, @Duration, @Status, @IsEdited,@IsDeleted, @CreatedAt, @UpdatedAt)
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
                                    MaintainBalanceId, AccountId, OpeningBalance,ClosingBalance, Duration, Status, IsEdited, IsDeleted, CreatedAt, UpdatedAt 
                                FROM 
                                    MaintainBalances 
                                WHERE
                                    AccountId=@AccountId AND IsDeleted=false
                                ORDER BY
                                    Duration
                                DESC
                                ";
                connection.Open();
                return connection.Query<MaintainBalanceModel>(query, new { AccountId = accountId }).ToList();
            }
        }

        public MaintainBalanceModel GetMaintainBalanceByAccountIdAndDuration(string accountId, DateTime duration)
        {
            using (IDbConnection connection = dbConnection)
            {
                string query = @"
                                SELECT
                                    MaintainBalanceId, AccountId, OpeningBalance,ClosingBalance, Duration, Status, IsEdited, IsDeleted, CreatedAt, UpdatedAt 
                                FROM 
                                    MaintainBalances 
                                WHERE
                                    AccountId = @AccountId AND EXTRACT( MONTH FROM Duration) = @Month AND EXTRACT(YEAR FROM Duration) = @Year AND IsDeleted=false
                                ORDER BY
                                    Duration
                                DESC
                                ";
                connection.Open();
                return connection.Query<MaintainBalanceModel>(query, new {
                    AccountId = accountId,
                    Month = duration.Month,
                    Year = duration.Year
                }).SingleOrDefault();
            }
        }

        public MaintainBalanceModel GetMaintainBalanceByBankReconcilationId(string maintainBalanceId)
        {
            using (IDbConnection connection = dbConnection)
            {
                string query = @"
                                SELECT
                                    MaintainBalanceId, AccountId, OpeningBalance,ClosingBalance, Duration, Status, IsEdited, IsDeleted, CreatedAt, UpdatedAt 
                                FROM 
                                    MaintainBalances 
                                WHERE
                                    MaintainBalanceId = @MaintainBalanceId AND IsDeleted=false
                                ORDER BY
                                    Duration
                                DESC
                                ";
                connection.Open();
                return connection.Query<MaintainBalanceModel>(query, new
                {
                    MaintainBalanceId = maintainBalanceId
                }).SingleOrDefault();
            }
        }
        public void CloseMaintainBalance(MaintainBalanceModel model)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = @"
                            UPDATE
                                MaintainBalances
                            SET
                                ClosingBalance=@ClosingBalance, Duration=@Duration, IsEdited=@IsEdited,Status = @Status, UpdatedAt=@UpdatedAt
                            WHERE
                                MaintainBalanceId=@MaintainBalanceId AND IsDeleted=false
                            ";

                        connection.Execute(query,param:model, transaction:transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void DeleteMaintainBalance(string maintainBalanceId)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"
                            UPDATE
                                MaintainBalances
                            SET
                                IsDeleted=true, UpdatedAt=@UpdatedAt
                            WHERE
                                MaintainBalanceId=@MaintainBalanceId AND IsDeleted=false
                            ";

                connection.Execute(query, param: new { MaintainBalanceId = maintainBalanceId,UpdatedAt = DateTime.Now});
            }
        }

        public void SetMaintainBalanceAsEdited(string maintainBalanceId)
        {
           
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = "SELECT * FROM MaintainBalances WHERE MaintainBalanceId=@MaintainBalanceId AND IsDeleted=false";

                var result = connection.Query<MaintainBalanceModel>(query, param: new { MaintainBalanceId = maintainBalanceId}).SingleOrDefault();

                var parameter = new { Duration = result.Duration, UpdatedAt = DateTime.Now };
                query = @"
                            UPDATE
                                MaintainBalances
                            SET
                                IsEdited=true, UpdatedAt=@UpdatedAt
                            WHERE
                                Duration >=  @Duration AND IsDeleted=false
                            ";

                connection.Execute(query, param: parameter);
            }
        }

        public List<MaintainBalanceModel> GetEditedMaintainBalanceByAccount(string accountId)
        {
            using (IDbConnection connection = dbConnection)
            {
                string query = @"
                                SELECT
                                    MaintainBalanceId, AccountId, OpeningBalance,ClosingBalance, Duration, Status, IsEdited, IsDeleted, CreatedAt, UpdatedAt 
                                FROM 
                                    MaintainBalances 
                                WHERE
                                    AccountId=@AccountId AND IsDeleted=false AND IsEdited=true
                                ORDER BY
                                    Duration
                                ASC
                                ";
                connection.Open();
                return connection.Query<MaintainBalanceModel>(query, new { AccountId = accountId }).ToList();
            }
        }

        public void UpdateMaintainBalance(MaintainBalanceModel model)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"
                            UPDATE
                                MaintainBalances
                            SET
                                OpeningBalance=@OpeningBalance, ClosingBalance=@ClosingBalance, IsEdited=@IsEdited,Status=@Status,UpdatedAt=@UpdatedAt
                            WHERE
                                MaintainBalanceId=@MaintainBalanceId AND IsDeleted=false
                            ";

                connection.Execute(query, param: model);
            }
        }
    }
}
