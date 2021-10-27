using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Dtos.BankReconcilation
{
    public class ReadBankReconcilationDto
    {
        public string BankReconcilationId { get; set; }
        public string AccountId { get; set; }
        public string Duration { get; set; }
        public decimal CreditTransfer { get; set; }
        public decimal InterestReceived { get; set; }
        public decimal StaleChqsReversed { get; set; }
        public decimal BankCharges { get; set; }
        public decimal DebitTransfer { get; set; }
        public decimal OutstandingStaleChqs { get; set; }
        public decimal UnpresentedChqs { get; set; }
        public decimal BankNotCashBook { get; set; }
        public decimal UncreditedLodgements { get; set; }
        public decimal CashBookNotBank { get; set; }
        public decimal DiffBtwBankAndCashBook { get; set; }
    }
}
