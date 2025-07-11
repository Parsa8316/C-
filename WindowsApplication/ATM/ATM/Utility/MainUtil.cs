using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Utility
{
    public static class MainUtil
    {
        public static string ConvertCsDateToSqlDate(DateTime date)
        {
            return $"{date.Year}-{date.Month}-{date.Day}";
        }
        public static string DatetimeNow()
        {
            DateTime dateTime = DateTime.Now;
            return $"{dateTime.Year}-{dateTime.Month}-{dateTime.Day}";
        }
    }
}
