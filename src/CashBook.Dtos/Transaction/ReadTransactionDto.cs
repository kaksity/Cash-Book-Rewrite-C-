using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Dtos.Transaction
{
    public class ReadTransactionDto
    {
        public string TransactionId { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public decimal AmmountDeposited { get; set; }
        public decimal AmmountWithdrawn { get; set; }
        public string NameOfBeneficiary { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public string PVOrRVNumber { get; set; }
        public string SubHeadColumn { get; set; }
        public string TransactionDescriptionName{ get; set; }
        public string RefNumber { get; set; }
    }
}
