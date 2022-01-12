using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.BinCard;
using CashBook.Models.BinCardItem;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace CashBook.DataAccess.BinCard
{
    public class BinCardRepository : IBinCardRepository
    {
        IDbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }
        public void CreateNewBinCard(BinCardModel model)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"INSERT INTO 
                                    BINCARDS(BINCARDID, BINCARDITEMID, DATEOFRECEIPTORISSUE,SIVSRVOTHERS,RECEIVEDQUANTITY, ISSUEDQUANTITY, UNITPRICE, DESCRIPTION, ISDELETED,CREATEDAT, UPDATEDAT)
                                 VALUES (@BinCardId, @BinCardItemId, @DateOfIssueOrReceipt, @SivSrvOthers, @RecievedQuantity, @IssuedQuantity, @UnitPrice, @Description, @IsDeleted, @CreatedAt, @UpdatedAt);
                ";
                connection.Execute(query,model);
            }
        }

        public void DeleteBinCard(string binCardId)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"UPDATE
                                    BinCards
                                 SET 
                                    IsDeleted=true,UpdatedAt=@UpdatedAt
                                 WHERE 
                                    BinCardId=@BinCardId AND IsDeleted=false
                ";
                connection.Execute(query, new { BinCardId = binCardId, UpdatedAt = DateTime.Now});
            }
        }

        public List<BinCardModel> GetAllBinCards()
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"SELECT 
                                    bc.*,bci.*
                                FROM
                                    BinCards bc
                                INNER JOIN
                                    BinCardItems bci
                                ON
                                    bc.BINCARDITEMID = bci.BINCARDITEMID
                                WHERE
                                    bc.IsDeleted = false
                                ORDER BY
                                    bc.DATEOFRECEIPTORISSUE DESC";
                return connection.Query<BinCardModel, BinCardItemModel, BinCardModel>(
                    sql:query,
                    map: (binCard,binCardItem) =>
                    {
                        binCard.BinCardItem = binCardItem;
                        return binCard;
                    },
                    splitOn: "BinCardItemId"
                    ).ToList();
            }
        }

        public List<BinCardModel> GetBinCardsByBinCardItemsMonthAndYear(string binCardItem, int month, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();

                string query = @"SELECT 
                                    bc.*,bci.*
                                FROM
                                    BinCards bc
                                INNER JOIN
                                    BinCardItems bci
                                ON
                                    bc.BINCARDITEMID = bci.BINCARDITEMID
                                WHERE
                                    bc.IsDeleted = false AND bc.BinCardItemId = @BinCardItemId AND EXTRACT(MONTH FROM bc.DateOfReceiptOrIssue) = @Month AND EXTRACT(Year FROM bc.DateOfReceiptOrIssue) = @Year
                                ORDER BY
                                    bc.DATEOFRECEIPTORISSUE DESC";
                return connection.Query<BinCardModel, BinCardItemModel, BinCardModel>(
                    sql: query,
                    map: (binCard, item) =>
                    {
                        binCard.BinCardItem = item;
                        return binCard;
                    },
                    param: new { BinCardItemId = binCardItem, Month = month, Year = year },
                    splitOn: "BinCardItemId"
                    ).ToList();
            }
        }

        public void UpdateExistingBinCard(BinCardModel model)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                string query = @"UPDATE BINCARDS
                                SET 
                                    DATEOFRECEIPTORISSUE = @DateOfReceiptOrIssue, 
                                    RECEIVEDQUANTITY = @ReceivedQuantity, 
                                    ISSUEDQUANTITY = @IssuedQuantity, 
                                    UNITPRICE = @UnitPrice, 
                                    DESCRIPTION = @Description, 
                                    UPDATEDAT = @UpdatedAt
                                WHERE
                                    BINCARDID = @BinCardId AND ISDELETED = @IsDeleted
                ";
                connection.Execute(query, model);
            }
        }
    }
}
