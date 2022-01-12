using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Models.BinCardItem
{
    public class BinCardItemModel
    {
        public string BinCardItemId { get; set; }
        public string BinCardItemName { get; set; }
        public string BinCardItemDescription { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
