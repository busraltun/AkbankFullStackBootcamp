using System;

namespace ToDo_App
{
    class Program
    {
        static void Main(string[] args)
        { 
            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("******************************************** ");

                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine ("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak \n");

                int secim = int.Parse(Console.ReadLine());
                switch(secim)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
                // Console.ReadKey();
            }

        }

    }
}
