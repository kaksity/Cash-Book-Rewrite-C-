using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.DebtorLedger;

namespace CashBook.Services.DebtorLedger
{
    public interface IDebtorLedgerService
    {
        void CreateDebtorLedger(CreateDebtorLedgerDto dto);
        void DeleteDebtorLedger(string debtorLedgerId);
        List<ReadDebtorLedgerDto> GetAllDebtorLedger();
        List<ReadDebtorLedgerDto> GetAllDebtorLedgerByDebtorId(string debtorId);
    }
}
