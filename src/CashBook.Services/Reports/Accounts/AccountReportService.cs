using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.DataAccess.Reports.Accounts;
using CashBook.Services.User;

namespace CashBook.Services.Reports.Accounts
{
    public class AccountReportService : IAccountReportService
    {
        private IAccountReportRepository _accountReportRepository;
        private IUserService _userService;
        public AccountReportService(IAccountReportRepository accountReportRepository, IUserService userService)
        {
            _accountReportRepository = accountReportRepository;
            _userService = userService;
        }

        public string GenerateReportParameters(string userId)
        {
            var user = _userService.GetUserByUserId(userId);
            return $"OrganizationName={user.OrganizationName}";
        }

        public DataTable GetAllAccounts()
        {
            return _accountReportRepository.GetAccounts();
        }
        
    }
}
