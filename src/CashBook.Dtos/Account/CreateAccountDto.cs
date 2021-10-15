using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashBook.Dtos.Account
{
    public class CreateAccountDto
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public DateTime OpeningDate { get; set; }
        public string Description { get; set; }
        public string OpeningBalance { get; set; }
        public string CurrentBalance { get; set; }
    }
}
