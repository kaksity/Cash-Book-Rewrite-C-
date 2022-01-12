using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.BinCardItem;

namespace CashBook.DataAccess.BinCardItem
{
    public interface IBinCardItemRepository
    {
        void CreateBinCardItem(BinCardItemModel model);
        void DeleteBinCardItem(string binCardItemId);
        void UpdateBinCardItem(BinCardItemModel model);

        List<BinCardItemModel> GetAllBinCardItem();
    }
}
