using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.DataAccess.Reports.Accounts
{
    public interface IAccountReportRepository
    {
        DataTable GetAccounts();
    }
}
