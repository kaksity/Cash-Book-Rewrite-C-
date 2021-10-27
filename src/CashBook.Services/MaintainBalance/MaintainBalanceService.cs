﻿using CashBook.Models.MaintainBalance;
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
            var maintainBalance = new MaintainBalanceModel
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
    }
}