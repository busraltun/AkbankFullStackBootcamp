using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethod.Extensions
{
    public static class FactorialExtension
    {
        public static long Factorial(this Int32 value)
        {
            if (value == 1)
                return 1;
            if (value == 2)
                return 2;
            else
                return value * Factorial(value - 1);
        }
    }
}
