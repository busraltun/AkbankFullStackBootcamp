using System;

namespace enum_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);

            int sicaklik = 32;
            if(sicaklik <= (int)HavaDurumu.Normal)
              Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekle");
            else if (sicaklik >= (int)HavaDurumu.Sıcak)
              Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
              Console.WriteLine("Hadi dışarı çıkalım ! ");
        }
    }
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSicak = 30
    }
}
