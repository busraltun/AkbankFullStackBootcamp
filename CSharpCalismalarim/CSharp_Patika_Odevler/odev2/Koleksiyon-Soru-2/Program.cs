using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyon_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını
             console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            */

            List<int> sayilar = new List<int>();
            int sayac = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine((i + 1) + " .sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                sayilar.Add(sayi);
                sayac++;
            }
            Console.WriteLine($"En Büyük 3 Sayı : {string.Join(",", sayilar.OrderByDescending(x => x).Take(3))}");
            Console.WriteLine($"En Küçük 3 Sayı : {string.Join(",", sayilar.OrderBy(x => x).Take(3))}");
            Console.WriteLine($"En Büyük 3 Sayının Ortalaması : {string.Join(",", sayilar.OrderByDescending(x => x).Take(3).Average())}");
            Console.WriteLine($"En Küçük 3 Sayının Ortalaması : {string.Join(",", sayilar.OrderBy(x => x).Take(3).Average())}");

        }
    }
}
