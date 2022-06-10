using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.DataAccess.BankReconcilation;
using CashBook.Dtos.Transaction;
using CashBook.Services.Account;
using CashBook.Services.MaintainBalance;
using CashBook.Services.Transaction;
using CashBook.Services.User;
using CashBook.Services.Utility;

namespace CashBook.Services.Reports.BankReconcilations
{
    public class BankReconcilationReportService : IBankReconcilationReportService
    {
        private readonly IBankReconcilationRepository _bankReconcilationRepository;
        private readonly IUserService _userService;
        private readonly IAccountService _accountService;
        private readonly IUtilityService _utilityService;
        private readonly IMaintainBalanceService _maintainBalanceService;
        private readonly ITransactionService _transactionService;
        public BankReconcilationReportService(IBankReconcilationRepository bankReconcilationRepository, ITransactionService transactionService,IMaintainBalanceService maintainBalanceService, IUserService userService, IAccountService accountService, IUtilityService utilityService)
        {
            _bankReconcilationRepository = bankReconcilationRepository;
            _accountService = accountService;
            _userService = userService;
            _utilityService = utilityService;
            _maintainBalanceService = maintainBalanceService;
            _transactionService = transactionService;
        }

        public string GenerateBankReconcilationReport(string bankReconcilationId,string accountId,string userId)
        {
            StringBuilder parameter = new StringBuilder();
            

            var user = _userService.GetUserByUserId(userId);

            parameter.Append($"OrganizationName={user.OrganizationName}&");

            var bankReconcilation = _bankReconcilationRepository.GetBankReconcilationByBankReconcilationId(bankReconcilationId);

            parameter.Append(GenerateReportTitleParameter(bankReconcilation.Duration));

            parameter.Append(GenerateAccountDetailsParameter(accountId));

            decimal openingBalance = GetOpeningBalance(accountId,bankReconcilation.Duration);

            parameter.Append($"OpeningBalance=N{_utilityService.FormatDecimal(openingBalance)}&");
            parameter.Append($"CreditTransfer=N{_utilityService.FormatDecimal(bankReconcilation.CreditTransfer)}&");
            parameter.Append($"InterestReceived=N{_utilityService.FormatDecimal(bankReconcilation.InterestReceived)}&");
            parameter.Append($"StaleChqsReversed=N{_utilityService.FormatDecimal(bankReconcilation.StaleChqsReversed)}&");

            parameter.Append($"BankCharges=N{_utilityService.FormatDecimal(bankReconcilation.BankCharges)}&");
            parameter.Append($"DebitTransfer=N{_utilityService.FormatDecimal(bankReconcilation.DebitTransfer)}&");


            parameter.Append($"UnpresentedCheques=N{_utilityService.FormatDecimal(bankReconcilation.UnpresentedChqs)}&");
            parameter.Append($"ItemsInBankNotInCashbook=N{_utilityService.FormatDecimal(bankReconcilation.BankNotCashBook)}&");
            decimal bankAddTotal = bankReconcilation.UnpresentedChqs + bankReconcilation.BankNotCashBook;
            parameter.Append($"BankAddTotal=N{_utilityService.FormatDecimal(bankAddTotal)}&");

            parameter.Append($"UncreditedLodgements=N{_utilityService.FormatDecimal(bankReconcilation.UncreditedLodgements)}&");
            parameter.Append($"ItemsInCashbookNotInBank=N{_utilityService.FormatDecimal(bankReconcilation.CashBookNotBank)}&");
            decimal bankLessTotal = bankReconcilation.UncreditedLodgements + bankReconcilation.CashBookNotBank;
            parameter.Append($"BankLessTotal=N{_utilityService.FormatDecimal(bankLessTotal)}&");

            decimal bankTotal = bankAddTotal - bankLessTotal;
            parameter.Append($"BankTotal=N{_utilityService.FormatDecimal(bankTotal)}&");

            var splitedDuration = bankReconcilation.Duration.Split('.');

            int month = Convert.ToInt16(splitedDuration[0]);
            int year = Convert.ToInt16(splitedDuration[1]);

            var allTransactions = _transactionService.GetAllTransactionByAccountIdMonthAndYear(accountId,month,year);
            var totalReceiptsAndPayments = CalculateTotalIncomeAndExpenseTransaction(allTransactions);

            var totalReceipts = totalReceiptsAndPayments.Item1;
            var totalPayments = totalReceiptsAndPayments.Item2;

            parameter.Append($"Receipts=N{_utilityService.FormatDecimal(totalReceipts)}&");
            parameter.Append($"Payments=N{_utilityService.FormatDecimal(totalPayments)}&");

            decimal subCashBookBalance = totalReceipts + bankReconcilation.CreditTransfer + bankReconcilation.InterestReceived + bankReconcilation.StaleChqsReversed - totalPayments - bankReconcilation.BankCharges - bankReconcilation.DebitTransfer;
            parameter.Append($"SubCashbookBalance=N{_utilityService.FormatDecimal(subCashBookBalance)}&");

            decimal cashbookBalance = openingBalance + subCashBookBalance;
            parameter.Append($"CashbookBalance=N{_utilityService.FormatDecimal(cashbookBalance)}&");

            decimal suggestedCashbookBalance = cashbookBalance + bankReconcilation.OutstandingStaleChqs;
            parameter.Append($"SuggestedCashbookBalance=N{_utilityService.FormatDecimal(suggestedCashbookBalance)}&");

            parameter.Append($"OutstandingStaleChqs=N{_utilityService.FormatDecimal(bankReconcilation.OutstandingStaleChqs)}&");

            decimal closingBalance = suggestedCashbookBalance + bankTotal;
            parameter.Append($"ClosingBalance=N{_utilityService.FormatDecimal(closingBalance)}&");
            parameter.Append($"TextCashbookOpeningBalance=CASHBOOK O/BALANCE AS AT {GenerateFirstDateInWord(bankReconcilation.Duration)}&");
            parameter.Append($"TextCashbookBalance=CASHBOOK BALANCE AS AT {GenerateLastDateInWord(bankReconcilation.Duration)}&");
            parameter.Append($"TextSuggestedCashbookBalance=SUGGESTED CASHBOOK BALANCE AS AT {GenerateLastDateInWord(bankReconcilation.Duration)}&");
            parameter.Append($"TextReconciledBalance=SUGGESTED CASHBOOK BALANCE AS AT {GenerateLastDateInWord(bankReconcilation.Duration)}&");
            parameter.Append($"TextClosingBalance=SUGGESTED BANK BALANCE AS AT {GenerateLastDateInWord(bankReconcilation.Duration)}&");

            parameter.Append($"PreparedBy={user.FullName}");
            return parameter.ToString();
        }

