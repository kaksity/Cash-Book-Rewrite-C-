using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.DataAccess.DataRecovery
{
    public interface IDataRecoveryRepository
    {
        void PerformBackup(string filePath);
        void PerformRestore(string filePath);
    }
}
