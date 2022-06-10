using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Services.DataRecovery
{
    public interface IDataRecoveryService
    {
        void PerformBackup(string filePath);
        void PerformRestore(string filePath);
    }
}
