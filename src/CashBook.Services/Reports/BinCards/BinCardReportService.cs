using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.DataAccess.Reports.BinCards;
using CashBook.Services.BinCardItem;
using CashBook.Services.User;
using CashBook.Services.Utility;

namespace CashBook.Services.Reports.BinCards
{
    public class BinCardReportService : IBinCardReportService
    {
        private readonly IBinCardReportRepository _binCardReportRepository;
        private readonly IUserService _userService;
        private readonly IBinCardItemService _binCardItemService;
        private readonly IUtilityService _utilityService;

        public BinCardReportService(IBinCardReportRepository binCardReportRepository, IUserService userService, IBinCardItemService binCardItemService,IUtilityService utilityService)
        {
            _binCardReportRepository = binCardReportRepository;
            _userService = userService;
            _utilityService = utilityService;
            _binCardItemService = binCardItemService;

        }
        private DataTable PrepareTable(DataTable table)
        {

            
            decimal balanceQuantity = 0;
            decimal balancePrice = 0;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                decimal issuedQuantity = table.Rows[i].Field<decimal>("IssuedQuantity");
                decimal receivedQuantity = table.Rows[i].Field<decimal>("ReceivedQuantity");
                decimal unitPrice = table.Rows[i].Field<decimal>("UnitPrice");
                decimal totalPrice = 0;

                if (issuedQuantity != 0)
                {
                    balanceQuantity = balanceQuantity - issuedQuantity;
                    totalPrice = unitPrice * issuedQuantity;
                    balancePrice = balancePrice - totalPrice;
                }
                else
                {

                    balanceQuantity = balanceQuantity + receivedQuantity;
                    totalPrice = unitPrice * receivedQuantity;
                    balancePrice = balancePrice + totalPrice;
                }

                table.Rows[i].SetField("IssuedQuantity", _utilityService.FormatDecimal(issuedQuantity));
                table.Rows[i].SetField("ReceivedQuantity", _utilityService.FormatDecimal(receivedQuantity));
                table.Rows[i].SetField("UnitPrice", _utilityService.FormatDecimal(unitPrice));
                table.Rows[i].SetField("BalanceQuantity", _utilityService.FormatDecimal(balanceQuantity));
                table.Rows[i].SetField("TotalPrice",_utilityService.FormatDecimal(totalPrice));
                table.Rows[i].SetField("CUMMULATIVEPRICETOTAL", _utilityService.FormatDecimal(balancePrice));
            }
            return table;
        }
        public DataTable GetAllBinCardsReports(string binCardItemId, int month, int year)
        {

            var tblResults = _binCardReportRepository.GetAllBinCardsReports(binCardItemId,month,year);
            return PrepareTable(tblResults);
        }

        public DataTable GetAllIssuedBinCardsReports(string binCardItemId, int month, int year)
        {
            var tblResults = _binCardReportRepository.GetAllIssuedBinCardsReports(binCardItemId, month, year);
            return PrepareTable(tblResults);
        }

        public DataTable GetAllReceivedBinCardsReports(string binCardItemId, int month, int year)
        {
            var tblResults = _binCardReportRepository.GetAllReceivedBinCardsReports(binCardItemId, month, year);
            return PrepareTable(tblResults);
        }

        public string GenerateReportParameters(string binCardItemId, int month, int year, string userId)
        {
            var user = _userService.GetUserByUserId(userId);
            var binCardItem = _binCardItemService.GetAllBinCardItem().Where(t => t.BinCardItemId == binCardItemId).FirstOrDefault();

            var date = DateTime.Parse($"{month}/1/{year}");

            var parameters = new StringBuilder();
            
            parameters.Append($"OrganizationName={user.OrganizationName}&");
            parameters.Append($"BinCardItemAndDuration={binCardItem.BinCardItemName} AS OF 1st {GetDateOfReport(month, year)}&");
            return parameters.ToString();
        }


        private string GetDateOfReport(int month, int year)
        {
            var tblMonths = _utilityService.GetMonths();
            
            return $"{tblMonths.Rows[month - 1].Field<string>("name")} {year}";
        }
    }
}
