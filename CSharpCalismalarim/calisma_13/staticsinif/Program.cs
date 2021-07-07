using System;

namespace staticsinif
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir sınıf içerisindeki static olmayan field lara, özelliklere o sınıftan oluşturduğumuz nesne aracılığıyla erişebiliyoruz.
            Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan ("Büşra", "Altun", "Mühendis");
            Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan ("Melike", "Altun", "Doktor");
            Calisan calisan2 = new Calisan ("İlkay", "Altun", "Gazeteci");
            Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);
            
            Console.WriteLine("Toplama İşlemi Sonucu : {0}",İslemler.Topla(100,200));
            Console.WriteLine("Çıkarma İşlemi Sonucu : {0} ",İslemler.Cikar(200,100));


        }
    }
    class Calisan
    {
        private static int calisanSayisi ;

        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan () //static kurucuların erişim belirteci olmaz
        {
            calisanSayisi = 0 ;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim ;
            this.Departman = departman;
            calisanSayisi ++;
        }
    }

    static class İslemler 
    {
        public static long Topla (int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikar (int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}

//Sınıfların statik olması durumu : Bir sınıfı statik yaparsak ;  o sınıf içerisindeki tüm property ler, field ler static olmak zorunda