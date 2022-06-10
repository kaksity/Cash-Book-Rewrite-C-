using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.DataAccess.BinCard;
using CashBook.Dtos.BinCard;
using CashBook.Models.BinCard;

namespace CashBook.Services.BinCard
{

   
    public class BinCardService : IBinCardService
    {
        private readonly IBinCardRepository _binCardRepository;
        public BinCardService(IBinCardRepository binCardRepository)
        {
            _binCardRepository = binCardRepository;
        }

        public void CreateNewBinCard(CreateBinCardDto dto)
        {
            var newBinCard = new BinCardModel
            {
                BinCardId = Guid.NewGuid().ToString(),
                BinCardItemId = dto.BinCardItemId,
                DateOfIssueOrReceipt = dto.DateOfIssueOrReceipt,
                IssuedQuantity = dto.IssuedQuantity,
                SivSrvOthers = dto.SivSrvOthers,
                ReceivedQuantity = dto.RecievedQuantity,
                UnitPrice = dto.UnitPrice,
                Description = dto.Description,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _binCardRepository.CreateNewBinCard(newBinCard);
        }

        public void DeleteBinCard(string binCardId)
        {
            _binCardRepository.DeleteBinCard(binCardId);
        }

        public List<ReadBinCardDto> GetAllBinCards()
        {
            var results = _binCardRepository.GetAllBinCards();
            return MapBinCardModelToDto(results);
        }

        private List<ReadBinCardDto> MapBinCardModelToDto(List<BinCardModel> model)
        {
            var data = new List<ReadBinCardDto>();
            foreach (var item in model)
            {
                data.Add(new ReadBinCardDto
                {
                    BinCardId = item.BinCardId,
                    BinCardItemName = item.BinCardItem.BinCardItemName,
                    DateOfIssueOrReceipt = item.DateOfIssueOrReceipt,
                    IssuedQuantity = item.IssuedQuantity,
                    SivSrvOthers = item.SivSrvOthers,
                    RecievedQuantity = item.ReceivedQuantity,
                    UnitPrice = item.UnitPrice,
                    Description = item.Description
                });
            }
            return data;
        }
        public void UpdateExistingBinCard(UpdateBinCardDto dto)
        {
            var editBinCard = new BinCardModel
            {
                BinCardId = "",
                DateOfIssueOrReceipt = dto.DateOfIssueOrReceipt,
                IssuedQuantity = dto.IssuedQuantity,
                ReceivedQuantity = dto.RecievedQuantity,
                UnitPrice = dto.UnitPrice,
                SivSrvOthers = dto.SivSrvOthers,
                Description = dto.Description,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _binCardRepository.UpdateExistingBinCard(editBinCard);
        }

        public List<ReadBinCardDto> GetBinCardsByBinCardItemsMonthAndYear(string binCardItem, int year)
        {
            var results = _binCardRepository.GetBinCardsByBinCardItemsMonthAndYear(binCardItem,year);
            return MapBinCardModelToDto(results);
        }
    }
}
