using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.DataAccess.BinCardItem;
using CashBook.Dtos.BinCardItem;
using CashBook.Models.BinCardItem;

namespace CashBook.Services.BinCardItem
{
    public class BinCardItemService : IBinCardItemService
    {
        private readonly IBinCardItemRepository _binCardItemRepository;
        public BinCardItemService(IBinCardItemRepository binCardItemRepository)
        {
            _binCardItemRepository = binCardItemRepository;
        }

        public void CreateBinCardItem(CreateBinCardItemDto dto)
        {
            var model = new BinCardItemModel
            {
                BinCardItemId = Guid.NewGuid().ToString(),
                BinCardItemName = dto.BinCardItemName,
                BinCardItemDescription = dto.BinCardItemDescription
            };
            _binCardItemRepository.CreateBinCardItem(model);
        }

        public void DeleteBinCardItem(string binCardItemId)
        {
            _binCardItemRepository.DeleteBinCardItem(binCardItemId);
        }

        public List<ReadBinCardItemDto> GetAllBinCardItem()
        {
            var results = _binCardItemRepository.GetAllBinCardItem();
            var data = new List<ReadBinCardItemDto>();
            foreach (var item in results)
            {
                data.Add(new ReadBinCardItemDto
                {
                    BinCardItemId = item.BinCardItemId,
                    BinCardItemName = item.BinCardItemName,
                    BinCardItemDescription = item.BinCardItemDescription
                });
            }
            return data;
        }

        public void UpdateBinCardItem(UpdateBinCardItemDto dto)
        {
            var model = new BinCardItemModel
            {
                BinCardItemId = dto.BinCardItemId,
                BinCardItemName = dto.BinCardItemName,
                BinCardItemDescription = dto.BinCardItemDescription == null ? "": dto.BinCardItemDescription,
            };
            _binCardItemRepository.UpdateBinCardItem(model);
        }
    }
}
