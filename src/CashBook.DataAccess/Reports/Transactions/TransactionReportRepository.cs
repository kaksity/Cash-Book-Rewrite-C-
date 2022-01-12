using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace CashBook.DataAccess.Reports
{
    public class TransactionReportRepository : ITransactionReportRepository
    {
        public FbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }

        

        public DataTable GetAllTransactionByTransactionDescriptionAndTransactionType(string accountId, int month, int year, string transactionDescriptionId,string transactionType)
        {
            using (var connection = dbConnection)
            {

                StringBuilder query = new StringBuilder("SELECT trans.AMMOUNTWITHDRAWN, trans.AMMOUNTDEPOSITED, trans.NAMEOFBENEFICIARY, trans.DATEOFTRANSACTION, trans.PVORRVNUMBER, trans.SUBHEADCOLUMN, trans.TRANSACTIONDESCRIPTIONID AS CummulativeBalance, transdec .DescriptionName,trans.REFNUMBER FROM TRANSACTIONS trans INNER JOIN TransactionDescriptions transdec ON trans.TRANSACTIONDESCRIPTIONID = transdec.TRANSACTIONDESCRIPTIONID WHERE trans.IsDeleted=false"); connection.Open();

                query.Append($" AND trans.AccountId = '{accountId}' AND trans.TRANSACTIONDESCRIPTIONID='{transactionDescriptionId}' AND EXTRACT(MONTH FROM trans.DATEOFTRANSACTION)={month} AND EXTRACT(year FROM trans.DATEOFTRANSACTION)={year}");

                if (transactionType == "INCOME")
                    query.Append(" AND trans.AmmountWithdrawn=0");
                else
                    query.Append(" AND trans.AmmountDeposited=0");

                var tblTransactions = new DataTable();

                
                var adapter = new FbDataAdapter(query.ToString(), connection);
                adapter.Fill(tblTransactions);
                return tblTransactions;
            }
        }

        public DataTable GetAllTransactionByTransactionDescriptionOnly(string accountId, int month, int year, string transactionDescriptionId)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                StringBuilder query = new StringBuilder("SELECT trans.AMMOUNTWITHDRAWN, trans.AMMOUNTDEPOSITED, trans.NAMEOFBENEFICIARY, trans.DATEOFTRANSACTION, trans.PVORRVNUMBER, trans.SUBHEADCOLUMN, trans.TRANSACTIONDESCRIPTIONID AS CummulativeBalance, transdec .DescriptionName,trans.REFNUMBER FROM TRANSACTIONS trans INNER JOIN TransactionDescriptions transdec ON trans.TRANSACTIONDESCRIPTIONID = transdec.TRANSACTIONDESCRIPTIONID WHERE trans.IsDeleted=false");
                query.Append($" AND trans.AccountId = '{accountId}' AND trans.TRANSACTIONDESCRIPTIONID='{transactionDescriptionId}' AND EXTRACT(MONTH FROM trans.DATEOFTRANSACTION)={month} AND EXTRACT(year FROM trans.DATEOFTRANSACTION)={year}");

                var tblTransactions = new DataTable();

                var adapter = new FbDataAdapter(query.ToString(), connection);
                adapter.Fill(tblTransactions);
                return tblTransactions;
            }
        }

        public DataTable GetAllTransactionByTransactionTypeOnly(string accountId, int month, int year, string transactionType)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                StringBuilder query = new StringBuilder("SELECT trans.AMMOUNTWITHDRAWN, trans.AMMOUNTDEPOSITED, trans.NAMEOFBENEFICIARY, trans.DATEOFTRANSACTION, trans.PVORRVNUMBER, trans.SUBHEADCOLUMN, trans.TRANSACTIONDESCRIPTIONID AS CummulativeBalance, transdec .DescriptionName,trans.REFNUMBER FROM TRANSACTIONS trans INNER JOIN TransactionDescriptions transdec ON trans.TRANSACTIONDESCRIPTIONID = transdec.TRANSACTIONDESCRIPTIONID WHERE trans.IsDeleted=false");
                query.Append($" AND trans.AccountId = '{accountId}' AND EXTRACT(MONTH FROM trans.DATEOFTRANSACTION)={month} AND EXTRACT(year FROM trans.DATEOFTRANSACTION)={year} ");

                if (transactionType == "INCOME")
                    query.Append(" AND trans.AmmountWithdrawn=0");
                else
                    query.Append(" AND trans.AmmountDeposited=0");

                var tblTransactions = new DataTable();


                var adapter = new FbDataAdapter(query.ToString(), connection);
                adapter.Fill(tblTransactions);
                return tblTransactions;
            }
        }

        public DataTable GetAllTransactions(string accountId, int month, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                StringBuilder query = new StringBuilder("SELECT trans.AMMOUNTWITHDRAWN, trans.AMMOUNTDEPOSITED, trans.NAMEOFBENEFICIARY, trans.DATEOFTRANSACTION, trans.PVORRVNUMBER, trans.SUBHEADCOLUMN, trans.TRANSACTIONDESCRIPTIONID AS CummulativeBalance, transdec .DescriptionName,trans.REFNUMBER FROM TRANSACTIONS trans INNER JOIN TransactionDescriptions transdec ON trans.TRANSACTIONDESCRIPTIONID = transdec.TRANSACTIONDESCRIPTIONID WHERE trans.IsDeleted=false");
                query.Append($" AND trans.AccountId = '{accountId}' AND EXTRACT(MONTH FROM trans.DATEOFTRANSACTION)={month} AND EXTRACT(year FROM trans.DATEOFTRANSACTION)={year} ");
                var tblTransactions = new DataTable();

                var adapter = new FbDataAdapter(query.ToString(), connection);
                adapter.Fill(tblTransactions);
                return tblTransactions;
            }
        }

    }
}
