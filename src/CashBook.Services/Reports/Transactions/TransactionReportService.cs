using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.DataAccess.Reports;
using CashBook.Services.Account;
using CashBook.Services.MaintainBalance;
using CashBook.Services.User;
using CashBook.Services.Utility;

namespace CashBook.Services.Reports
{
    public class TransactionReportService : ITransactionReportService
    {

        private readonly ITransactionReportRepository _transactionReportRepository;
        private readonly IAccountService _accountService;
        private readonly IUtilityService _utilityService;
        private readonly IUserService _userService;
        private readonly IMaintainBalanceService _maintainBalanceService;
        public TransactionReportService(ITransactionReportRepository transactionReportRepository, IAccountService accountService, IUtilityService utilityService, IUserService userService, IMaintainBalanceService maintainBalanceService)
        {
            _transactionReportRepository = transactionReportRepository;
            _accountService = accountService;
            _utilityService = utilityService;
            _userService = userService;
            _maintainBalanceService = maintainBalanceService;
        }

        public DataTable GetAllTransactionByTransactionDescriptionAndTransactionType(string accountId, int month, int year, string transactionDescriptionId, string transactionType)
        {
            decimal OpeningBalance = GetOpeningBalance(accountId, month, year);
            var table = _transactionReportRepository.GetAllTransactionByTransactionDescriptionAndTransactionType(accountId, month, year, transactionDescriptionId, transactionType);
            return PrepareTable(table,OpeningBalance);
        }

        public DataTable GetAllTransactionByTransactionDescriptionOnly(string accountId, int month, int year, string transactionDescriptionId)
        {
            decimal OpeningBalance = GetOpeningBalance(accountId, month, year);
            var table = _transactionReportRepository.GetAllTransactionByTransactionDescriptionOnly(accountId, month, year, transactionDescriptionId);
            return PrepareTable(table,OpeningBalance);
        }

        public DataTable GetAllTransactionByTransactionTypeOnly(string accountId, int month, int year, string transactionType)
        {
            decimal OpeningBalance = GetOpeningBalance(accountId, month, year);
            var table = _transactionReportRepository.GetAllTransactionByTransactionTypeOnly(accountId, month, year, transactionType);
            return PrepareTable(table,OpeningBalance);
        }

        public DataTable GetAllTransactionsByAccountIdAndDuration(string accountId, int month, int year)
        {
            decimal OpeningBalance = GetOpeningBalance(accountId,month,year);
            var table = _transactionReportRepository.GetAllTransactions(accountId, month, year);
            return PrepareTable(table,OpeningBalance);
        }
        private decimal GetOpeningBalance(string accountId, int month, int year)
        {
            string duration = $"{month}.{year}";
            var maintainBalance = _maintainBalanceService.GetMaintainBalanceByAccountIdAndDuration(accountId, duration);
            return (maintainBalance == null) ? 0 : maintainBalance.OpeningBalance;
        }
        private string GenerateAccountDetailsParameter(string accountId)
        {
            var accounts = _accountService.GetAccountByAccountId(accountId);
            return $"AccountDetails={accounts.AccountName}[{accounts.BankName}]";
        }
        private string GenerateReportTitleParamenter(int month, int year)
        {
            int numberOfDaysInMonth = DateTime.DaysInMonth(year, month);

            var allMonths = _utilityService.GetMonths();
            var reportMonths = allMonths.Rows[month - 1].Field<string>("name");
            return $"ReportTitle=DETAILED CASHBOOK REPORT AS AT {numberOfDaysInMonth}, {reportMonths} {year}";
        }
        private string GenerateOrganizationNameParameter(string userId)
        {
            var user = _userService.GetUserByUserId(userId);
            return $"OrganizationName={user.OrganizationName}";
        }
        public string GenerateReportParameters(string userId, string accountId, int month, int year)
        {
            return $"{GenerateOrganizationNameParameter(userId)}&{GenerateReportTitleParamenter(month, year)}&{GenerateAccountDetailsParameter(accountId)}&{GenerateOpeningBalanceParameter(accountId, month, year)}";
        }
        private string GenerateOpeningBalanceParameter(string accountId, int month, int year)
        {
            string duration = $"{month}.{year}";
            var maintainBalance = _maintainBalanceService.GetMaintainBalanceByAccountIdAndDuration(accountId, duration);
            var allMonths = _utilityService.GetMonths();
            var reportMonths = allMonths.Rows[month - 1].Field<string>("name");
            string openingBalance = maintainBalance == null ? "NILL" : $"{_utilityService.FormatDecimal(maintainBalance.OpeningBalance)}";
            return $"OpeningBalance=TRANSACTION OPENING BALANCE AS AT 1ST {reportMonths} {year} N{openingBalance}";
        }
        private DataTable PrepareTable(DataTable table,decimal OpeningBalance)
        {
            decimal cummulativeBalance = OpeningBalance;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                decimal ammountDeposited = table.Rows[i].Field<decimal>("AmmountDeposited");
                decimal ammountWithdrawn = table.Rows[i].Field<decimal>("AmmountWithdrawn");

                if (ammountDeposited == 0)
                {
                    cummulativeBalance = cummulativeBalance - ammountWithdrawn;
                }
                else
                {
                    cummulativeBalance = cummulativeBalance + ammountDeposited;
                }
                table.Rows[i].SetField("CummulativeBalance",_utilityService.FormatDecimal(cummulativeBalance));
            }
            return table;
        }
    }
}
