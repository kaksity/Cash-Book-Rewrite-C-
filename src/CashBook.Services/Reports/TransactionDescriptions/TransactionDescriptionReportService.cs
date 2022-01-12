using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.DataAccess.Reports.TransactionDescriptions;
using CashBook.Services.User;

namespace CashBook.Services.Reports.TransactionDescriptions
{
    public class TransactionDescriptionReportService : ITransactionDescriptionReportService
    {
        private ITransactionDescriptionReportRepository _transactionDescriptionRepository;
        private IUserService _userService;
        public TransactionDescriptionReportService(ITransactionDescriptionReportRepository transactionDecriptionReportRepository, IUserService userService)
        {
            _transactionDescriptionRepository = transactionDecriptionReportRepository;
            _userService = userService;
        }

        public string GenerateReportParameters(string userId)
        {
            var user = _userService.GetUserByUserId(userId);
            return $"OrganizationName={user.OrganizationName}";
        }

        public DataTable GetAllExpenseItems()
        {
            return _transactionDescriptionRepository.GetAllExpenseItems();
        }

        public DataTable GetAllIncomeItems()
        {
            return _transactionDescriptionRepository.GetAllIncomeItems();
        }

        public DataTable GetAllItems()
        {
            return _transactionDescriptionRepository.GetAllItems();
        }
    }
}
