using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.DataAccess.DebtorLedger;
using CashBook.Dtos.DebtorLedger;
using CashBook.Models.DebtorLedger;

namespace CashBook.Services.DebtorLedger
{
    public class DebtorLedgerService : IDebtorLedgerService
    {
        private readonly IDebtorLedgerRepository _debtorLedgerRepository;
        public DebtorLedgerService(IDebtorLedgerRepository debtorLedgerRepository)
        {
            _debtorLedgerRepository = debtorLedgerRepository;
        }
        public void CreateDebtorLedger(CreateDebtorLedgerDto dto)
        {
            var model = new DebtorLedgerModel
            {
                DebtorLedgerId = Guid.NewGuid().ToString(),
                DebtorId = dto.DebtorId,
                AccountId = dto.AccountId,
                DateOfAdvanceRetire = dto.DateOfAdvanceRetire,
                AmmountAdvanced = dto.AmmountAdvanced,
                AmmountRetired = dto.AmmountRetired,
                JvNumber = dto.JvNumber,
                PvNumber = dto.PvNumber,
                Description = dto.Description,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _debtorLedgerRepository.CreateDebtorLedger(model);
        }

        public void DeleteDebtorLedger(string debtorLedgerId)
        {
            _debtorLedgerRepository.DeleteDebtorLedger(debtorLedgerId);
        }

        public List<ReadDebtorLedgerDto> GetAllDebtorLedger()
        {
            var data = new List<ReadDebtorLedgerDto>();
            var results = _debtorLedgerRepository.GetAllDebtorLedger();

            foreach (var item in results)
            {
                data.Add(new ReadDebtorLedgerDto {
                    DebtorLedgerId = item.DebtorLedgerId,
                    AccountName = item.Account.AccountName,
                    DebtorFullName = item.Debtor.FullName,
                    DebtorLedgerNumber = item.Debtor.DebtorLedgerNumber,
                    AmmountAdvanced = item.AmmountAdvanced,
                    AmmountRetired = item.AmmountRetired,
                    DateOfAdvanceRetire = item.DateOfAdvanceRetire,
                    PvNumber = item.PvNumber,
                    JvNumber = item.JvNumber,
                    Description = item.Description
                });
            }

            return data;
        }

        public List<ReadDebtorLedgerDto> GetAllDebtorLedgerByDebtorId(string debtorId)
        {
            var data = new List<ReadDebtorLedgerDto>();
            var results = _debtorLedgerRepository.GetAllDebtorLedgerByDebtorId(debtorId);

            foreach (var item in results)
            {
                data.Add(new ReadDebtorLedgerDto
                {
                    DebtorLedgerId = item.DebtorLedgerId,
                    DebtorFullName = item.Debtor.FullName,
                    AccountName = item.Account.AccountName,
                    DebtorLedgerNumber = item.Debtor.DebtorLedgerNumber,
                    AmmountAdvanced = item.AmmountAdvanced,
                    AmmountRetired = item.AmmountRetired,
                    DateOfAdvanceRetire = item.DateOfAdvanceRetire,
                    PvNumber = item.PvNumber,
                    JvNumber = item.JvNumber,
                    Description = item.Description
                });
            }
            return data;
        }
    }
}
