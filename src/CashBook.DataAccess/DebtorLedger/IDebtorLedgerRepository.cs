using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.DebtorLedger;

namespace CashBook.DataAccess.DebtorLedger
{
    public interface IDebtorLedgerRepository
    {
        void CreateDebtorLedger(DebtorLedgerModel model);
        void DeleteDebtorLedger(string debtorLedgerId);
        List<DebtorLedgerModel> GetAllDebtorLedger();
        List<DebtorLedgerModel> GetAllDebtorLedgerByDebtorId(string debtorId);

    }
}
