using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethod.Extensions
{
    public static class IsWeekExtension
    {
        public static bool IsWeekend(this DateTime day)
        {
            return (day.DayOfWeek == DayOfWeek.Sunday || day.DayOfWeek == DayOfWeek.Saturday);
        }
    }
}
