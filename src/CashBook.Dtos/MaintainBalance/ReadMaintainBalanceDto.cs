using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Dtos.MaintainBalance
{
    public class ReadMaintainBalanceDto
    {
        public string MaintainBalanceId { get; set; }
        public string AccountId { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal ClosingBalance { get; set; }
        public string Duration { get; set; }
        public int Status { get; set; }
        public bool IsEdited { get; set; }
    }
}
