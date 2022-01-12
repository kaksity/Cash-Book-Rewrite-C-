using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.Account;
using CashBook.Models.TransactionDescription;

namespace CashBook.Models.Transaction
{
    public class TransactionModel
    {
        public string TransactionId { get; set; }
        public string AccountId { get; set; }
        public decimal AmmountWithdrawn { get; set; }
        public decimal AmmountDeposited { get; set; }
        public string NameOfBeneficiary { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public string PVOrRVNumber { get; set; }
        public string SubHeadColumn { get; set; }
        public string TransactionDescriptionId { get; set; }
        public string RefNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public AccountModel Account { get; set; }
        public TransactionDescriptionModel TransactionDescription { get; set; }
    }
}
