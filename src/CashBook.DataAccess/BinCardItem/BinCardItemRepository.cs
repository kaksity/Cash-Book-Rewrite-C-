using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.BinCardItem;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace CashBook.DataAccess.BinCardItem
{
    public class BinCardItemRepository : IBinCardItemRepository
    {
        IDbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }

        public void CreateBinCardItem(BinCardItemModel model)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"INSERT INTO
                                    BINCARDITEMS (BINCARDITEMID, BINCARDITEMNAME, BINCARDITEMDESCRPTION,ISDELETED, CREATEDAT, UPDATEDAT)
                                VALUES (@BinCardItemId,@BinCardItemName,@BinCardItemDescription,@IsDeleted,@CreatedAt,@UpdatedAt)
                ";
                connection.Execute(query,model);
            }
        }

        public void DeleteBinCardItem(string binCardItemId)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"UPDATE 
                                    BinCardItems
                                 SET
                                    IsDeleted=true, UpdatedAt=@UpdatedAt 
                                WHERE
                                    BinCardItemId=@BinCardItemId AND IsDeleted=false
                ";
                connection.Execute(query, new { BinCardItemId=binCardItemId,UpdatedAt=DateTime.Now});
            }
        }

        public List<BinCardItemModel> GetAllBinCardItem()
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"SELECT * FROM BinCardItems WHERE IsDeleted=false ORDER BY BinCardItemName ASC";
                return connection.Query<BinCardItemModel>(query).ToList();
            }
        }

        public void UpdateBinCardItem(BinCardItemModel model)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"UPDATE 
                                    BinCardItems
                                 SET
                                    BinCardItemName=@BinCardItemName,BINCARDITEMDESCRPTION=@BinCardItemDescription,UpdatedAt=@UpdatedAt 
                                WHERE
                                    BinCardItemId=@BinCardItemId AND IsDeleted=false
                ";
                connection.Execute(query, model);
            }
        }
    }
}
