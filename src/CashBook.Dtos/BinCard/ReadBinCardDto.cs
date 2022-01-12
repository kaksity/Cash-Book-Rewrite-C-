using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Dtos.BinCard
{
    public class ReadBinCardDto
    {
        public string BinCardId { get; set; }
        public string BinCardItemName { get; set; }
        public DateTime DateOfIssueOrReceipt { get; set; }
        public string SivSrvOthers { get; set; }
        public decimal RecievedQuantity { get; set; }
        public decimal IssuedQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
    }
}
