using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.TransactionDescription;
using CashBook.DataAccess.TransactionDescription;
using CashBook.Models.TransactionDescription;

namespace CashBook.Services.TransactionDescription
{
    public class TransactionDescriptionService : ITransactionDescriptionService
    {
        private readonly ITransactionDescriptionRepository _transactionDescriptionRepository;
        public TransactionDescriptionService(ITransactionDescriptionRepository transactionDescriptionRepository)
        {
            _transactionDescriptionRepository = transactionDescriptionRepository;
        }
        public void CreateTransactionDescription(CreateTransactionDescriptionDto dto)
        {
            var transactionDescription = new TransactionDescriptionModel
            {
                TransactionDescriptionId = Guid.NewGuid().ToString(),
                DescriptionName = dto.DescriptionName,
                TransactionType = dto.TransactionType,
                Description = dto.Description,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
        }

        public void DeleteTransactionDescription(string transactionDescriptionId)
        {
            _transactionDescriptionRepository.DeleteTransactionDescription(transactionDescriptionId);
        }

        public List<ReadTransactionDescriptionDto> GetAllTransactionDescriptions()
        {
            var results = _transactionDescriptionRepository.GetAllTransactionDescriptions();

            var transactionDescription = new List<ReadTransactionDescriptionDto>();

            foreach (var item in results)
            {
                transactionDescription.Add(new ReadTransactionDescriptionDto
                {
                    TransactionDescriptionId = item.TransactionDescriptionId,
                    DescriptionName = item.DescriptionName,
                    TransactionType = item.TransactionType,
                    Description = item.Description
                });
            }
            return transactionDescription;
        }

        public List<ReadTransactionDescriptionDto> GetAllTransactionDescriptionsByTransactionType(string transactionType)
        {
            var results = _transactionDescriptionRepository.GetAllTransactionDescriptionsByTransactionType(transactionType);

            var transactionDescription = new List<ReadTransactionDescriptionDto>();

            foreach (var item in results)
            {
                transactionDescription.Add(new ReadTransactionDescriptionDto
                {
                    TransactionDescriptionId = item.TransactionDescriptionId,
                    DescriptionName = item.DescriptionName,
                    TransactionType = item.TransactionType,
                    Description = item.Description
                });
            }
            return transactionDescription;
        }
    }
}
