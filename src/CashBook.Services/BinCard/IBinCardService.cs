using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.BinCard;

namespace CashBook.Services.BinCard
{
    public interface IBinCardService
    {
        void CreateNewBinCard(CreateBinCardDto model);
        void UpdateExistingBinCard(UpdateBinCardDto model);
        void DeleteBinCard(string binCardId);
        List<ReadBinCardDto> GetAllBinCards();
        List<ReadBinCardDto> GetBinCardsByBinCardItemsMonthAndYear(string binCardItem, int year);
    }
}
