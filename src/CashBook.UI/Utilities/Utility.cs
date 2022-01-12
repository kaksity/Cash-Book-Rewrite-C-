using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.UI.Utilities
{
    public static class Utility
    {
        public static bool IsNumeric(string input)
        {
            int outInt = 0;
            long outLong = 0;
            decimal outDecimal = 0;
            if (int.TryParse(input,out outInt) == true || long.TryParse(input,out outLong) == true || decimal.TryParse(input, out outDecimal) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static decimal ParseNumber(string input)
        {
            return decimal.Parse(input);
        }
        public static string FormatDecimal(decimal input)
        {
            return input.ToString("N");
        }
        public static string FormatDate(DateTime input)
        {
            return input.ToString("dd/MM/yyyy");
        }
    }
}
