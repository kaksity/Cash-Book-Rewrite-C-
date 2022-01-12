﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Services.Utility
{
    public interface IUtilityService 
    {
        DataTable GetMonths();
        DataTable GetYears();
        DataTable GetIssueOrReceipt();
        string FormatDecimal(decimal input);
    }
}
