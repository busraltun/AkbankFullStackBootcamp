using System;

namespace soru3
{
    class Program
    {
        /*
        Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
        Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
         Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
            int number = int.Parse(Console.ReadLine());
            if (true)
            {
                Console.WriteLine("Lütfen" + " " + number + " " + "tane kelime giriniz :");
                string[] word = new string[number];
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(i + 1 + ".kelime:");
                    word[i] = Convert.ToString(Console.ReadLine());
                    int rank = word.Length - 1;

                    for (int j = rank; j >= 0; --j)
                    {
                        Console.WriteLine(word[j]);

                    }

                }

            }

        }
    }
}
