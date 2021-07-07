using System;

namespace sınıf_instance_field
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Calisan calisan1 = new Calisan("Ayşe","Kara",23456,"İnsan Kaynakları");
            calisan1.CalisanBilgieleri();

            Calisan calisan2 = new Calisan ();
            calisan2.Ad = "Ayşe";
            calisan2.SoyAd = "Kara";
            calisan2.No = 23456;
            calisan2.Departman = "İnsan Kaynakları";
            calisan2.CalisanBilgieleri();
            
            Calisan calisan3 = new Calisan ("Zikriye","Ürkmez");
            calisan3.CalisanBilgieleri();
        }
    }
            class Calisan
            {
                public string Ad;
                public string SoyAd;
                public int No;
                public string Departman;

                public Calisan(string ad, string soyad, int no, string departman)
                {
                    this.Ad = ad;
                    this.SoyAd = soyad;
                    this.No = no;
                    this.SoyAd = soyad;

                }
                public Calisan(string ad, string soyad)
                {
                    this.Ad = ad;
                    this.SoyAd = soyad;
                }
                public Calisan(){}
                
                //Çalışan bilgilerini getiren metot

                public void CalisanBilgieleri()
                {
                    Console.WriteLine("Çalışan Adı : {0}", Ad);
                    Console.WriteLine("Çalışan Soy Adı : {0}", SoyAd);
                    Console.WriteLine("Çalışan No : {0}", No);
                    Console.WriteLine("Çalışan Departman : {0}", Departman);
                    
                }
            }
}
//Kurucu metotların erişim belirteçleri muhakkak public olmalı,  metot adıyla sınıf adı aynı