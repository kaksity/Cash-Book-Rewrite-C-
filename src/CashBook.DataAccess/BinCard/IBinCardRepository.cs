using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.BinCard;

namespace CashBook.DataAccess.BinCard
{
    public interface IBinCardRepository
    {
        void CreateNewBinCard(BinCardModel model);
        void UpdateExistingBinCard(BinCardModel model);
        void DeleteBinCard(string binCardId);

        List<BinCardModel> GetAllBinCards();
        List<BinCardModel> GetBinCardsByBinCardItemsMonthAndYear(string binCardItem, int year);
    }
}
