using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.DataAccess.Debtor;
using CashBook.Dtos.Debtor;
using CashBook.Models.Debtor;

namespace CashBook.Services.Debtor
{
    public class DebtorService : IDebtorService
    {
        private readonly IDebtorRepository _debtorRepository;
        public DebtorService(IDebtorRepository debtorRepository)
        {
            _debtorRepository = debtorRepository;
        }
        public void CreateDebtor(CreateDebtorDto dto)
        {
            var model = new DebtorModel
            {
                DebtorId = Guid.NewGuid().ToString(),
                FullName = dto.FullName.ToUpper().Trim(),
                DebtorLedgerNumber = dto.DebtorLedgerNumber.ToUpper().Trim(),
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _debtorRepository.CreateDebtor(model);
        }

        public void DeleteDebtor(string debtorId)
        {
            _debtorRepository.DeleteDebtor(debtorId);
        }

        public List<ReadDebtorDto> GetAllDebtors()
        {
            var results = _debtorRepository.GetAllDebtors();
            var data = new List<ReadDebtorDto>();

            foreach (var item in results)
            {
                data.Add(new ReadDebtorDto {
                    DebtorId = item.DebtorId,
                    FullName = item.FullName,
                    DebtorLedgerNumber = item.DebtorLedgerNumber
                });
            }

            return data;
        }

        public ReadDebtorDto GetDebtorByDebtorId(string debtorId)
        {
            var result = _debtorRepository.GetDebtorByDebtorId(debtorId);

            if (result == null)
                return null;

            return new ReadDebtorDto
            {
                DebtorId = result.DebtorId,
                FullName = result.FullName,
                DebtorLedgerNumber = result.DebtorLedgerNumber
            };
        }

        public ReadDebtorDto GetDebtorByDebtorLedgerNumber(string debtorLedgerNumber)
        {
            var result = _debtorRepository.GetDebtorByDebtorLedgerNumber(debtorLedgerNumber.ToUpper());

            if (result == null)
                return null;

            return new ReadDebtorDto
            {
                DebtorId = result.DebtorId,
                FullName = result.FullName,
                DebtorLedgerNumber = result.DebtorLedgerNumber
            };
        }

        public void UpdateDebtor(UpdateDebtorDto dto)
        {
            var model = new DebtorModel
            {
                DebtorId = dto.DebtorId,
                FullName = dto.FullName.ToUpper().Trim(),
                DebtorLedgerNumber = dto.DebtorLedgerNumber.ToUpper().Trim(),
                UpdatedAt = DateTime.Now
            };

            _debtorRepository.UpdateDebtor(model);
        }
    }
}
