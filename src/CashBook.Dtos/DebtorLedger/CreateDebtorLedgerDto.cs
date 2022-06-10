using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Dtos.DebtorLedger
{
    public class CreateDebtorLedgerDto
    {
        public string DebtorId { get; set; }
        public string AccountId { get; set; }
        public DateTime DateOfAdvanceRetire { get; set; }
        public string JvNumber { get; set; }
        public string PvNumber { get; set; }
        public decimal AmmountAdvanced { get; set; }
        public decimal AmmountRetired { get; set; }
        public string Description { get; set; }
    }
}
