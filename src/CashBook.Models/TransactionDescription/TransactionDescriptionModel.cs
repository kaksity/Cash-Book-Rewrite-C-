using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Models.TransactionDescription
{
    public class TransactionDescriptionModel
    {
        public string TransactionDescriptionId { get; set; }
        public string DescriptionName { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
