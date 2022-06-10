using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace CashBook.DataAccess.Reports.BinCards
{
    public class BinCardReportRepository : IBinCardReportRepository
    {
        public FbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }

        public DataTable GetAllBinCardBeforeDateOfRequest(string binCardItemId, DateTime date)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                var tblResults = new DataTable();

                string query = @"SELECT SUM(RECEIVEDQUANTITY) AS TotalReceivedQuantity, SUM(ISSUEDQUANTITY) AS TotalIssuedQuantity FROM BINCARDS WHERE ISDELETED = false AND BINCARDITEMID = @BinCardItemId AND DATEOFISSUEORRECEIPT < @DateOfReceiptOrIssue";

                var adapter = new FbDataAdapter(query,connection);
                adapter.SelectCommand.Parameters.Add("BinCardItemId", binCardItemId);
                adapter.SelectCommand.Parameters.Add("DateOfReceiptOrIssue", date);

                adapter.Fill(tblResults);

                return tblResults;
            }
        }

        public DataTable GetAllBinCardsReports(string binCardItemId, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                var tblResults = new DataTable();
                string query = $"SELECT BINCARDID, BINCARDITEMID, SIVSRVOTHERS,DATEOFISSUEORRECEIPT, RECEIVEDQUANTITY, ISSUEDQUANTITY, ISSUEDQUANTITY AS BALANCEQUANTITY,ISSUEDQUANTITY AS CUMMULATIVEPRICETOTAL, UNITPRICE, UNITPRICE AS TOTALPRICE, DESCRIPTION, ISDELETED, CREATEDAT, UPDATEDAT FROM BINCARDS WHERE ISDELETED = false AND BINCARDITEMID = '{binCardItemId}' AND EXTRACT(YEAR FROM DATEOFISSUEORRECEIPT ) = {year} ORDER BY DATEOFISSUEORRECEIPT ASC";

                var adapter = new FbDataAdapter(query,connection);
                adapter.Fill(tblResults);

                return tblResults;
            }
        }

        public DataTable GetAllIssuedBinCardsReports(string binCardItemId, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                var tblResults = new DataTable();
                string query = $"SELECT BINCARDID, BINCARDITEMID, SIVSRVOTHERS,DATEOFISSUEORRECEIPT, RECEIVEDQUANTITY, ISSUEDQUANTITY, ISSUEDQUANTITY AS BALANCEQUANTITY, UNITPRICE, UNITPRICE AS TOTALPRICE, DESCRIPTION,ISSUEDQUANTITY AS CUMMULATIVEPRICETOTAL, ISDELETED, CREATEDAT, UPDATEDAT FROM BINCARDS WHERE ISDELETED = false AND BINCARDITEMID = '{binCardItemId}' AND EXTRACT(YEAR FROM DATEOFISSUEORRECEIPT ) = {year} AND RECEIVEDQUANTITY = 0.00 ORDER BY DATEOFISSUEORRECEIPT ASC";

                var adapter = new FbDataAdapter(query, connection);
                adapter.Fill(tblResults);

                return tblResults;
            }
        }

        public DataTable GetAllReceivedBinCardsReports(string binCardItemId, int year)
        {
            using (var connection = dbConnection)
            {

                connection.Open();
                var tblResults = new DataTable();
                string query = $"SELECT BINCARDID, BINCARDITEMID, SIVSRVOTHERS,DATEOFISSUEORRECEIPT, RECEIVEDQUANTITY, ISSUEDQUANTITY, ISSUEDQUANTITY AS BALANCEQUANTITY, UNITPRICE, UNITPRICE AS TOTALPRICE,ISSUEDQUANTITY AS CUMMULATIVEPRICETOTAL, DESCRIPTION, ISDELETED, CREATEDAT, UPDATEDAT FROM BINCARDS WHERE ISDELETED = false AND BINCARDITEMID = '{binCardItemId}' AND EXTRACT(YEAR FROM DATEOFISSUEORRECEIPT ) = {year} AND ISSUEDQUANTITY = 0.00 ORDER BY DATEOFISSUEORRECEIPT ASC";

                var adapter = new FbDataAdapter(query, connection);
                adapter.Fill(tblResults);

                return tblResults;
            }
        }
    }
}
