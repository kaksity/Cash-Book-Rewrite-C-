using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.DataAccess.DataRecovery;

namespace CashBook.Services.DataRecovery
{
    public class DataRecoveryService : IDataRecoveryService
    {
        private readonly IDataRecoveryRepository _dataRecoveryRepository;

        public DataRecoveryService(IDataRecoveryRepository dataRecoveryRepository)
        {
            _dataRecoveryRepository = dataRecoveryRepository;
        }
        public void PerformBackup(string filePath)
        {
            _dataRecoveryRepository.PerformBackup(filePath);
        }

        public void PerformRestore(string filePath)
        {
            _dataRecoveryRepository.PerformRestore(filePath);
        }
    }
}
