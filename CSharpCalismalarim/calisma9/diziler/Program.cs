using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[5]; //eleman sayısı belli olan dizi

            string[] animals = { "Balık", "Papağan", "Köpek", "Kedi" }; //hem eleman sayısı hem de eleman içeriği belli olan dizi

            int[] dizi;
            dizi = new int[6];

            //Dizilerde değer atama ve erişim

            colors[0] = "Mavi"; //dizinin 0.indeksi yani ilk elemanına Mavi rengini atamış olduk.
            Console.WriteLine(animals[1]); //output papağan olur
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(colors[0]);


            //Kullanıcıdan 20 tane sayı girmesini isteyen ve kullanıcının girdiği bu sayıların ortalamasını hesaplayan kod parçası
            // int[] sayiDizisi = new int[20];
            // int toplam = 0;
            // for (int i = 0; i < sayiDizisi.Length; i++)
            // {
            //     Console.Write("Lütfen {0}. sayıyı girin:", i + 1);
            //     sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
            //     toplam += sayiDizisi[i];
            // }
            // double ortalama = toplam / 20;
            // Console.WriteLine("Sayıların ortalaması: " + ortalama);
            // Console.ReadLine();
            // //Döngülerde dizi kullanımı,kullanıcıdan alınan sayıların ortalamasını hesaplama
            // Console.WriteLine("Kaç tane sayının ortalamasını istiyorsun ? ");//dizinin eleman sayısını kullanıcıdan istiyoruz
            // int arrayLength = int.Parse(Console.ReadLine());
            // int[] arrayNumber = new int[arrayLength];

            // for (int i = 0; i < arrayLength; i++)
            // {
            //     Console.WriteLine("Lütfen {0}. sayıyı giriniz : ", i + 1);
            //     arrayNumber[i] = int.Parse(Console.ReadLine());
            // }

            // int total = 0;
            // foreach (var sayi in arrayNumber)
            //     total += sayi;
            // Console.WriteLine("Ortalama:" + total / arrayLength);

            //SORT 
            int[] sayi_dizisi = {23,12,4,86,72,3,11,17};
            Console.WriteLine("******** SIRASIZ DİZİ *******");
            foreach (var sayi in sayi_dizisi)
                    Console.WriteLine(sayi);
            
            Console.WriteLine("******* SIRALI DİZİ ********* ");
            Array.Sort(sayi_dizisi);

            foreach (var sayi in sayi_dizisi)
                   Console.WriteLine(sayi);

            //CLEAR

            Console.WriteLine("*******//// ARRAY CLEAR ////********* ");
            Array.Clear(sayi_dizisi,2,2);
//sayı dizisi elemanları kullanarak 2.index ten itibaren 2 tane elemanı 0'lar.
            foreach (var sayi in sayi_dizisi)
                   Console.WriteLine(sayi);

            Console.WriteLine("******* ARRAY REVERSE ********* ");
            Array.Reverse(sayi_dizisi,2,2);
            foreach (var sayi in sayi_dizisi)
                   Console.WriteLine(sayi);

            Console.WriteLine("******* ARRAY INDEXOF ********* ");
            Console.WriteLine(Array.IndexOf(sayi_dizisi,23));

            Console.ReadKey();
        }
    }
}
