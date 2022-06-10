using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Services;

namespace CashBook.DataAccess.DataRecovery
{
    public class DataRecoveryRepository : IDataRecoveryRepository
    {

        public void PerformBackup(string filePath)
        {
            var firebirdBackup = new FbBackup(Utility.ConnectionString);

            var file = new FbBackupFile(filePath);
            firebirdBackup.BackupFiles.Add(file);
            firebirdBackup.Verbose = true;
            firebirdBackup.Execute();
        }

        public void PerformRestore(string filePath)
        {
            var firebirdRestore = new FbRestore(Utility.ConnectionString);
            var file = new FbBackupFile(filePath);
            firebirdRestore.BackupFiles.Add(file);
            FbConnection.ClearAllPools();
            firebirdRestore.Options = FbRestoreFlags.Replace;
            firebirdRestore.Verbose = true;
            firebirdRestore.Execute();
        }
    }
}
