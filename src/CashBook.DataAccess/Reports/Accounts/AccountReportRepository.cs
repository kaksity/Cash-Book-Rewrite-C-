using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace CashBook.DataAccess.Reports.Accounts
{
    public class AccountReportRepository : IAccountReportRepository
    {
        public FbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }


        public DataTable GetAccounts()
        {
            using (var connection = dbConnection)
            {
                connection.Open();

                string query = "SELECT * FROM Accounts WHERE IsDeleted=false";
                var tblReports = new DataTable();

                tblReports.Clear();

                var adapter = new FbDataAdapter(query,connection);
                adapter.Fill(tblReports);

                return tblReports;
            }
        }
    }
}
