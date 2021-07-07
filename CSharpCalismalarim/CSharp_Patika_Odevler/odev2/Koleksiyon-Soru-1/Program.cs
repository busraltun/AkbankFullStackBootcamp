using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyon_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
            (ArrayList sınıfını kullanara yazınız.)
            Negatif ve numeric olmayan girişleri engelleyin.
            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            */
            int sayac = 0, toplam_asal= 0 , toplam_notAsal = 0;
            double ortalama_asal = 0, ortalama_notAsal = 0;
            Console.WriteLine("Lütfen 20 adet sayı giriniz : ");


            ArrayList asal = new ArrayList();
            ArrayList notAsal = new ArrayList();

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("{0}.sayı : ", i);
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 1 || sayi == 0)
                {
                    Console.WriteLine("Girilen sayı asal değildir.");
                }
                else
                {
                    for (int j = 2; j < sayi; j++)
                    {
                        if (sayi % j == 0)
                        {
                            sayac++;
                            break;
                        }
                    }

                }
                if (sayac != 0)
                {
                    notAsal.Add(sayi);
                    toplam_notAsal += sayi;
                    ortalama_notAsal = toplam_notAsal / notAsal.Count;
                    siralama(notAsal);


                }

                else
                {
                    asal.Add(sayi);
                    toplam_asal += sayi;
                    ortalama_asal = toplam_asal / asal.Count;
                    siralama(asal);
                    Console.WriteLine(" ");



                }
            }
            Console.WriteLine("Asal Sayısı: " + asal.Count);
            Console.WriteLine("Asal Olmayan Sayısı :" + notAsal.Count);
            Console.WriteLine("Asal Sayıların Ortalaması : " + ortalama_asal);
            Console.WriteLine("Asal Olmayanların Ortalaması :" + ortalama_notAsal);


        }

        public static void siralama(ArrayList liste)
        {
            liste.Sort();
            liste.Reverse();
        }

    }
}