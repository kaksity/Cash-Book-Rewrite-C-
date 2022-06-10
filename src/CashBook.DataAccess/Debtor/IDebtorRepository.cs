using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.Debtor;

namespace CashBook.DataAccess.Debtor
{
    public interface IDebtorRepository
    {
        void CreateDebtor(DebtorModel model);
        void DeleteDebtor(string debtorId);
        void UpdateDebtor(DebtorModel model);
        List<DebtorModel> GetAllDebtors();
        DebtorModel GetDebtorByDebtorLedgerNumber(string debtorLedgerNumber);
        DebtorModel GetDebtorByDebtorId(string debtorId);
    }
}
