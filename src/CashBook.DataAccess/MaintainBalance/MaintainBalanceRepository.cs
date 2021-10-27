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
        public void CreateMaintainBalance(ReadMaintainBalanceDto model)
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

        public List<ReadMaintainBalanceDto> GetAllMaintainBalanceByAccount(string accountId)
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
                return connection.Query<ReadMaintainBalanceDto>(query, new { AccountId = accountId }).ToList();
            }
        }

        public ReadMaintainBalanceDto GetMaintainBalanceByAccountIdAndDuration(string accountId, string duration)
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
                return connection.Query<ReadMaintainBalanceDto>(query, new {
                    AccountId = accountId,
                    Duration = duration
                }).SingleOrDefault();
            }
        }
    }
}
