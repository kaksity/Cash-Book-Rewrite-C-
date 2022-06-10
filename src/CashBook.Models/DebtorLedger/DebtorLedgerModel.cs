using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.Debtor;
using CashBook.Models.Account;

namespace CashBook.Models.DebtorLedger
{
    public class DebtorLedgerModel
    {
        public string DebtorLedgerId { get; set; }
        public string DebtorId { get; set; }
        public string AccountId { get; set; }
        public DateTime DateOfAdvanceRetire { get; set; }
        public string JvNumber { get; set; }
        public string PvNumber { get; set; }
        public decimal AmmountAdvanced { get; set; }
        public decimal AmmountRetired { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DebtorModel Debtor { get; set; }
        public AccountModel Account { get; set; }
    }
}
