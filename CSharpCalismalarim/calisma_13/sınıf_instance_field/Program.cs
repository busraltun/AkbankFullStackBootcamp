using System;

namespace sınıf_instance_field
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.SoyAd = "Kara";
            calisan1.No = 23456;
            calisan1.Departman = "İnsan Kaynakları";

            calisan1.CalisanBilgieleri();
        }
    }
            class Calisan
            {
                public string Ad;
                public string SoyAd;
                public int No;
                public string Departman;
                
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