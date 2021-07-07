using System;

namespace Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Öz yinelemeli, üslü işlemler, faktöriyel, fibonacci gibi işlemlerde kullanılır
            
            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
                Console.WriteLine(result);
                Islemler instance = new Islemler();
                Console.WriteLine(instance.Expo(3,4));

                //Extension Metotlar
                string ifade = "Büşra Altun";
                bool sonuc = ifade.CheckSpace();
                Console.WriteLine(sonuc);
                if (sonuc)
                    Console.WriteLine (ifade.RemoveWhiteSpaces());
            
        }
    }
    public class Islemler 
    {
        public int Expo ( int sayi, int üs)
        {
            if(üs<2)
                return sayi;
            return Expo (sayi, üs -1) * sayi;
        }
        //Expo (3,4)
        //Expo (3,3) * 3
        //Expo (3,2) * 3 * 3
        //Expo (3,1) *3 * 3 * 3
        //3 * 3 * 3 * 3 = 3 ^ 4 = 81
    }
    public static class Extension
    { //içeride boşluk olup olmadığını kontrol eden metot
        public static bool CheckSpace (this string param)
        {
            return param.Contains ( "");
        }
        public static string RemoveWhiteSpaces (this string  param) 
        {
            string[] dizi = param.Split( " "); // bu string i boşluklara göre ayırıp diziye alacak olan kod satırı
            return string.Join ("",dizi);
        }
    }
}
