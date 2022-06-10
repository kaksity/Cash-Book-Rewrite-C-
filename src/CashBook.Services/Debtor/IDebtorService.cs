using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.Debtor;

namespace CashBook.Services.Debtor
{
    public interface IDebtorService
    {

        void CreateDebtor(CreateDebtorDto dto);
        void DeleteDebtor(string debtorId);
        void UpdateDebtor(UpdateDebtorDto dto);
        List<ReadDebtorDto> GetAllDebtors();
        ReadDebtorDto GetDebtorByDebtorLedgerNumber(string debtorLedgerNumber);
        ReadDebtorDto GetDebtorByDebtorId(string debtorId);
    }
}
