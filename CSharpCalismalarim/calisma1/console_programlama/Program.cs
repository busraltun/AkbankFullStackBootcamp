using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selam, merak ettim adın nedir ?");
            string name1 = Console.ReadLine();

            Console.WriteLine("Benim adım " + name1 + " " +"senin adın ne ?");

            string name2 = Console.ReadLine();
            Console.WriteLine("Benim de adım " + name2 + " " + "çok memnun oldum. Şu an ne yapıyorsun ? ");
            
            int sayi1 = 60;
            int sayi2 = 120;
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Kardeşime" + sayi1 +" ve " +  sayi2 + "nin toplamının " + toplam + " olduğunu anlatmaya çalışıyorum");
            Console.WriteLine("Vayy bu çok güzel");
            Console.ReadLine();
        }
    }
}