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
        //List<MaintainBalanceModel> GetAllMaintainBalance();
        //MaintainBalanceModel GetMaintainBalanceByAccountIdAndDuration(string accountId, string duration);
    }
}
