using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.DataAccess.Reports.BinCards
{
    public interface IBinCardReportRepository
    {
        DataTable GetAllBinCardsReports(string binCardItemId,  int year);
        DataTable GetAllReceivedBinCardsReports(string binCardItemId, int year);
        DataTable GetAllIssuedBinCardsReports(string binCardItemId, int year);
        DataTable GetAllBinCardBeforeDateOfRequest(string binCardItemId, DateTime date);
    }
}
