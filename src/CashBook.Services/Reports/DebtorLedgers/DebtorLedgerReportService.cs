using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.DataAccess.Reports.DebtorLedger;
using CashBook.Services.Debtor;
using CashBook.Services.User;
using CashBook.Services.Utility;

namespace CashBook.Services.Reports.DebtorLedgers
{
    public class DebtorLedgerReportService : IDebtorLedgerReportService
    {
        private readonly IUtilityService _utilityService;
        private readonly IUserService _userSerivice;
        private readonly IDebtorLedgerReportRepository _debtorReportRepository;
        private readonly IDebtorService _debtorService; 
        public DebtorLedgerReportService(IDebtorLedgerReportRepository debtorLedgerReportRepository, IUserService userService, IUtilityService utilityService, IDebtorService debtorService)
        {
            _utilityService = utilityService;
            _userSerivice = userService;
            _debtorService = debtorService;
            _debtorReportRepository = debtorLedgerReportRepository;
        }

        public DataTable GetAllAdvancedDebtorLedgerReports(string debtorId, int year)
        {
            var results = _debtorReportRepository.GetAllAdvancedDebtorLedgerReports(debtorId,year);
            return PrepareTable(results);
        }

        private DataTable PrepareTable(DataTable table)
        {
            decimal cummulativeBalance = 0;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                decimal ammountAdvanced = table.Rows[i].Field<decimal>("AmmountAdvanced");
                decimal ammountRetired = table.Rows[i].Field<decimal>("AmmountRetired");

                if (ammountAdvanced != 0)
                {
                    cummulativeBalance = cummulativeBalance + ammountAdvanced;
                }
                else
                {

                    cummulativeBalance = cummulativeBalance - ammountRetired;
                }

                table.Rows[i].SetField("AmmountAdvanced", _utilityService.FormatDecimal(ammountAdvanced));
                table.Rows[i].SetField("AmmountRetired", _utilityService.FormatDecimal(ammountRetired));
                table.Rows[i].SetField("CummulativeBalance", _utilityService.FormatDecimal(cummulativeBalance));
            }

            return table;
        }
        public DataTable GetAllDebtorLedgerReports(string debtorId, int year)
        {
            var results = _debtorReportRepository.GetAllDebtorLedgerReports(debtorId,year);
            return PrepareTable(results);
        }

        public DataTable GetAllRetiredDebtorLedgerReports(string debtorId, int year)
        {
            var results = _debtorReportRepository.GetAllRetiredDebtorLedgerReports(debtorId,year);
            return PrepareTable(results);
        }

        public string GenerateReportParameters(string userId, string debtorId, int year)
        {
            var parameters = new StringBuilder();

            // Get the User Data
            var user = _userSerivice.GetUserByUserId(userId);

            parameters.Append($"OrganizationName={user.OrganizationName}&");

            var debtor = _debtorService.GetAllDebtors().Find(t => t.DebtorId == debtorId);
            parameters.Append($"DebtorName={debtor.FullName}&");
            parameters.Append($"DebtorLedgerNumber={debtor.DebtorLedgerNumber}&");

            parameters.Append($"ReportDuration={year}");
            return parameters.ToString();
        }
        private string GetDateOfReport(int month, int year)
        {
            var tblMonths = _utilityService.GetMonths();

            return $"{tblMonths.Rows[month - 1].Field<string>("name")} {year}";
        }

        public DataTable GetSingleAccountAndAllAdvanceRetireDebtorLedgerReports(string debtorId, string accountId, int year)
        {
            var results = _debtorReportRepository.GetSingleAccountAndAllAdvanceRetireDebtorLedgerReports(debtorId, accountId,year);
            return PrepareTable(results);
        }

        public DataTable GetSingleAccountAndAdvanceOrRetire(string debtorId, string accountId, string advancedRetired, int year)
        {
            var results = _debtorReportRepository.GetSingleAccountAndAdvanceOrRetire(debtorId, accountId, advancedRetired,year);
            return PrepareTable(results);
        }
    }
}
