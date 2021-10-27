using CashBook.Dtos.MaintainBalance;
using CashBook.Models.MaintainBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Services.MaintainBalance
{
    public interface IMaintainBalanceService
    {

        void CreateMaintainBalance(CreateMaintainBalanceDto model);
        List<ReadMaintainBalanceDto> GetAllMaintainBalanceByAccountId(string accountId);
        //MaintainBalanceModel GetMaintainBalanceByAccountIdAndDuration(string accountId, string duration);
    }
}
