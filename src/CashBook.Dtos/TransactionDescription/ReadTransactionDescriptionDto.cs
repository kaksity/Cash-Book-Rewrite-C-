using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Dtos.TransactionDescription
{
    class ReadTransactionDescriptionDto
    {
        public string TransactionDescriptionId { get; set; }
        public string DescriptionName { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
    }
}
