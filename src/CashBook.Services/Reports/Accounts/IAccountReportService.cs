using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Services.Reports.Accounts
{
    public interface IAccountReportService
    {
        DataTable GetAllAccounts();
        string GenerateReportParameters(string userId);
    }
}
