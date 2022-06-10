using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.BinCardItem;

namespace CashBook.Services.BinCardItem
{
    public interface IBinCardItemService
    {
        void CreateBinCardItem(CreateBinCardItemDto dto);
        void DeleteBinCardItem(string binCardItemId);
        void UpdateBinCardItem(UpdateBinCardItemDto dto);

        List<ReadBinCardItemDto> GetAllBinCardItem();
        ReadBinCardItemDto GetBinCardItemByBinCardItemId(string binCardItemId);
    }
}
