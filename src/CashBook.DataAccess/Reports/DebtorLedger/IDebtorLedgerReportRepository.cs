using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.DataAccess.Reports.DebtorLedger
{
    public interface IDebtorLedgerReportRepository
    {
        DataTable GetSingleAccountAndAdvanceOrRetire(string debtorId, string accountId, string advancedRetired, int year);
        DataTable GetSingleAccountAndAllAdvanceRetireDebtorLedgerReports(string debtorId, string accountId, int year);
        DataTable GetAllDebtorLedgerReports(string debtorId, int year);
        DataTable GetAllAdvancedDebtorLedgerReports(string debtorId, int year);
        DataTable GetAllRetiredDebtorLedgerReports(string debtorId, int year);
    }
}
