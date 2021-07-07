using System;

namespace odev1
{
    class Program
    {
/*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Sayı Giriniz : ");
                int number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    for (int i = 0; i < number; i++)
                    {
                        
                        if ( i %2 == 0)
                        {
                            Console.Write( i + "-" );
                        }

                        
                    }

                    break;
                }
                else
                {
                    Console.WriteLine(" !!! Lütfen Sıfırdan Büyük Bir Sayı Giriniz !!! ");
                }
            }
        }
    }
}
