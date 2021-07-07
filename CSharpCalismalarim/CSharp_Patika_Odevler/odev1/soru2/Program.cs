using System;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("İlk pozitif sayıyı giriniz :");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz :");
            int number2 = int.Parse(Console.ReadLine());
            if (number1 > 0 && number2 > 0)
            {
                Console.WriteLine("Lütfen" + " " + number1 + " adet sayı girişi yapınız :");


                for (int i = 0; i < number1; i++)
                {
                    Console.Write("{0}.sayı : ", i + 1);
                    int value = int.Parse(Console.ReadLine());

                    if (value == number2 || value % 2 == 0)
                    {


                        Console.WriteLine(value + " " + number2 + " eşit veya tam bölünen bir sayıdır.");

                    }

                    else
                    {
                        Console.WriteLine(number2 + " " + value + " ile aynı veya tam bölünen sayı değildir.");
                    }


                }

            }
            else
            {
                Console.WriteLine("Lütfen sayıları pozitif giriniz !!! ");
            }

        }
    }
}
