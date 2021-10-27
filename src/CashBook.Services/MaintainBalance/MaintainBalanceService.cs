using CashBook.Models.MaintainBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.MaintainBalance;
using CashBook.DataAccess.MaintainBalance;

namespace CashBook.Services.MaintainBalance
{
    public class MaintainBalanceService : IMaintainBalanceService
    {
        private readonly IMaintainBalanceRepository _maintainBalanceRepository;

        public MaintainBalanceService(IMaintainBalanceRepository maintainBalanceRepository)
        {
            _maintainBalanceRepository = maintainBalanceRepository;
        }
        public void CreateMaintainBalance(CreateMaintainBalanceDto model)
        {
            var maintainBalance = new ReadMaintainBalanceDto
            {
                MaintainBalanceId = Guid.NewGuid().ToString(),
                AccountId = model.AccountId,
                OpeningBalance = model.OpeningBalance,
                ClosingBalance = model.ClosingBalance,
                Duration = model.Duration,
                Status = model.Status,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _maintainBalanceRepository.CreateMaintainBalance(maintainBalance);
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
                    Duration = accountsList[i].Duration,
                    Status = accountsList[i].Status,
                });
            }
            return data;
        }

        public ReadMaintainBalanceDto GetMaintainBalanceByAccountIdAndDuration(string accountId, string duration)
        {
            var result = _maintainBalanceRepository.GetMaintainBalanceByAccountIdAndDuration(accountId,duration);

            if (result == null) return null;

            var returnData = new ReadMaintainBalanceDto
            {
                MaintainBalanceId = result.MaintainBalanceId,
                AccountId = result.AccountId,
                OpeningBalance = result.OpeningBalance,
                ClosingBalance = result.ClosingBalance,
                Duration = result.Duration,
                Status = result.Status
            };
            return returnData;
        }
    }
}
