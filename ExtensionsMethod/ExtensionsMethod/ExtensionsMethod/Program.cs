using ExtensionsMethod.Extensions;
using System;

namespace ExtensionsMethod
{
    class Program
    {


        static void Main(string[] args)
        {
            DateTime dateTo = default;
            DateTime dateFrom = default;
            for (DateTime date = dateFrom; date <= dateTo; date = date.AddDays(1))
            {
                if (date.IsWeekend()) continue;
                Console.WriteLine("Evet bugün haftasonu");

            }

            int number = 7;
            long answer = number.Factorial();
            Console.WriteLine("Faktöriyel : " + answer);
        }
    }
}
