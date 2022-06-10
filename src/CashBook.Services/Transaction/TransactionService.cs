using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.Transaction;
using CashBook.DataAccess.Transaction;
using CashBook.Models.Transaction;
using System.Data;
using CashBook.Services.TransactionDescription;
using CashBook.Services.Utility;

namespace CashBook.Services.Transaction
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly ITransactionDescriptionService _transactionDescriptionService;
        private readonly IUtilityService _utilityService;

        public TransactionService(ITransactionRepository transactionRepository, ITransactionDescriptionService transactionDescriptionService, IUtilityService utilityService)
        {
            _transactionDescriptionService = transactionDescriptionService;
            _transactionRepository = transactionRepository;
            _utilityService = utilityService;
        }

        public void CreateTransaction(CreateTransactionDto dto)
        {
            var transaction = new TransactionModel
            {
                 TransactionId = Guid.NewGuid().ToString(),
                 AccountId = dto.AccountId,
                 AmmountWithdrawn = dto.AmmountWithdrawn,
                 AmmountDeposited = dto.AmmountDeposited,
                 NameOfBeneficiary = dto.NameOfBeneficiary,
                 DateOfTransaction = dto.DateOfTransaction,
                 PVOrRVNumber = dto.PVOrRVNumber,
                 SubHeadColumn = dto.SubHeadColumn,
                 TransactionDescriptionId = dto.TransactionDescriptionId,
                 RefNumber = dto.RefNumber,
                 IsDeleted = false,
                 CreatedAt = DateTime.Now,
                 UpdatedAt = DateTime.Now
            };
            _transactionRepository.CreateTransaction(transaction);
        }

        public void DeleteTransaction(string transactionId)
        {
            _transactionRepository.DeleteTransaction(transactionId);
        }

        public List<ReadTransactionDto> GetAllExpenseTransaction()
        {
            var expenseTransactions = _transactionRepository.GetAllExpenseTransaction();

            var result = new List<ReadTransactionDto>();
            foreach (var item in expenseTransactions)
            {
                result.Add(new ReadTransactionDto
                {
                    TransactionId = item.TransactionId,
                    AccountName = item.Account.AccountName,
                    AccountNumber = item.Account.AccountNumber,
                    AmmountDeposited = item.AmmountDeposited,
                    AmmountWithdrawn = item.AmmountWithdrawn,
                    NameOfBeneficiary = item.NameOfBeneficiary,
                    DateOfTransaction = item.DateOfTransaction,
                    PVOrRVNumber = item.PVOrRVNumber,
                    SubHeadColumn = item.SubHeadColumn,
                    TransactionDescriptionName = item.TransactionDescription.DescriptionName,
                    RefNumber = item.RefNumber
                });
            }
            return result;
        }

        public List<ReadTransactionDto> GetAllRevenueRegiserTransaction()
        {
            var revenueTransactions = _transactionRepository.GetAllRevenueRegisterTransaction();

            var result = new List<ReadTransactionDto>();
            foreach (var item in revenueTransactions)
            {
                result.Add(new ReadTransactionDto
                {
                    TransactionId = item.TransactionId,
                    AccountName = item.Account.AccountName,
                    AccountNumber = item.Account.AccountNumber,
                    AmmountDeposited = item.AmmountDeposited,
                    AmmountWithdrawn = item.AmmountWithdrawn,
                    NameOfBeneficiary = item.NameOfBeneficiary,
                    DateOfTransaction = item.DateOfTransaction,
                    PVOrRVNumber = item.PVOrRVNumber,
                    SubHeadColumn = item.SubHeadColumn,
                    TransactionDescriptionName = item.TransactionDescription.DescriptionName,
                    RefNumber = item.RefNumber
                });
            }
            return result;
        }

        public List<ReadTransactionDto> GetFilteredExpenseTransaction(string accountId, int month, int year)
        {
            var expenseTransactions = _transactionRepository.GetFilteredExpenseTransaction(accountId,month,year);

            var result = new List<ReadTransactionDto>();
            foreach (var item in expenseTransactions)
            {
                result.Add(new ReadTransactionDto
                {
                    TransactionId = item.TransactionId,
                    AccountName = item.Account.AccountName,
                    AccountNumber = item.Account.AccountNumber,
                    AmmountDeposited = item.AmmountDeposited,
                    AmmountWithdrawn = item.AmmountWithdrawn,
                    NameOfBeneficiary = item.NameOfBeneficiary,
                    DateOfTransaction = item.DateOfTransaction,
                    PVOrRVNumber = item.PVOrRVNumber,
                    SubHeadColumn = item.SubHeadColumn,
                    TransactionDescriptionName = item.TransactionDescription.DescriptionName,
                    RefNumber = item.RefNumber
                });
            }
            return result;
        }

        public List<ReadTransactionDto> GetFilteredRevenueRegisterTransaction(string accountId, int month, int year)
        {
            var revenueTransactions = _transactionRepository.GetFilteredRevenueRegisterTransaction(accountId, month, year);

            var result = new List<ReadTransactionDto>();
            foreach (var item in revenueTransactions)
            {
                result.Add(new ReadTransactionDto
                {
                    TransactionId = item.TransactionId,
                    AccountName = item.Account.AccountName,
                    AccountNumber = item.Account.AccountNumber,
                    AmmountDeposited = item.AmmountDeposited,
                    AmmountWithdrawn = item.AmmountWithdrawn,
                    NameOfBeneficiary = item.NameOfBeneficiary,
                    DateOfTransaction = item.DateOfTransaction,
                    PVOrRVNumber = item.PVOrRVNumber,
                    SubHeadColumn = item.SubHeadColumn,
                    TransactionDescriptionName = item.TransactionDescription.DescriptionName,
                    RefNumber = item.RefNumber
                });
            }
            return result;
        }

        public DataTable Get32ColumnCashBook(string accountId, int year)
        {
            // Prepare a table to hold the results of transactions

            var tblColumnCashbook = new DataTable();

            //Create the Appropriate rows for the table
            tblColumnCashbook.Columns.Clear();
            tblColumnCashbook.Rows.Clear();

            tblColumnCashbook.Columns.Add("colsDateOfTransaction",typeof(DateTime));
            tblColumnCashbook.Columns.Add("colsTotalTransaction", typeof(string));

            var transactionDescriptionItems = _transactionDescriptionService.GetAllTransactionDescriptionsByTransactionType("EXPENSE");

            foreach (var item in transactionDescriptionItems)
            {
                tblColumnCashbook.Columns.Add(item.TransactionDescriptionId,typeof(string));
            }


            // First Get the List of Transaction Distinctively
            var expenseTransactions = _transactionRepository.GetAllExpenseTransactionDistinctByYear(accountId,year);
            decimal totalPerDay = 0;

            //Loop through the transactions to get all the transactions that occured on a particular day
            foreach (var transaction in expenseTransactions)
            {
                // List of transaction that occured in a particular date

                var results = _transactionRepository.GetAllExpenseTransactionByDate(accountId,transaction.DateOfTransaction);

                //Loop throught the transactions and then put the transactions in the required place

                DataRow row = tblColumnCashbook.NewRow();

                row["colsDateOfTransaction"] =  transaction.DateOfTransaction;
                

                foreach (var item in results)
                {

                    decimal ammountWithdrawn = item.AmmountWithdrawn;
                    decimal previousAmmountWithdrawn = 0;
                    // Get the previous value and then updated it with the current value
                    if (Convert.IsDBNull(row[item.TransactionDescriptionId]) == true)
                    {
                        previousAmmountWithdrawn = 0;
                    }
                    else
                    {
                        previousAmmountWithdrawn = Convert.ToDecimal(row[item.TransactionDescriptionId]);
                    }

                    row[item.TransactionDescriptionId] = previousAmmountWithdrawn + ammountWithdrawn; 
                    totalPerDay += ammountWithdrawn;
                }

                row["colsTotalTransaction"] = totalPerDay;

                tblColumnCashbook.Rows.Add(row);
            }
            return tblColumnCashbook;
        }

        public List<ReadTransactionDto> GetAllTransactionByAccountIdMonthAndYear(string accountId, int month, int year)
        {
            var transactions = _transactionRepository.GetAllTransactionByAccountIdMonthAndYear(accountId,month,year);

            var result = new List<ReadTransactionDto>();
            foreach (var item in transactions)
            {
                result.Add(new ReadTransactionDto
                {
                    TransactionId = item.TransactionId,
                    AccountName = item.Account.AccountName,
                    AccountNumber = item.Account.AccountNumber,
                    AmmountDeposited = item.AmmountDeposited,
                    AmmountWithdrawn = item.AmmountWithdrawn,
                    NameOfBeneficiary = item.NameOfBeneficiary,
                    DateOfTransaction = item.DateOfTransaction,
                    PVOrRVNumber = item.PVOrRVNumber,
                    SubHeadColumn = item.SubHeadColumn,
                    TransactionDescriptionName = item.TransactionDescription.DescriptionName,
                    RefNumber = item.RefNumber
                });
            }

            return result;
        }

        public ReadTransactionDto GetTransactionByTransactionId(string transactionId)
        {
            var item = _transactionRepository.GetTransactionByTransactionId(transactionId);

            if (item == null) return null;

            return new ReadTransactionDto
            {
                TransactionId = item.TransactionId,
                AccountId = item.AccountId,
                AccountName = item.Account.AccountName,
                AccountNumber = item.Account.AccountNumber,
                AmmountDeposited = item.AmmountDeposited,
                AmmountWithdrawn = item.AmmountWithdrawn,
                NameOfBeneficiary = item.NameOfBeneficiary,
                DateOfTransaction = item.DateOfTransaction,
                PVOrRVNumber = item.PVOrRVNumber,
                SubHeadColumn = item.SubHeadColumn,
                TransactionDescriptionName = item.TransactionDescription.DescriptionName,
                RefNumber = item.RefNumber
            };
        }
    }
}
