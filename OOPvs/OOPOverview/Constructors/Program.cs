using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* CardAccount card = new CardAccount();
             Console.WriteLine(card.Type);*/
            // CardAccount card = new CardAccount(10000);
            CardAccount card = new CardAccount();
            Console.WriteLine(card.Type);

        }
    }
}
