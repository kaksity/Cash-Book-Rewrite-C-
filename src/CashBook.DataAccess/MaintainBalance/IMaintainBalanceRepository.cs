using CashBook.Models.MaintainBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.DataAccess.MaintainBalance
{
    public interface IMaintainBalanceRepository
    {
        void CreateMaintainBalance(MaintainBalanceModel model);
        List<MaintainBalanceModel> GetAllMaintainBalance();
        MaintainBalanceModel GetMaintainBalanceByAccountIdAndDuration(string accountId, string duration);
    }
}
