using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.TransactionDescription;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using Dapper;

namespace CashBook.DataAccess.TransactionDescription
{
    public class TransactionDescriptionRepository : ITransactionDescriptionRepository
    {
        IDbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }

        public void CreateTransactionDescription(TransactionDescriptionModel model)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"INSERT INTO 
                                    TransactionDescriptions(TransactionDescriptionId,DescriptionName,TransactionType,Description,IsDeleted,CreatedAt,UpdatedAt)
                                 VALUES
                                    (@TransactionDescriptionId,@DescriptionName,@TransactionType,@Description,@IsDeleted,@CreatedAt,@UpdatedAt)
                                ";
                connection.Execute(query,model);
            }   
        }

        public void DeleteTransactionDescription(string transactionDescriptionId)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"UPDATE 
                                    TransactionDescriptions
                                 SET                                            
                                    IsDeleted = true
                                 WHERE
                                    TransactionDescriptionId = @TransactionDescriptionId AND IsDeleted = false
                                ";
                connection.Execute(query, new { TransactionDescriptionId  = transactionDescriptionId});
            }
        }

        public List<TransactionDescriptionModel> GetAllTransactionDescriptions()
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"SELECT 
                                    TransactionDescriptionId,DescriptionName,TransactionType,Description,IsDeleted,CreatedAt,UpdatedAt
                                 FROM 
                                    TransactionDescriptions 
                                 WHERE
                                    IsDeleted=false
                                 ORDER BY
                                    DescriptionName
                                 ASC
                                ";
                return connection.Query<TransactionDescriptionModel>(query).ToList();
            }
        }

        public List<TransactionDescriptionModel> GetAllTransactionDescriptionsByTransactionType(string transactionType)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"SELECT 
                                    TransactionDescriptionId,DescriptionName,TransactionType,Description,IsDeleted,CreatedAt,UpdatedAt
                                 FROM 
                                    TransactionDescriptions 
                                 WHERE
                                    IsDeleted=false AND TransactionType=@TransactionType
                                 ORDER BY
                                    DescriptionName
                                 ASC
                                ";
                return connection.Query<TransactionDescriptionModel>(query,new { TransactionType = transactionType}).ToList();
            }
        }
    }
}
