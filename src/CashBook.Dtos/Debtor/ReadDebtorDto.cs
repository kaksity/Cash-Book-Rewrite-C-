using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Dtos.Debtor
{
    public class ReadDebtorDto
    {
        public string DebtorId { get; set; }
        public string FullName { get; set; }
        public string DebtorLedgerNumber { get; set; }
    }
}
