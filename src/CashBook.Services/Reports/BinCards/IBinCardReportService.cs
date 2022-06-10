using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Services.Reports.BinCards
{
    public interface IBinCardReportService
    {
        DataTable GetAllBinCardsReports(string binCardItemId, int year);
        DataTable GetAllReceivedBinCardsReports(string binCardItemId, int year);
        DataTable GetAllIssuedBinCardsReports(string binCardItemId, int year);
        string GenerateReportParameters(string binCardItemId, int year, string userId);
    }
}
