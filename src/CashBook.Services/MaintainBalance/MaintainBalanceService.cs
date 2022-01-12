using CashBook.Models.MaintainBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.MaintainBalance;
using CashBook.DataAccess.MaintainBalance;
using CashBook.Services.BankReconcilation;

namespace CashBook.Services.MaintainBalance
{
    public class MaintainBalanceService : IMaintainBalanceService
    {
        private readonly IMaintainBalanceRepository _maintainBalanceRepository;
        private readonly IBankReconcilationService _bankReconcilationService;

        public MaintainBalanceService(IMaintainBalanceRepository maintainBalanceRepository, IBankReconcilationService bankReconcilationService)
        {
            _maintainBalanceRepository = maintainBalanceRepository;
            _bankReconcilationService = bankReconcilationService;
        }

        private DateTime GetDateFromDuration(int month,int year)
        {
            var date = $"{month}/1/{year}";
            return DateTime.Parse(date);
        }

        private DateTime GetDateFromDuration(string duration)
        {
            var splitedDuration = duration.Split('.');

            int month = Convert.ToInt16(splitedDuration[0]);
            int year = Convert.ToInt16(splitedDuration[1]);
            var date = $"{month}/1/{year}";
            return DateTime.Parse(date);
        }
        
        public void CloseMaintainBalance(UpdateMaintainBalanceDto dto)
        {
            var splitedDuration = dto.Duration.Split('.');

            int month = Convert.ToInt16(splitedDuration[0]);
            int year = Convert.ToInt16(splitedDuration[1]);

            var maintainBalance = new MaintainBalanceModel
            {
                MaintainBalanceId = dto.MaintainBalanceId,
                AccountId = dto.AccountId,
                ClosingBalance = dto.ClosingBalance,
                Duration = GetDateFromDuration(month,year),
                Status = dto.Status,
                UpdatedAt = DateTime.Now
            };

            _maintainBalanceRepository.CloseMaintainBalance(maintainBalance);

            if (month == 12)
            {
                year = year + 1;
            }
            else
            {
                month = month + 1;
            }

            var newDuration = GetDateFromDuration(month,year);

            var newMaintainBalance = new MaintainBalanceModel
            {
                MaintainBalanceId = Guid.NewGuid().ToString(),
                AccountId = dto.AccountId,
                OpeningBalance = dto.ClosingBalance,
                ClosingBalance = 0,
                Duration = newDuration,
                Status = 0,
                IsEdited = false,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _maintainBalanceRepository.CreateMaintainBalance(newMaintainBalance);
        }

        public void CreateMaintainBalance(CreateMaintainBalanceDto model)
        {
            var maintainBalance = new MaintainBalanceModel
            {
                MaintainBalanceId = Guid.NewGuid().ToString(),
                AccountId = model.AccountId,
                OpeningBalance = model.OpeningBalance,
                ClosingBalance = model.ClosingBalance,
                Duration = GetDateFromDuration(model.Duration),
                Status = model.Status,
                IsDeleted = false,
                IsEdited = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _maintainBalanceRepository.CreateMaintainBalance(maintainBalance);
        }

        public void DeleteMaintainBalance(string maintainBalanceId)
        {
            _maintainBalanceRepository.DeleteMaintainBalance(maintainBalanceId);
        }

        public List<ReadMaintainBalanceDto> GetAllMaintainBalanceByAccountId(string accountId)
        {
            var accountsList = _maintainBalanceRepository.GetAllMaintainBalanceByAccount(accountId);

            var data = new List<ReadMaintainBalanceDto>();

            for (int i = 0; i < accountsList.Count; i++)
            {
                data.Add( new ReadMaintainBalanceDto
                {
                    MaintainBalanceId = accountsList[i].MaintainBalanceId,
                    AccountId = accountsList[i].AccountId,
                    OpeningBalance = accountsList[i].OpeningBalance,
                    ClosingBalance = accountsList[i].ClosingBalance,
                    Duration = PrepareDuration(accountsList[i].Duration),
                    Status = accountsList[i].Status,
                    IsEdited = accountsList[i].IsEdited
                });
            }
            return data;
        }
        private string PrepareDuration(DateTime input)
        {
            return $"{input.Month}.{input.Year}";
        }
        public ReadMaintainBalanceDto GetMaintainBalanceByAccountIdAndDuration(string accountId, string duration)
        {
            var date = GetDateFromDuration(duration);
            var result = _maintainBalanceRepository.GetMaintainBalanceByAccountIdAndDuration(accountId,date);

            if (result == null) return null;

            var returnData = new ReadMaintainBalanceDto
            {
                MaintainBalanceId = result.MaintainBalanceId,
                AccountId = result.AccountId,
                OpeningBalance = result.OpeningBalance,
                ClosingBalance = result.ClosingBalance,
                Duration = PrepareDuration(result.Duration),
                Status = result.Status,
                IsEdited = result.IsEdited
            };
            return returnData;
        }

        public void SetMaintainBalanceAsEdited(string maintainBalanceId)
        {
            _maintainBalanceRepository.SetMaintainBalanceAsEdited(maintainBalanceId);
        }
        
        public List<ReadMaintainBalanceDto> GetEditedMaintainBalanceByAccountId(string accountId)
        {
            // Get All the Maintain Balance Record in the database
            var editedMaintainBalance =_maintainBalanceRepository.GetEditedMaintainBalanceByAccount(accountId);

            // Loop through them 
            var data = new List<ReadMaintainBalanceDto>();

            for (int i = 0; i < editedMaintainBalance.Count; i++)
            {
                data.Add(new ReadMaintainBalanceDto
                {
                    MaintainBalanceId = editedMaintainBalance[i].MaintainBalanceId,
                    AccountId = editedMaintainBalance[i].AccountId,
                    OpeningBalance = editedMaintainBalance[i].OpeningBalance,
                    ClosingBalance = editedMaintainBalance[i].ClosingBalance,
                    Duration = PrepareDuration(editedMaintainBalance[i].Duration),
                    Status = editedMaintainBalance[i].Status,
                    IsEdited = editedMaintainBalance[i].IsEdited
                });
            }
            return data;
        }
        public ReadMaintainBalanceDto RecalculateMaintainBalance(ReadMaintainBalanceDto dto)
        {

            // Get the Bank Reconcilation Details
            var bankReconcilation = _bankReconcilationService.GetBankReconcilationByAccountIdAndDuration(dto.AccountId,dto.Duration);

            // Perform the Calculations
            
            if(bankReconcilation != null)
            {
                dto.ClosingBalance = _bankReconcilationService.CalculateBankReconcilationClosingBalance(dto.OpeningBalance, bankReconcilation);
            }
            else
            {
                dto.ClosingBalance = dto.OpeningBalance;
            }

            // Update the database with the closing balance
            var updateMaintainBalance = new UpdateMaintainBalanceDto
            {
                MaintainBalanceId = dto.MaintainBalanceId,
                AccountId = dto.AccountId,
                OpeningBalance = dto.OpeningBalance,
                ClosingBalance = dto.ClosingBalance,
                Duration = dto.Duration,
                IsEdited = false,
                Status = 1
            };

            UpdatedCorrectedMaintainBalance(updateMaintainBalance);

            // return the dto correct closing balance
            return dto;
        }

        public void UpdatedCorrectedMaintainBalance(UpdateMaintainBalanceDto dto)
        {
            var splitedDuration = dto.Duration.Split('.');

            int month = Convert.ToInt16(splitedDuration[0]);
            int year = Convert.ToInt16(splitedDuration[1]);

            var maintainBalance = new MaintainBalanceModel
            {
                MaintainBalanceId = dto.MaintainBalanceId,
                AccountId = dto.AccountId,
                OpeningBalance = dto.OpeningBalance,
                ClosingBalance = dto.ClosingBalance,
                Duration = GetDateFromDuration(month, year),
                IsEdited = dto.IsEdited,
                Status = dto.Status,
                UpdatedAt = DateTime.Now
            };

            _maintainBalanceRepository.UpdateMaintainBalance(maintainBalance);
        }
    }
}
