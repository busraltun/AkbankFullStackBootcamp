using System;

namespace Koleksiyon_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle gir bakalım");
            string cumle = Convert.ToString(Console.ReadLine());
            char[] sesliler = { 'a', 'e', 'ı','i', 'o','ö', 'u', 'ü' }; //sesli harfler dizisi
            int seslisayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j < sesliler.Length; j++)
                {
                    if (cumle[i] == sesliler[j])
                    {
                        seslisayac++;
                        char cumledekisesliler = cumle[i];
                        Console.Write(cumledekisesliler);
                    }                  
                }
            }
            Console.WriteLine("Sesli harf sayısı : " +seslisayac);
        }
    }
}