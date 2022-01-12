using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Dtos.BinCardItem
{
    public class UpdateBinCardItemDto
    {
        public string BinCardItemId { get; set; }
        public string BinCardItemName { get; set; }
        public string BinCardItemDescription { get; set; }
    }
}
