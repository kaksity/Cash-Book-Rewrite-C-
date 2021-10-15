using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashBook.DataAccess
{
    public static class Utility
    {
        public static string ConnectionString { get; set; } = "database=cashbook;username=SYSDBA;password=masterkey;server=localhost";
    }
}
