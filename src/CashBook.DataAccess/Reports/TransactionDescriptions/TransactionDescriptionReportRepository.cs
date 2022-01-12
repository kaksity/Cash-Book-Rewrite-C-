using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace CashBook.DataAccess.Reports.TransactionDescriptions
{
    public class TransactionDescriptionReportRepository : ITransactionDescriptionReportRepository
    {

        public FbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }


        public DataTable GetAllExpenseItems()
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                DataTable tblItems = new DataTable();
                tblItems.Clear();

                string query = @"
                                 SELECT * FROM TransactionDescriptions WHERE IsDeleted=false AND TransactionType='EXPENSE'
                ";

                var adapter = new FbDataAdapter(query,connection);
                adapter.Fill(tblItems);
                return tblItems;
            }
        }

        public DataTable GetAllIncomeItems()
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                DataTable tblItems = new DataTable();
                tblItems.Clear();

                string query = @"
                                 SELECT * FROM TransactionDescriptions WHERE IsDeleted=false AND TransactionType='INCOME'
                ";

                var adapter = new FbDataAdapter(query, connection);
                adapter.Fill(tblItems);
                return tblItems;
            }
        }

        public DataTable GetAllItems()
        {
            using (var connection = dbConnection)
            {
                connection.Open();
                DataTable tblItems = new DataTable();
                tblItems.Clear();

                string query = @"
                                 SELECT * FROM TransactionDescriptions WHERE IsDeleted=false
                ";

                var adapter = new FbDataAdapter(query, connection);
                adapter.Fill(tblItems);
                return tblItems;
            }
        }
    }
}
