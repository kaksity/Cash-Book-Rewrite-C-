using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.BinCardItem;

namespace CashBook.Models.BinCard
{
    public class BinCardModel
    {
        public string BinCardId { get; set; }
        public string BinCardItemId { get; set; }
        public DateTime DateOfIssueOrReceipt { get; set; }
        public string SivSrvOthers { get; set; }
        public decimal RecievedQuantity { get; set; }
        public decimal IssuedQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public BinCardItemModel BinCardItem{ get; set; }

    }
}