        private string GenerateFirstDateInWord(string duration)
        {
            var splitedDuration = duration.Split('.');

            int month = Convert.ToInt16(splitedDuration[0]);
            int year = Convert.ToInt16(splitedDuration[1]);

            int numberOfDaysInMonth = DateTime.DaysInMonth(year, month);

            var allMonths = _utilityService.GetMonths();
            var reportMonths = allMonths.Rows[month - 1].Field<string>("name");
            return $"1st, {reportMonths} {year}";
        }
        private decimal GetOpeningBalance(string accountId, string duration)
        {
            var maintainBalance = _maintainBalanceService.GetMaintainBalanceByAccountIdAndDuration(accountId, duration);
            return (maintainBalance == null) ? 0 : maintainBalance.OpeningBalance;
        }
        public Tuple<decimal,decimal> CalculateTotalIncomeAndExpenseTransaction(List<ReadTransactionDto> data)
        {
            decimal totalIncomeTransaction = 0;
            decimal totalExpenseTransaction = 0;

            foreach (var item in data)
            {
                if (item.AmmountDeposited == 0)
                {
                    totalExpenseTransaction += item.AmmountWithdrawn;
                }
                else
                {
                    totalIncomeTransaction += item.AmmountDeposited;
                }
            }
            return Tuple.Create(totalIncomeTransaction,totalExpenseTransaction);
        }
        private int GetLastDateOfTheMonth(string duration)
        {
            var splitedDuration = duration.Split('.');
            int month = Convert.ToInt16(splitedDuration[0]);
            int year = Convert.ToInt16(splitedDuration[1]);
            return DateTime.DaysInMonth(year, month);
        }

        private string GenerateLastDateInWord(string duration)
        {
            var splitedDuration = duration.Split('.');

            int month = Convert.ToInt16(splitedDuration[0]);
            int year = Convert.ToInt16(splitedDuration[1]);

            int numberOfDaysInMonth = DateTime.DaysInMonth(year, month);

            var allMonths = _utilityService.GetMonths();
            var date = ((numberOfDaysInMonth) == 31) ? $"{numberOfDaysInMonth}st" : $"{numberOfDaysInMonth}th";
            var reportMonths = allMonths.Rows[month - 1].Field<string>("name");
            return $"{ date }, {reportMonths} {year}";
        }

        private string GenerateAccountDetailsParameter(string accountId)
        {
            var accounts = _accountService.GetAccountByAccountId(accountId);
            return $"AccountDetails={accounts.AccountName}[{accounts.BankName}]&";
        }
        private string GenerateReportTitleParameter(string duration)
        {
            
            return $"ReportTitle=BANK RECONCILATION AS AT {GenerateLastDateInWord(duration)}&";
        }

        //public string GenerateReportParameters(string userId, string accountId, int month, int year)
        //{
        //    return $"{GenerateOrganizationNameParameter(userId)}&{GenerateReportTitleParamenter(month, year)}&{GenerateAccountDetailsParameter(accountId)}&{GenerateOpeningBalanceParameter(accountId, month, year)}";
        //}
        //private string GenerateOpeningBalanceParameter(string accountId, int month, int year)
        //{
        //    string duration = $"{month}.{year}";
        //    var maintainBalance = _maintainBalanceService.GetMaintainBalanceByAccountIdAndDuration(accountId, duration);
        //    var allMonths = _utilityService.GetMonths();
        //    var reportMonths = allMonths.Rows[month - 1].Field<string>("name");
        //    string openingBalance = maintainBalance == null ? "NILL" : $"{maintainBalance.OpeningBalance}";
        //    return $"OpeningBalance=TRANSACTION OPENING BALANCE AS AT 1ST {reportMonths} {year} N{openingBalance}";
        //}
    }
}
