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
        List<MaintainBalanceModel> GetAllMaintainBalanceByAccount(string accountId);
        List<MaintainBalanceModel> GetEditedMaintainBalanceByAccount(string accountId);
        MaintainBalanceModel GetMaintainBalanceByAccountIdAndDuration(string accountId, DateTime duration);
        MaintainBalanceModel GetMaintainBalanceByBankReconcilationId(string maintainBalanceId);
        void CloseMaintainBalance(MaintainBalanceModel model);
        void UpdateMaintainBalance(MaintainBalanceModel model);
        void DeleteMaintainBalance(string maintainBalanceId);
        void SetMaintainBalanceAsEdited(string maintainBalanceId);


    }
}
