using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace CashBook.DataAccess.Reports.DebtorLedger
{
    public class DebtorLedgerReportRepository : IDebtorLedgerReportRepository
    {
        public FbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }

        public DataTable GetAllAdvancedDebtorLedgerReports(string debtorId, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                var tblResults = new DataTable();

                string query = @"SELECT DL.DEBTORLEDGERID, DL.DEBTORID, AC.ACCOUNTNAME, DL.DATEOFADVANCERETIRE, DL.JVNUMBER, DL.PVNUMBER, DL.AMMOUNTADVANCED, DL.AMMOUNTRETIRED, DL.AMMOUNTRETIRED AS CUMMULATIVEBALANCE, DL.DESCRIPTION, DL.ISDELETED, DL.CREATEDAT, DL.UPDATEDAT FROM DEBTORLEDGERS DL INNER JOIN ACCOUNTS AC ON DL.ACCOUNTID = AC.ACCOUNTID WHERE DL.IsDeleted=false AND DL.DebtorId=@DebtorId AND EXTRACT(YEAR FROM DL.DATEOFADVANCERETIRE) = @Year AND DL.AMMOUNTRETIRED=0.00 AND DL.PVNUMBER='-' ORDER BY DL.DATEOFADVANCERETIRE ASC";

                var adapter = new FbDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.Add("DebtorId", debtorId);
                adapter.SelectCommand.Parameters.Add("Year", year);

                adapter.Fill(tblResults);

                return tblResults;
            }
        }

        public DataTable GetAllDebtorLedgerReports(string debtorId, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                var tblResults = new DataTable();

                string query = @"SELECT DL.DEBTORLEDGERID, DL.DEBTORID, AC.ACCOUNTNAME, DL.DATEOFADVANCERETIRE, DL.JVNUMBER, DL.PVNUMBER, DL.AMMOUNTADVANCED, DL.AMMOUNTRETIRED, DL.AMMOUNTRETIRED AS CUMMULATIVEBALANCE, DL.DESCRIPTION, DL.ISDELETED, DL.CREATEDAT, DL.UPDATEDAT FROM DEBTORLEDGERS DL INNER JOIN ACCOUNTS AC ON DL.ACCOUNTID = AC.ACCOUNTID WHERE DL.IsDeleted=false AND DL.DebtorId=@DebtorId AND EXTRACT(YEAR FROM DL.DATEOFADVANCERETIRE) = @Year  ORDER BY DL.DATEOFADVANCERETIRE ASC";

                var adapter = new FbDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.Add("DebtorId", debtorId);
                adapter.SelectCommand.Parameters.Add("Year", year);

                adapter.Fill(tblResults);

                return tblResults;
            }
        }

        public DataTable GetAllRetiredDebtorLedgerReports(string debtorId, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                var tblResults = new DataTable();

                string query = @"SELECT DL.DEBTORLEDGERID, DL.DEBTORID, AC.ACCOUNTNAME, DL.DATEOFADVANCERETIRE, DL.JVNUMBER, DL.PVNUMBER, DL.AMMOUNTADVANCED, DL.AMMOUNTRETIRED, DL.AMMOUNTRETIRED AS CUMMULATIVEBALANCE, DL.DESCRIPTION, DL.ISDELETED, DL.CREATEDAT, DL.UPDATEDAT FROM DEBTORLEDGERS DL INNER JOIN ACCOUNTS AC ON DL.ACCOUNTID = AC.ACCOUNTID WHERE DL.IsDeleted=false AND DL.DebtorId=@DebtorId AND EXTRACT(YEAR FROM DL.DATEOFADVANCERETIRE) = @Year AND DL.AMMOUNTADVANCED=0.00 AND DL.JVNUMBER='-'  ORDER BY DL.DATEOFADVANCERETIRE ASC";

                var adapter = new FbDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.Add("DebtorId", debtorId);
                adapter.SelectCommand.Parameters.Add("Year", year);

                adapter.Fill(tblResults);

                return tblResults;
            }
        }

        public DataTable GetSingleAccountAndAdvanceOrRetire(string debtorId, string accountId, string advancedRetired, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                var tblResults = new DataTable();
                var query = new StringBuilder();

                query.Append(@"SELECT DL.DEBTORLEDGERID, DL.DEBTORID, AC.ACCOUNTNAME, DL.DATEOFADVANCERETIRE, DL.JVNUMBER, DL.PVNUMBER, DL.AMMOUNTADVANCED, DL.AMMOUNTRETIRED, DL.AMMOUNTRETIRED AS CUMMULATIVEBALANCE, DL.DESCRIPTION, DL.ISDELETED, DL.CREATEDAT, DL.UPDATEDAT FROM DEBTORLEDGERS DL INNER JOIN ACCOUNTS AC ON DL.ACCOUNTID = AC.ACCOUNTID WHERE DL.IsDeleted=false AND DL.DebtorId=@DebtorId AND EXTRACT(YEAR FROM DL.DATEOFADVANCERETIRE) = @Year AND DL.AccountId = @AccountId ");
                if (advancedRetired == "ADVANCE")
                    query.Append(" AND DL.AMMOUNTRETIRED=0.00 AND DL.PVNUMBER='-' ");
                else
                    query.Append(" AND DL.AMMOUNTADVANCED = 0.00 AND DL.JVNUMBER = '-' ");
                query.Append(" ORDER BY DL.DATEOFADVANCERETIRE ASC");
                var adapter = new FbDataAdapter(query.ToString(), connection);
                adapter.SelectCommand.Parameters.Add("DebtorId", debtorId);
                adapter.SelectCommand.Parameters.Add("AccountId", accountId);
                adapter.SelectCommand.Parameters.Add("Year", year);

                adapter.Fill(tblResults);

                return tblResults;
            }
        }

        public DataTable GetSingleAccountAndAllAdvanceRetireDebtorLedgerReports(string debtorId, string accountId, int year)
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                var tblResults = new DataTable();

                string query = @"SELECT DL.DEBTORLEDGERID, DL.DEBTORID, AC.ACCOUNTNAME, DL.DATEOFADVANCERETIRE, DL.JVNUMBER, DL.PVNUMBER, DL.AMMOUNTADVANCED, DL.AMMOUNTRETIRED, DL.AMMOUNTRETIRED AS CUMMULATIVEBALANCE, DL.DESCRIPTION, DL.ISDELETED, DL.CREATEDAT, DL.UPDATEDAT FROM DEBTORLEDGERS DL INNER JOIN ACCOUNTS AC ON DL.ACCOUNTID = AC.ACCOUNTID WHERE DL.IsDeleted=false AND DL.DebtorId=@DebtorId AND EXTRACT(YEAR FROM DL.DATEOFADVANCERETIRE) = @Year AND DL.AccountId = @AccountId ORDER BY DL.DATEOFADVANCERETIRE ASC";

                var adapter = new FbDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.Add("DebtorId", debtorId);
                adapter.SelectCommand.Parameters.Add("AccountId",accountId);
                adapter.SelectCommand.Parameters.Add("Year", year);

                adapter.Fill(tblResults);

                return tblResults;
            }
        }
    }
}
