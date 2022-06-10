using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Models.Debtor
{
    public class DebtorModel
    {
        public string DebtorId { get; set; }
        public string FullName { get; set; }
        public string DebtorLedgerNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
