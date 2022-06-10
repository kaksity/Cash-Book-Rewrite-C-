using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Services.Utility
{
    public class UtilityService : IUtilityService
    {
        public string FormatDecimal(decimal input)
        {
            return input.ToString("N");
        }

        public DataTable GetIssueOrReceipt()
        {
            var tblIssueOrReceipt = new DataTable();

            tblIssueOrReceipt.Columns.Add("name",typeof(string));
            tblIssueOrReceipt.Columns.Add("value",typeof(string));

            tblIssueOrReceipt.Rows.Add("Issue","ISSUE");
            tblIssueOrReceipt.Rows.Add("Receipt","RECEIPT");

            return tblIssueOrReceipt;
        }
        public string FormatDate(DateTime input)
        {
            return input.ToString("dd/MM/yyyy");
        }
        public DataTable GetMonths()
        {
            var tblMonths = new DataTable();

            tblMonths.Columns.Add("name", typeof(string));
            tblMonths.Columns.Add("value", typeof(int));

            tblMonths.Rows.Add("January", 1);
            tblMonths.Rows.Add("February", 2);
            tblMonths.Rows.Add("March", 3);
            tblMonths.Rows.Add("April", 4);
            tblMonths.Rows.Add("May", 5);
            tblMonths.Rows.Add("June", 6);
            tblMonths.Rows.Add("July", 7);
            tblMonths.Rows.Add("August", 8);
            tblMonths.Rows.Add("September", 9);
            tblMonths.Rows.Add("October", 10);
            tblMonths.Rows.Add("November", 11);
            tblMonths.Rows.Add("December", 12);

            return tblMonths;
        }

        public DataTable GetYears()
        {
            var tblYears = new DataTable();
            int currentYear = 0;
            currentYear = 2020;

            tblYears.Columns.Add("name", typeof(string));
            tblYears.Columns.Add("value", typeof(int));

            while (currentYear <= DateTime.Today.Year)
            {
                tblYears.Rows.Add(currentYear, currentYear);
                currentYear += 1;
            }
            return tblYears;
        }

        public DataTable GetAdavnceOrRetire()
        {
            var tblAdvanceOrRetire = new DataTable();

            tblAdvanceOrRetire.Columns.Add("name", typeof(string));
            tblAdvanceOrRetire.Columns.Add("value", typeof(string));

            tblAdvanceOrRetire.Rows.Add("Advance", "ADVANCE");
            tblAdvanceOrRetire.Rows.Add("Retire", "RETIRE");

            return tblAdvanceOrRetire;
        }
    }
}
